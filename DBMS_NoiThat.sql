CREATE DATABASE DBMS_NoiThat
GO
USE DBMS_NoiThat
GO

CREATE TABLE TYPEACCS(
	id		CHAR(5)			PRIMARY KEY,
	name	NVARCHAR(MAX)
);

CREATE TABLE ACCOUNTS(
	id			CHAR(5)			PRIMARY KEY,
	name		NVARCHAR(MAX)	NOT NULL,
	dob			DATE,
	gender		NVARCHAR(10),
	phone		CHAR(10),
	idNo		VARCHAR(12)		UNIQUE,
	address		NVARCHAR(MAX),
	email		NVARCHAR(200)	UNIQUE,
	password	CHAR(64),							--hash using SHA256 algorithm
	avatar		VARBINARY(MAX),
	idType		CHAR(5)			FOREIGN KEY REFERENCES TYPEACCS(id) 
			ON UPDATE CASCADE
			ON DELETE SET NULL,
	active		BIT,

	CONSTRAINT chk_phone
	CHECK (phone like '0[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),

	CONSTRAINT chk_idNo
	CHECK (idNo like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'
	OR idNo like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),

	CONSTRAINT chk_email
	CHECK (email like '%@%.%')
);

CREATE TABLE CATEGORIES(
	id		CHAR(5)			PRIMARY KEY,
	name	NVARCHAR(MAX)
);

CREATE TABLE PRODUCTS(
	id			CHAR(5)			PRIMARY KEY,
	idCategory	CHAR(5),
	name		NVARCHAR(MAX),
	image		VARBINARY(MAX),
	sellPrice	DECIMAL(19,5),	--auto update attribute
	quantity	INT,			--auto update attribute
	active		INT,			--auto update attribute

	FOREIGN KEY (idCategory) REFERENCES CATEGORIES(id) 
			ON DELETE SET NULL
			ON UPDATE CASCADE,
	CHECK (quantity >= 0)
);

CREATE TABLE INVENTORIES(
	id				CHAR(5)				PRIMARY KEY, 
	idProduct		CHAR(5)				NOT NULL,
	quantity		INT					NOT NULL,
	originalPrice	DECIMAL(19,5)		NOT NULL,
	profit			DECIMAL(19,5)		NOT NULL,
	vat				DECIMAL(19,5)		NOT NULL,
	importDate		DATE				NOT NULL,
	waiting			BIT,				--1 (default) if this lot is waiting to sell - 0 if this lot have been sold out
	isSelling		BIT,				--1 if this lot is selling - 0 (default) if this lot isn't selling
	CHECK (quantity > 0),
	CHECK (originalPrice > 0),
	CHECK (profit > 0),
	CHECK (vat > 0),
	FOREIGN KEY (idProduct) REFERENCES PRODUCTS(id) ON UPDATE CASCADE

	--waiting | isSelling
	--	0			0		=> sold out
	--	0			1		=> selling
	--	1			0		=> waiting to sell
);

-- BILLS (id, idEmployee, createDate)
CREATE TABLE BILLS (
	id			CHAR(5)		PRIMARY KEY,
	idEmployee	CHAR(5),
	createDate	DATETIME,

	CONSTRAINT fk_bill_id_acc FOREIGN KEY (idEmployee) REFERENCES ACCOUNTS (id)
		ON DELETE SET NULL
		ON UPDATE CASCADE
);

-- BILLDETAILS (idBill, idProduct, idInventory, price, quantity)
CREATE TABLE BILLDETAILS (
	idBill		CHAR(5),
	idProduct	CHAR(5),
	idInventory	CHAR(5),	--auto update base on idProduct
	price		DECIMAL(19,5),
	quantity	INT,

	PRIMARY KEY (idBill, idProduct, idInventory),
	CONSTRAINT fk_billDt_id_bill FOREIGN KEY (idBill) REFERENCES BILLS (id),
	CONSTRAINT fk_billDt_id_prd FOREIGN KEY (idProduct) REFERENCES PRODUCTS (id),
	CONSTRAINT fk_billDt_id_ivt FOREIGN KEY (idInventory) REFERENCES INVENTORIES (id),

	CHECK (quantity > 0),
	CHECK (price > 0)
);
GO
-----------------------CREATE TRIGGER-----------------------	
CREATE TRIGGER PRODUCTS_LOT_UPDATE ON PRODUCTS --for monitor out of stock
FOR UPDATE
AS
BEGIN
	IF EXISTS (SELECT * FROM inserted WHERE inserted.quantity = 0 AND inserted.active = 1) --need to be update lot for products
	BEGIN
		-------------------------UPDATE LOT TO SOLD OUT-------------------------
		UPDATE INVENTORIES
		SET isSelling = 0
		FROM
			(SELECT INVENTORIES.id
			FROM 
				(SELECT inserted.id
				FROM inserted
				WHERE inserted.quantity = 0) AS update_product
			INNER JOIN INVENTORIES ON update_product.id = INVENTORIES.idProduct
			WHERE INVENTORIES.waiting = 0 AND INVENTORIES.isSelling = 1) AS tmp
		WHERE INVENTORIES.id = tmp.id
		-------------------------------------------------------------------------
		SELECT tmp.idProduct, INVENTORIES.id AS idInventory, INVENTORIES.importDate AS oldest_lot_date
		INTO #tmptable
		FROM (	SELECT INVENTORIES.idProduct, MIN(INVENTORIES.importDate) AS oldest_lot_date 
				FROM
					(SELECT inserted.id
					FROM inserted
					WHERE inserted.quantity = 0) AS update_product
				INNER JOIN INVENTORIES ON update_product.id = INVENTORIES.idProduct
				WHERE INVENTORIES.waiting = 1 AND INVENTORIES.isSelling = 0 --lot waiting to sell
				GROUP BY INVENTORIES.idProduct) tmp
		INNER JOIN INVENTORIES
		ON tmp.idProduct = INVENTORIES.idProduct
		WHERE tmp.oldest_lot_date = INVENTORIES.importDate AND INVENTORIES.waiting = 1 AND INVENTORIES.isSelling = 0

		SELECT idProduct, idInventory --if exist two or more importdate of same product, then just select one of them
		INTO #sell_lot
		FROM ( SELECT *, ROW_NUMBER() OVER(PARTITION BY #tmptable.idProduct ORDER BY #tmptable.oldest_lot_date) AS rn
				FROM #tmptable) p
		WHERE p.rn = 1
		-----------------------DEACTIVE OUT OF STOCK PRODUCT---------------------
		UPDATE PRODUCTS
		SET active = 0
		WHERE id IN (SELECT id
					FROM inserted
					WHERE id NOT IN (SELECT inserted.id
										FROM inserted
										INNER JOIN #sell_lot
										ON inserted.id = #sell_lot.idProduct))
		-------------------------------------------------------------------------
		IF EXISTS (SELECT 1 FROM #sell_lot) -- check if lot is in stock
		BEGIN
			------------------UPDATE LOT TO PRODUCT------------------
			UPDATE PRODUCTS
			SET PRODUCTS.sellPrice = tmp.sellPrice, PRODUCTS.quantity = tmp.quantity, PRODUCTS.active = 1
			FROM
				(SELECT INVENTORIES.idProduct, INVENTORIES.originalPrice * (1 + INVENTORIES.profit/100.0 + INVENTORIES.vat/100.0) AS sellPrice, INVENTORIES.quantity
				FROM #sell_lot
				INNER JOIN INVENTORIES ON #sell_lot.idProduct = INVENTORIES.idProduct
				WHERE INVENTORIES.id = #sell_lot.idInventory) AS tmp
			WHERE PRODUCTS.id = tmp.idProduct
			------------------UPDATE LOT STATUS TO SELLING------------------
			UPDATE INVENTORIES
			SET waiting = 0, isSelling = 1
			FROM #sell_lot
			WHERE INVENTORIES.id = #sell_lot.idInventory
		END
	END
END
GO

CREATE TRIGGER PRODUCTS_INIT ON PRODUCTS --set default attribute value after insert new product
FOR INSERT
AS
BEGIN
	UPDATE PRODUCTS
	SET sellPrice = 0.0, quantity = 0, active = 0
	FROM inserted
	WHERE PRODUCTS.id = inserted.id
END
GO

CREATE TRIGGER PRODUCTS_DELETE ON PRODUCTS --only allow delete product that doesn't have any lot
INSTEAD OF DELETE
AS
BEGIN
	DELETE FROM PRODUCTS
	WHERE PRODUCTS.id IN
		(SELECT deleted.id
		FROM deleted
		EXCEPT
		SELECT deleted.id
		FROM deleted
		INNER JOIN INVENTORIES ON deleted.id = INVENTORIES.idProduct)
END
GO

CREATE TRIGGER INVENTORIES_INIT ON INVENTORIES
FOR INSERT
AS
BEGIN
	UPDATE INVENTORIES
	SET INVENTORIES.waiting = 1, INVENTORIES.isSelling = 0
	FROM inserted
	WHERE INVENTORIES.id = inserted.id

	IF EXISTS ( SELECT *
				FROM PRODUCTS
				INNER JOIN inserted ON PRODUCTS.id = inserted.idProduct
				WHERE PRODUCTS.quantity = 0) --if new lot of deactived product is imported, then update lot to product
	BEGIN
		SELECT tmp.idProduct, inserted.id AS idInventory, inserted.importDate AS oldest_lot_date
		INTO #tmptable
		FROM (	SELECT update_product.idProduct, MIN(inserted.importDate) AS oldest_lot_date 
				FROM
					(SELECT id AS idProduct
					FROM PRODUCTS
					WHERE quantity = 0) AS update_product
				INNER JOIN inserted ON update_product.idProduct = inserted.idProduct
				GROUP BY update_product.idProduct) tmp
		INNER JOIN inserted
		ON tmp.idProduct = inserted.idProduct
		WHERE tmp.oldest_lot_date = inserted.importDate

		SELECT idProduct, idInventory --if exist two or more importdate of same product, then just select one of them
		INTO #sell_lot
		FROM ( SELECT *, ROW_NUMBER() OVER(PARTITION BY #tmptable.idProduct ORDER BY #tmptable.oldest_lot_date) AS rn
				FROM #tmptable) p
		WHERE p.rn = 1
		------------------------------------------------------------------------------------------------------------------
		UPDATE PRODUCTS
		SET PRODUCTS.sellPrice = tmp.sellPrice, PRODUCTS.quantity = tmp.quantity, PRODUCTS.active = 1
		FROM
			(SELECT inserted.idProduct, inserted.originalPrice * (1 + inserted.profit/100.0 + inserted.vat/100.0) AS sellPrice, inserted.quantity
			FROM #sell_lot
			INNER JOIN inserted ON #sell_lot.idProduct = inserted.idProduct
			WHERE inserted.id = #sell_lot.idInventory) AS tmp
		WHERE PRODUCTS.id = tmp.idProduct

		UPDATE INVENTORIES
		SET waiting = 0, isSelling = 1
		FROM #sell_lot
		WHERE INVENTORIES.id = #sell_lot.idInventory
	END
END
GO

CREATE TRIGGER INVENTORIES_UPDATE ON INVENTORIES --only allow update on waiting to sell lot
AFTER UPDATE
AS
BEGIN
	IF TRIGGER_NESTLEVEL() <= 1 --comming from user
	BEGIN
		IF EXISTS (SELECT * FROM deleted WHERE deleted.waiting = 0)
		BEGIN
			RAISERROR('only allow update on waiting to sell lot', 11, 1)
			ROLLBACK TRANSACTION
		END
	END
END
GO

CREATE TRIGGER INVENTORIES_DELETE ON INVENTORIES --only delete waiting to sell lot
INSTEAD OF DELETE
AS
BEGIN
	DELETE FROM INVENTORIES
	WHERE INVENTORIES.id IN
		(SELECT deleted.id
		FROM deleted
		WHERE deleted.waiting = 1 AND deleted.isSelling = 0)
END
GO

----------------------------------------------------------------------------------------------

CREATE TRIGGER BILLS_INIT ON BILLS
FOR INSERT
AS
BEGIN
	UPDATE BILLS
	SET createDate = GETDATE()
	WHERE id IN (SELECT id FROM inserted)
END
GO

CREATE TRIGGER trg_BILLS_DEL ON BILLS
INSTEAD OF DELETE
AS
BEGIN
	DELETE FROM BILLS
	WHERE BILLS.id = 
		(SELECT deleted.id 
		FROM deleted 
		WHERE deleted.id NOT IN 
			(SELECT DISTINCT BILLDETAILS.idBill
			FROM BILLDETAILS))
END
GO

CREATE TRIGGER BILLDETAILS_INSERT ON BILLDETAILS
INSTEAD OF INSERT
AS
BEGIN
	SELECT inserted.idBill, inserted.idProduct, INVENTORIES.id AS idInventory, PRODUCTS.sellPrice, inserted.quantity AS buyQuantity, PRODUCTS.quantity AS stockQuantity
	INTO #tmp_table
	FROM inserted
	INNER JOIN PRODUCTS
	ON inserted.idProduct = PRODUCTS.id
	INNER JOIN INVENTORIES
	ON PRODUCTS.id = INVENTORIES.idProduct
	WHERE inserted.quantity <= PRODUCTS.quantity AND PRODUCTS.active = 1 AND INVENTORIES.isSelling = 1

	INSERT INTO BILLDETAILS(idBill, idProduct, idInventory, price, quantity)
	SELECT #tmp_table.idBill, #tmp_table.idProduct, #tmp_table.idInventory, #tmp_table.sellPrice, #tmp_table.buyQuantity
	FROM #tmp_table

	UPDATE PRODUCTS
	SET PRODUCTS.quantity = PRODUCTS.quantity - #tmp_table.buyQuantity
	FROM PRODUCTS
	INNER JOIN #tmp_table
	ON PRODUCTS.id = #tmp_table.idProduct

END
GO

CREATE TRIGGER tr_BILLDETAILS_DEL ON BILLDETAILS
INSTEAD OF DELETE
AS
BEGIN
	RAISERROR (N'CAN NOT DELETE', 18, 1);
END
GO

CREATE TRIGGER tr_BILLDETAILS_UPD ON BILLDETAILS
INSTEAD OF UPDATE
AS
BEGIN
	RAISERROR (N'CAN NOT UPDATE', 18, 1);
END
GO

-----------------------CREATE VIEW-----------------------
CREATE VIEW V_QL_ACCOUNTS AS
	SELECT acc.id, acc.name, dob, gender, phone, idNo, address, email, avatar, TYPEACCS.name as role, active 
	FROM ACCOUNTS AS acc, TYPEACCS
	WHERE acc.idType = TYPEACCS.id
GO

CREATE VIEW V_NV_PRODUCTS AS
SELECT	PRODUCTS.id AS productId,
		CATEGORIES.name AS productCategory,
		PRODUCTS.name AS productName,
		PRODUCTS.image AS productImg,
		PRODUCTS.sellPrice AS productPrice,
		PRODUCTS.quantity AS productQuantity,
		productLotInf.lotId AS productLotId,
		productLotInf.lotDate AS productLotDate
FROM PRODUCTS
INNER JOIN CATEGORIES ON PRODUCTS.idCategory = CATEGORIES.id
INNER JOIN 
	(SELECT PRODUCTS.id AS productId, INVENTORIES.id AS lotId, INVENTORIES.importDate AS lotDate
	FROM PRODUCTS
	LEFT OUTER JOIN INVENTORIES ON PRODUCTS.id = INVENTORIES.idProduct
	WHERE PRODUCTS.active = 1 AND INVENTORIES.isSelling = 1) AS productLotInf -- only product that is active (=1) and its selling lot
ON PRODUCTS.id = productLotInf.productId
GO

CREATE VIEW V_QL_PRODUCTS AS
SELECT	PRODUCTS.id AS productId,
		PRODUCTS.idCategory AS idCategory,
		PRODUCTS.name AS productName,
		PRODUCTS.image AS productImg,
		CASE WHEN PRODUCTS.active = 0 THEN N'Vô hiệu hóa' ELSE N'Đang bán' END AS productStatus,
		PRODUCTS.sellPrice AS productPrice,
		PRODUCTS.quantity AS productQuantity,
		productLotInf.lotId AS productLotId,
		productLotInf.lotDate AS productLotDate
FROM PRODUCTS
LEFT OUTER JOIN 
	(SELECT PRODUCTS.id AS productId, INVENTORIES.id AS lotId, INVENTORIES.importDate AS lotDate
	FROM INVENTORIES 
	INNER JOIN  PRODUCTS
	ON PRODUCTS.id = INVENTORIES.idProduct
	WHERE INVENTORIES.isSelling = 1) AS productLotInf
ON PRODUCTS.id = productLotInf.productId
GO

CREATE VIEW V_NV_INVENTORIES AS --only waiting to sell lot
SELECT INVENTORIES.id AS lotId,
		CATEGORIES.name AS productCategory,
		PRODUCTS.name AS productName,
		PRODUCTS.id AS productId,
		PRODUCTS.image AS productImg,
		INVENTORIES.quantity AS lotQuantity, 
		INVENTORIES.originalPrice * (1 + INVENTORIES.profit/100 + INVENTORIES.vat/100) AS sellPrice,
		INVENTORIES.importDate AS lotImportDate
FROM INVENTORIES
INNER JOIN PRODUCTS ON INVENTORIES.idProduct = PRODUCTS.id
INNER JOIN CATEGORIES ON PRODUCTS.idCategory = CATEGORIES.id
WHERE PRODUCTS.active = 1 AND INVENTORIES.waiting = 1
GO
CREATE VIEW V_QL_INVENTORIES AS
SELECT INVENTORIES.id AS lotId,
		CATEGORIES.name AS productCategory,
		PRODUCTS.id AS productId,
		INVENTORIES.importDate AS importDate,
		PRODUCTS.image AS productImg,
		CASE WHEN PRODUCTS.active = 0 THEN N'Sản phẩm đã vô hiệu hóa' ELSE N'Sản phẩm đang bán' END AS productStatus,
		INVENTORIES.quantity AS lotQuantity, 
		INVENTORIES.originalPrice AS originalPrice,
		INVENTORIES.originalPrice * (1 + INVENTORIES.profit/100 + INVENTORIES.vat/100) AS sellPrice,
		INVENTORIES.profit AS profit,
		INVENTORIES.vat AS vat,
		CASE WHEN (INVENTORIES.waiting = 1 AND INVENTORIES.isSelling = 0) THEN N'Lô đang chờ bán' 
			WHEN (INVENTORIES.waiting = 0 AND INVENTORIES.isSelling = 1) THEN N'Lô đang bán'
			ELSE N'Lô đã bán hết' END AS lotStatus
FROM INVENTORIES
INNER JOIN PRODUCTS ON INVENTORIES.idProduct = PRODUCTS.id
INNER JOIN CATEGORIES ON PRODUCTS.idCategory = CATEGORIES.id
GO

CREATE VIEW V_BILLDETAILS AS
SELECT
	b.idBill AS idBill,
	b.idProduct AS idProduct,
	b.idInventory AS idInventory,
	b.price * b.quantity AS detailPrice
FROM BILLDETAILS b
GO

CREATE VIEW V_BILLS AS
SELECT
	b.id AS id,
	b.idEmployee AS idEmployee,
	SUM(v.detailPrice) AS checkOut
FROM
	BILLS b INNER JOIN V_BILLDETAILS v ON b.id=v.idBill
GROUP BY b.id, b.idEmployee
GO

---------------------------------------STORED PROCEDURE/FUNCTION---------------------------------------
-- Thêm Bill (nv, ql)
CREATE PROC sp_insBill @id CHAR(5), @idEmployee CHAR(5)
AS
BEGIN
	INSERT INTO BILLS(id, idEmployee) VALUES(@id, @idEmployee);
END
GO

-- Cập nhật BILL
CREATE PROC sp_updBill @id CHAR(5), @idEmployee CHAR(5)
AS
BEGIN
	UPDATE BILLS
	SET BILLS.idEmployee = @idEmployee
	WHERE BILLS.id = @id
END
GO

-- Xóa BILL
CREATE PROC sp_delBill @id CHAR(5)
AS
BEGIN
	DELETE FROM BILLS
	WHERE BILLS.id = @id
END
GO

-- Thêm BillDetail (nv, ql)
CREATE PROC sp_insBillDetail @idBill CHAR(5), @idProduct CHAR(5), @quantity INT
AS
BEGIN
	INSERT INTO BILLDETAILS(idBill, idProduct, quantity) VALUES(@idBill, @idProduct, @quantity);
END
GO

-- Danh sach nhan vien
CREATE PROC sp_DS_NV
AS
BEGIN
	SELECT * FROM ACCOUNTS
END
GO

-- Danh sach loai san pham
CREATE PROC sp_DS_LSP
AS
BEGIN
	SELECT * FROM CATEGORIES
END
GO

-- Danh sach san pham
CREATE PROC sp_DS_SP
AS
BEGIN
	SELECT * FROM PRODUCTS
END
GO

-- Danh sach lo san pham
CREATE PROC sp_DS_Lo
AS
BEGIN
	SELECT * FROM INVENTORIES
END
GO

-- Danh sach hoa hon
CREATE PROC sp_DS_Bill
AS
BEGIN
	SELECT * FROM BILLS
END
GO

-- Danh sach chi tiet hoa hon
CREATE PROC sp_DS_BillDetail
AS
BEGIN
	SELECT * FROM BILLDETAILS
END
GO

--SP thêm nhân viên
CREATE PROC sp_add_employee @id char(5), @name nvarchar(MAX), @dob date, @gender nvarchar(10),
							@phone char(10), @idNo char(12), @address nvarchar(200), @email varchar(200),
							@password varchar(100), @avatar varbinary(max), @idType char(5), @active bit
AS
INSERT INTO ACCOUNTS(id, name, dob, gender, phone, idNo, 
			address, email, password, avatar, idType, active) 
VALUES(@id, @name, @dob, @gender, @phone, @idNo, 
	@address, @email, CONVERT(CHAR(64),HashBytes('sha2_256', @password + @email),2), @avatar, @idType, @active)
GO

-- SP quản lý chỉnh sửa thông tin
CREATE PROCEDURE sp_admin_update_employee @id char(5), @name nvarchar(MAX), @dob date, @gender nvarchar(10), 
				@phone char(10), @idNo char(12), @address nvarchar(200), @email varchar(200),
				@password varchar(100), @avatar varbinary(max), @idType char(5), @active bit
AS
	IF (@password IS NULL OR @password = '') BEGIN
		UPDATE ACCOUNTS 
			SET name = @name,
			dob = @dob, 
			gender = @gender, 
			phone = @phone, 
			idNo = @idNo, 
			address = @address, 
			email = @email,
			avatar = @avatar,
			idType = @idType,
			active = @active
		WHERE id = @id
	END
	ELSE BEGIN
		UPDATE ACCOUNTS 
			SET name = @name,
			dob = @dob, 
			gender = @gender, 
			phone = @phone, 
			idNo = @idNo, 
			address = @address, 
			email = @email,
			password = CONVERT(CHAR(64),HashBytes('sha2_256', @password + @email),2),
			avatar = @avatar,
			idType = @idType,
			active = @active
		WHERE id = @id
	END
GO

-- SP nhân viên chỉnh sửa thông tin
CREATE PROCEDURE sp_employee_update_employee @id char(5), @name nvarchar(MAX), @dob date, @gender nvarchar(10),@phone char(10), 
									@idNo char(12), @address nvarchar(200), @avatar varbinary(max)
AS
	UPDATE ACCOUNTS SET name=@name, dob=@dob, gender=@gender, phone=@phone, idNo=@idNo, address=@address, avatar = @avatar
	WHERE id = @id
GO

-- SP ẩn nhân viên
CREATE PROCEDURE sp_hide_employee @id char(5)
AS
	UPDATE ACCOUNTS SET active = 0 WHERE id = @id
GO

CREATE PROC sp_employee_update_password @id char(5), @email varchar(200),
			@old_password varchar(100), @new_password varchar(100)
AS BEGIN
	DECLARE @result bit = 0;
	IF EXISTS (SELECT * FROM fnLogin(@email, @old_password)) BEGIN
		UPDATE ACCOUNTS SET password = CONVERT(CHAR(64),HashBytes('sha2_256', @new_password + @email),2)
			WHERE id = @id;
		SET @result = 1;
	END
	RETURN @result;
END
GO

-- SP thêm lô 
CREATE PROCEDURE sp_add_inventory @id char(5), @idProduct char(5), @quantity int, 
				@originalPrice decimal(19,5), @profit decimal(19,5),
				@vat decimal(19,5),@importDate date
AS
	INSERT INTO INVENTORIES(id,idProduct,quantity, originalPrice, profit, vat, importDate)
			VALUES(@id,@idProduct,@quantity, @originalPrice, @profit, @vat, @importDate)
GO

-- SP sửa lô
CREATE PROCEDURE sp_update_inventory @id char(5), @idProduct char(5), @quantity int, 
				@originalPrice decimal(19,5), @profit decimal(19,5), 
				@vat decimal(19,5),@importDate date
AS
	UPDATE INVENTORIES SET	
		idProduct=@idProduct,
		quantity=@quantity, 
		originalPrice=@originalPrice, 
		profit=@profit, 
		vat=@vat, 
		importDate=@importDate
	WHERE id = @id
GO

-- SP xóa lô
CREATE PROCEDURE sp_delete_inventory @id char(5)
AS
	DELETE FROM INVENTORIES WHERE id = @id
GO

-- SP thêm loại sản phẩm
CREATE PROCEDURE sp_add_category @id char(5), @name nvarchar(MAX)
AS
	INSERT INTO CATEGORIES(id,name) VALUES(@id, @name)
GO

-- SP cập nhật loại sản phẩm
CREATE PROCEDURE sp_update_category @id char(5), @name nvarchar(MAX)
AS
	UPDATE CATEGORIES SET name = @name WHERE id = @id
GO

-- SP xóa loại sản phẩm
CREATE PROCEDURE sp_delete_category @id char(5)
AS
	DELETE FROM CATEGORIES WHERE id = @id
GO

-- SP thêm sản phẩm
CREATE PROCEDURE sp_add_product @id char(5), @idCategory char(5), @name nvarchar(MAX), @image varbinary(MAX)
AS
	INSERT INTO PRODUCTS(id,idCategory,name,image)
	VALUES(@id,@idCategory,@name,@image)
GO

-- SP sửa sản phẩm
CREATE PROCEDURE sp_update_product @id char(5), @idCategory char(5), @name nvarchar(MAX), @image varbinary(MAX)
AS
	UPDATE PRODUCTS SET 
		idCategory=@idCategory,
		name=@name,
		image=@image
	WHERE id=@id
GO

-- SP xóa sản phẩm
CREATE PROCEDURE sp_delete_product @id char(5)
AS
	DELETE FROM PRODUCTS WHERE id=@id
GO

-- PROCEDURE THỐNG KÊ TẤT CẢ NĂM
CREATE PROCEDURE sp_revenue_allyear
AS
BEGIN
	select ISNULL(thuTable.year, chiTable.year) as year,
	       ISNULL(tienThu, 0) as thu,
		ISNULL(tienChi,0) as chi, 
		loiNhuan = ISNULL(tienThu, 0) - ISNULL(tienChi, 0) 
	from 
		(SELECT Year(createDate) as year,
			SUM(price*quantity) as tienThu
		FROM BILLs b inner join BILLDETAILS bd on b.id = bd.idBill
		group by Year(createDate)) as thuTable 
		FULL JOIN 
		(SELECT Year(importDate) as year,
			 SUM(originalprice*quantity*(1+vat/100)) as tienChi
		FROM INVENTORIES
		group by Year(importDate)) as chiTable
		ON thuTable.year = chiTable.year
	ORDER BY year DESC
END
GO

-- PROCEDURE THỐNG KÊ TẤT CẢ THÁNG CỦA TẤT CẢ NĂM
CREATE PROCEDURE sp_revenue_allmonth
AS
BEGIN
	select ISNULL(thuTable.year, chiTable.year) as year,
		ISNULL(thuTable.month, chiTable.month) as month,
		ISNULL(tienThu, 0) as thu,
		ISNULL(tienChi,0) as chi, 
		loiNhuan = ISNULL(tienThu, 0) - ISNULL(tienChi, 0) 
	from 
		(SELECT Year(createDate) as year,
			Month(createDate) as month,
			SUM(price*quantity) as tienThu
		FROM BILLs b inner join BILLDETAILS bd on b.id = bd.idBill
		group by Year(createDate), Month(createDate)) as thuTable 
		FULL JOIN 
		(SELECT Year(importDate) as year,
			Month(importDate) as month,
			SUM(originalprice*quantity*(1+vat/100)) as tienChi
		FROM INVENTORIES
		group by Year(importDate), Month(importDate)) as chiTable
		ON thuTable.year = chiTable.year and thuTable.month = chiTable.month
	ORDER BY year DESC, month DESC
END
GO

-- PROCEDURE THỐNG KÊ THEO TẤT CẢ QUÝ CỦA TẤT CẢ NĂM
CREATE PROCEDURE sp_revenue_allquarter
AS
BEGIN
	select ISNULL(thuTable.year, chiTable.year) as year,
		ISNULL(thuTable.quarter, chiTable.quarter) as quarter,
	       ISNULL(tienThu, 0) as thu,
		ISNULL(tienChi,0) as chi, 
		loiNhuan = ISNULL(tienThu, 0) - ISNULL(tienChi, 0)
	from 
		(SELECT Year(createDate) as year,
			DATEPART(QUARTER,createDate) as quarter,
			SUM(price*quantity) as tienThu
		FROM BILLs b inner join BILLDETAILS bd on b.id = bd.idBill
		group by Year(createDate), DATEPART(QUARTER,createDate)) as thuTable 
		FULL JOIN 
		(SELECT Year(importDate) as year,
			DATEPART(QUARTER,importDate) as quarter,
			SUM(originalprice*quantity*(1+vat/100)) as tienChi
		FROM INVENTORIES
		group by Year(importDate), DATEPART(QUARTER,importDate)) as chiTable
		ON thuTable.year = chiTable.year and thuTable.quarter = chiTable.quarter
	ORDER BY year DESC, quarter DESC
END
GO

--Function Login
CREATE FUNCTION fnLogin (@email varchar(200), @password varchar(100))
RETURNS TABLE
AS
RETURN (SELECT *
	FROM ACCOUNTS
	WHERE email = @email AND password = CONVERT(CHAR(64),HashBytes('sha2_256', @password + @email),2))
GO

-- FUNCTION xem thông tin
CREATE FUNCTION fn_account_detail(@id char(5))
RETURNS TABLE
AS
RETURN
	SELECT *
	FROM ACCOUNTS
	WHERE id = @id;
GO

-- FUNCTION kiểm tra xem lô có thể cập nhật không ( 0: lô đã được bán  -- 1: lô chưa bán)
CREATE FUNCTION fn_can_modify_inventory(@id char(5))
RETURNS BIT
BEGIN
	DECLARE @result bit = 0;
	IF EXISTS (SELECT id FROM INVENTORIES WHERE id = @id AND waiting = 1 AND isSelling = 0) 
		SET @result = 1 -- Lô chưa bán
	RETURN @result
END
GO

-- FUNCTION kiểm tra xem loại sản phẩm có sửa hay xóa được không
CREATE FUNCTION fn_can_modify_category(@id char(5))
RETURNS BIT
BEGIN
	DECLARE @result bit = 1;
	
	IF EXISTS (SELECT DISTINCT idCategory --id loại sản phẩm có sản phẩm đã hoặc đang bán
			   FROM PRODUCTS 
			   WHERE idCategory = @id
				AND (active = 1 
					OR id IN (SELECT DISTINCT idProduct --- id sản phẩm đã hoặc đang bán 
							FROM INVENTORIES 
							WHERE waiting = 0))) 
		SET @result = 0

	RETURN @result
END		
GO

-- FUNCTION kiểm tra xem sản phẩm đã/đang bán hay chưa
CREATE FUNCTION fn_can_modify_product(@id char(5))
RETURNS BIT
BEGIN
	DECLARE @result bit = 1;
	IF EXISTS (SELECT idProduct FROM INVENTORIES WHERE idProduct = @id AND waiting = 0)
		SET @result = 0
	RETURN @result
END
GO

CREATE FUNCTION fn_can_modify_bill(@id char(5))
RETURNS BIT
BEGIN
	DECLARE @result bit = 1;
	IF EXISTS (SELECT * FROM BILLDETAILS WHERE BILLDETAILS.idBill = @id)
		SET @result = 0
	RETURN @result
END
GO

------ Thong ke san pham duoc ban
CREATE PROC sp_Products_Sold 
	@startDate	DATE = NULL, 
	@endDate	DATE = NULL
AS
BEGIN
	SELECT
		pd.id, pd.name, pd.nameCategory, SUM(bd.quantity) AS quantity
	FROM (SELECT bid.idProduct, bid.quantity, b.createDate
		FROM BILLDETAILS bid INNER JOIN BILLS b ON bid.idBill = b.id) bd INNER JOIN
		(SELECT p.id, p.name, c.name AS nameCategory
		FROM PRODUCTS p INNER JOIN CATEGORIES c ON p.idCategory = c.id) pd
		ON bd.idProduct = pd.id
	WHERE (@startDate IS NULL OR bd.createDate >= @startDate) AND
		(@endDate IS NULL OR bd.createDate <= @endDate)
	GROUP BY pd.id, pd.name, pd.nameCategory
END
GO

-- FUNCTION THỐNG KÊ DOANH THU THEO MỘT KHOẢNG THỜI GIAN
CREATE FUNCTION fn_revenue_report(@startDate DATE = NULL, @endDate DATE = NULL)
RETURNS @result TABLE (thu DECIMAL(19,5), chi DECIMAL(19,5), doanhThu DECIMAL(19,5))
BEGIN
	SET @endDate = DATEADD(day,1,@endDate)
	DECLARE @tienChi DECIMAL(19,5), @tienThu DECIMAL(19,5);

	SELECT @tienChi = SUM(originalprice*quantity*(1+vat/100))
	FROM INVENTORIES 
	WHERE (@startDate IS NULL OR importDate >= @startDate) AND
		(@endDate IS NULL OR importDate <= @endDate);
	IF @tienChi IS NULL SELECT @tienChi = 0;

	SELECT @tienThu = SUM(price*quantity)
	FROM BILLDETAILS bd INNER JOIN BILLS b ON bd.idBill = b.id
	WHERE (@startDate IS NULL OR b.createDate >= @startDate) AND
		(@endDate IS NULL OR b.createDate <= @endDate);
	IF @tienThu IS NULL SELECT @tienThu = 0;

	INSERT INTO @result VALUES(@tienThu,@tienChi,@tienThu-@tienChi);
	RETURN;
END
GO

-- FUNTION LẤY TÊN SẢN PHẨM
CREATE FUNCTION fn_get_product_name()
Returns table
	return select id, name from products;
GO

CREATE VIEW V_QL_BILLHISTORY AS
SELECT
	b.id AS id,
	acc.name,
	CAST(b.createDate AS date) AS createTime,
	SUM(bd.detailPrice) AS checkOut
FROM BILLS b 
INNER JOIN V_BILLDETAILS bd ON b.id=bd.idBill
INNER JOIN V_QL_ACCOUNTS acc ON b.idEmployee=acc.id
GROUP BY b.id, acc.name, b.createDate
GO

CREATE VIEW V_NV_BILLHISTORY AS
SELECT
	b.id AS id,
	acc.id AS idAcc,
	CAST(b.createDate AS date) AS createTime,
	SUM(bd.detailPrice) AS checkOut
FROM BILLS b 
INNER JOIN V_BILLDETAILS bd ON b.id=bd.idBill
INNER JOIN ACCOUNTS acc ON b.idEmployee=acc.id
GROUP BY b.id, acc.id, b.createDate
GO

-- FUNCTION TÌM CHI TIẾT HÓA ĐƠN THEO HÓA ĐƠN
CREATE FUNCTION fn_get_billDetails(@id char(5))
returns table
	return select p.id, p.name, bd.price, bd.quantity
			from BILLDETAILS bd
			INNER JOIN PRODUCTS p ON p.id=bd.idProduct
			INNER JOIN BILLS b ON b.id=bd.idBill
			WHERE bd.idBill = @id
GO

-- FUNTION NHÂN VIÊN XEM LỊCH SỬ HÓA ĐƠN
CREATE FUNCTION fn_nv_get_billHistory(@id char(5))
Returns table
	return select * from V_NV_BILLHISTORY WHERE V_NV_BILLHISTORY.idAcc = @id;
GO

-- FUNTION NHÂN VIÊN TÌM LÔ SẢN PHẨM THEO ID SẢN PHẨM
CREATE FUNCTION fn_nv_get_inventories_by_pid(@id char(5))
Returns table
	return select * from V_NV_INVENTORIES WHERE V_NV_INVENTORIES.productId = @id;
GO

-- FUNTION QUẢN LÝ TÌM LÔ SẢN PHẨM THEO ID SẢN PHẨM
CREATE FUNCTION fn_ql_get_inventories_by_pid(@id char(5))
Returns table
	return select * from V_QL_INVENTORIES WHERE V_QL_INVENTORIES.productId = @id;
GO

-- FUNTION NHÂN VIÊN TÌM LỊCH SỬ HÓA ĐƠN THEO NGÀY
CREATE FUNCTION fn_nv_get_billHistory_by_createDate(@createTime DATE)
Returns table
	return select * from V_NV_BILLHISTORY WHERE V_NV_BILLHISTORY.createTime = @createTime;
GO

-- FUNTION QUẢN LÝ TÌM LỊCH SỬ HÓA ĐƠN THEO NGÀY
CREATE FUNCTION fn_ql_get_billHistory_by_createDate(@createTime DATE)
Returns table
	return select * from V_QL_BILLHISTORY WHERE V_QL_BILLHISTORY.createTime = @createTime;
GO

INSERT TYPEACCS (id, name) VALUES (N'1    ', N'Nhân viên')
INSERT TYPEACCS (id, name) VALUES (N'2    ', N'Quản lý')

--username: ql01@qlchnt.com | password: 1
INSERT INTO ACCOUNTS(id, name, dob, gender, phone, idNo, 
			address, email, password, avatar, idType, active) 
VALUES('QL001', N'Quản Thị Lí', '2000-1-1', N'Nam', '0954325198', '854369548', 
	'TP. HCM', 'ql01@qlchnt.com', CONVERT(CHAR(64),HashBytes('sha2_256', '1' + 'ql01@qlchnt.com'),2), null, 2, 1)
