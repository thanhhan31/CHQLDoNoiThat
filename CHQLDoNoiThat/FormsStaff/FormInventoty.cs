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

namespace CHQLDoNoiThat.FormsStaff
{
    public partial class FormInventoty : Form
    {
        private DBL_Product dbl_p = new DBL_Product();
        private DBL_Inventory dbl_i = new DBL_Inventory();
        public FormInventoty()
        {
            InitializeComponent();
        }

        private void FormInventoty_Load(object sender, EventArgs e)
        {
            string err = "";
            DataSet dsi = dbl_i.employee_get_inventories_by_pid("",ref err);
            if (dsi == null)
            {
                MessageBox.Show("Lỗi(" + err + ")", "Lỗi không thể lấy dữ liệu lô sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            err = "";
            DataSet ds_pname = dbl_p.get_products_name(ref err);
            if (ds_pname == null)
            {
                MessageBox.Show("Lỗi(" + err + ")", "Lỗi không thể lấy dữ liệu tên sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataRow dr = ds_pname.Tables[0].NewRow();
            dr["id"] = null;
            dr["name"] = "Tất cả";
            ds_pname.Tables[0].Rows.Add(dr);
            cmbTenSanPham.ValueMember = "id";
            cmbTenSanPham.DisplayMember = "name";
            cmbTenSanPham.DataSource = ds_pname.Tables[0];
            cmbTenSanPham.SelectedIndex = ds_pname.Tables[0].Rows.Count-1;

            dataGridViewKho.DataSource = dsi.Tables[0];
            dataGridViewKho.Columns["productImg"].Visible = false;
            dataGridViewKho.Columns["productId"].Visible = false;
            dataGridViewKho.MultiSelect = false;
            dataGridViewKho.AllowUserToAddRows = false;
            dataGridViewKho.ReadOnly = true;
            dataGridViewKho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewKho.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewKho.DefaultCellStyle.BackColor = Color.White;
            dataGridViewKho_CellClick(null, null);
        }

        private void dataGridViewKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewKho.CurrentRow;
            if (row == null)
                return;

            txtTenSanPham.Texts = row.Cells["name"].Value.ToString();
            txtId.Texts = row.Cells["id"].Value.ToString();
            txtSoLuong.Texts = row.Cells["quatity"].Value.ToString();
            datePickerControlNgayNhap.Value = (DateTime)(row.Cells["impDate"].Value);
        }

        private void cmbTenSanPham_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string err = "";
            var pid = ((DataRowView)(cmbTenSanPham.SelectedItem)).Row.ItemArray[0];
            if (pid != null)
                pid = pid.ToString();
            dbl_i = new DBL_Inventory();
            DataSet dsi = dbl_i.employee_get_inventories_by_pid((string)pid, ref err);
            dataGridViewKho.DataSource = dsi.Tables[0];
        }
    }
}
