using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBusiness;

namespace CHQLDoNoiThat
{
    public partial class FormHomeStaff : Form
    {
        private Button currentButton;
        private Form activeForm;
        private Form parent;
        private string uid;

        public FormHomeStaff(string uid, Form parent)
        {
            InitializeComponent();
            this.uid = uid;
            this.parent = parent;
            this.FormClosed += FormHomeStaff_FormClosed;
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            panel1.Dispose();
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.tableLayoutPanelDesktop.Controls.Add(childForm);
            this.tableLayoutPanelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;

        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(152, 190, 240);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in tableLayoutPanelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.SteelBlue;
                }
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSanPham_FNhanVien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormsStaff.FormProduct(), sender);
        }

        private void btnTaoHoaDon_FNhanVien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormsStaff.FormBill(uid), sender);
        }

        private void btnKho_FNhanVien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormsStaff.FormInventoty(), sender);
        }

        private void btnLichSuHoaDon_FNhanVien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormsStaff.FormBillHistory(uid), sender);

        }

        private void lblTenDangNhap_Click(object sender, EventArgs e)
        {
            DisableButton();
            OpenChildForm(new FormAccount(uid), sender);
        }

        private void lblDangXuat_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.FormClosed -= FormHomeStaff_FormClosed;
            this.Close();
        }

        private void FormHomeStaff_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Close();
        }

        private void FormHomeStaff_Load(object sender, EventArgs e)
        {
            string error = "";
            AccountObject account = Utils.getUserInfo(uid, ref error);
            if (account == null)
            {
                MessageBox.Show(error, "Lỗi tải thông tin nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (account.Avatar.Length != 0)
                {
                    lblTenDangNhap.Image = Utils.ByteToImage(account.Avatar, new Size(40, 40));
                    lblTenDangNhap.ImageAlign = ContentAlignment.MiddleLeft;
                }
                lblTenDangNhap.TextAlign = ContentAlignment.MiddleRight;
                lblTenDangNhap.Text = account.Email;
            }
        }
    }
}
