
namespace CHQLDoNoiThat.FormsStaff
{
    partial class FormInventoty
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
            this.cmbTinhTrang = new CHQLDoNoiThat.ComboBoxControl();
            this.label10 = new System.Windows.Forms.Label();
            this.datePickerControlNgayNhap = new CHQLDoNoiThat.DatePickerControl();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewKho = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoLuong = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.lblIdLoaiSanPham = new System.Windows.Forms.Label();
            this.txtTenSanPham = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.cmbTenSanPham = new CHQLDoNoiThat.ComboBoxControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.elipseControl1 = new ElipseToolDemo.ElipseControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKho)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTinhTrang
            // 
            this.cmbTinhTrang.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbTinhTrang.BorderColor = System.Drawing.Color.SteelBlue;
            this.cmbTinhTrang.BorderSize = 1;
            this.cmbTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbTinhTrang.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTinhTrang.ForeColor = System.Drawing.Color.SteelBlue;
            this.cmbTinhTrang.IconColor = System.Drawing.Color.SteelBlue;
            this.cmbTinhTrang.Items.AddRange(new object[] {
            "Đang bán",
            "Tồn kho"});
            this.cmbTinhTrang.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbTinhTrang.ListTextColor = System.Drawing.Color.SteelBlue;
            this.cmbTinhTrang.Location = new System.Drawing.Point(654, 65);
            this.cmbTinhTrang.MinimumSize = new System.Drawing.Size(130, 30);
            this.cmbTinhTrang.Name = "cmbTinhTrang";
            this.cmbTinhTrang.Padding = new System.Windows.Forms.Padding(1);
            this.cmbTinhTrang.Size = new System.Drawing.Size(171, 39);
            this.cmbTinhTrang.TabIndex = 39;
            this.cmbTinhTrang.Texts = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SteelBlue;
            this.label10.Location = new System.Drawing.Point(504, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 28);
            this.label10.TabIndex = 38;
            this.label10.Text = "Tình trạng";
            // 
            // datePickerControlNgayNhap
            // 
            this.datePickerControlNgayNhap.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.datePickerControlNgayNhap.BorderSize = 0;
            this.datePickerControlNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.datePickerControlNgayNhap.Location = new System.Drawing.Point(654, 16);
            this.datePickerControlNgayNhap.MinimumSize = new System.Drawing.Size(4, 35);
            this.datePickerControlNgayNhap.Name = "datePickerControlNgayNhap";
            this.datePickerControlNgayNhap.Size = new System.Drawing.Size(276, 35);
            this.datePickerControlNgayNhap.SkinColor = System.Drawing.Color.SteelBlue;
            this.datePickerControlNgayNhap.TabIndex = 37;
            this.datePickerControlNgayNhap.TextColor = System.Drawing.Color.White;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(504, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 28);
            this.label9.TabIndex = 32;
            this.label9.Text = "Ngày nhập";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(357, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(344, 37);
            this.label6.TabIndex = 29;
            this.label6.Text = "Danh sách sản phẩm trong kho";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewKho
            // 
            this.dataGridViewKho.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewKho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKho.Location = new System.Drawing.Point(14, 299);
            this.dataGridViewKho.Name = "dataGridViewKho";
            this.dataGridViewKho.RowHeadersWidth = 51;
            this.dataGridViewKho.RowTemplate.Height = 24;
            this.dataGridViewKho.Size = new System.Drawing.Size(972, 434);
            this.dataGridViewKho.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(14, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 28);
            this.label2.TabIndex = 23;
            this.label2.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtId.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtId.BorderSize = 2;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtId.Location = new System.Drawing.Point(159, 10);
            this.txtId.Multiline = false;
            this.txtId.Name = "txtId";
            this.txtId.Padding = new System.Windows.Forms.Padding(7);
            this.txtId.PasswordChar = false;
            this.txtId.Size = new System.Drawing.Size(254, 39);
            this.txtId.TabIndex = 22;
            this.txtId.Texts = "";
            this.txtId.UnderlinedStyle = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(14, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtSoLuong.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSoLuong.BorderSize = 2;
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtSoLuong.Location = new System.Drawing.Point(159, 121);
            this.txtSoLuong.Multiline = false;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Padding = new System.Windows.Forms.Padding(7);
            this.txtSoLuong.PasswordChar = false;
            this.txtSoLuong.Size = new System.Drawing.Size(254, 39);
            this.txtSoLuong.TabIndex = 9;
            this.txtSoLuong.Texts = "";
            this.txtSoLuong.UnderlinedStyle = true;
            // 
            // lblIdLoaiSanPham
            // 
            this.lblIdLoaiSanPham.AutoSize = true;
            this.lblIdLoaiSanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdLoaiSanPham.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblIdLoaiSanPham.Location = new System.Drawing.Point(14, 73);
            this.lblIdLoaiSanPham.Name = "lblIdLoaiSanPham";
            this.lblIdLoaiSanPham.Size = new System.Drawing.Size(139, 28);
            this.lblIdLoaiSanPham.TabIndex = 8;
            this.lblIdLoaiSanPham.Text = "Tên sản phẩm";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtTenSanPham.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTenSanPham.BorderSize = 2;
            this.txtTenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSanPham.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtTenSanPham.Location = new System.Drawing.Point(159, 65);
            this.txtTenSanPham.Multiline = false;
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Padding = new System.Windows.Forms.Padding(7);
            this.txtTenSanPham.PasswordChar = false;
            this.txtTenSanPham.Size = new System.Drawing.Size(254, 39);
            this.txtTenSanPham.TabIndex = 0;
            this.txtTenSanPham.Texts = "";
            this.txtTenSanPham.UnderlinedStyle = true;
            // 
            // cmbTenSanPham
            // 
            this.cmbTenSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbTenSanPham.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmbTenSanPham.BackColor = System.Drawing.Color.White;
            this.cmbTenSanPham.BorderColor = System.Drawing.Color.SteelBlue;
            this.cmbTenSanPham.BorderSize = 1;
            this.cmbTenSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbTenSanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenSanPham.ForeColor = System.Drawing.Color.SteelBlue;
            this.cmbTenSanPham.IconColor = System.Drawing.Color.SteelBlue;
            this.cmbTenSanPham.ListBackColor = System.Drawing.Color.White;
            this.cmbTenSanPham.ListTextColor = System.Drawing.Color.SteelBlue;
            this.cmbTenSanPham.Location = new System.Drawing.Point(14, 255);
            this.cmbTenSanPham.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmbTenSanPham.MaximumSize = new System.Drawing.Size(241, 39);
            this.cmbTenSanPham.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbTenSanPham.Name = "cmbTenSanPham";
            this.cmbTenSanPham.Padding = new System.Windows.Forms.Padding(1);
            this.cmbTenSanPham.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbTenSanPham.Size = new System.Drawing.Size(241, 39);
            this.cmbTenSanPham.TabIndex = 30;
            this.cmbTenSanPham.Texts = "Tên sản phẩm";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.cmbTinhTrang);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.datePickerControlNgayNhap);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtId);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtSoLuong);
            this.panel3.Controls.Add(this.lblIdLoaiSanPham);
            this.panel3.Controls.Add(this.txtTenSanPham);
            this.panel3.Location = new System.Drawing.Point(14, 38);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(972, 187);
            this.panel3.TabIndex = 27;
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 30;
            this.elipseControl1.TargetControl = this;
            // 
            // FormInventoty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1000, 760);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewKho);
            this.Controls.Add(this.cmbTenSanPham);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInventoty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kho";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKho)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ComboBoxControl cmbTinhTrang;
        private System.Windows.Forms.Label label10;
        private DatePickerControl datePickerControlNgayNhap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewKho;
        private System.Windows.Forms.Label label2;
        private CustomControls.TextBoxControl txtId;
        private System.Windows.Forms.Label label1;
        private CustomControls.TextBoxControl txtSoLuong;
        private System.Windows.Forms.Label lblIdLoaiSanPham;
        private CustomControls.TextBoxControl txtTenSanPham;
        private ComboBoxControl cmbTenSanPham;
        private System.Windows.Forms.Panel panel3;
        private ElipseToolDemo.ElipseControl elipseControl1;
    }
}