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
    public partial class FormAccount : Form
    {
        private Button currentButton;
        private Form activeForm;
        private string uid;
        private string email;
        private string hashed_password;
        private Action<object, EventArgs> logoutAction;

        public FormAccount(string uid, string email, string hashed_password, Action<object, EventArgs> logoutAction)
        {
            InitializeComponent();
            this.uid = uid;
            this.email = email;
            this.hashed_password = hashed_password;
            this.logoutAction = logoutAction;
            OpenChildForm(new FormInfo(uid, email, hashed_password), this);
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {         
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.None;
            this.panelAccount.Controls.Add(childForm);
            this.panelAccount.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
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
            foreach (Control previousBtn in panelMenuAccount.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.SteelBlue;
                }
            }
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormInfo(uid, email, hashed_password), sender);
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormChangePassword(uid, email, hashed_password, logoutAction), sender);
        }
    }
}
