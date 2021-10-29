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
    public partial class FormBillHistory : Form
    {
        DBL_Bill dbl = new DBL_Bill();

        private string id_employee;

        public FormBillHistory(string id_employee)
        {
            InitializeComponent();
            dataGridViewLSHD.ForeColor = Color.Black;
            this.Shown += delegate (object sender, EventArgs args) { dataGridViewLSHD.ClearSelection(); };
            this.id_employee = id_employee;
        }

        private void FormBillHistory_Load(object sender, EventArgs e)
        {
            string err = "";
            DataSet ds = dbl.get_nv_billHistory(id_employee, ref err);
            dataGridViewLSHD.DataSource = ds.Tables[0];
            dataGridViewLSHD.AllowUserToAddRows = false;
            dataGridViewLSHD.Columns["idAcc"].Visible = false;
            dataGridViewCTHD.ForeColor = Color.Black;
        }

        private void dataGridViewLSHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewLSHD.CurrentRow;

            txtTongTien.Texts = row.Cells["checkOut"].Value.ToString();
            txtId.Texts = row.Cells["id"].Value.ToString();
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
            DataSet ds = dbl.get_nv_billHistory_createDate(date, ref err);
            dataGridViewLSHD.DataSource = ds.Tables[0];
        }
    }
}
