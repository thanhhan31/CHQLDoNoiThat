
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
    public partial class FormBillHistory : Form
    {
        DBL_Bill dbl = new DBL_Bill();
        public FormBillHistory()
        {
            InitializeComponent();
        }

        private void FormBillHistory_Load_1(object sender, EventArgs e)
        {
            string err = "";
            DataSet ds = dbl.get_view_billhistory(ref err);
            dataGridViewLSHD.DataSource = ds.Tables[0];
            dataGridViewLSHD.AllowUserToAddRows = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewLSHD.CurrentRow;

            txtTongTien.Texts = row.Cells["checkOut"].Value.ToString();
            txtId.Texts = row.Cells["id"].Value.ToString();
            txtTenNhanVien.Texts = row.Cells["name"].Value.ToString();
            datePickerControlNgayTao.Value = (DateTime)(row.Cells["createTime"].Value);

            string err = "";
            DataSet ds = dbl.get_billDetails_by_idBill(row.Cells["id"].Value.ToString(), ref err);
            dataGridViewCTHD.DataSource = ds.Tables[0];
        }

        private void datePickerControlLichSuHoaDon_ValueChanged(object sender, EventArgs e)
        {
            string err = "";
            var date = datePickerControlLichSuHoaDon.Value;
            dbl = new DBL_Bill();
            DataSet ds = dbl.get_ql_billHistory_createDate(date, ref err);
            dataGridViewLSHD.DataSource = ds.Tables[0];
        }


    }
}