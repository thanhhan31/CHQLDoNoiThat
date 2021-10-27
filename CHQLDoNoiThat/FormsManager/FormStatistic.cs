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
    public partial class FormStatistic : Form
    {
        DBL_Statistic dbl_s = new DBL_Statistic();
        public FormStatistic()
        {
            InitializeComponent();
        }

        private void comboBoxControlThongKeTheo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string choose = comboBoxControlThongKeTheo.Texts;
            string err = "";
            var current = new Dictionary<string, string>();
            if(choose == "Năm")
            {
                DataSet ds = dbl_s.statistic_allyear(ref err);
                if (ds == null)
                {
                    MessageBox.Show("Không có dữ liệu", "Thông báo");
                    return;
                }
                dataGridViewStatistic.DataSource = ds.Tables[0];
                current = getCurrent("year");
                lblNgayBatDau.Text = current["start"];
                lblNgayHomNay.Text = current["end"];
                lbl_now.Text = "Năm nay";
            }
            else if(choose =="Tháng")
            {
                DataSet ds = dbl_s.statistic_allmonth(ref err);
                if (ds == null)
                {
                    MessageBox.Show("Không có dữ liệu", "Thông báo");
                    return;
                }
                dataGridViewStatistic.DataSource = ds.Tables[0];
                current = getCurrent("month");
                lblNgayBatDau.Text = current["start"];
                lblNgayHomNay.Text = current["end"];
                lbl_now.Text = "Tháng này";
                dataGridViewStatistic.Columns["month"].HeaderText = "Tháng";
                dataGridViewStatistic.Columns["month"].DisplayIndex = 1;
            }
            else if(choose == "Quý")
            {
                DataSet ds = dbl_s.statistic_allquarter(ref err);
                if (ds == null)
                {
                    MessageBox.Show("Không có dữ liệu", "Thông báo");
                    return;
                }
                dataGridViewStatistic.DataSource = ds.Tables[0];
                current = getCurrent("quarter");
                lblNgayBatDau.Text = current["start"];
                lblNgayHomNay.Text = current["end"];
                lbl_now.Text = "Quý này("+ current["index"]+")";
                dataGridViewStatistic.Columns["quarter"].HeaderText = "Quý";
                dataGridViewStatistic.Columns["quarter"].DisplayIndex = 1;
            }
            lblTienChi.Text = "Tiền chi: " + current["chi"];
            lblTienThu.Text = "Tiền thu: " + current["thu"];
            lblLoiNhuan.Text = "Lợi nhuận: " + current["loi"];
        }

        private void FormStatistic_Load(object sender, EventArgs e)
        {
            comboBoxControlThongKeTheo.SelectedIndex = 2;
            dataGridViewStatistic.ReadOnly = true;
            dataGridViewStatistic.AllowUserToAddRows = false;
        }
        private Dictionary<string,string> getCurrent(string kw)
        {
            Dictionary<string, string> date = new Dictionary<string, string>();
            DataGridViewRow correctRow = new DataGridViewRow();
            if (kw == "year")
            {
                int year = DateTime.Now.Year;
                date["start"] = "1/1/" + year.ToString();
                date["index"] = year.ToString();
                foreach (DataGridViewRow i in dataGridViewStatistic.Rows)
                {
                    if (i.Cells["year"].Value.ToString() == year.ToString())
                    {
                        correctRow = i;
                        break;
                    }
                }
                
            }
            else if(kw == "month")
            {
                int year = DateTime.Now.Year;
                int month = DateTime.Now.Month;
                date["start"] = string.Format("1/{0}/{1}", month, year);
                date["index"] = month.ToString();
                foreach (DataGridViewRow i in dataGridViewStatistic.Rows)
                {
                    if (i.Cells["year"].Value.ToString() == year.ToString() &&
                        i.Cells["month"].Value.ToString() == month.ToString())
                    {
                        correctRow = i;
                        break;
                    }
                }
            }   
            else if(kw == "quarter")
            {
                int year = DateTime.Now.Year;
                int month = DateTime.Now.Month;
                int quarter = (month + 2) / 3;
                int startMonth = (quarter - 1) * 3 + 1;
                date["start"] = string.Format("1/{0}/{1}", startMonth, year);
                date["index"] = quarter.ToString();
                foreach (DataGridViewRow i in dataGridViewStatistic.Rows)
                {
                    if (i.Cells["year"].Value.ToString() == year.ToString()&&
                        i.Cells["quarter"].Value.ToString() == quarter.ToString())
                    {
                        correctRow = i;
                        break;
                    }
                }
            }
            if (correctRow.Index != -1)
            {
                date["thu"] = correctRow.Cells["thu"].Value.ToString();
                date["chi"] = correctRow.Cells["chi"].Value.ToString();
                date["loi"] = correctRow.Cells["loi"].Value.ToString();
            }
            else
            {
                date["thu"] = "0";
                date["chi"] = "0";
                date["loi"] = "0";
            }
            date["end"] = DateTime.Now.ToString("dd/MM/yyyy");
            return date;
        }
    }
}
