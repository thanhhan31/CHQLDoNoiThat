
namespace CHQLDoNoiThat.FormsManager
{
    partial class FormStaff
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
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewNhanVien = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avatar = new System.Windows.Forms.DataGridViewImageColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBoxNhanVien = new System.Windows.Forms.PictureBox();
            this.btnTaiAnhDaiDien = new System.Windows.Forms.Button();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.cmbTinhTrang = new CHQLDoNoiThat.ComboBoxControl();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbChucVu = new CHQLDoNoiThat.ComboBoxControl();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.cmbGioiTinh = new CHQLDoNoiThat.ComboBoxControl();
            this.label10 = new System.Windows.Forms.Label();
            this.datePickerControlNgaySinh = new CHQLDoNoiThat.DatePickerControl();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCMND = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.txtSDT = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.btnVohieuhoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiaChi = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.lblIdLoaiSanPham = new System.Windows.Forms.Label();
            this.txtHoTen = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.elipseControl1 = new ElipseToolDemo.ElipseControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(262, 334);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 30);
            this.label6.TabIndex = 14;
            this.label6.Text = "Danh sách nhân viên";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewNhanVien
            // 
            this.dataGridViewNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.dob,
            this.gender,
            this.phone,
            this.idNo,
            this.address,
            this.email,
            this.idType,
            this.active,
            this.avatar,
            this.password});
            this.dataGridViewNhanVien.Location = new System.Drawing.Point(10, 366);
            this.dataGridViewNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewNhanVien.Name = "dataGridViewNhanVien";
            this.dataGridViewNhanVien.RowHeadersWidth = 51;
            this.dataGridViewNhanVien.RowTemplate.Height = 24;
            this.dataGridViewNhanVien.Size = new System.Drawing.Size(746, 195);
            this.dataGridViewNhanVien.TabIndex = 13;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã nhân viên";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Tên nhân viên";
            this.name.Name = "name";
            // 
            // dob
            // 
            this.dob.DataPropertyName = "dob";
            this.dob.HeaderText = "Ngày sinh";
            this.dob.Name = "dob";
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Giới tính";
            this.gender.Name = "gender";
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Số điện thoại";
            this.phone.Name = "phone";
            // 
            // idNo
            // 
            this.idNo.DataPropertyName = "idNo";
            this.idNo.HeaderText = "CMND/CCCD";
            this.idNo.Name = "idNo";
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Địa chỉ";
            this.address.Name = "address";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // idType
            // 
            this.idType.DataPropertyName = "idType";
            this.idType.HeaderText = "Chức vụ";
            this.idType.Name = "idType";
            this.idType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // active
            // 
            this.active.DataPropertyName = "active";
            this.active.HeaderText = "active";
            this.active.Name = "active";
            this.active.Visible = false;
            // 
            // avatar
            // 
            this.avatar.DataPropertyName = "avatar";
            this.avatar.HeaderText = "avatar";
            this.avatar.Name = "avatar";
            this.avatar.Visible = false;
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "password";
            this.password.Name = "password";
            this.password.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pictureBoxNhanVien);
            this.panel3.Controls.Add(this.btnTaiAnhDaiDien);
            this.panel3.Controls.Add(this.btnTaiLai);
            this.panel3.Controls.Add(this.btnLuu);
            this.panel3.Controls.Add(this.cmbTinhTrang);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.cmbChucVu);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtPassword);
            this.panel3.Controls.Add(this.cmbGioiTinh);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.datePickerControlNgaySinh);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtCMND);
            this.panel3.Controls.Add(this.txtSDT);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtId);
            this.panel3.Controls.Add(this.btnVohieuhoa);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtDiaChi);
            this.panel3.Controls.Add(this.lblIdLoaiSanPham);
            this.panel3.Controls.Add(this.txtHoTen);
            this.panel3.Location = new System.Drawing.Point(10, 17);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(746, 307);
            this.panel3.TabIndex = 12;
            // 
            // pictureBoxNhanVien
            // 
            this.pictureBoxNhanVien.Location = new System.Drawing.Point(16, 6);
            this.pictureBoxNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxNhanVien.Name = "pictureBoxNhanVien";
            this.pictureBoxNhanVien.Size = new System.Drawing.Size(133, 136);
            this.pictureBoxNhanVien.TabIndex = 77;
            this.pictureBoxNhanVien.TabStop = false;
            // 
            // btnTaiAnhDaiDien
            // 
            this.btnTaiAnhDaiDien.AutoSize = true;
            this.btnTaiAnhDaiDien.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTaiAnhDaiDien.FlatAppearance.BorderSize = 0;
            this.btnTaiAnhDaiDien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiAnhDaiDien.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiAnhDaiDien.ForeColor = System.Drawing.Color.White;
            this.btnTaiAnhDaiDien.Location = new System.Drawing.Point(16, 145);
            this.btnTaiAnhDaiDien.Margin = new System.Windows.Forms.Padding(0);
            this.btnTaiAnhDaiDien.Name = "btnTaiAnhDaiDien";
            this.btnTaiAnhDaiDien.Size = new System.Drawing.Size(133, 32);
            this.btnTaiAnhDaiDien.TabIndex = 76;
            this.btnTaiAnhDaiDien.TabStop = false;
            this.btnTaiAnhDaiDien.Text = "Tải ảnh đại diện";
            this.btnTaiAnhDaiDien.UseVisualStyleBackColor = false;
            this.btnTaiAnhDaiDien.Click += new System.EventHandler(this.btnTaiAnhDaiDien_Click);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.AutoSize = true;
            this.btnTaiLai.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTaiLai.FlatAppearance.BorderSize = 0;
            this.btnTaiLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiLai.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiLai.ForeColor = System.Drawing.Color.White;
            this.btnTaiLai.Location = new System.Drawing.Point(576, 268);
            this.btnTaiLai.Margin = new System.Windows.Forms.Padding(0);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(79, 32);
            this.btnTaiLai.TabIndex = 48;
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
            this.btnLuu.Location = new System.Drawing.Point(634, 217);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(0);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(79, 32);
            this.btnLuu.TabIndex = 47;
            this.btnLuu.TabStop = false;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
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
            "Còn làm",
            "Nghỉ việc"});
            this.cmbTinhTrang.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbTinhTrang.ListTextColor = System.Drawing.Color.SteelBlue;
            this.cmbTinhTrang.Location = new System.Drawing.Point(370, 232);
            this.cmbTinhTrang.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTinhTrang.MinimumSize = new System.Drawing.Size(98, 24);
            this.cmbTinhTrang.Name = "cmbTinhTrang";
            this.cmbTinhTrang.Padding = new System.Windows.Forms.Padding(1);
            this.cmbTinhTrang.Size = new System.Drawing.Size(114, 24);
            this.cmbTinhTrang.TabIndex = 45;
            this.cmbTinhTrang.Texts = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.SteelBlue;
            this.label11.Location = new System.Drawing.Point(286, 233);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 21);
            this.label11.TabIndex = 44;
            this.label11.Text = "Tình trạng";
            // 
            // cmbChucVu
            // 
            this.cmbChucVu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbChucVu.BorderColor = System.Drawing.Color.SteelBlue;
            this.cmbChucVu.BorderSize = 1;
            this.cmbChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbChucVu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChucVu.ForeColor = System.Drawing.Color.SteelBlue;
            this.cmbChucVu.IconColor = System.Drawing.Color.SteelBlue;
            this.cmbChucVu.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbChucVu.ListTextColor = System.Drawing.Color.SteelBlue;
            this.cmbChucVu.Location = new System.Drawing.Point(370, 183);
            this.cmbChucVu.Margin = new System.Windows.Forms.Padding(2);
            this.cmbChucVu.MinimumSize = new System.Drawing.Size(98, 24);
            this.cmbChucVu.Name = "cmbChucVu";
            this.cmbChucVu.Padding = new System.Windows.Forms.Padding(1);
            this.cmbChucVu.Size = new System.Drawing.Size(114, 24);
            this.cmbChucVu.TabIndex = 43;
            this.cmbChucVu.Texts = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(286, 183);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 21);
            this.label7.TabIndex = 42;
            this.label7.Text = "Chức vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(13, 270);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 21);
            this.label4.TabIndex = 41;
            this.label4.Text = "Password mới";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPassword.BorderSize = 2;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtPassword.Location = new System.Drawing.Point(128, 260);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPassword.PasswordChar = false;
            this.txtPassword.Size = new System.Drawing.Size(167, 31);
            this.txtPassword.TabIndex = 40;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlinedStyle = true;
            // 
            // cmbGioiTinh
            // 
            this.cmbGioiTinh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbGioiTinh.BorderColor = System.Drawing.Color.SteelBlue;
            this.cmbGioiTinh.BorderSize = 1;
            this.cmbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbGioiTinh.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGioiTinh.ForeColor = System.Drawing.Color.SteelBlue;
            this.cmbGioiTinh.IconColor = System.Drawing.Color.SteelBlue;
            this.cmbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmbGioiTinh.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbGioiTinh.ListTextColor = System.Drawing.Color.SteelBlue;
            this.cmbGioiTinh.Location = new System.Drawing.Point(557, 23);
            this.cmbGioiTinh.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGioiTinh.MinimumSize = new System.Drawing.Size(98, 24);
            this.cmbGioiTinh.Name = "cmbGioiTinh";
            this.cmbGioiTinh.Padding = new System.Windows.Forms.Padding(1);
            this.cmbGioiTinh.Size = new System.Drawing.Size(160, 24);
            this.cmbGioiTinh.TabIndex = 39;
            this.cmbGioiTinh.Texts = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SteelBlue;
            this.label10.Location = new System.Drawing.Point(13, 227);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 21);
            this.label10.TabIndex = 38;
            this.label10.Text = "Email";
            // 
            // datePickerControlNgaySinh
            // 
            this.datePickerControlNgaySinh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.datePickerControlNgaySinh.BorderSize = 0;
            this.datePickerControlNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.datePickerControlNgaySinh.Location = new System.Drawing.Point(239, 114);
            this.datePickerControlNgaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.datePickerControlNgaySinh.MinimumSize = new System.Drawing.Size(4, 35);
            this.datePickerControlNgaySinh.Name = "datePickerControlNgaySinh";
            this.datePickerControlNgaySinh.Size = new System.Drawing.Size(194, 35);
            this.datePickerControlNgaySinh.SkinColor = System.Drawing.Color.SteelBlue;
            this.datePickerControlNgaySinh.TabIndex = 37;
            this.datePickerControlNgaySinh.TextColor = System.Drawing.Color.White;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(467, 116);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 21);
            this.label8.TabIndex = 34;
            this.label8.Text = "CMND";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(13, 181);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 21);
            this.label9.TabIndex = 32;
            this.label9.Text = "Địa chỉ";
            // 
            // txtCMND
            // 
            this.txtCMND.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtCMND.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCMND.BorderSize = 2;
            this.txtCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtCMND.Location = new System.Drawing.Point(557, 109);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(2);
            this.txtCMND.Multiline = false;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtCMND.PasswordChar = false;
            this.txtCMND.Size = new System.Drawing.Size(160, 31);
            this.txtCMND.TabIndex = 31;
            this.txtCMND.Texts = "";
            this.txtCMND.UnderlinedStyle = true;
            // 
            // txtSDT
            // 
            this.txtSDT.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtSDT.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSDT.BorderSize = 2;
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtSDT.Location = new System.Drawing.Point(557, 65);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDT.Multiline = false;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtSDT.PasswordChar = false;
            this.txtSDT.Size = new System.Drawing.Size(162, 31);
            this.txtSDT.TabIndex = 30;
            this.txtSDT.Texts = "";
            this.txtSDT.UnderlinedStyle = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(467, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 21);
            this.label5.TabIndex = 29;
            this.label5.Text = "SDT";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtEmail.Location = new System.Drawing.Point(100, 223);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.Size = new System.Drawing.Size(167, 31);
            this.txtEmail.TabIndex = 27;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(467, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 26;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(158, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 21);
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
            this.txtId.Location = new System.Drawing.Point(266, 13);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Multiline = false;
            this.txtId.Name = "txtId";
            this.txtId.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtId.PasswordChar = false;
            this.txtId.Size = new System.Drawing.Size(166, 31);
            this.txtId.TabIndex = 22;
            this.txtId.Texts = "";
            this.txtId.UnderlinedStyle = true;
            // 
            // btnVohieuhoa
            // 
            this.btnVohieuhoa.AutoSize = true;
            this.btnVohieuhoa.BackColor = System.Drawing.Color.SteelBlue;
            this.btnVohieuhoa.FlatAppearance.BorderSize = 0;
            this.btnVohieuhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVohieuhoa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVohieuhoa.ForeColor = System.Drawing.Color.White;
            this.btnVohieuhoa.Location = new System.Drawing.Point(509, 217);
            this.btnVohieuhoa.Margin = new System.Windows.Forms.Padding(0);
            this.btnVohieuhoa.Name = "btnVohieuhoa";
            this.btnVohieuhoa.Size = new System.Drawing.Size(105, 32);
            this.btnVohieuhoa.TabIndex = 21;
            this.btnVohieuhoa.TabStop = false;
            this.btnVohieuhoa.Text = "Vô hiệu hóa";
            this.btnVohieuhoa.UseVisualStyleBackColor = false;
            this.btnVohieuhoa.Click += new System.EventHandler(this.btnVohieuhoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = true;
            this.btnSua.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(634, 156);
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
            this.btnThem.Location = new System.Drawing.Point(524, 158);
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
            this.label1.Location = new System.Drawing.Point(158, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ngày sinh";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtDiaChi.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDiaChi.BorderSize = 2;
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtDiaChi.Location = new System.Drawing.Point(100, 180);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiaChi.Multiline = false;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtDiaChi.PasswordChar = false;
            this.txtDiaChi.Size = new System.Drawing.Size(167, 31);
            this.txtDiaChi.TabIndex = 9;
            this.txtDiaChi.Texts = "";
            this.txtDiaChi.UnderlinedStyle = true;
            // 
            // lblIdLoaiSanPham
            // 
            this.lblIdLoaiSanPham.AutoSize = true;
            this.lblIdLoaiSanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdLoaiSanPham.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblIdLoaiSanPham.Location = new System.Drawing.Point(158, 61);
            this.lblIdLoaiSanPham.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdLoaiSanPham.Name = "lblIdLoaiSanPham";
            this.lblIdLoaiSanPham.Size = new System.Drawing.Size(60, 21);
            this.lblIdLoaiSanPham.TabIndex = 8;
            this.lblIdLoaiSanPham.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtHoTen.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtHoTen.BorderSize = 2;
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtHoTen.Location = new System.Drawing.Point(266, 58);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoTen.Multiline = false;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtHoTen.PasswordChar = false;
            this.txtHoTen.Size = new System.Drawing.Size(166, 31);
            this.txtHoTen.TabIndex = 0;
            this.txtHoTen.Texts = "";
            this.txtHoTen.UnderlinedStyle = true;
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 30;
            this.elipseControl1.TargetControl = this;
            // 
            // FormStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(766, 579);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewNhanVien);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormStaff";
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.FormStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewNhanVien;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private CustomControls.TextBoxControl txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CustomControls.TextBoxControl txtId;
        private System.Windows.Forms.Button btnVohieuhoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private CustomControls.TextBoxControl txtDiaChi;
        private System.Windows.Forms.Label lblIdLoaiSanPham;
        private CustomControls.TextBoxControl txtHoTen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private CustomControls.TextBoxControl txtCMND;
        private CustomControls.TextBoxControl txtSDT;
        private DatePickerControl datePickerControlNgaySinh;
        private ComboBoxControl cmbGioiTinh;
        private System.Windows.Forms.Label label10;
        private ElipseToolDemo.ElipseControl elipseControl1;
        private System.Windows.Forms.Label label4;
        private CustomControls.TextBoxControl txtPassword;
        private ComboBoxControl cmbTinhTrang;
        private System.Windows.Forms.Label label11;
        private ComboBoxControl cmbChucVu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.Button btnTaiAnhDaiDien;
        private System.Windows.Forms.PictureBox pictureBoxNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewComboBoxColumn idType;
        private System.Windows.Forms.DataGridViewTextBoxColumn active;
        private System.Windows.Forms.DataGridViewImageColumn avatar;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
    }
}