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

namespace CHQLDoNoiThat.FormsStaff
{
    public partial class FormProduct : Form
    {
        private byte[] image;

        public FormProduct()
        {
            InitializeComponent();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            update_data();
            pictureBoxSanPham.SizeMode = PictureBoxSizeMode.StretchImage;
            dataGridViewSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSanPham.MultiSelect = false;
            dataGridViewSanPham.AllowUserToAddRows = false;
            dataGridViewSanPham.ReadOnly = true;

            DataGridViewSanPham_CellClick(null, null);

            disable_edit();
        }

        private void update_data()
        {
            string error = "";
            DBL_Product dbl_products = new DBL_Product();
            var ds_products = dbl_products.employee_get_view_product(ref error);
            if (ds_products == null)
            {
                MessageBox.Show(error, "Lỗi không thể lấy dữ liệu sản phẩm");
                return;
            }

            dataGridViewSanPham.DataSource = ds_products.Tables[0];

            DataGridViewSanPham_CellClick(null, null);
        }

        private void DataGridViewSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSanPham.CurrentCell == null)
                return;

            if (dataGridViewSanPham.CurrentCell.RowIndex >= 0)
            {
                var r = dataGridViewSanPham.CurrentCell.RowIndex;
                if (r >= dataGridViewSanPham.RowCount)
                    return;

                txtId.Texts = dataGridViewSanPham.CurrentRow.Cells["productId"].Value.ToString();
                txtLoaiSanPham.Texts = dataGridViewSanPham.CurrentRow.Cells["productCategory"].Value.ToString();
                txtTenSanPham.Texts = dataGridViewSanPham.CurrentRow.Cells["productName"].Value.ToString();
                txtGiaBan.Texts = dataGridViewSanPham.CurrentRow.Cells["productPrice"].Value.ToString();
                txtSoLuong.Texts = dataGridViewSanPham.CurrentRow.Cells["productQuantity"].Value.ToString();


                if (dataGridViewSanPham.CurrentRow.Cells["productImg"].Value == DBNull.Value)
                {
                    image = Array.Empty<byte>();
                    pictureBoxSanPham.Image = Properties.Resources.no_img;
                }
                else
                {
                    image = (byte[])dataGridViewSanPham.CurrentRow.Cells["productImg"].Value;
                    pictureBoxSanPham.Image = Utils.ByteToImage(image);
                }
            }

        }
        private void disable_edit()
        {
            txtLoaiSanPham.Enabled = false;
            txtId.Enabled = false;
            txtTenSanPham.Enabled = false;
            txtGiaBan.Enabled = false;
            txtSoLuong.Enabled = false;

            dataGridViewSanPham.CellClick += DataGridViewSanPham_CellClick;
        }

        private void txtTimTenSanPham_TextChanged(object sender, EventArgs e)
        {
            string filter = txtTimTenSanPham.Texts;
            if (!String.IsNullOrEmpty(filter))
                (dataGridViewSanPham.DataSource as DataTable).DefaultView.RowFilter = string.Format("productName LIKE '*{0}*'", filter);
            else
                (dataGridViewSanPham.DataSource as DataTable).DefaultView.RowFilter = "";
        }
    }
}