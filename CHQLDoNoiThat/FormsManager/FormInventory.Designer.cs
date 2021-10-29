
namespace CHQLDoNoiThat.FormsManager
{
    partial class FormInventory
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
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewKho = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTinhTrang = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.cmbTenSanPham = new CHQLDoNoiThat.ComboBoxControl();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.datePickerControlNgayNhap = new CHQLDoNoiThat.DatePickerControl();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVat = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.txtLoiNhuan = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGiaGoc = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoLuong = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.lblIdLoaiSanPham = new System.Windows.Forms.Label();
            this.cmbTenSanPham_Loc = new CHQLDoNoiThat.ComboBoxControl();
            this.elipseControl1 = new ElipseToolDemo.ElipseControl();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productCate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oriPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quatity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lotStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKho)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(341, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(344, 37);
            this.label6.TabIndex = 14;
            this.label6.Text = "Danh sách sản phẩm trong kho";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewKho
            // 
            this.dataGridViewKho.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewKho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewKho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.productName,
            this.productCate,
            this.sellPrice,
            this.oriPrice,
            this.profit,
            this.vat,
            this.quatity,
            this.productStatus,
            this.lotStatus,
            this.impDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewKho.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewKho.EnableHeadersVisualStyles = false;
            this.dataGridViewKho.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewKho.Location = new System.Drawing.Point(13, 362);
            this.dataGridViewKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewKho.Name = "dataGridViewKho";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewKho.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewKho.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewKho.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewKho.RowTemplate.Height = 24;
            this.dataGridViewKho.Size = new System.Drawing.Size(981, 329);
            this.dataGridViewKho.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtTinhTrang);
            this.panel3.Controls.Add(this.cmbTenSanPham);
            this.panel3.Controls.Add(this.btnTaiLai);
            this.panel3.Controls.Add(this.btnLuu);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.datePickerControlNgayNhap);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtVat);
            this.panel3.Controls.Add(this.txtLoiNhuan);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtGiaGoc);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtId);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtSoLuong);
            this.panel3.Controls.Add(this.lblIdLoaiSanPham);
            this.panel3.Location = new System.Drawing.Point(13, 33);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(981, 254);
            this.panel3.TabIndex = 12;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtTinhTrang.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTinhTrang.BorderSize = 2;
            this.txtTinhTrang.Enabled = false;
            this.txtTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTinhTrang.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtTinhTrang.Location = new System.Drawing.Point(712, 66);
            this.txtTinhTrang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTinhTrang.Multiline = false;
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtTinhTrang.PasswordChar = false;
            this.txtTinhTrang.Size = new System.Drawing.Size(259, 39);
            this.txtTinhTrang.TabIndex = 42;
            this.txtTinhTrang.Texts = "";
            this.txtTinhTrang.UnderlinedStyle = true;
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
            this.cmbTenSanPham.Location = new System.Drawing.Point(157, 78);
            this.cmbTenSanPham.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmbTenSanPham.MaximumSize = new System.Drawing.Size(241, 39);
            this.cmbTenSanPham.MinimumSize = new System.Drawing.Size(133, 30);
            this.cmbTenSanPham.Name = "cmbTenSanPham";
            this.cmbTenSanPham.Padding = new System.Windows.Forms.Padding(1);
            this.cmbTenSanPham.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbTenSanPham.Size = new System.Drawing.Size(164, 37);
            this.cmbTenSanPham.TabIndex = 27;
            this.cmbTenSanPham.Texts = "";
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.AutoSize = true;
            this.btnTaiLai.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTaiLai.FlatAppearance.BorderSize = 0;
            this.btnTaiLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiLai.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiLai.ForeColor = System.Drawing.Color.White;
            this.btnTaiLai.Location = new System.Drawing.Point(817, 197);
            this.btnTaiLai.Margin = new System.Windows.Forms.Padding(0);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(105, 47);
            this.btnTaiLai.TabIndex = 41;
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
            this.btnLuu.Location = new System.Drawing.Point(633, 197);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(0);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(105, 47);
            this.btnLuu.TabIndex = 40;
            this.btnLuu.TabStop = false;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SteelBlue;
            this.label10.Location = new System.Drawing.Point(595, 78);
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
            this.datePickerControlNgayNhap.Location = new System.Drawing.Point(712, 14);
            this.datePickerControlNgayNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datePickerControlNgayNhap.MinimumSize = new System.Drawing.Size(4, 35);
            this.datePickerControlNgayNhap.Name = "datePickerControlNgayNhap";
            this.datePickerControlNgayNhap.Size = new System.Drawing.Size(257, 35);
            this.datePickerControlNgayNhap.SkinColor = System.Drawing.Color.SteelBlue;
            this.datePickerControlNgayNhap.TabIndex = 37;
            this.datePickerControlNgayNhap.TextColor = System.Drawing.Color.White;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(328, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 28);
            this.label8.TabIndex = 34;
            this.label8.Text = "Vat";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(595, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 28);
            this.label9.TabIndex = 32;
            this.label9.Text = "Ngày nhập";
            // 
            // txtVat
            // 
            this.txtVat.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtVat.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtVat.BorderSize = 2;
            this.txtVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVat.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtVat.Location = new System.Drawing.Point(437, 121);
            this.txtVat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVat.Multiline = false;
            this.txtVat.Name = "txtVat";
            this.txtVat.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtVat.PasswordChar = false;
            this.txtVat.Size = new System.Drawing.Size(145, 39);
            this.txtVat.TabIndex = 31;
            this.txtVat.Texts = "";
            this.txtVat.UnderlinedStyle = true;
            // 
            // txtLoiNhuan
            // 
            this.txtLoiNhuan.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtLoiNhuan.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtLoiNhuan.BorderSize = 2;
            this.txtLoiNhuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoiNhuan.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtLoiNhuan.Location = new System.Drawing.Point(437, 66);
            this.txtLoiNhuan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLoiNhuan.Multiline = false;
            this.txtLoiNhuan.Name = "txtLoiNhuan";
            this.txtLoiNhuan.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtLoiNhuan.PasswordChar = false;
            this.txtLoiNhuan.Size = new System.Drawing.Size(145, 39);
            this.txtLoiNhuan.TabIndex = 30;
            this.txtLoiNhuan.Texts = "";
            this.txtLoiNhuan.UnderlinedStyle = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(328, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 28);
            this.label5.TabIndex = 29;
            this.label5.Text = "Lợi nhuận";
            // 
            // txtGiaGoc
            // 
            this.txtGiaGoc.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtGiaGoc.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtGiaGoc.BorderSize = 2;
            this.txtGiaGoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaGoc.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtGiaGoc.Location = new System.Drawing.Point(437, 10);
            this.txtGiaGoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaGoc.Multiline = false;
            this.txtGiaGoc.Name = "txtGiaGoc";
            this.txtGiaGoc.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtGiaGoc.PasswordChar = false;
            this.txtGiaGoc.Size = new System.Drawing.Size(145, 39);
            this.txtGiaGoc.TabIndex = 27;
            this.txtGiaGoc.Texts = "";
            this.txtGiaGoc.UnderlinedStyle = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(328, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 28);
            this.label3.TabIndex = 26;
            this.label3.Text = "Giá gốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(13, 18);
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
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Multiline = false;
            this.txtId.Name = "txtId";
            this.txtId.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtId.PasswordChar = false;
            this.txtId.Size = new System.Drawing.Size(163, 39);
            this.txtId.TabIndex = 22;
            this.txtId.Texts = "";
            this.txtId.UnderlinedStyle = true;
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.BackColor = System.Drawing.Color.SteelBlue;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(445, 197);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(105, 47);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.TabStop = false;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Kho_Click);
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = true;
            this.btnSua.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(251, 197);
            this.btnSua.Margin = new System.Windows.Forms.Padding(0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(107, 47);
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
            this.btnThem.Location = new System.Drawing.Point(51, 196);
            this.btnThem.Margin = new System.Windows.Forms.Padding(0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(103, 47);
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
            this.label1.Location = new System.Drawing.Point(13, 130);
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
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuong.Multiline = false;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtSoLuong.PasswordChar = false;
            this.txtSoLuong.Size = new System.Drawing.Size(163, 39);
            this.txtSoLuong.TabIndex = 9;
            this.txtSoLuong.Texts = "";
            this.txtSoLuong.UnderlinedStyle = true;
            // 
            // lblIdLoaiSanPham
            // 
            this.lblIdLoaiSanPham.AutoSize = true;
            this.lblIdLoaiSanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdLoaiSanPham.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblIdLoaiSanPham.Location = new System.Drawing.Point(13, 74);
            this.lblIdLoaiSanPham.Name = "lblIdLoaiSanPham";
            this.lblIdLoaiSanPham.Size = new System.Drawing.Size(139, 28);
            this.lblIdLoaiSanPham.TabIndex = 8;
            this.lblIdLoaiSanPham.Text = "Tên sản phẩm";
            // 
            // cmbTenSanPham_Loc
            // 
            this.cmbTenSanPham_Loc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbTenSanPham_Loc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmbTenSanPham_Loc.BackColor = System.Drawing.Color.White;
            this.cmbTenSanPham_Loc.BorderColor = System.Drawing.Color.SteelBlue;
            this.cmbTenSanPham_Loc.BorderSize = 1;
            this.cmbTenSanPham_Loc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbTenSanPham_Loc.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenSanPham_Loc.ForeColor = System.Drawing.Color.SteelBlue;
            this.cmbTenSanPham_Loc.IconColor = System.Drawing.Color.SteelBlue;
            this.cmbTenSanPham_Loc.ListBackColor = System.Drawing.Color.White;
            this.cmbTenSanPham_Loc.ListTextColor = System.Drawing.Color.SteelBlue;
            this.cmbTenSanPham_Loc.Location = new System.Drawing.Point(13, 306);
            this.cmbTenSanPham_Loc.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmbTenSanPham_Loc.MaximumSize = new System.Drawing.Size(241, 39);
            this.cmbTenSanPham_Loc.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbTenSanPham_Loc.Name = "cmbTenSanPham_Loc";
            this.cmbTenSanPham_Loc.Padding = new System.Windows.Forms.Padding(1);
            this.cmbTenSanPham_Loc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbTenSanPham_Loc.Size = new System.Drawing.Size(241, 39);
            this.cmbTenSanPham_Loc.TabIndex = 26;
            this.cmbTenSanPham_Loc.Texts = "Tên sản phẩm";
            this.cmbTenSanPham_Loc.OnSelectedIndexChanged += new System.EventHandler(this.cmbTenSanPham_Loc_OnSelectedIndexChanged);
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 30;
            this.elipseControl1.TargetControl = this;
            // 
            // id
            // 
            this.id.DataPropertyName = "lotId";
            this.id.HeaderText = "Mã lô";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // productName
            // 
            this.productName.DataPropertyName = "productId";
            this.productName.HeaderText = "Tên sản phẩm";
            this.productName.MinimumWidth = 6;
            this.productName.Name = "productName";
            this.productName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.productName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.productName.Width = 150;
            // 
            // productCate
            // 
            this.productCate.DataPropertyName = "productCategory";
            this.productCate.HeaderText = "Loại sản phẩm";
            this.productCate.MinimumWidth = 6;
            this.productCate.Name = "productCate";
            this.productCate.Width = 150;
            // 
            // sellPrice
            // 
            this.sellPrice.DataPropertyName = "sellPrice";
            this.sellPrice.HeaderText = "Giá bán";
            this.sellPrice.MinimumWidth = 6;
            this.sellPrice.Name = "sellPrice";
            this.sellPrice.Width = 125;
            // 
            // oriPrice
            // 
            this.oriPrice.DataPropertyName = "originalPrice";
            this.oriPrice.HeaderText = "Giá gốc";
            this.oriPrice.MinimumWidth = 6;
            this.oriPrice.Name = "oriPrice";
            this.oriPrice.Width = 125;
            // 
            // profit
            // 
            this.profit.DataPropertyName = "profit";
            this.profit.HeaderText = "Lợi nhuận";
            this.profit.MinimumWidth = 6;
            this.profit.Name = "profit";
            this.profit.Width = 120;
            // 
            // vat
            // 
            this.vat.DataPropertyName = "vat";
            this.vat.HeaderText = "Thuế";
            this.vat.MinimumWidth = 6;
            this.vat.Name = "vat";
            // 
            // quatity
            // 
            this.quatity.DataPropertyName = "lotQuantity";
            this.quatity.HeaderText = "Số lượng";
            this.quatity.MinimumWidth = 6;
            this.quatity.Name = "quatity";
            this.quatity.Width = 120;
            // 
            // productStatus
            // 
            this.productStatus.DataPropertyName = "productStatus";
            this.productStatus.HeaderText = "Trạng thái sản phẩm";
            this.productStatus.MinimumWidth = 6;
            this.productStatus.Name = "productStatus";
            this.productStatus.Width = 200;
            // 
            // lotStatus
            // 
            this.lotStatus.DataPropertyName = "lotStatus";
            this.lotStatus.HeaderText = "Trạng thái lô";
            this.lotStatus.MinimumWidth = 6;
            this.lotStatus.Name = "lotStatus";
            this.lotStatus.Width = 150;
            // 
            // impDate
            // 
            this.impDate.DataPropertyName = "importDate";
            this.impDate.HeaderText = "Ngày nhập";
            this.impDate.MinimumWidth = 6;
            this.impDate.Name = "impDate";
            this.impDate.Width = 150;
            // 
            // FormInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1021, 713);
            this.Controls.Add(this.cmbTenSanPham_Loc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewKho);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormInventory";
            this.Text = "Kho";
            this.Load += new System.EventHandler(this.FormInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKho)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewKho;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private CustomControls.TextBoxControl txtGiaGoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CustomControls.TextBoxControl txtId;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private CustomControls.TextBoxControl txtSoLuong;
        private System.Windows.Forms.Label lblIdLoaiSanPham;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private CustomControls.TextBoxControl txtVat;
        private CustomControls.TextBoxControl txtLoiNhuan;
        private DatePickerControl datePickerControlNgayNhap;
        private System.Windows.Forms.Label label10;
        private ElipseToolDemo.ElipseControl elipseControl1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnTaiLai;
        private ComboBoxControl cmbTenSanPham_Loc;
        private ComboBoxControl cmbTenSanPham;
        private CustomControls.TextBoxControl txtTinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewComboBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCate;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn oriPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn vat;
        private System.Windows.Forms.DataGridViewTextBoxColumn quatity;
        private System.Windows.Forms.DataGridViewTextBoxColumn productStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn lotStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn impDate;
    }
}