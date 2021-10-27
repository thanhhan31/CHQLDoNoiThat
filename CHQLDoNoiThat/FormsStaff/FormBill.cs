﻿using System;
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
    public partial class FormBill : Form
    {
        private string id_employee;
        public FormBill(string id_employee)
        {
            InitializeComponent();
            this.Shown += delegate (object sender, EventArgs args) { dataGridViewSanPham.ClearSelection(); };
            this.id_employee = id_employee;
        }

        private void FormBill_Load(object sender, EventArgs e)
        {
            update_data();
            disable_edit();
            clear_edit();
            disable_thanhToan();
            disable_xoa_cthd();
            lblTongTien.Text = "Tổng tiền: 0";
        }

        private void disable_edit()
        {
            txtSoLuong.Enabled = false;
            btnThemSanPham.Enabled = false;
        }

        private void disable_thanhToan()
        {
            btnThanhToan.Enabled = false;
        }

        private void disable_xoa_cthd()
        {
            btnXoa.Enabled = false;
        }

        private void enable_edit()
        {
            txtSoLuong.Enabled = true;
            btnThemSanPham.Enabled = true;
        }

        private void enable_thanhToan()
        {
            btnThanhToan.Enabled = true;
        }

        private void enable_xoa_cthd()
        {
            btnXoa.Enabled = true;
        }

        private void clear_edit()
        {
            txtTenSanPham.Text = "";
            txtDonGia.Text = "";
            txtSoLuong.Text = "";
        }

        private void update_data()
        {
            string error = "";
            DBL_Product dbl_product = new DBL_Product();
            DataSet ds_product = dbl_product.get_products(ref error);
            if (ds_product == null)
            {
                MessageBox.Show(error, "Lỗi không thể lấy dữ loại loại sản phẩm");
                return;
            }

            dataGridViewSanPham.DataSource = ds_product.Tables[0];
            dataGridViewSanPham.Columns["idCategory"].Visible = false;
            dataGridViewSanPham.Columns["active"].Visible = false;

            error = "";
            DBL_Category dbl_category = new DBL_Category();
            DataSet ds_catefory = dbl_category.get_categories(ref error);
            if (ds_catefory == null)
            {
                MessageBox.Show(error, "Lỗi không thể lấy dữ loại loại sản phẩm");
                return;
            }

            DataRow dr = ds_catefory.Tables[0].NewRow();
            dr["id"] = null;
            dr["name"] = "Tất cả";
            ds_catefory.Tables[0].Rows.Add(dr);

            cmbLoaiSanPham.DataSource = ds_catefory.Tables[0];
            cmbLoaiSanPham.ValueMember = "id";
            cmbLoaiSanPham.DisplayMember = "name";
            cmbLoaiSanPham.SelectedIndex = ds_catefory.Tables[0].Rows.Count - 1;
        }

        private void cmbLoaiSanPham_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (((DataRowView)cmbLoaiSanPham.SelectedItem).Row.ItemArray[0] == DBNull.Value)
            {
                (dataGridViewSanPham.DataSource as DataTable).DefaultView.RowFilter = "active = 1";
            }
            else
            {
                (dataGridViewSanPham.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("idCategory = '{0}' and active = 1", ((string)(cmbLoaiSanPham.SelectedItem as DataRowView).Row.ItemArray[0]));
            }
            dataGridViewSanPham.ClearSelection();
            clear_edit();
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            update_data();
            disable_edit();
            clear_edit();
            disable_thanhToan();
            disable_xoa_cthd();
        }

        private void dataGridViewSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            enable_edit();
            if (dataGridViewSanPham.CurrentCell.RowIndex >= 0)
            {
                var r = dataGridViewSanPham.CurrentCell.RowIndex;
                if (r >= dataGridViewSanPham.RowCount)
                    return;

                txtTenSanPham.Text = dataGridViewSanPham.CurrentRow.Cells["name"].Value.ToString();
                txtDonGia.Text = dataGridViewSanPham.CurrentRow.Cells["sellPrice"].Value.ToString();
                txtSoLuong.Text = "1";
            }
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            bool da_co = false;
            int i_row = dataGridViewSanPham.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridViewSanPham.Rows[i_row];

            if (dataGridViewChiTietHoaDon.Rows.Count >= 1)
            {
                foreach (DataGridViewRow r in dataGridViewChiTietHoaDon.Rows)
                {
                    if (r.Cells[0].Value != null && r.Cells["idProduct"].Value.ToString() == selectedRow.Cells["id"].Value.ToString())
                    {
                        int total_quantity = int.Parse(r.Cells["quantity_"].Value.ToString()) + int.Parse(txtSoLuong.Text);
                        if (total_quantity > int.Parse(selectedRow.Cells["quantity"].Value.ToString()))
                        {
                            MessageBox.Show("Số lượng sản phẩm quá lượng sản phẩm trên kệ", "Thông báo");
                            return;
                        }
                        r.Cells["quantity_"].Value = total_quantity.ToString();
                        da_co = true;
                    }
                }
            }

            if (!da_co)
            {
                if (int.Parse(txtSoLuong.Text) > int.Parse(selectedRow.Cells["quantity"].Value.ToString()))
                {
                    MessageBox.Show("Số lượng sản phẩm quá lượng sản phẩm trên kệ", "Thông báo");
                    return;
                }
                dataGridViewChiTietHoaDon.Rows.Add(selectedRow.Cells["id"].Value,
                    selectedRow.Cells["name"].Value,
                    selectedRow.Cells["sellPrice"].Value,
                    txtSoLuong.Text);
            }

            enable_thanhToan();
            disable_edit();
            clear_edit();
            tinhTongTien();
        }

        private void tinhTongTien()
        {
            decimal total = 0;
            foreach (DataGridViewRow r in dataGridViewChiTietHoaDon.Rows)
            {
                if (r.Cells[0].Value == null)
                    break;
                total += decimal.Parse(r.Cells["price"].Value.ToString()) * int.Parse(r.Cells["quantity_"].Value.ToString());
            }
            lblTongTien.Text = "Tổng tiền: " + total.ToString();
        }

        private void dataGridViewChiTietHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            enable_xoa_cthd();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow i_row = dataGridViewChiTietHoaDon.CurrentRow;
            if (i_row.Cells[0].Value != null)
            {
                dataGridViewChiTietHoaDon.Rows.Remove(i_row);
                disable_xoa_cthd();
                tinhTongTien();
            }

            if (dataGridViewChiTietHoaDon.Rows.Count <= 1)
            {
                disable_thanhToan();
            }
        }

        private string genarateIdBill(int count)
        {
            return string.Format("HD{0}", count.ToString().PadLeft(3, '0'));
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string error = "";
            DBL_Bill dbl_bill = new DBL_Bill();
            DataSet ds_bill = dbl_bill.get_bills(ref error);
            if (ds_bill == null)
            {
                MessageBox.Show(error, "Lỗi không thể lấy được dữ liệu hóa đơn");
                return;
            }

            string idBill = genarateIdBill(ds_bill.Tables[0].Rows.Count);

            if (!dbl_bill.add_bill(idBill,
                id_employee,
                ref error))
            {
                if (!String.IsNullOrEmpty(error))
                {
                    MessageBox.Show(error, "Lỗi khi thêm mới hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Thêm hóa đơn thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            error = "";
            DBL_BillDetail dbl_billDetail = new DBL_BillDetail();
            foreach (DataGridViewRow r in dataGridViewChiTietHoaDon.Rows)
            {
                if (r.Cells[0].Value == null)
                    break;

                if (!dbl_billDetail.add_billdetail(idBill,
                    r.Cells["idProduct"].Value.ToString(),
                    int.Parse(r.Cells["quantity_"].Value.ToString()),
                    ref error))
                {
                    if (!String.IsNullOrEmpty(error))
                    {
                        MessageBox.Show(error, "Lỗi khi thêm mới chi tiết hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            dataGridViewChiTietHoaDon.Rows.Clear();
            btnTaiLai_Click(null, null);
        }
    }
}
