﻿
namespace CHQLDoNoiThat.FormsStaff
{
    partial class FormBillHistory
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
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewCTHD = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridViewLSHD = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtId = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.txtTongTien = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.datePickerControlNgayTao = new CHQLDoNoiThat.DatePickerControl();
            this.datePickerControlLichSuHoaDon = new CHQLDoNoiThat.DatePickerControl();
            this.elipseControl1 = new ElipseToolDemo.ElipseControl();
            this.idProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLSHD)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(325, 267);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 68;
            this.label3.Text = "Lịch sử hóa đơn";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // dataGridViewCTHD
            // 
            this.dataGridViewCTHD.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCTHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProduct,
            this.productName,
            this.price,
            this.quantity});
            this.dataGridViewCTHD.Location = new System.Drawing.Point(319, 30);
            this.dataGridViewCTHD.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewCTHD.Name = "dataGridViewCTHD";
            this.dataGridViewCTHD.RowHeadersWidth = 51;
            this.dataGridViewCTHD.RowTemplate.Height = 24;
            this.dataGridViewCTHD.Size = new System.Drawing.Size(450, 220);
            this.dataGridViewCTHD.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(13, 229);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 65;
            this.label2.Text = "Thành tiền";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(14, 157);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 21);
            this.label8.TabIndex = 64;
            this.label8.Text = "Ngày tạo";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(68, 30);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 25);
            this.label9.TabIndex = 61;
            this.label9.Text = "Chi tiết hóa đơn";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SteelBlue;
            this.label10.Location = new System.Drawing.Point(14, 86);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 21);
            this.label10.TabIndex = 62;
            this.label10.Text = "Mã hóa đơn";
            // 
            // dataGridViewLSHD
            // 
            this.dataGridViewLSHD.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewLSHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewLSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLSHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.createTime,
            this.checkOut});
            this.dataGridViewLSHD.Location = new System.Drawing.Point(18, 305);
            this.dataGridViewLSHD.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewLSHD.Name = "dataGridViewLSHD";
            this.dataGridViewLSHD.RowHeadersWidth = 51;
            this.dataGridViewLSHD.RowTemplate.Height = 24;
            this.dataGridViewLSHD.Size = new System.Drawing.Size(749, 283);
            this.dataGridViewLSHD.TabIndex = 60;
            this.dataGridViewLSHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLSHD_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã hóa đơn";
            this.id.Name = "id";
            this.id.Width = 180;
            // 
            // createTime
            // 
            this.createTime.DataPropertyName = "createTime";
            this.createTime.HeaderText = "Ngày tạo";
            this.createTime.Name = "createTime";
            this.createTime.Width = 220;
            // 
            // checkOut
            // 
            this.checkOut.DataPropertyName = "checkOut";
            this.checkOut.HeaderText = "Thành tiền";
            this.checkOut.Name = "checkOut";
            this.checkOut.Width = 220;
            // 
            // txtId
            // 
            this.txtId.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtId.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtId.BorderSize = 2;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtId.Location = new System.Drawing.Point(120, 76);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Multiline = false;
            this.txtId.Name = "txtId";
            this.txtId.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtId.PasswordChar = false;
            this.txtId.Size = new System.Drawing.Size(178, 31);
            this.txtId.TabIndex = 71;
            this.txtId.Texts = "";
            this.txtId.UnderlinedStyle = true;
            // 
            // txtTongTien
            // 
            this.txtTongTien.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtTongTien.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTongTien.BorderSize = 2;
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtTongTien.Location = new System.Drawing.Point(120, 219);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongTien.Multiline = false;
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTongTien.PasswordChar = false;
            this.txtTongTien.Size = new System.Drawing.Size(178, 31);
            this.txtTongTien.TabIndex = 69;
            this.txtTongTien.Texts = "";
            this.txtTongTien.UnderlinedStyle = true;
            // 
            // datePickerControlNgayTao
            // 
            this.datePickerControlNgayTao.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.datePickerControlNgayTao.BorderSize = 0;
            this.datePickerControlNgayTao.Enabled = false;
            this.datePickerControlNgayTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.datePickerControlNgayTao.Location = new System.Drawing.Point(120, 150);
            this.datePickerControlNgayTao.Margin = new System.Windows.Forms.Padding(2);
            this.datePickerControlNgayTao.MinimumSize = new System.Drawing.Size(4, 35);
            this.datePickerControlNgayTao.Name = "datePickerControlNgayTao";
            this.datePickerControlNgayTao.Size = new System.Drawing.Size(178, 35);
            this.datePickerControlNgayTao.SkinColor = System.Drawing.Color.SteelBlue;
            this.datePickerControlNgayTao.TabIndex = 66;
            this.datePickerControlNgayTao.TextColor = System.Drawing.Color.White;
            // 
            // datePickerControlLichSuHoaDon
            // 
            this.datePickerControlLichSuHoaDon.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.datePickerControlLichSuHoaDon.BorderSize = 0;
            this.datePickerControlLichSuHoaDon.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerControlLichSuHoaDon.Location = new System.Drawing.Point(19, 262);
            this.datePickerControlLichSuHoaDon.Margin = new System.Windows.Forms.Padding(25, 8, 2, 2);
            this.datePickerControlLichSuHoaDon.MinimumSize = new System.Drawing.Size(4, 35);
            this.datePickerControlLichSuHoaDon.Name = "datePickerControlLichSuHoaDon";
            this.datePickerControlLichSuHoaDon.Size = new System.Drawing.Size(218, 35);
            this.datePickerControlLichSuHoaDon.SkinColor = System.Drawing.Color.SteelBlue;
            this.datePickerControlLichSuHoaDon.TabIndex = 59;
            this.datePickerControlLichSuHoaDon.TextColor = System.Drawing.Color.White;
            this.datePickerControlLichSuHoaDon.ValueChanged += new System.EventHandler(this.datePickerControlLichSuHoaDon_ValueChanged);
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 30;
            this.elipseControl1.TargetControl = this;
            // 
            // idProduct
            // 
            this.idProduct.DataPropertyName = "id";
            this.idProduct.HeaderText = "Mã sản phẩm";
            this.idProduct.Name = "idProduct";
            // 
            // productName
            // 
            this.productName.DataPropertyName = "name";
            this.productName.HeaderText = "Tên sản phẩm";
            this.productName.Name = "productName";
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Đơn giá";
            this.price.Name = "price";
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Số lượng";
            this.quantity.Name = "quantity";
            this.quantity.Width = 80;
            // 
            // FormBillHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(780, 618);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewCTHD);
            this.Controls.Add(this.datePickerControlNgayTao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridViewLSHD);
            this.Controls.Add(this.datePickerControlLichSuHoaDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormBillHistory";
            this.Text = "Lịch sử hóa đơn";
            this.Load += new System.EventHandler(this.FormBillHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLSHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ElipseToolDemo.ElipseControl elipseControl1;
        private CustomControls.TextBoxControl txtId;
        private CustomControls.TextBoxControl txtTongTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewCTHD;
        private DatePickerControl datePickerControlNgayTao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridViewLSHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkOut;
        private DatePickerControl datePickerControlLichSuHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
    }
}