
namespace CHQLDoNoiThat
{
    partial class FormAccount
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
            this.panelMenuAccount = new System.Windows.Forms.Panel();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.btnThongTin = new System.Windows.Forms.Button();
            this.panelAccount = new System.Windows.Forms.Panel();
            this.elipseControl1 = new ElipseToolDemo.ElipseControl();
            this.panelMenuAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuAccount
            // 
            this.panelMenuAccount.Controls.Add(this.btnDoiMatKhau);
            this.panelMenuAccount.Controls.Add(this.btnThongTin);
            this.panelMenuAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuAccount.Location = new System.Drawing.Point(0, 0);
            this.panelMenuAccount.Name = "panelMenuAccount";
            this.panelMenuAccount.Size = new System.Drawing.Size(1000, 70);
            this.panelMenuAccount.TabIndex = 14;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.AutoSize = true;
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDoiMatKhau.FlatAppearance.BorderSize = 0;
            this.btnDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(519, 16);
            this.btnDoiMatKhau.Margin = new System.Windows.Forms.Padding(0);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(200, 40);
            this.btnDoiMatKhau.TabIndex = 22;
            this.btnDoiMatKhau.TabStop = false;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = false;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // btnThongTin
            // 
            this.btnThongTin.AutoSize = true;
            this.btnThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.btnThongTin.FlatAppearance.BorderSize = 0;
            this.btnThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongTin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTin.ForeColor = System.Drawing.Color.White;
            this.btnThongTin.Location = new System.Drawing.Point(319, 16);
            this.btnThongTin.Margin = new System.Windows.Forms.Padding(0);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.Size = new System.Drawing.Size(200, 40);
            this.btnThongTin.TabIndex = 21;
            this.btnThongTin.TabStop = false;
            this.btnThongTin.Text = "Thông tin";
            this.btnThongTin.UseVisualStyleBackColor = false;
            this.btnThongTin.Click += new System.EventHandler(this.btnThongTin_Click);
            // 
            // panelAccount
            // 
            this.panelAccount.Location = new System.Drawing.Point(23, 88);
            this.panelAccount.Name = "panelAccount";
            this.panelAccount.Size = new System.Drawing.Size(970, 647);
            this.panelAccount.TabIndex = 15;
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 30;
            this.elipseControl1.TargetControl = this;
            // 
            // FormAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1000, 760);
            this.Controls.Add(this.panelAccount);
            this.Controls.Add(this.panelMenuAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAccount";
            this.Text = "Tài khoản";
            this.panelMenuAccount.ResumeLayout(false);
            this.panelMenuAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenuAccount;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Button btnThongTin;
        private ElipseToolDemo.ElipseControl elipseControl1;
        private System.Windows.Forms.Panel panelAccount;
    }
}