using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using DataBusiness;

namespace CHQLDoNoiThat.FormsManager
{
    public partial class FormStatistic : Form
    {
        DBL_Statistic dbl_s = new DBL_Statistic();
        public FormStatistic()
        {
            InitializeComponent();
        }
        private void FormStatistic_Load(object sender, EventArgs e)
        {
            comboBoxControlThongKeTheo.SelectedIndex = 2;
            dataGridViewStatistic.ReadOnly = true;
            dataGridViewStatistic.AllowUserToAddRows = false;
            dataGridViewStatistic.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStatistic.MultiSelect = false;

        }
        private void comboBoxControlThongKeTheo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string choose = comboBoxControlThongKeTheo.Texts;
            string err = "";
            if(choose == "Năm")
            {
                DataSet ds = dbl_s.statistic_allyear(ref err);
                if (ds == null)
                {
                    MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dataGridViewStatistic.DataSource = ds.Tables[0];
            }
            else if(choose =="Tháng")
            {
                DataSet ds = dbl_s.statistic_allmonth(ref err);
                if (ds == null)
                {
                    MessageBox.Show("Không có dữ liệu!", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dataGridViewStatistic.DataSource = ds.Tables[0];
                dataGridViewStatistic.Columns["month"].HeaderText = "Tháng";
                dataGridViewStatistic.Columns["month"].DisplayIndex = 1;
            }
            else if(choose == "Quý")
            {
                DataSet ds = dbl_s.statistic_allquarter(ref err);
                if (ds == null)
                {
                    MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dataGridViewStatistic.DataSource = ds.Tables[0];
                dataGridViewStatistic.Columns["quarter"].HeaderText = "Quý";
                dataGridViewStatistic.Columns["quarter"].DisplayIndex = 1;
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string err = "";
            DataSet ds = dbl_s.statistic_custom(datePickerControlNgayBatDau.Value, datePickerControlNgayKetThuc.Value, ref err);
            var result = ds.Tables[0].Rows[0];

            Decimal thu = (Decimal)result["thu"];
            Decimal chi = (Decimal)result["chi"];
            Decimal loi = (Decimal)result["loiNhuan"];
            lblTienThu.Text = "Tiền thu: " + thu.ToString("C3", CultureInfo.CreateSpecificCulture("vi-VN"));
            lblTienChi.Text = "Tiền chi: " + chi.ToString("C3", CultureInfo.CreateSpecificCulture("vi-VN"));
            lblLoiNhuan.Text = "Lợi nhuận: " + loi.ToString("C3", CultureInfo.CreateSpecificCulture("vi-VN"));
        }

        private void dataGridViewStatistic_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var choose = comboBoxControlThongKeTheo.Texts;
            var row = dataGridViewStatistic.CurrentRow;
            DateTime startDate = DateTime.Now, endDate = DateTime.Now;

            if (choose == "Năm")
            {
                int thisYear = DateTime.Now.Year;
                int year = (int)row.Cells["year"].Value;
                startDate = DateTime.ParseExact("01/01/" + year, "dd/MM/yyyy", null);
                if (year == thisYear)
                    endDate = DateTime.Now;
                else
                    endDate = DateTime.ParseExact("31/12/" + year, "dd/MM/yyyy", null);
            }
            else if(choose =="Tháng")
            {
                int thisYear = DateTime.Now.Year;
                int thisMonth = DateTime.Now.Month;
                int year = (int)row.Cells["year"].Value;
                int month = (int)row.Cells["month"].Value;
                startDate = DateTime.ParseExact(string.Format("01/{0:00}/{1}", month, year), "dd/MM/yyyy", null);
                if (year == thisYear && month == thisMonth)
                    endDate = DateTime.Now;
                else
                {
                    string tmp = string.Format("{0:00}/{1:00}/{2}",
                        DateTime.DaysInMonth(year, month), month, year);
                    endDate = DateTime.ParseExact(tmp, "dd/MM/yyyy", null);
                }
            }
            else if(choose == "Quý")
            {
                int thisYear = DateTime.Now.Year;
                int thisQuarter = (DateTime.Now.Month + 2) / 3;
                int year = (int)row.Cells["year"].Value;
                int quarter = (int)row.Cells["quarter"].Value;
                int startMonth = (quarter - 1) * 3 + 1;

                startDate = DateTime.ParseExact(string.Format("01/{0:00}/{1}", startMonth, year), "dd/MM/yyyy", null);
                if (year == thisYear && quarter == thisQuarter )
                    endDate = DateTime.Now;
                else
                {
                    string tmp = string.Format("{0:00}/{1:00}/{2}",
                        DateTime.DaysInMonth(year, startMonth + 2), (startMonth + 2), year);
                    endDate = DateTime.ParseExact(tmp, "dd/MM/yyyy", null);
                }
                    
            }
            datePickerControlNgayBatDau.Value = startDate;
            datePickerControlNgayKetThuc.Value = endDate;

            Decimal thu = (Decimal)row.Cells["thu"].Value;
            Decimal chi = (Decimal)row.Cells["chi"].Value;
            Decimal loi = (Decimal)row.Cells["loi"].Value;
            lblTienThu.Text = "Tiền thu: " + thu.ToString("C3", CultureInfo.CreateSpecificCulture("vi-VN"));
            lblTienChi.Text = "Tiền chi: " + chi.ToString("C3", CultureInfo.CreateSpecificCulture("vi-VN"));
            lblLoiNhuan.Text = "Lợi nhuận: " + loi.ToString("C3", CultureInfo.CreateSpecificCulture("vi-VN"));
        }
    }
}
