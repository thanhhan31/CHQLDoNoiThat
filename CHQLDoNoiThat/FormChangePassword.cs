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
    public partial class FormChangePassword : Form
    {
        private string uid;
        public FormChangePassword(string uid)
        {
            InitializeComponent();
            this.uid = uid;
            txtTenDangNhap.Enabled = false;
        }

        private void FormChangePassword_Load(object sender, EventArgs e)
        {
            string error = "";
            AccountObject account = Utils.getUserInfo(uid, ref error);
            if (account == null)
            {
                MessageBox.Show(error, "Lỗi tải thông tin nhân viên");
            }
            else
            {
                txtTenDangNhap.Texts = account.Email;
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.Texts != txtMatKhauMoi2.Texts)
            {
                MessageBox.Show("Mật khẩu mới nhập lại không đúng!");
                return;
            }
            string error = "";
            DBL_Account dbl = new DBL_Account();
            if(!dbl.change_password(
                uid,
                txtTenDangNhap.Texts,
                txtMatKhauCu.Texts,
                txtMatKhauMoi.Texts,
                ref error))
            {
                if (!String.IsNullOrEmpty(error))
                {
                    MessageBox.Show("Lỗi: " + error, "Lỗi không thể cập nhật mật khẩu");
                }
            }
            else
            {
                MessageBox.Show("Cập nhật mật khẩu thành công!");
            }
        }
    }
}
