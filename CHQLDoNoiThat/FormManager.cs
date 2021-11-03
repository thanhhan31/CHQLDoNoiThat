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
    public partial class FormManager : Form
    {
        private Button currentButton;
        private Form activeForm;
        private Form parent;
        private string uid;
        private string email;
        private string hashed_password;

        public FormManager(string uid, string email, string hashed_password, Form parent)
        {
            InitializeComponent();
            this.uid = uid;
            this.email = email;
            this.hashed_password = hashed_password;
            this.parent = parent;
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
            System.Windows.Forms.Application.Exit();
        }

        private void btnNhanVien_FManager_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormsManager.FormStaff(), sender);
        }

        private void btnKho_FManager_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormsManager.FormInventory(), sender);
        }

        private void btnLoaiSanPham_FManager_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormsManager.FormCategory(), sender);
        }

        private void btnSanPham_FManager_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormsManager.FormProduct(), sender);
        }

        private void btnTaoHoaDon_FManager_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormsManager.FormBill(uid), sender);
        }

        private void btnLichSuHoaDon_FManager_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormsManager.FormBillHistory(), sender);
        }

        private void btnThongKe_FManager_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormsManager.FormStatistic(), sender);
        }

        private void lblDangXuat_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.FormClosed -= FormManager_FormClosed;
            this.Close();
        }

        private void FormManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Close();
        }

        private void lblTenDangNhap_Click(object sender, EventArgs e)
        {
            DisableButton();
            OpenChildForm(new FormAccount(uid, email, hashed_password, lblDangXuat_Click), sender);
        }

        private void FormManager_Load(object sender, EventArgs e)
        {
            string error = "";
            AccountObject account = Utils.getUserInfo(email, hashed_password, ref error);
            if (account == null)
            {
                MessageBox.Show(error, "Lỗi tải thông tin nhân viên");
            }
            else
            {
                if (account.Avatar.Length != 0)
                {
                    lblTenDangNhap.Image = Utils.ByteToImage(account.Avatar, new Size(40, 40));
                    lblTenDangNhap.ImageAlign = ContentAlignment.MiddleLeft;
                }
                lblTenDangNhap.Text = account.Email;
            }
        }
    }
}
