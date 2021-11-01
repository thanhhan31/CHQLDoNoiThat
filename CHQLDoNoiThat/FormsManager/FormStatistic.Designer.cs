
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
            this.btnThongKe = new System.Windows.Forms.Button();
            this.datePickerControlNgayKetThuc = new CHQLDoNoiThat.DatePickerControl();
            this.datePickerControlNgayBatDau = new CHQLDoNoiThat.DatePickerControl();
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
            this.comboBoxControlThongKeTheo = new CHQLDoNoiThat.ComboBoxControl();
            this.label6 = new System.Windows.Forms.Label();
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
            this.panel1.Location = new System.Drawing.Point(53, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 658);
            this.panel1.TabIndex = 0;
            // 
            // btnThongKe
            // 
            this.btnThongKe.AutoSize = true;
            this.btnThongKe.BackColor = System.Drawing.Color.SteelBlue;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(724, 386);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(0);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(145, 47);
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
            this.datePickerControlNgayKetThuc.Location = new System.Drawing.Point(425, 391);
            this.datePickerControlNgayKetThuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datePickerControlNgayKetThuc.MinimumSize = new System.Drawing.Size(4, 35);
            this.datePickerControlNgayKetThuc.Name = "datePickerControlNgayKetThuc";
            this.datePickerControlNgayKetThuc.Size = new System.Drawing.Size(278, 35);
            this.datePickerControlNgayKetThuc.SkinColor = System.Drawing.Color.SteelBlue;
            this.datePickerControlNgayKetThuc.TabIndex = 39;
            this.datePickerControlNgayKetThuc.TextColor = System.Drawing.Color.White;
            // 
            // datePickerControlNgayBatDau
            // 
            this.datePickerControlNgayBatDau.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.datePickerControlNgayBatDau.BorderSize = 0;
            this.datePickerControlNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.datePickerControlNgayBatDau.Location = new System.Drawing.Point(91, 392);
            this.datePickerControlNgayBatDau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datePickerControlNgayBatDau.MinimumSize = new System.Drawing.Size(4, 35);
            this.datePickerControlNgayBatDau.Name = "datePickerControlNgayBatDau";
            this.datePickerControlNgayBatDau.Size = new System.Drawing.Size(277, 35);
            this.datePickerControlNgayBatDau.SkinColor = System.Drawing.Color.SteelBlue;
            this.datePickerControlNgayBatDau.TabIndex = 38;
            this.datePickerControlNgayBatDau.TextColor = System.Drawing.Color.White;
            // 
            // dataGridViewStatistic
            // 
            this.dataGridViewStatistic.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStatistic.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStatistic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.year,
            this.chi,
            this.thu,
            this.loi});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStatistic.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewStatistic.EnableHeadersVisualStyles = false;
            this.dataGridViewStatistic.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewStatistic.Location = new System.Drawing.Point(67, 116);
            this.dataGridViewStatistic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewStatistic.Name = "dataGridViewStatistic";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStatistic.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewStatistic.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewStatistic.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewStatistic.Size = new System.Drawing.Size(780, 261);
            this.dataGridViewStatistic.TabIndex = 10;
            this.dataGridViewStatistic.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStatistic_CellClick);
            // 
            // year
            // 
            this.year.DataPropertyName = "year";
            this.year.HeaderText = "Năm";
            this.year.MinimumWidth = 6;
            this.year.Name = "year";
            this.year.Width = 70;
            // 
            // chi
            // 
            this.chi.DataPropertyName = "chi";
            this.chi.HeaderText = "Chi tiêu";
            this.chi.MinimumWidth = 6;
            this.chi.Name = "chi";
            this.chi.Width = 150;
            // 
            // thu
            // 
            this.thu.DataPropertyName = "thu";
            this.thu.HeaderText = "Doanh thu";
            this.thu.MinimumWidth = 6;
            this.thu.Name = "thu";
            this.thu.Width = 150;
            // 
            // loi
            // 
            this.loi.DataPropertyName = "loiNhuan";
            this.loi.HeaderText = "Lợi nhuận";
            this.loi.MinimumWidth = 6;
            this.loi.Name = "loi";
            this.loi.Width = 150;
            // 
            // lblLoiNhuan
            // 
            this.lblLoiNhuan.AutoSize = true;
            this.lblLoiNhuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoiNhuan.Location = new System.Drawing.Point(216, 591);
            this.lblLoiNhuan.Name = "lblLoiNhuan";
            this.lblLoiNhuan.Size = new System.Drawing.Size(109, 24);
            this.lblLoiNhuan.TabIndex = 9;
            this.lblLoiNhuan.Text = "Lợi nhuận:";
            // 
            // lblTienChi
            // 
            this.lblTienChi.AutoSize = true;
            this.lblTienChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienChi.Location = new System.Drawing.Point(573, 484);
            this.lblTienChi.Name = "lblTienChi";
            this.lblTienChi.Size = new System.Drawing.Size(92, 24);
            this.lblTienChi.TabIndex = 8;
            this.lblTienChi.Text = "Tiền chi:";
            // 
            // label5
            // 
            this.label5.Image = global::CHQLDoNoiThat.Properties.Resources.profit_48px;
            this.label5.Location = new System.Drawing.Point(63, 540);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 107);
            this.label5.TabIndex = 7;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Image = global::CHQLDoNoiThat.Properties.Resources.money_100px;
            this.label4.Location = new System.Drawing.Point(68, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 113);
            this.label4.TabIndex = 6;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTienThu
            // 
            this.lblTienThu.AutoSize = true;
            this.lblTienThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienThu.Location = new System.Drawing.Point(233, 484);
            this.lblTienThu.Name = "lblTienThu";
            this.lblTienThu.Size = new System.Drawing.Size(93, 24);
            this.lblTienThu.TabIndex = 5;
            this.lblTienThu.Text = "Tiền thu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(373, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 25);
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
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(897, 82);
            this.panel2.TabIndex = 0;
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
            this.comboBoxControlThongKeTheo.Location = new System.Drawing.Point(456, 23);
            this.comboBoxControlThongKeTheo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxControlThongKeTheo.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboBoxControlThongKeTheo.Name = "comboBoxControlThongKeTheo";
            this.comboBoxControlThongKeTheo.Padding = new System.Windows.Forms.Padding(1);
            this.comboBoxControlThongKeTheo.Size = new System.Drawing.Size(213, 34);
            this.comboBoxControlThongKeTheo.TabIndex = 13;
            this.comboBoxControlThongKeTheo.Texts = "";
            this.comboBoxControlThongKeTheo.OnSelectedIndexChanged += new System.EventHandler(this.comboBoxControlThongKeTheo_OnSelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(184, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "Thống kê doanh thu theo";
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 30;
            this.elipseControl1.TargetControl = this;
            // 
            // FormStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1040, 761);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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