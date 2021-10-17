
namespace CHQLDoNoiThat.FormsManager
{
    partial class FormProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTaiAnhSanPham = new System.Windows.Forms.Button();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxSanPham = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIdLoaiSanPham = new System.Windows.Forms.Label();
            this.dataGridViewSanPham = new System.Windows.Forms.DataGridView();
            this.productId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategory = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productImg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productLotId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productLotDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCategory = new CHQLDoNoiThat.ComboBoxControl();
            this.txtSoLuong = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.txtGiaBan = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.txtId = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.txtTenSanPham = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.elipseControl1 = new ElipseToolDemo.ElipseControl();
            this.txtTinhTrang = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtTinhTrang);
            this.panel3.Controls.Add(this.cmbCategory);
            this.panel3.Controls.Add(this.btnTaiAnhSanPham);
            this.panel3.Controls.Add(this.btnTaiLai);
            this.panel3.Controls.Add(this.btnLuu);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtSoLuong);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtGiaBan);
            this.panel3.Controls.Add(this.pictureBoxSanPham);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtId);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtTenSanPham);
            this.panel3.Controls.Add(this.lblIdLoaiSanPham);
            this.panel3.Location = new System.Drawing.Point(10, 11);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(746, 238);
            this.panel3.TabIndex = 6;
            // 
            // btnTaiAnhSanPham
            // 
            this.btnTaiAnhSanPham.AutoSize = true;
            this.btnTaiAnhSanPham.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTaiAnhSanPham.FlatAppearance.BorderSize = 0;
            this.btnTaiAnhSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiAnhSanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiAnhSanPham.ForeColor = System.Drawing.Color.White;
            this.btnTaiAnhSanPham.Location = new System.Drawing.Point(316, 145);
            this.btnTaiAnhSanPham.Margin = new System.Windows.Forms.Padding(0);
            this.btnTaiAnhSanPham.Name = "btnTaiAnhSanPham";
            this.btnTaiAnhSanPham.Size = new System.Drawing.Size(144, 32);
            this.btnTaiAnhSanPham.TabIndex = 76;
            this.btnTaiAnhSanPham.TabStop = false;
            this.btnTaiAnhSanPham.Text = "Tải ảnh sản phẩm";
            this.btnTaiAnhSanPham.UseVisualStyleBackColor = false;
            this.btnTaiAnhSanPham.Click += new System.EventHandler(this.btnTaiAnhSanPham_Click);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.AutoSize = true;
            this.btnTaiLai.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTaiLai.FlatAppearance.BorderSize = 0;
            this.btnTaiLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiLai.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiLai.ForeColor = System.Drawing.Color.White;
            this.btnTaiLai.Location = new System.Drawing.Point(558, 188);
            this.btnTaiLai.Margin = new System.Windows.Forms.Padding(0);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(79, 32);
            this.btnTaiLai.TabIndex = 32;
            this.btnTaiLai.TabStop = false;
            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.UseVisualStyleBackColor = false;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.AutoSize = true;
            this.btnLuu.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(449, 188);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(0);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(79, 32);
            this.btnLuu.TabIndex = 31;
            this.btnLuu.TabStop = false;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(464, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 29;
            this.label5.Text = "Tình trạng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(464, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 28;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(464, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 26;
            this.label3.Text = "Giá bán";
            // 
            // pictureBoxSanPham
            // 
            this.pictureBoxSanPham.Location = new System.Drawing.Point(316, 2);
            this.pictureBoxSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxSanPham.Name = "pictureBoxSanPham";
            this.pictureBoxSanPham.Size = new System.Drawing.Size(144, 136);
            this.pictureBoxSanPham.TabIndex = 24;
            this.pictureBoxSanPham.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(17, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Id sản phẩm";
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.BackColor = System.Drawing.Color.SteelBlue;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(344, 188);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(79, 32);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.TabStop = false;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_LoaiSanPham_Click);
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = true;
            this.btnSua.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(233, 188);
            this.btnSua.Margin = new System.Windows.Forms.Padding(0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 32);
            this.btnSua.TabIndex = 20;
            this.btnSua.TabStop = false;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.BackColor = System.Drawing.Color.SteelBlue;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(118, 188);
            this.btnThem.Margin = new System.Windows.Forms.Padding(0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(77, 32);
            this.btnThem.TabIndex = 19;
            this.btnThem.TabStop = false;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(17, 128);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên sản phẩm";
            // 
            // lblIdLoaiSanPham
            // 
            this.lblIdLoaiSanPham.AutoSize = true;
            this.lblIdLoaiSanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdLoaiSanPham.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblIdLoaiSanPham.Location = new System.Drawing.Point(17, 81);
            this.lblIdLoaiSanPham.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdLoaiSanPham.Name = "lblIdLoaiSanPham";
            this.lblIdLoaiSanPham.Size = new System.Drawing.Size(113, 21);
            this.lblIdLoaiSanPham.TabIndex = 8;
            this.lblIdLoaiSanPham.Text = "Loại sản phẩm";
            // 
            // dataGridViewSanPham
            // 
            this.dataGridViewSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productId,
            this.idCategory,
            this.productName,
            this.productImg,
            this.productPrice,
            this.productQuantity,
            this.productLotId,
            this.productLotDate,
            this.productStatus});
            this.dataGridViewSanPham.Location = new System.Drawing.Point(10, 286);
            this.dataGridViewSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewSanPham.Name = "dataGridViewSanPham";
            this.dataGridViewSanPham.RowHeadersWidth = 51;
            this.dataGridViewSanPham.RowTemplate.Height = 24;
            this.dataGridViewSanPham.Size = new System.Drawing.Size(746, 270);
            this.dataGridViewSanPham.TabIndex = 7;
            // 
            // productId
            // 
            this.productId.DataPropertyName = "productId";
            this.productId.HeaderText = "Mã sản phẩm";
            this.productId.Name = "productId";
            // 
            // idCategory
            // 
            this.idCategory.DataPropertyName = "idCategory";
            this.idCategory.HeaderText = "Loại sản phẩm";
            this.idCategory.Name = "idCategory";
            this.idCategory.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // productName
            // 
            this.productName.DataPropertyName = "productName";
            this.productName.HeaderText = "Tên sản phẩm";
            this.productName.Name = "productName";
            // 
            // productImg
            // 
            this.productImg.DataPropertyName = "productImg";
            this.productImg.HeaderText = "productImg";
            this.productImg.Name = "productImg";
            this.productImg.Visible = false;
            // 
            // productPrice
            // 
            this.productPrice.DataPropertyName = "productPrice";
            this.productPrice.HeaderText = "Giá bán";
            this.productPrice.Name = "productPrice";
            // 
            // productQuantity
            // 
            this.productQuantity.DataPropertyName = "productQuantity";
            this.productQuantity.HeaderText = "Số lượng hiện có";
            this.productQuantity.Name = "productQuantity";
            // 
            // productLotId
            // 
            this.productLotId.DataPropertyName = "productLotId";
            this.productLotId.HeaderText = "Mã lô sản phẩm";
            this.productLotId.Name = "productLotId";
            // 
            // productLotDate
            // 
            this.productLotDate.DataPropertyName = "productLotDate";
            this.productLotDate.HeaderText = "Ngày nhập lô";
            this.productLotDate.Name = "productLotDate";
            // 
            // productStatus
            // 
            this.productStatus.DataPropertyName = "productStatus";
            this.productStatus.HeaderText = "Trạng thái";
            this.productStatus.Name = "productStatus";
            this.productStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.productStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(308, 254);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 30);
            this.label6.TabIndex = 11;
            this.label6.Text = "Danh sách sản phẩm";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbCategory.BorderColor = System.Drawing.Color.SteelBlue;
            this.cmbCategory.BorderSize = 1;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.ForeColor = System.Drawing.Color.SteelBlue;
            this.cmbCategory.IconColor = System.Drawing.Color.SteelBlue;
            this.cmbCategory.Items.AddRange(new object[] {
            "Còn hàng",
            "Hết hàng"});
            this.cmbCategory.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbCategory.ListTextColor = System.Drawing.Color.SteelBlue;
            this.cmbCategory.Location = new System.Drawing.Point(135, 81);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCategory.MinimumSize = new System.Drawing.Size(98, 24);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Padding = new System.Windows.Forms.Padding(1);
            this.cmbCategory.Size = new System.Drawing.Size(168, 24);
            this.cmbCategory.TabIndex = 77;
            this.cmbCategory.Texts = "";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtSoLuong.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSoLuong.BorderSize = 2;
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtSoLuong.Location = new System.Drawing.Point(546, 74);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoLuong.Multiline = false;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtSoLuong.PasswordChar = false;
            this.txtSoLuong.Size = new System.Drawing.Size(170, 31);
            this.txtSoLuong.TabIndex = 27;
            this.txtSoLuong.Texts = "";
            this.txtSoLuong.UnderlinedStyle = true;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtGiaBan.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtGiaBan.BorderSize = 2;
            this.txtGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBan.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtGiaBan.Location = new System.Drawing.Point(546, 27);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(2);
            this.txtGiaBan.Multiline = false;
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtGiaBan.PasswordChar = false;
            this.txtGiaBan.Size = new System.Drawing.Size(170, 31);
            this.txtGiaBan.TabIndex = 25;
            this.txtGiaBan.Texts = "";
            this.txtGiaBan.UnderlinedStyle = true;
            // 
            // txtId
            // 
            this.txtId.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtId.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtId.BorderSize = 2;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtId.Location = new System.Drawing.Point(135, 31);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Multiline = false;
            this.txtId.Name = "txtId";
            this.txtId.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtId.PasswordChar = false;
            this.txtId.Size = new System.Drawing.Size(169, 31);
            this.txtId.TabIndex = 22;
            this.txtId.Texts = "";
            this.txtId.UnderlinedStyle = true;
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtTenSanPham.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTenSanPham.BorderSize = 2;
            this.txtTenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSanPham.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtTenSanPham.Location = new System.Drawing.Point(135, 121);
            this.txtTenSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenSanPham.Multiline = false;
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTenSanPham.PasswordChar = false;
            this.txtTenSanPham.Size = new System.Drawing.Size(169, 31);
            this.txtTenSanPham.TabIndex = 9;
            this.txtTenSanPham.Texts = "";
            this.txtTenSanPham.UnderlinedStyle = true;
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 30;
            this.elipseControl1.TargetControl = this;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtTinhTrang.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTinhTrang.BorderSize = 2;
            this.txtTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTinhTrang.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtTinhTrang.Location = new System.Drawing.Point(546, 135);
            this.txtTinhTrang.Margin = new System.Windows.Forms.Padding(2);
            this.txtTinhTrang.Multiline = false;
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTinhTrang.PasswordChar = false;
            this.txtTinhTrang.Size = new System.Drawing.Size(170, 31);
            this.txtTinhTrang.TabIndex = 78;
            this.txtTinhTrang.Texts = "";
            this.txtTinhTrang.UnderlinedStyle = true;
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(766, 579);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewSanPham);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormProduct";
            this.Text = "Sản phẩm";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ElipseToolDemo.ElipseControl elipseControl1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private CustomControls.TextBoxControl txtSoLuong;
        private System.Windows.Forms.Label label3;
        private CustomControls.TextBoxControl txtGiaBan;
        private System.Windows.Forms.PictureBox pictureBoxSanPham;
        private System.Windows.Forms.Label label2;
        private CustomControls.TextBoxControl txtId;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private CustomControls.TextBoxControl txtTenSanPham;
        private System.Windows.Forms.Label lblIdLoaiSanPham;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewSanPham;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnTaiAnhSanPham;
        private ComboBoxControl cmbCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn productId;
        private System.Windows.Forms.DataGridViewComboBoxColumn idCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productImg;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn productLotId;
        private System.Windows.Forms.DataGridViewTextBoxColumn productLotDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn productStatus;
        private CustomControls.TextBoxControl txtTinhTrang;
    }
}