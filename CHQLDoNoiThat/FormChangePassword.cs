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
        private string email;
        private string hashed_password;
        private Action<object, EventArgs> logoutAction;
        public FormChangePassword(string uid, string email, string hashed_password, Action<object, EventArgs> logoutAction)
        {
            InitializeComponent();
            this.uid = uid;
            this.email = email;
            this.hashed_password = hashed_password;
            this.logoutAction = logoutAction;
            txtTenDangNhap.Enabled = false;
        }

        private void FormChangePassword_Load(object sender, EventArgs e)
        {
            string error = "";
            AccountObject account = Utils.getUserInfo(email, hashed_password, ref error);
            if (account == null)
            {
                MessageBox.Show(error, "Lỗi tải thông tin nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (!dbl.user_update_password(
                uid,
                txtTenDangNhap.Texts,
                Utils.sha256(txtMatKhauCu.Texts + email),
                txtMatKhauMoi.Texts,
                ref error))
            {
                if (!String.IsNullOrEmpty(error))
                {
                    MessageBox.Show("Lỗi: " + error, "Lỗi không thể cập nhật mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không chính xác", "Lỗi không thể cập nhật mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Cập nhật mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                logoutAction.Invoke(null, null);
            }
        }
    }
}
