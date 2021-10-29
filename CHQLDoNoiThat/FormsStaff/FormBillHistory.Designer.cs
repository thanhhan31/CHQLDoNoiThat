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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewCTHD = new System.Windows.Forms.DataGridView();
            this.idProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label3.Location = new System.Drawing.Point(433, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 32);
            this.label3.TabIndex = 68;
            this.label3.Text = "Lịch sử hóa đơn";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // dataGridViewCTHD
            // 
            this.dataGridViewCTHD.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCTHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCTHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProduct,
            this.productName,
            this.price,
            this.quantity});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCTHD.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCTHD.EnableHeadersVisualStyles = false;
            this.dataGridViewCTHD.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewCTHD.Location = new System.Drawing.Point(425, 37);
            this.dataGridViewCTHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewCTHD.Name = "dataGridViewCTHD";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCTHD.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCTHD.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewCTHD.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewCTHD.RowTemplate.Height = 24;
            this.dataGridViewCTHD.Size = new System.Drawing.Size(600, 271);
            this.dataGridViewCTHD.TabIndex = 67;
            // 
            // idProduct
            // 
            this.idProduct.DataPropertyName = "id";
            this.idProduct.HeaderText = "Mã sản phẩm";
            this.idProduct.MinimumWidth = 6;
            this.idProduct.Name = "idProduct";
            this.idProduct.Width = 150;
            // 
            // productName
            // 
            this.productName.DataPropertyName = "name";
            this.productName.HeaderText = "Tên sản phẩm";
            this.productName.MinimumWidth = 6;
            this.productName.Name = "productName";
            this.productName.Width = 150;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Đơn giá";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.Width = 125;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Số lượng";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.Width = 120;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(17, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 28);
            this.label2.TabIndex = 65;
            this.label2.Text = "Thành tiền";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(19, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 28);
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
            this.label9.Location = new System.Drawing.Point(91, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 32);
            this.label9.TabIndex = 61;
            this.label9.Text = "Chi tiết hóa đơn";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SteelBlue;
            this.label10.Location = new System.Drawing.Point(19, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 28);
            this.label10.TabIndex = 62;
            this.label10.Text = "Mã hóa đơn";
            // 
            // dataGridViewLSHD
            // 
            this.dataGridViewLSHD.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewLSHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewLSHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLSHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.createTime,
            this.checkOut});
            this.dataGridViewLSHD.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewLSHD.EnableHeadersVisualStyles = false;
            this.dataGridViewLSHD.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewLSHD.Location = new System.Drawing.Point(24, 375);
            this.dataGridViewLSHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewLSHD.Name = "dataGridViewLSHD";
            this.dataGridViewLSHD.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewLSHD.RowHeadersWidth = 51;
            this.dataGridViewLSHD.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewLSHD.RowTemplate.Height = 24;
            this.dataGridViewLSHD.Size = new System.Drawing.Size(999, 348);
            this.dataGridViewLSHD.TabIndex = 60;
            this.dataGridViewLSHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLSHD_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã hóa đơn";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 180;
            // 
            // createTime
            // 
            this.createTime.DataPropertyName = "createTime";
            this.createTime.HeaderText = "Ngày tạo";
            this.createTime.MinimumWidth = 6;
            this.createTime.Name = "createTime";
            this.createTime.Width = 220;
            // 
            // checkOut
            // 
            this.checkOut.DataPropertyName = "checkOut";
            this.checkOut.HeaderText = "Thành tiền";
            this.checkOut.MinimumWidth = 6;
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
            this.txtId.Location = new System.Drawing.Point(160, 94);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Multiline = false;
            this.txtId.Name = "txtId";
            this.txtId.Padding = new System.Windows.Forms.Padding(7);
            this.txtId.PasswordChar = false;
            this.txtId.Size = new System.Drawing.Size(237, 39);
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
            this.txtTongTien.Location = new System.Drawing.Point(160, 270);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongTien.Multiline = false;
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Padding = new System.Windows.Forms.Padding(7);
            this.txtTongTien.PasswordChar = false;
            this.txtTongTien.Size = new System.Drawing.Size(237, 39);
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
            this.datePickerControlNgayTao.Location = new System.Drawing.Point(160, 185);
            this.datePickerControlNgayTao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datePickerControlNgayTao.MinimumSize = new System.Drawing.Size(4, 35);
            this.datePickerControlNgayTao.Name = "datePickerControlNgayTao";
            this.datePickerControlNgayTao.Size = new System.Drawing.Size(236, 35);
            this.datePickerControlNgayTao.SkinColor = System.Drawing.Color.SteelBlue;
            this.datePickerControlNgayTao.TabIndex = 66;
            this.datePickerControlNgayTao.TextColor = System.Drawing.Color.White;
            // 
            // datePickerControlLichSuHoaDon
            // 
            this.datePickerControlLichSuHoaDon.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.datePickerControlLichSuHoaDon.BorderSize = 0;
            this.datePickerControlLichSuHoaDon.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerControlLichSuHoaDon.Location = new System.Drawing.Point(25, 322);
            this.datePickerControlLichSuHoaDon.Margin = new System.Windows.Forms.Padding(33, 10, 3, 2);
            this.datePickerControlLichSuHoaDon.MinimumSize = new System.Drawing.Size(4, 35);
            this.datePickerControlLichSuHoaDon.Name = "datePickerControlLichSuHoaDon";
            this.datePickerControlLichSuHoaDon.Size = new System.Drawing.Size(289, 35);
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
            // FormBillHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1040, 761);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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