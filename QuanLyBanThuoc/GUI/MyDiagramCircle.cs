using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using QuanLyBanThuoc.DAL;
namespace QuanLyBanThuoc.GUI
{
    public partial class MyDiagramCircle : UserControl
    {
        public MyDiagramCircle()
        {
            InitializeComponent();
        }
        DataTable table = null;
        DataSet dataContain = null;
        private void btnAddMonth_Click(object sender, EventArgs e)
        {
            int dayOfMonth = 0;
            DateTime aDateTime = DateTime.Now;
            int year = aDateTime.Year;

            if (txbMonth.Text == "") { return; }
            try
            {
                if (Convert.ToInt32(txbMonth.Text) <= 0 || Convert.ToInt32(txbMonth.Text) > 12) return;
                else { dayOfMonth = System.DateTime.DaysInMonth(year, int.Parse(txbMonth.Text)); }
            }
            catch
            {
                return;
            }

            if (table == null)
            {
                table = new DataTable();
                table.Columns.Add("Month", typeof(string));
                table.Columns.Add("Total", typeof(int));
            }
            double total = InformationMedicineDAO.Instance.GetTotalMonth(txbMonth.Text, dayOfMonth + "", year + "");
            table.Rows.Add("Tháng " + txbMonth.Text, total);
            pngOk.Visible = true;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            guna2Transition1.HideSync(chart1);
            dataContain = new DataSet();
            try { dataContain.Tables.Add(table); }
            catch
            {
                MessageBox.Show("You don't reset");
            }
            chart1.DataSource = dataContain;
            chart1.Series["Turnover"].XValueMember = "Month";
            chart1.Series["Turnover"].YValueMembers = "Total";
            chart1.Series[0].ChartType = SeriesChartType.Pie;
            dtgvRevenue.DataSource = table;
            guna2Transition1.ShowSync(chart1);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            guna2Transition1.HideSync(chart1);
            guna2Transition1.ShowSync(chart1);
            if (dataContain == null) return;
            dataContain.Tables.Clear();
            if (table == null) { LoadDataForCircle(); return; }
            table.Rows.Clear();
            LoadDataForCircle();
            dataContain = null;
            table = null;
            pngOk.Visible = true;

        }
        void LoadDataForCircle()
        {
            DataTable tableDefault = new DataTable();
            tableDefault.Columns.Add("Month", typeof(string));
            tableDefault.Columns.Add("Total", typeof(int));
            tableDefault.Rows.Add("Tháng " + 4, 30);
            tableDefault.Rows.Add("Tháng " + 8, 40);
            tableDefault.Rows.Add("Tháng " + 9, 30);
            DataSet dataContainDefault = new DataSet();
            dataContainDefault.Tables.Add(tableDefault);
            chart1.DataSource = dataContainDefault;
            chart1.Series["Turnover"].XValueMember = "Month";
            chart1.Series["Turnover"].YValueMembers = "Total";
            chart1.Series[0].ChartType = SeriesChartType.Pie;
            dtgvRevenue.DataSource = tableDefault;

        }
        private void MyDiagramCircle_Load(object sender, EventArgs e)
        {
            LoadDataForCircle();
            pngOk.Visible = false;
        }

        private void txbMonth_MouseClick(object sender, MouseEventArgs e)
        {
            pngOk.Visible = false;
        }

        private void chart1_DoubleClick(object sender, EventArgs e)
        {

            chart1.Series[0].ChartType = (chart1.Series[0].ChartType == SeriesChartType.Pie) ?
                chart1.Series[0].ChartType = SeriesChartType.Column : chart1.Series[0].ChartType = SeriesChartType.Pie;
        }
    }
}