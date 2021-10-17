
using System.Drawing;

namespace CHQLDoNoiThat
{
    partial class FormInfo
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
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIdLoaiSanPham = new System.Windows.Forms.Label();
            this.pictureBoxNhanVien = new System.Windows.Forms.PictureBox();
            this.btnTaiAnhDaiDien = new System.Windows.Forms.Button();
            this.cmbGioiTinh = new CHQLDoNoiThat.ComboBoxControl();
            this.datePickerControlNgaySinh = new CHQLDoNoiThat.DatePickerControl();
            this.txtCMND = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.txtSDT = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.txtEmail = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.txtId = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.txtDiaChi = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.txtHoTen = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.AutoSize = true;
            this.btnTaiLai.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTaiLai.FlatAppearance.BorderSize = 0;
            this.btnTaiLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiLai.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiLai.ForeColor = System.Drawing.Color.White;
            this.btnTaiLai.Location = new System.Drawing.Point(336, 419);
            this.btnTaiLai.Margin = new System.Windows.Forms.Padding(0);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(79, 32);
            this.btnTaiLai.TabIndex = 74;
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
            this.btnLuu.Location = new System.Drawing.Point(479, 419);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(0);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(79, 32);
            this.btnLuu.TabIndex = 73;
            this.btnLuu.TabStop = false;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.SteelBlue;
            this.label11.Location = new System.Drawing.Point(466, 280);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 21);
            this.label11.TabIndex = 70;
            this.label11.Text = "Tình trạng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(466, 229);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 21);
            this.label7.TabIndex = 68;
            this.label7.Text = "Chức vụ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SteelBlue;
            this.label10.Location = new System.Drawing.Point(156, 275);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 21);
            this.label10.TabIndex = 64;
            this.label10.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(466, 166);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 21);
            this.label8.TabIndex = 62;
            this.label8.Text = "CMND";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(156, 229);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 21);
            this.label9.TabIndex = 61;
            this.label9.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(466, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 21);
            this.label5.TabIndex = 58;
            this.label5.Text = "SDT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(466, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 56;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(156, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 21);
            this.label2.TabIndex = 55;
            this.label2.Text = "Id";
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = true;
            this.btnSua.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(186, 419);
            this.btnSua.Margin = new System.Windows.Forms.Padding(0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 32);
            this.btnSua.TabIndex = 53;
            this.btnSua.TabStop = false;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(156, 163);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 52;
            this.label1.Text = "Ngày sinh";
            // 
            // lblIdLoaiSanPham
            // 
            this.lblIdLoaiSanPham.AutoSize = true;
            this.lblIdLoaiSanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdLoaiSanPham.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblIdLoaiSanPham.Location = new System.Drawing.Point(156, 102);
            this.lblIdLoaiSanPham.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdLoaiSanPham.Name = "lblIdLoaiSanPham";
            this.lblIdLoaiSanPham.Size = new System.Drawing.Size(60, 21);
            this.lblIdLoaiSanPham.TabIndex = 50;
            this.lblIdLoaiSanPham.Text = "Họ tên";
            // 
            // pictureBoxNhanVien
            // 
            this.pictureBoxNhanVien.Location = new System.Drawing.Point(15, 54);
            this.pictureBoxNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxNhanVien.Name = "pictureBoxNhanVien";
            this.pictureBoxNhanVien.Size = new System.Drawing.Size(133, 157);
            this.pictureBoxNhanVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxNhanVien.TabIndex = 72;
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
            this.btnTaiAnhDaiDien.Location = new System.Drawing.Point(15, 221);
            this.btnTaiAnhDaiDien.Margin = new System.Windows.Forms.Padding(0);
            this.btnTaiAnhDaiDien.Name = "btnTaiAnhDaiDien";
            this.btnTaiAnhDaiDien.Size = new System.Drawing.Size(133, 32);
            this.btnTaiAnhDaiDien.TabIndex = 75;
            this.btnTaiAnhDaiDien.TabStop = false;
            this.btnTaiAnhDaiDien.Text = "Tải ảnh đại diện";
            this.btnTaiAnhDaiDien.UseVisualStyleBackColor = false;
            this.btnTaiAnhDaiDien.Click += new System.EventHandler(this.btnTaiAnhDaiDien_Click);
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
            this.cmbGioiTinh.Location = new System.Drawing.Point(539, 57);
            this.cmbGioiTinh.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGioiTinh.MinimumSize = new System.Drawing.Size(98, 24);
            this.cmbGioiTinh.Name = "cmbGioiTinh";
            this.cmbGioiTinh.Padding = new System.Windows.Forms.Padding(1);
            this.cmbGioiTinh.Size = new System.Drawing.Size(168, 37);
            this.cmbGioiTinh.TabIndex = 65;
            this.cmbGioiTinh.Texts = "";
            // 
            // datePickerControlNgaySinh
            // 
            this.datePickerControlNgaySinh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.datePickerControlNgaySinh.BorderSize = 0;
            this.datePickerControlNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.datePickerControlNgaySinh.Location = new System.Drawing.Point(244, 163);
            this.datePickerControlNgaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.datePickerControlNgaySinh.MinimumSize = new System.Drawing.Size(4, 35);
            this.datePickerControlNgaySinh.Name = "datePickerControlNgaySinh";
            this.datePickerControlNgaySinh.Size = new System.Drawing.Size(198, 35);
            this.datePickerControlNgaySinh.SkinColor = System.Drawing.Color.SteelBlue;
            this.datePickerControlNgaySinh.TabIndex = 63;
            this.datePickerControlNgaySinh.TextColor = System.Drawing.Color.White;
            // 
            // txtCMND
            // 
            this.txtCMND.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtCMND.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCMND.BorderSize = 2;
            this.txtCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtCMND.Location = new System.Drawing.Point(539, 158);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(2);
            this.txtCMND.Multiline = false;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtCMND.PasswordChar = false;
            this.txtCMND.Size = new System.Drawing.Size(168, 31);
            this.txtCMND.TabIndex = 60;
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
            this.txtSDT.Location = new System.Drawing.Point(539, 106);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDT.Multiline = false;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtSDT.PasswordChar = false;
            this.txtSDT.Size = new System.Drawing.Size(168, 31);
            this.txtSDT.TabIndex = 59;
            this.txtSDT.Texts = "";
            this.txtSDT.UnderlinedStyle = true;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtEmail.Location = new System.Drawing.Point(244, 271);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.Size = new System.Drawing.Size(197, 31);
            this.txtEmail.TabIndex = 57;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = true;
            // 
            // txtId
            // 
            this.txtId.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtId.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtId.BorderSize = 2;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtId.Location = new System.Drawing.Point(244, 54);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Multiline = false;
            this.txtId.Name = "txtId";
            this.txtId.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtId.PasswordChar = false;
            this.txtId.Size = new System.Drawing.Size(197, 31);
            this.txtId.TabIndex = 54;
            this.txtId.Texts = "";
            this.txtId.UnderlinedStyle = true;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtDiaChi.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDiaChi.BorderSize = 2;
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtDiaChi.Location = new System.Drawing.Point(244, 228);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiaChi.Multiline = false;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtDiaChi.PasswordChar = false;
            this.txtDiaChi.Size = new System.Drawing.Size(197, 31);
            this.txtDiaChi.TabIndex = 51;
            this.txtDiaChi.Texts = "";
            this.txtDiaChi.UnderlinedStyle = true;
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtHoTen.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtHoTen.BorderSize = 2;
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtHoTen.Location = new System.Drawing.Point(244, 98);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoTen.Multiline = false;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtHoTen.PasswordChar = false;
            this.txtHoTen.Size = new System.Drawing.Size(197, 31);
            this.txtHoTen.TabIndex = 49;
            this.txtHoTen.Texts = "";
            this.txtHoTen.UnderlinedStyle = true;
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(722, 506);
            this.Controls.Add(this.btnTaiAnhDaiDien);
            this.Controls.Add(this.btnTaiLai);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.pictureBoxNhanVien);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbGioiTinh);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.datePickerControlNgaySinh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lblIdLoaiSanPham);
            this.Controls.Add(this.txtHoTen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInfo";
            this.Load += new System.EventHandler(this.FormInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.PictureBox pictureBoxNhanVien;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private ComboBoxControl cmbGioiTinh;
        private System.Windows.Forms.Label label10;
        private DatePickerControl datePickerControlNgaySinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private CustomControls.TextBoxControl txtCMND;
        private CustomControls.TextBoxControl txtSDT;
        private System.Windows.Forms.Label label5;
        private CustomControls.TextBoxControl txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CustomControls.TextBoxControl txtId;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label1;
        private CustomControls.TextBoxControl txtDiaChi;
        private System.Windows.Forms.Label lblIdLoaiSanPham;
        private CustomControls.TextBoxControl txtHoTen;
        private System.Windows.Forms.Button btnTaiAnhDaiDien;
    }
}