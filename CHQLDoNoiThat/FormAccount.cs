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

        public FormAccount(string uid)
        {
            InitializeComponent();
            this.uid = uid;
            OpenChildForm(new FormInfo(uid), this);
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
            OpenChildForm(new FormInfo(uid), sender);
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormChangePassword(uid), sender);
        }
    }
}
