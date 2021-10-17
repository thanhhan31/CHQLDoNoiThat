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

namespace CHQLDoNoiThat.FormsManager
{
    public partial class FormStaff : Form
    {
        private byte[] avt;
        private int selected_mode = -1;

        public FormStaff()
        {
            InitializeComponent();
        }

        private void FormStaff_Load(object sender, EventArgs e)
        {
            update_data();
            (dataGridViewNhanVien.Columns["idType"] as DataGridViewComboBoxColumn).ValueMember = "id";
            (dataGridViewNhanVien.Columns["idType"] as DataGridViewComboBoxColumn).DisplayMember = "name";
            cmbChucVu.ValueMember = "id";
            cmbChucVu.DisplayMember = "name";

            pictureBoxNhanVien.SizeMode = PictureBoxSizeMode.StretchImage;
            dataGridViewNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewNhanVien.MultiSelect = false;
            dataGridViewNhanVien.AllowUserToAddRows = false;
            DataGridViewNhanVien_CellClick(null, null);
            dataGridViewNhanVien.ReadOnly = true;
            disable_edit();
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

        private void DataGridViewNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewNhanVien.CurrentCell.RowIndex >= 0)
            {
                var r = dataGridViewNhanVien.CurrentCell.RowIndex;
                if (r >= dataGridViewNhanVien.RowCount)
                    return;

                txtId.Texts = dataGridViewNhanVien.CurrentRow.Cells["id"].Value.ToString();
                txtHoTen.Texts = dataGridViewNhanVien.CurrentRow.Cells["name"].Value.ToString();
                datePickerControlNgaySinh.Value = (DateTime)dataGridViewNhanVien.CurrentRow.Cells["dob"].Value;
                txtSDT.Texts = dataGridViewNhanVien.CurrentRow.Cells["phone"].Value.ToString();
                txtCMND.Texts = dataGridViewNhanVien.CurrentRow.Cells["idNo"].Value.ToString();
                txtDiaChi.Texts = dataGridViewNhanVien.CurrentRow.Cells["address"].Value.ToString();
                txtEmail.Texts = dataGridViewNhanVien.CurrentRow.Cells["email"].Value.ToString();


                var t = dataGridViewNhanVien.CurrentRow.Cells["idType"] as DataGridViewComboBoxCell;
                for (int i = 0; i < t.Items.Count; i++)
                {
                    if ((t.Items[i] as DataRowView).Row.ItemArray[0].ToString() == t.Value.ToString())
                    {
                        cmbChucVu.SelectedIndex = i;
                        break;
                    }
                }
                cmbGioiTinh.SelectedIndex = dataGridViewNhanVien.CurrentRow.Cells["gender"].Value.ToString() == "Nam" ? 0 : 1;
                cmbTinhTrang.SelectedIndex = (bool)dataGridViewNhanVien.CurrentRow.Cells["active"].Value ? 0 : 1;
                
                if (dataGridViewNhanVien.CurrentRow.Cells["avatar"].Value == DBNull.Value)
                {
                    avt = Array.Empty<byte>();
                    pictureBoxNhanVien.Image = Properties.Resources.no_avt;
                }
                else
                {
                    avt = (byte[])dataGridViewNhanVien.CurrentRow.Cells["avatar"].Value;
                    pictureBoxNhanVien.Image = Utils.ByteToImage(avt);
                }
            }
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            clear_edit();
            enable_edit();
            btnSua.Enabled = false;
            btnVohieuhoa.Enabled = false;
            btnThem.Enabled = false;
            selected_mode = 1;
            avt = Array.Empty<byte>();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            enable_edit();
            btnThem.Enabled = false;
            btnVohieuhoa.Enabled = false;
            btnSua.Enabled = false;
            txtId.Enabled = false;
            selected_mode = 2;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (selected_mode == 1)
            {
                string error = "";
                DBL_Account dbl = new DBL_Account();
                if (!dbl.add_employee(
                    txtId.Texts,
                    txtHoTen.Texts,
                    datePickerControlNgaySinh.Value,
                    (string)cmbGioiTinh.SelectedItem,
                    txtSDT.Texts,
                    txtCMND.Texts,
                    txtDiaChi.Texts,
                    txtEmail.Texts,
                    txtPassword.Texts,
                    avt,
                    (string)(cmbChucVu.SelectedItem as DataRowView).Row.ItemArray[0],
                    cmbTinhTrang.SelectedIndex == 0 ? true : false,
                    ref error))
                {
                    if (!String.IsNullOrEmpty(error))
                    {
                        MessageBox.Show(error, "Lỗi khi thêm mới nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (selected_mode == 2)
            {
                string error = "";
                DBL_Account dbl = new DBL_Account();
                if(!dbl.admin_update_employee(
                    txtId.Texts,
                    txtHoTen.Texts,
                    datePickerControlNgaySinh.Value,
                    (string)cmbGioiTinh.SelectedItem,
                    txtSDT.Texts,
                    txtCMND.Texts,
                    txtDiaChi.Texts,
                    txtEmail.Texts,
                    txtPassword.Texts,
                    avt,
                    (string)(cmbChucVu.SelectedItem as DataRowView).Row.ItemArray[0],
                    cmbTinhTrang.SelectedIndex == 0 ? true : false,
                    ref error))
                {
                    if (!String.IsNullOrEmpty(error))
                    {
                        MessageBox.Show(error, "Lỗi khi chỉnh sửa thông tin nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Sửa đổi thông tin nhân viên thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sửa hoặc thêm nhân viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            disable_edit();
            update_data();
            txtPassword.Texts = "";
            btnThem.Enabled = true;
            btnVohieuhoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            disable_edit();
            update_data();
            btnThem.Enabled = true;
            btnVohieuhoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void btnVohieuhoa_Click(object sender, EventArgs e)
        {
            string error = "";
            DBL_Account dbl_account = new DBL_Account();
            if (!dbl_account.deactive_employee(txtId.Texts, ref error))
            {
                MessageBox.Show(error, "Lỗi khi vô hiệu hóa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Vô hiệu hóa nhân viên thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                update_data();
            }
        }

        private void update_data()
        {
            string error = "";
            DBL_Account dbl_account = new DBL_Account();
            DataSet ds_account = dbl_account.admin_get_accounts(ref error);
            if (ds_account == null)
            {
                MessageBox.Show(error, "Lỗi không thể lấy dữ liệu nhân viên");
                return;
            }

            error = "";
            DBL_TypeAccount dbl_typeaccount = new DBL_TypeAccount();
            var ds_typeaccount = dbl_typeaccount.get_typeaccounts(ref error).Tables[0];
            if (ds_typeaccount == null)
            {
                MessageBox.Show(error, "Lỗi không thể lấy dữ liệu chức vụ");
                return;
            }

            dataGridViewNhanVien.DataSource = ds_account.Tables[0];
            (dataGridViewNhanVien.Columns["idType"] as DataGridViewComboBoxColumn).DataSource = ds_typeaccount;
            cmbChucVu.DataSource = ds_typeaccount;
            cmbChucVu.SelectedIndex = -1;
            DataGridViewNhanVien_CellClick(null, null);
        }

        private void disable_edit()
        {
            txtId.Enabled = false;
            txtHoTen.Enabled = false;
            txtSDT.Enabled = false;
            txtCMND.Enabled = false;
            txtDiaChi.Enabled = false;
            txtEmail.Enabled = false;
            txtPassword.Enabled = false;

            datePickerControlNgaySinh.Enabled = false;
            cmbGioiTinh.Enabled = false;
            cmbChucVu.Enabled = false;
            cmbTinhTrang.Enabled = false;

            btnTaiAnhDaiDien.Enabled = false;
            btnLuu.Enabled = false;

          
            dataGridViewNhanVien.CellClick += DataGridViewNhanVien_CellClick;
        }

        private void enable_edit()
        {
            txtId.Enabled = true;
            txtHoTen.Enabled = true;
            txtSDT.Enabled = true;
            txtCMND.Enabled = true;
            txtDiaChi.Enabled = true;
            txtEmail.Enabled = true;
            txtPassword.Enabled = true;

            datePickerControlNgaySinh.Enabled = true;
            cmbGioiTinh.Enabled = true;
            cmbChucVu.Enabled = true;
            cmbTinhTrang.Enabled = true;

            btnTaiAnhDaiDien.Enabled = true;
            btnLuu.Enabled = true;

            dataGridViewNhanVien.CellClick -= DataGridViewNhanVien_CellClick;
        }

        private void clear_edit()
        {
            txtId.Texts = "";
            txtHoTen.Texts = "";
            txtSDT.Texts = "";
            txtCMND.Texts = "";
            txtDiaChi.Texts = "";
            txtEmail.Texts = "";

            //datePickerControlNgaySinh.Enabled = true;
            cmbGioiTinh.SelectedIndex = -1;
            cmbChucVu.SelectedIndex = -1;
            cmbTinhTrang.SelectedIndex = -1;

            pictureBoxNhanVien.Image = null;
        }
    }
}
