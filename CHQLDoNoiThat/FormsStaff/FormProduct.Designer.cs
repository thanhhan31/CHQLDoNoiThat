
namespace CHQLDoNoiThat.FormsStaff
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.elipseControl1 = new ElipseToolDemo.ElipseControl();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoLuong = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGiaBan = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.dataGridViewSanPham = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenSanPham = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.lblIdLoaiSanPham = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtId = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtLoaiSanPham = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.pictureBoxSanPham = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTimTenSanPham = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.productId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productImg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productLotId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productLotDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanPham)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 30;
            this.elipseControl1.TargetControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(611, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 28);
            this.label4.TabIndex = 28;
            this.label4.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtSoLuong.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSoLuong.BorderSize = 2;
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtSoLuong.Location = new System.Drawing.Point(713, 94);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuong.Multiline = false;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtSoLuong.PasswordChar = false;
            this.txtSoLuong.Size = new System.Drawing.Size(227, 39);
            this.txtSoLuong.TabIndex = 27;
            this.txtSoLuong.Texts = "";
            this.txtSoLuong.UnderlinedStyle = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(611, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 28);
            this.label3.TabIndex = 26;
            this.label3.Text = "Giá bán";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtGiaBan.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtGiaBan.BorderSize = 2;
            this.txtGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBan.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtGiaBan.Location = new System.Drawing.Point(713, 30);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaBan.Multiline = false;
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtGiaBan.PasswordChar = false;
            this.txtGiaBan.Size = new System.Drawing.Size(227, 39);
            this.txtGiaBan.TabIndex = 25;
            this.txtGiaBan.Texts = "";
            this.txtGiaBan.UnderlinedStyle = true;
            // 
            // dataGridViewSanPham
            // 
            this.dataGridViewSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productId,
            this.productCategory,
            this.productName,
            this.productImg,
            this.productPrice,
            this.productQuantity,
            this.productLotId,
            this.productLotDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSanPham.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSanPham.EnableHeadersVisualStyles = false;
            this.dataGridViewSanPham.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewSanPham.Location = new System.Drawing.Point(13, 290);
            this.dataGridViewSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewSanPham.Name = "dataGridViewSanPham";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSanPham.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSanPham.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewSanPham.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewSanPham.RowTemplate.Height = 24;
            this.dataGridViewSanPham.Size = new System.Drawing.Size(995, 401);
            this.dataGridViewSanPham.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(23, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 28);
            this.label2.TabIndex = 23;
            this.label2.Text = "Id sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(23, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên sản phẩm";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtTenSanPham.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTenSanPham.BorderSize = 2;
            this.txtTenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSanPham.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtTenSanPham.Location = new System.Drawing.Point(180, 149);
            this.txtTenSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenSanPham.Multiline = false;
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtTenSanPham.PasswordChar = false;
            this.txtTenSanPham.Size = new System.Drawing.Size(225, 39);
            this.txtTenSanPham.TabIndex = 9;
            this.txtTenSanPham.Texts = "";
            this.txtTenSanPham.UnderlinedStyle = true;
            // 
            // lblIdLoaiSanPham
            // 
            this.lblIdLoaiSanPham.AutoSize = true;
            this.lblIdLoaiSanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdLoaiSanPham.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblIdLoaiSanPham.Location = new System.Drawing.Point(23, 100);
            this.lblIdLoaiSanPham.Name = "lblIdLoaiSanPham";
            this.lblIdLoaiSanPham.Size = new System.Drawing.Size(144, 28);
            this.lblIdLoaiSanPham.TabIndex = 8;
            this.lblIdLoaiSanPham.Text = "Loại sản phẩm";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(411, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 37);
            this.label6.TabIndex = 14;
            this.label6.Text = "Danh sách sản phẩm";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtId
            // 
            this.txtId.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtId.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtId.BorderSize = 2;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtId.Location = new System.Drawing.Point(180, 38);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Multiline = false;
            this.txtId.Name = "txtId";
            this.txtId.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtId.PasswordChar = false;
            this.txtId.Size = new System.Drawing.Size(225, 39);
            this.txtId.TabIndex = 22;
            this.txtId.Texts = "";
            this.txtId.UnderlinedStyle = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtLoaiSanPham);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtSoLuong);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtGiaBan);
            this.panel3.Controls.Add(this.pictureBoxSanPham);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtId);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtTenSanPham);
            this.panel3.Controls.Add(this.lblIdLoaiSanPham);
            this.panel3.Location = new System.Drawing.Point(13, 21);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(995, 222);
            this.panel3.TabIndex = 12;
            // 
            // txtLoaiSanPham
            // 
            this.txtLoaiSanPham.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtLoaiSanPham.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtLoaiSanPham.BorderSize = 2;
            this.txtLoaiSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiSanPham.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtLoaiSanPham.Location = new System.Drawing.Point(180, 89);
            this.txtLoaiSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLoaiSanPham.Multiline = false;
            this.txtLoaiSanPham.Name = "txtLoaiSanPham";
            this.txtLoaiSanPham.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtLoaiSanPham.PasswordChar = false;
            this.txtLoaiSanPham.Size = new System.Drawing.Size(225, 39);
            this.txtLoaiSanPham.TabIndex = 80;
            this.txtLoaiSanPham.Texts = "";
            this.txtLoaiSanPham.UnderlinedStyle = true;
            // 
            // pictureBoxSanPham
            // 
            this.pictureBoxSanPham.Location = new System.Drawing.Point(421, 20);
            this.pictureBoxSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxSanPham.Name = "pictureBoxSanPham";
            this.pictureBoxSanPham.Size = new System.Drawing.Size(183, 185);
            this.pictureBoxSanPham.TabIndex = 24;
            this.pictureBoxSanPham.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(15, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 28);
            this.label5.TabIndex = 24;
            this.label5.Text = "Tìm tên sản phẩm";
            // 
            // txtTimTenSanPham
            // 
            this.txtTimTenSanPham.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtTimTenSanPham.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTimTenSanPham.BorderSize = 2;
            this.txtTimTenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimTenSanPham.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtTimTenSanPham.Location = new System.Drawing.Point(193, 247);
            this.txtTimTenSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimTenSanPham.Multiline = false;
            this.txtTimTenSanPham.Name = "txtTimTenSanPham";
            this.txtTimTenSanPham.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtTimTenSanPham.PasswordChar = false;
            this.txtTimTenSanPham.Size = new System.Drawing.Size(225, 39);
            this.txtTimTenSanPham.TabIndex = 81;
            this.txtTimTenSanPham.Texts = "";
            this.txtTimTenSanPham.UnderlinedStyle = true;
            this.txtTimTenSanPham.TextChanged += new System.EventHandler(this.txtTimTenSanPham_TextChanged);
            // 
            // productId
            // 
            this.productId.DataPropertyName = "productId";
            this.productId.HeaderText = "Mã sản phẩm";
            this.productId.MinimumWidth = 6;
            this.productId.Name = "productId";
            this.productId.Width = 150;
            // 
            // productCategory
            // 
            this.productCategory.DataPropertyName = "productCategory";
            this.productCategory.HeaderText = "Loại sản phẩm";
            this.productCategory.MinimumWidth = 6;
            this.productCategory.Name = "productCategory";
            this.productCategory.Width = 150;
            // 
            // productName
            // 
            this.productName.DataPropertyName = "productName";
            this.productName.HeaderText = "Tên sản phẩm";
            this.productName.MinimumWidth = 6;
            this.productName.Name = "productName";
            this.productName.Width = 150;
            // 
            // productImg
            // 
            this.productImg.DataPropertyName = "productImg";
            this.productImg.HeaderText = "productImg";
            this.productImg.MinimumWidth = 6;
            this.productImg.Name = "productImg";
            this.productImg.Visible = false;
            this.productImg.Width = 125;
            // 
            // productPrice
            // 
            this.productPrice.DataPropertyName = "productPrice";
            this.productPrice.HeaderText = "Giá bán";
            this.productPrice.MinimumWidth = 6;
            this.productPrice.Name = "productPrice";
            this.productPrice.Width = 125;
            // 
            // productQuantity
            // 
            this.productQuantity.DataPropertyName = "productQuantity";
            this.productQuantity.HeaderText = "Số lượng hiện có";
            this.productQuantity.MinimumWidth = 6;
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.Width = 175;
            // 
            // productLotId
            // 
            this.productLotId.DataPropertyName = "productLotId";
            this.productLotId.HeaderText = "Mã lô sản phẩm";
            this.productLotId.MinimumWidth = 6;
            this.productLotId.Name = "productLotId";
            this.productLotId.Width = 175;
            // 
            // productLotDate
            // 
            this.productLotDate.DataPropertyName = "productLotDate";
            this.productLotDate.HeaderText = "Ngày nhập lô";
            this.productLotDate.MinimumWidth = 6;
            this.productLotDate.Name = "productLotDate";
            this.productLotDate.Width = 150;
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1021, 713);
            this.Controls.Add(this.txtTimTenSanPham);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewSanPham);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormProduct";
            this.Text = "Sản phẩm";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanPham)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ElipseToolDemo.ElipseControl elipseControl1;
        private System.Windows.Forms.DataGridView dataGridViewSanPham;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private CustomControls.TextBoxControl txtSoLuong;
        private System.Windows.Forms.Label label3;
        private CustomControls.TextBoxControl txtGiaBan;
        private System.Windows.Forms.PictureBox pictureBoxSanPham;
        private System.Windows.Forms.Label label2;
        private CustomControls.TextBoxControl txtId;
        private System.Windows.Forms.Label label1;
        private CustomControls.TextBoxControl txtTenSanPham;
        private System.Windows.Forms.Label lblIdLoaiSanPham;
        private CustomControls.TextBoxControl txtLoaiSanPham;
        private CustomControls.TextBoxControl txtTimTenSanPham;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn productId;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productImg;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn productLotId;
        private System.Windows.Forms.DataGridViewTextBoxColumn productLotDate;
    }
}