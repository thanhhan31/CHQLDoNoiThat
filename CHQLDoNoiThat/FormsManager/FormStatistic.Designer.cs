
namespace CHQLDoNoiThat.FormsManager
{
    partial class FormStatistic
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewStatistic = new System.Windows.Forms.DataGridView();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLoiNhuan = new System.Windows.Forms.Label();
            this.lblTienChi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTienThu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.datePickerControlNgayKetThuc = new CHQLDoNoiThat.DatePickerControl();
            this.datePickerControlNgayBatDau = new CHQLDoNoiThat.DatePickerControl();
            this.comboBoxControlThongKeTheo = new CHQLDoNoiThat.ComboBoxControl();
            this.elipseControl1 = new ElipseToolDemo.ElipseControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistic)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnThongKe);
            this.panel1.Controls.Add(this.datePickerControlNgayKetThuc);
            this.panel1.Controls.Add(this.datePickerControlNgayBatDau);
            this.panel1.Controls.Add(this.dataGridViewStatistic);
            this.panel1.Controls.Add(this.lblLoiNhuan);
            this.panel1.Controls.Add(this.lblTienChi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblTienThu);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.ForeColor = System.Drawing.Color.SteelBlue;
            this.panel1.Location = new System.Drawing.Point(40, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 535);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewStatistic
            // 
            this.dataGridViewStatistic.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStatistic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.year,
            this.chi,
            this.thu,
            this.loi});
            this.dataGridViewStatistic.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridViewStatistic.Location = new System.Drawing.Point(50, 94);
            this.dataGridViewStatistic.Name = "dataGridViewStatistic";
            this.dataGridViewStatistic.Size = new System.Drawing.Size(585, 212);
            this.dataGridViewStatistic.TabIndex = 10;
            this.dataGridViewStatistic.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStatistic_CellClick);
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStatistic.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStatistic.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewStatistic.EnableHeadersVisualStyles = false;
            this.dataGridViewStatistic.GridColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStatistic.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewStatistic.RowsDefaultCellStyle = dataGridViewCellStyle4;
            // 
            // year
            // 
            this.year.DataPropertyName = "year";
            this.year.HeaderText = "Năm";
            this.year.Name = "year";
            this.year.Width = 70;
            // 
            // chi
            // 
            this.chi.DataPropertyName = "chi";
            this.chi.HeaderText = "Chi tiêu";
            this.chi.Name = "chi";
            this.chi.Width = 150;
            // 
            // thu
            // 
            this.thu.DataPropertyName = "thu";
            this.thu.HeaderText = "Doanh thu";
            this.thu.Name = "thu";
            this.thu.Width = 150;
            // 
            // loi
            // 
            this.loi.DataPropertyName = "loiNhuan";
            this.loi.HeaderText = "Lợi nhuận";
            this.loi.Name = "loi";
            this.loi.Width = 150;
            // 
            // lblLoiNhuan
            // 
            this.lblLoiNhuan.AutoSize = true;
            this.lblLoiNhuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoiNhuan.Location = new System.Drawing.Point(162, 480);
            this.lblLoiNhuan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoiNhuan.Name = "lblLoiNhuan";
            this.lblLoiNhuan.Size = new System.Drawing.Size(86, 18);
            this.lblLoiNhuan.TabIndex = 9;
            this.lblLoiNhuan.Text = "Lợi nhuận:";
            // 
            // lblTienChi
            // 
            this.lblTienChi.AutoSize = true;
            this.lblTienChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienChi.Location = new System.Drawing.Point(430, 393);
            this.lblTienChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTienChi.Name = "lblTienChi";
            this.lblTienChi.Size = new System.Drawing.Size(72, 18);
            this.lblTienChi.TabIndex = 8;
            this.lblTienChi.Text = "Tiền chi:";
            // 
            // label5
            // 
            this.label5.Image = global::CHQLDoNoiThat.Properties.Resources.profit_48px;
            this.label5.Location = new System.Drawing.Point(47, 439);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 87);
            this.label5.TabIndex = 7;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Image = global::CHQLDoNoiThat.Properties.Resources.money_100px;
            this.label4.Location = new System.Drawing.Point(51, 352);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 92);
            this.label4.TabIndex = 6;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTienThu
            // 
            this.lblTienThu.AutoSize = true;
            this.lblTienThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienThu.Location = new System.Drawing.Point(175, 393);
            this.lblTienThu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTienThu.Name = "lblTienThu";
            this.lblTienThu.Size = new System.Drawing.Size(73, 18);
            this.lblTienThu.TabIndex = 5;
            this.lblTienThu.Text = "Tiền thu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 323);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 323);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.comboBoxControlThongKeTheo);
            this.panel2.Controls.Add(this.label6);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(673, 67);
            this.panel2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(138, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Thống kê doanh thu theo";
            // 
            // btnThongKe
            // 
            this.btnThongKe.AutoSize = true;
            this.btnThongKe.BackColor = System.Drawing.Color.SteelBlue;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(543, 315);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(0);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(88, 32);
            this.btnThongKe.TabIndex = 41;
            this.btnThongKe.TabStop = false;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // datePickerControlNgayKetThuc
            // 
            this.datePickerControlNgayKetThuc.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.datePickerControlNgayKetThuc.BorderSize = 0;
            this.datePickerControlNgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.datePickerControlNgayKetThuc.Location = new System.Drawing.Point(319, 314);
            this.datePickerControlNgayKetThuc.Margin = new System.Windows.Forms.Padding(2);
            this.datePickerControlNgayKetThuc.MinimumSize = new System.Drawing.Size(4, 35);
            this.datePickerControlNgayKetThuc.Name = "datePickerControlNgayKetThuc";
            this.datePickerControlNgayKetThuc.Size = new System.Drawing.Size(194, 35);
            this.datePickerControlNgayKetThuc.SkinColor = System.Drawing.Color.SteelBlue;
            this.datePickerControlNgayKetThuc.TabIndex = 39;
            this.datePickerControlNgayKetThuc.TextColor = System.Drawing.Color.White;
            // 
            // datePickerControlNgayBatDau
            // 
            this.datePickerControlNgayBatDau.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.datePickerControlNgayBatDau.BorderSize = 0;
            this.datePickerControlNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.datePickerControlNgayBatDau.Location = new System.Drawing.Point(82, 314);
            this.datePickerControlNgayBatDau.Margin = new System.Windows.Forms.Padding(2);
            this.datePickerControlNgayBatDau.MinimumSize = new System.Drawing.Size(4, 35);
            this.datePickerControlNgayBatDau.Name = "datePickerControlNgayBatDau";
            this.datePickerControlNgayBatDau.Size = new System.Drawing.Size(194, 35);
            this.datePickerControlNgayBatDau.SkinColor = System.Drawing.Color.SteelBlue;
            this.datePickerControlNgayBatDau.TabIndex = 38;
            this.datePickerControlNgayBatDau.TextColor = System.Drawing.Color.White;
            // 
            // comboBoxControlThongKeTheo
            // 
            this.comboBoxControlThongKeTheo.BackColor = System.Drawing.Color.White;
            this.comboBoxControlThongKeTheo.BorderColor = System.Drawing.Color.SteelBlue;
            this.comboBoxControlThongKeTheo.BorderSize = 1;
            this.comboBoxControlThongKeTheo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboBoxControlThongKeTheo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxControlThongKeTheo.ForeColor = System.Drawing.Color.SteelBlue;
            this.comboBoxControlThongKeTheo.IconColor = System.Drawing.Color.SteelBlue;
            this.comboBoxControlThongKeTheo.Items.AddRange(new object[] {
            "Tháng",
            "Quý",
            "Năm"});
            this.comboBoxControlThongKeTheo.ListBackColor = System.Drawing.Color.White;
            this.comboBoxControlThongKeTheo.ListTextColor = System.Drawing.Color.SteelBlue;
            this.comboBoxControlThongKeTheo.Location = new System.Drawing.Point(342, 19);
            this.comboBoxControlThongKeTheo.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxControlThongKeTheo.MinimumSize = new System.Drawing.Size(150, 24);
            this.comboBoxControlThongKeTheo.Name = "comboBoxControlThongKeTheo";
            this.comboBoxControlThongKeTheo.Padding = new System.Windows.Forms.Padding(1);
            this.comboBoxControlThongKeTheo.Size = new System.Drawing.Size(160, 28);
            this.comboBoxControlThongKeTheo.TabIndex = 13;
            this.comboBoxControlThongKeTheo.Texts = "";
            this.comboBoxControlThongKeTheo.OnSelectedIndexChanged += new System.EventHandler(this.comboBoxControlThongKeTheo_OnSelectedIndexChanged);
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 30;
            this.elipseControl1.TargetControl = this;
            // 
            // FormStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(780, 618);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormStatistic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.FormStatistic_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistic)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private ComboBoxControl comboBoxControlThongKeTheo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTienThu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTienChi;
        private ElipseToolDemo.ElipseControl elipseControl1;
        private System.Windows.Forms.Label lblLoiNhuan;
        private System.Windows.Forms.DataGridView dataGridViewStatistic;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn chi;
        private System.Windows.Forms.DataGridViewTextBoxColumn thu;
        private System.Windows.Forms.DataGridViewTextBoxColumn loi;
        private DatePickerControl datePickerControlNgayKetThuc;
        private DatePickerControl datePickerControlNgayBatDau;
        private System.Windows.Forms.Button btnThongKe;
    }
}