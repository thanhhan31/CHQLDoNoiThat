using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBusiness;

namespace CHQLDoNoiThat
{
    public partial class FormInfo : Form
    {
        private string uid;
        private byte[] avt;
        public FormInfo(string uid)
        {
            InitializeComponent();
            this.uid = uid;
        }

        private void btnTaiAnhDaiDien_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBoxNhanVien.Image = new Bitmap(open.FileName);
                avt = File.ReadAllBytes(open.FileName);
            }
        }

        private void FormInfo_Load(object sender, EventArgs e)
        {
            update_data();
            txtId.Enabled = false;
            txtEmail.Enabled = false;
            disable_edit();
        }

        private void disable_edit()
        {
            txtHoTen.Enabled = false;
            datePickerControlNgaySinh.Enabled = false;
            txtDiaChi.Enabled = false;
            cmbGioiTinh.Enabled = false;
            txtSDT.Enabled = false;
            txtCMND.Enabled = false;

            btnLuu.Enabled = false;
            btnTaiAnhDaiDien.Enabled = false;

            btnSua.Enabled = true;
        }

        private void enable_edit()
        {
            txtHoTen.Enabled = true;
            datePickerControlNgaySinh.Enabled = true;
            txtDiaChi.Enabled = true;
            cmbGioiTinh.Enabled = true;
            txtSDT.Enabled = true;
            txtCMND.Enabled = true;

            btnLuu.Enabled = true;
            btnTaiAnhDaiDien.Enabled = true;

            btnSua.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            enable_edit();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string error = "";
            DBL_Account dbl = new DBL_Account();
            if (!dbl.employee_update_employee(
                uid,
                txtHoTen.Texts,
                datePickerControlNgaySinh.Value,
                (string)cmbGioiTinh.SelectedItem,
                txtSDT.Texts,
                txtCMND.Texts,
                txtDiaChi.Texts,
                avt,
                ref error))
            {
                MessageBox.Show(error, "Lỗi cập nhật thông tin");
            }
            disable_edit();
            update_data();
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            update_data();
            disable_edit();
        }

        private void update_data()
        {
            string error = "";
            AccountObject account = Utils.getUserInfo(uid, ref error);
            if (account == null)
            {
                MessageBox.Show(error, "Lỗi tải thông tin nhân viên");
            }
            else
            {
                txtId.Texts = account.Id;
                txtHoTen.Texts = account.Name;
                datePickerControlNgaySinh.Value = account.Dob;
                txtDiaChi.Texts = account.Address;
                txtEmail.Texts = account.Email;
                cmbGioiTinh.SelectedIndex = account.Gender.ToLower() == "nam" ? 0 : 1;
                txtSDT.Texts = account.Phone;
                txtCMND.Texts = account.IdNo;

                var r = Utils.getTypeAccName(account.IdType, ref error);
                if (r != null)
                    label7.Text = "Chức vụ: " + r;
                else
                    MessageBox.Show("Không tìm thấy chức vụ " + error, "Lỗi tải thông tin chức vụ");
                label11.Text = "Tình trạng: Đang hoạt động";

                pictureBoxNhanVien.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxNhanVien.Image = Utils.ByteToImage(account.Avatar);
                avt = account.Avatar;
            }
        }
    }
}
