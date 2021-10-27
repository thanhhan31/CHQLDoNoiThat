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
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.BackColor = System.Drawing.Color.DodgerBlue;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Close_MouseHover(object sender, EventArgs e)
        {
            btnClose.ForeColor = System.Drawing.Color.Red;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            btnClose.ForeColor = System.Drawing.Color.White;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtUser.Text;
            string passwd = txtPassword.Text;


            string error = "";
            DBL_Account dbl = new DBL_Account();
            DataSet userinf = dbl.login(email, passwd, ref error);
            bool login_as_employee = radioButton2.Checked;
            if (userinf.Tables[0].Rows.Count == 1)
            {
                var tmp = userinf.Tables[0].Rows[0].ItemArray;
                if ((bool)tmp[11]) //active account
                {
                    if (((string)tmp[10]).Trim() == "1" && login_as_employee)
                    {
                        var formHomeStaff = new FormHomeStaff((string)tmp[0], this);
                        formHomeStaff.Show();
                        this.Hide();
                    }
                    else if (((string)tmp[10]).Trim() == "2" && !login_as_employee) //Quản lí
                    {
                        var formManager = new FormManager((string)tmp[0], this);
                        formManager.Show();
                        this.Hide();
                    }
                    else //wrong account type
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else //deactive account
                {
                    MessageBox.Show("Tài khoản đã bị vô hiệu hóa", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (String.IsNullOrEmpty(error))
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(error, "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
