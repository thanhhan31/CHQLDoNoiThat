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

namespace CHQLDoNoiThat.FormsManager
{
    public partial class FormInventory : Form
    {
        private DBL_Product dbl_p = new DBL_Product();
        private DBL_Inventory dbl_i = new DBL_Inventory();
        private int selected_mode = 0;
        public FormInventory()
        {
            InitializeComponent();
        }
        private void FormInventory_Load(object sender, EventArgs e)
        {
            cmbTenSanPham.ValueMember = "id";
            cmbTenSanPham.DisplayMember = "name";
            cmbTenSanPham_Loc.ValueMember = "id";
            cmbTenSanPham_Loc.DisplayMember = "name";
            (dataGridViewKho.Columns["productName"] as DataGridViewComboBoxColumn).ValueMember = "id";
            (dataGridViewKho.Columns["productName"] as DataGridViewComboBoxColumn).DisplayMember = "name";

            update_data();

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            disable_edit();
        }

        private void btnXoa_Kho_Click(object sender, EventArgs e)
        {
            String err = "";
            if(!dbl_i.delete_inventory(txtId.Texts, ref err))
            {
                MessageBox.Show(err, "Lỗi khi xóa lô sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Xóa lô sản phẩm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                update_data();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            selected_mode = 1;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            enable_edit();
            clear_edit();

        }
        private void disable_edit()
        {
            txtId.Enabled = false;
            txtGiaGoc.Enabled = false;
            txtLoiNhuan.Enabled = false;
            txtSoLuong.Enabled = false;
            txtVat.Enabled = false;

            datePickerControlNgayNhap.Enabled = false;
            cmbTenSanPham.Enabled = false;

            btnLuu.Enabled = false;
            dataGridViewKho.CellClick += dataGridViewKho_CellClick;
        }

        private void enable_edit()
        {
            txtId.Enabled = true;
            txtSoLuong.Enabled = true;
            txtGiaGoc.Enabled = true;
            txtLoiNhuan.Enabled = true;
            txtVat.Enabled = true;

            datePickerControlNgayNhap.Enabled = true;
            cmbTenSanPham.Enabled = true;

            btnLuu.Enabled = true;

            dataGridViewKho.CellClick -= dataGridViewKho_CellClick;
        }
        private void update_data()
        {
            string err = "";
            DataSet dsi = dbl_i.admin_get_view_inventories(ref err);
            if (dsi == null)
            {
                MessageBox.Show(err, "Lỗi không thể lấy dữ liệu lô sản phẩm");
                return;
            }
            err = "";
            DataSet ds_pname_loc = dbl_p.get_products_name(ref err);
            if (ds_pname_loc == null)
            {
                MessageBox.Show(err, "Lỗi không thể lấy dữ liệu tên sản phẩm");
                return;
            }
            DataSet dsp = dbl_p.get_products_name(ref err);
            if (dsp == null)
            {
                MessageBox.Show(err, "Lỗi không thể lấy dữ liệu tên sản phẩm");
                return;
            }
            DataRow dr = ds_pname_loc.Tables[0].NewRow();
            dr["id"] = null;
            dr["name"] = "Tất cả";
            ds_pname_loc.Tables[0].Rows.Add(dr);
            cmbTenSanPham_Loc.DataSource = ds_pname_loc.Tables[0];
            cmbTenSanPham_Loc.SelectedIndex = ds_pname_loc.Tables[0].Rows.Count - 1;

            dataGridViewKho.DataSource = dsi.Tables[0];
            dataGridViewKho.Columns["productImg"].Visible = false;
            (dataGridViewKho.Columns["productName"] as DataGridViewComboBoxColumn).DataSource = dsp.Tables[0];
            cmbTenSanPham.DataSource = dsp.Tables[0];
            dataGridViewKho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewKho.MultiSelect = false;
            dataGridViewKho.AllowUserToAddRows = false;
            dataGridViewKho.ReadOnly = true;

            cmbTenSanPham.SelectedIndex = -1;
            dataGridViewKho_CellClick(null, null);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            String err = "";
            if (selected_mode == 1)
            {
                if (!check_null()) return;
                if (!dbl_i.add_inventory(
                    txtId.Texts,
                    (string)(cmbTenSanPham.SelectedItem as DataRowView).Row.ItemArray[0],
                    Int32.Parse(txtSoLuong.Texts),
                    Decimal.Parse(txtGiaGoc.Texts),
                    Decimal.Parse(txtLoiNhuan.Texts),
                    Decimal.Parse(txtVat.Texts),
                    datePickerControlNgayNhap.Value, 
                    ref err))
                {
                    if (!String.IsNullOrEmpty(err))
                    {
                        MessageBox.Show(err, "Lỗi khi thêm lô sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Thêm lô sản phẩm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if(selected_mode == 2)
            {
                if (!check_null()) return;
                if (!dbl_i.update_inventory(
                    txtId.Texts,
                    (string)(cmbTenSanPham.SelectedItem as DataRowView).Row.ItemArray[0],
                    Int32.Parse(txtSoLuong.Texts),
                    Decimal.Parse(txtGiaGoc.Texts),
                    Decimal.Parse(txtLoiNhuan.Texts),
                    Decimal.Parse(txtVat.Texts),
                    datePickerControlNgayNhap.Value,
                    ref err))
                {
                    if (!String.IsNullOrEmpty(err))
                    {
                        MessageBox.Show(err, "Lỗi khi cập nhật lô sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Cập nhật lô sản phẩm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sửa hoặc thêm lô sản phẩm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void dataGridViewKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewKho.CurrentRow;

            if (row == null)
                return;

            txtGiaGoc.Texts = row.Cells["oriPrice"].Value.ToString();
            txtLoiNhuan.Texts = row.Cells["profit"].Value.ToString();
            txtId.Texts = row.Cells["id"].Value.ToString();
            txtVat.Texts = row.Cells["vat"].Value.ToString();
            txtSoLuong.Texts = row.Cells["quatity"].Value.ToString();
            cmbTinhTrang.Texts = row.Cells["lotStatus"].Value.ToString();
            datePickerControlNgayNhap.Value = (DateTime)(row.Cells["impDate"].Value);
            
            foreach (var i in cmbTenSanPham.Items)
            {
                if (((DataRowView)i).Row.ItemArray[0].ToString() == row.Cells["productName"].Value.ToString())
                {
                    cmbTenSanPham.SelectedItem = i;
                    break;
                }
            }

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
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
        private void clear_edit()
        {
            txtId.Texts = "";
            cmbTenSanPham.SelectedIndex = -1;;
            txtSoLuong.Texts = "";
            txtGiaGoc.Texts = "";
            txtLoiNhuan.Texts = "";
            txtVat.Texts = "";
            datePickerControlNgayNhap.Value = DateTime.Now;
        }
        private bool check_null()
        {
            if(txtId.Texts == null || txtGiaGoc == null || txtLoiNhuan == null || txtSoLuong == null || txtVat == null || cmbTenSanPham.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng cung cấp đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void cmbTenSanPham_Loc_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string err = "";
            var pid = ((DataRowView)(cmbTenSanPham_Loc.SelectedItem)).Row.ItemArray[0];
            if (pid != null)
                pid = pid.ToString();
            dbl_i = new DBL_Inventory();
            DataSet dsi = dbl_i.admin_get_inventories_by_pid((string)pid, ref err);
            dataGridViewKho.DataSource = dsi.Tables[0];
        }
    }
}
