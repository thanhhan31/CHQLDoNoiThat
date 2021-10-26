using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBusiness;

namespace CHQLDoNoiThat.FormsManager
{
    public partial class FormProduct : Form
    {
        private int selected_mode = -1;
        private byte[] image;

        public FormProduct()
        {
            InitializeComponent();
        }

        private void btnTaiAnhSanPham_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBoxSanPham.Image = new Bitmap(open.FileName);
                image = File.ReadAllBytes(open.FileName);
            }
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            update_data();
            pictureBoxSanPham.SizeMode = PictureBoxSizeMode.StretchImage;
            dataGridViewSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSanPham.MultiSelect = false;
            dataGridViewSanPham.AllowUserToAddRows = false;
            dataGridViewSanPham.ReadOnly = true;
            (dataGridViewSanPham.Columns["idCategory"] as DataGridViewComboBoxColumn).ValueMember = "id";
            (dataGridViewSanPham.Columns["idCategory"] as DataGridViewComboBoxColumn).DisplayMember = "name";
                        
            DataGridViewSanPham_CellClick(null, null);

            cmbCategory.ValueMember = "id";
            cmbCategory.DisplayMember = "name";

            txtGiaBan.Enabled = false;
            txtSoLuong.Enabled = false;
            txtTinhTrang.Enabled = false;
            disable_edit();
        }

        private void update_data()
        {
            string error = "";
            DBL_Product dbl_products = new DBL_Product();
            var ds_products = dbl_products.admin_get_view_product(ref error);
            if (ds_products == null)
            {
                MessageBox.Show(error, "Lỗi không thể lấy dữ liệu sản phẩm");
                return;
            }

            error = "";
            DBL_Category dbl_categories = new DBL_Category();
            var ds_categories = dbl_categories.get_categories(ref error);
            if (ds_categories == null)
            {
                MessageBox.Show(error, "Lỗi không thể lấy dữ liệu loại sản phẩm");
                return;
            }

            dataGridViewSanPham.DataSource = ds_products.Tables[0];

            (dataGridViewSanPham.Columns["idCategory"] as DataGridViewComboBoxColumn).DataSource = ds_categories.Tables[0];
            
            cmbCategory.DataSource = ds_categories.Tables[0];
            cmbCategory.SelectedIndex = -1;
            DataGridViewSanPham_CellClick(null, null);
        }

        private void enable_edit()
        {
            cmbCategory.Enabled = true;
            txtId.Enabled = true;
            txtTenSanPham.Enabled = true;
            btnTaiAnhSanPham.Enabled = true;
            btnLuu.Enabled = true;
            dataGridViewSanPham.CellClick -= DataGridViewSanPham_CellClick;
        }

        private void disable_edit()
        {
            cmbCategory.Enabled = false;
            txtId.Enabled = false;
            txtTenSanPham.Enabled = false;
            btnTaiAnhSanPham.Enabled = false;
            btnLuu.Enabled = false;
            dataGridViewSanPham.CellClick += DataGridViewSanPham_CellClick;
        }

        private void clear_edit()
        {
            txtId.Texts = "";
            cmbCategory.SelectedIndex = -1;
            txtTenSanPham.Texts = "";
            txtGiaBan.Texts = "";
            txtSoLuong.Texts = "";
            pictureBoxSanPham.Image = null;
        }

        private void DataGridViewSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSanPham.CurrentCell.RowIndex >= 0)
            {
                var r = dataGridViewSanPham.CurrentCell.RowIndex;
                if (r >= dataGridViewSanPham.RowCount)
                    return;

                txtId.Texts = dataGridViewSanPham.CurrentRow.Cells["productId"].Value.ToString();
                txtTenSanPham.Texts = dataGridViewSanPham.CurrentRow.Cells["productName"].Value.ToString();
                txtGiaBan.Texts = dataGridViewSanPham.CurrentRow.Cells["productPrice"].Value.ToString();
                txtSoLuong.Texts = dataGridViewSanPham.CurrentRow.Cells["productQuantity"].Value.ToString();

                var t = dataGridViewSanPham.CurrentRow.Cells["idCategory"] as DataGridViewComboBoxCell;
                for (int i = 0; i < t.Items.Count; i++)
                {
                    if ((t.Items[i] as DataRowView).Row.ItemArray[0].ToString() == t.Value.ToString())
                    {
                        cmbCategory.SelectedIndex = i;
                        break;
                    }
                }
                txtTinhTrang.Texts = dataGridViewSanPham.CurrentRow.Cells["productStatus"].Value.ToString();

                if (dataGridViewSanPham.CurrentRow.Cells["productImg"].Value == DBNull.Value)
                {
                    image = Array.Empty<byte>();
                    pictureBoxSanPham.Image = Properties.Resources.no_avt;
                }
                else
                {
                    image = (byte[])dataGridViewSanPham.CurrentRow.Cells["productImg"].Value;
                    pictureBoxSanPham.Image = Utils.ByteToImage(image);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            clear_edit();
            enable_edit();
            selected_mode = 1;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            txtId.Enabled = true;
            btnLuu.Enabled = true;
            image = Array.Empty<byte>();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            enable_edit();
            selected_mode = 2;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            txtId.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnXoa_LoaiSanPham_Click(object sender, EventArgs e)
        {
            string error = "";
            DBL_Product dbl = new DBL_Product();
            if (!dbl.delete_product(
                txtId.Texts,
                ref error))
            {
                MessageBox.Show(error, "Lỗi khi xóa sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Xóa sản phẩm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                update_data();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (selected_mode == 1)
            {
                string error = "";
                DBL_Product dbl = new DBL_Product();
                if (!dbl.add_product(
                    txtId.Texts,
                    (string)(cmbCategory.SelectedItem as DataRowView).Row.ItemArray[0],
                    txtTenSanPham.Texts,
                    image,
                    ref error
                    ))
                {
                    if (!String.IsNullOrEmpty(error))
                    {
                        MessageBox.Show(error, "Lỗi khi thêm mới sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (selected_mode == 2)
            {
                string error = "";
                DBL_Product dbl = new DBL_Product();
                if (!dbl.update_product(
                    txtId.Texts,
                    (string)(cmbCategory.SelectedItem as DataRowView).Row.ItemArray[0],
                    txtTenSanPham.Texts,
                    image,
                    ref error))
                {
                    if (!String.IsNullOrEmpty(error))
                    {
                        MessageBox.Show(error, "Lỗi khi cập nhật thông tin sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin sản phẩm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thêm hoặc sửa thông tin sản phẩm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            disable_edit();
            update_data();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            disable_edit();
            update_data();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            
        }
    }
}
