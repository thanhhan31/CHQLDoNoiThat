using DataBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHQLDoNoiThat.FormsManager
{
    public partial class FormCategory : Form
    {
        private int selected_mode = -1;

        public FormCategory()
        {
            InitializeComponent();
        }

        private void FormCategory_Load(object sender, EventArgs e)
        {
            update_data();
 
            dataGridViewLoaiSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLoaiSanPham.MultiSelect = false;
            dataGridViewLoaiSanPham.AllowUserToAddRows = false;
            DataGridViewLoaiSanPham_CellClick(null, null);
            dataGridViewLoaiSanPham.ReadOnly = true;

            disable_edit();
        }

        private void DataGridViewLoaiSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewLoaiSanPham.CurrentCell == null)
                return;
            if (dataGridViewLoaiSanPham.CurrentCell.RowIndex >= 0)
            {
                var r = dataGridViewLoaiSanPham.CurrentCell.RowIndex;
                if (r >= dataGridViewLoaiSanPham.RowCount)
                    return;

                txtIdLoaiSanPham.Texts = dataGridViewLoaiSanPham.CurrentRow.Cells["id"].Value.ToString();
                txtTenLoaiSanPham.Texts = dataGridViewLoaiSanPham.CurrentRow.Cells["name"].Value.ToString();

            }
        }

        private void update_data()
        {
            string error = "";
            DBL_Category dbl_category = new DBL_Category();
            DataSet ds_category = dbl_category.get_categories(ref error);
            if (ds_category == null)
            {
                MessageBox.Show("Lỗi(" + error + ")", "Lỗi không thể lấy dữ liệu loại sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridViewLoaiSanPham.DataSource = ds_category.Tables[0];
           
            DataGridViewLoaiSanPham_CellClick(null, null);
        }

        private void disable_edit()
        {
            txtIdLoaiSanPham.Enabled = false;
            txtTenLoaiSanPham.Enabled = false;

            btnLuu.Enabled = false;

            dataGridViewLoaiSanPham.CellClick += DataGridViewLoaiSanPham_CellClick;
        }

        private void enable_edit()
        {
            txtIdLoaiSanPham.Enabled = true;
            txtTenLoaiSanPham.Enabled = true;  

            btnLuu.Enabled = true;

            dataGridViewLoaiSanPham.CellClick -= DataGridViewLoaiSanPham_CellClick;
        }

        private void clear_edit()
        {
            txtIdLoaiSanPham.Texts = "";
            txtTenLoaiSanPham.Texts = "";        
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            clear_edit();
            enable_edit();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            selected_mode = 1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            enable_edit();
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtIdLoaiSanPham.Enabled = false;
            selected_mode = 2;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string error = "";
            DBL_Category dbl_category = new DBL_Category();
            if (!dbl_category.delete_category(txtIdLoaiSanPham.Texts, ref error))
            {
                MessageBox.Show("Lỗi(" + error + ")", "Lỗi khi xóa loại sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Xóa loại sản phẩm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                update_data();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (selected_mode == 1)
            {
                string error = "";
                DBL_Category dbl = new DBL_Category();
                if (!dbl.add_category(
                    txtIdLoaiSanPham.Texts,
                    txtTenLoaiSanPham.Texts,
                    ref error))
                {
                    if (!String.IsNullOrEmpty(error))
                    {
                        MessageBox.Show("Lỗi("+error+")", "Lỗi khi thêm mới loại sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Thêm loại sản phẩm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (selected_mode == 2)
            {
                string error = "";
                DBL_Category dbl = new DBL_Category();
                if (!dbl.update_category(
                    txtIdLoaiSanPham.Texts,
                    txtTenLoaiSanPham.Texts,                    
                    ref error))
                {
                    if (!String.IsNullOrEmpty(error))
                    {
                        MessageBox.Show("Lỗi("+error+")", "Lỗi khi chỉnh sửa thông tin loại sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Sửa đổi thông tin loại sản phẩm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sửa hoặc thêm loại sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            disable_edit();
            update_data();
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }
        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            disable_edit();
            update_data();
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }
    }
}
