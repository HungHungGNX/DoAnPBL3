using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanThuoc.DAL;
namespace QuanLyBanThuoc.GUI
{
    public partial class fInformationMedicine : Form
    {
        public fInformationMedicine()
        {
            InitializeComponent();
            SidePanel.Height = btnQuayLai.Height;
            SidePanel.Top = btnQuayLai.Top;
            ptbxInformationMedicine.Visible = true;
        }
        private void fInformationMedicine_Load(object sender, EventArgs e)
        {
            guna2AnimateWindow1.SetAnimateWindow(this, Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HOR_POSITIVE, Bottom);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMedicineBest_Click(object sender, EventArgs e)
        {
            int month = 0;
            try
            {
               month= int.Parse(txbMonth.Text);
            }
            catch
            {
                return;
            }
            if (int.Parse(txbMonth.Text) > 12 || int.Parse(txbMonth.Text) < 0) return;
          
            if (month >= 1 && month <= 12)
            {
                int dayOfMonth = 0;
                DateTime aDateTime = DateTime.Now;
                int year = aDateTime.Year;
                dayOfMonth = System.DateTime.DaysInMonth(year, int.Parse(txbMonth.Text));
                ptbxInformationMedicine.Visible = false;
                SidePanel.Height = btnMedicineBest.Height;
                SidePanel.Top = btnMedicineBest.Top;
                DataTable data = InformationMedicineDAO.Instance.GetListMedicineBestByMonth(txbMonth.Text, dayOfMonth.ToString(), year.ToString());
                dtgvInformationMedicine.DataSource = data;
                guna2Transition1.HideSync(dtgvInformationMedicine);
                guna2Transition1.ShowSync(dtgvInformationMedicine);
            }
            else
            {
                ptbxInformationMedicine.Visible = false;
                SidePanel.Height = btnMedicineBest.Height;
                SidePanel.Top = btnMedicineBest.Top;
                DataTable data = InformationMedicineDAO.Instance.GetListMedicineBest();
                dtgvInformationMedicine.DataSource = data;
                guna2Transition1.HideSync(dtgvInformationMedicine);
                guna2Transition1.ShowSync(dtgvInformationMedicine);
            }

        }

        private void btnMedicineEmpty_Click(object sender, EventArgs e)
        {

            ptbxInformationMedicine.Visible = false;
            SidePanel.Height = btnMedicineEmpty.Height;
            SidePanel.Top = btnMedicineEmpty.Top;
            DataTable data = InformationMedicineDAO.Instance.GetListMedicineEmpty();
            dtgvInformationMedicine.DataSource = data;
            guna2Transition1.HideSync(dtgvInformationMedicine);
            guna2Transition1.ShowSync(dtgvInformationMedicine);
        }

        private void btnSellOut_Click(object sender, EventArgs e)
        {

            ptbxInformationMedicine.Visible = false;
            SidePanel.Height = btnSellOut.Height;
            SidePanel.Top = btnSellOut.Top;
            DataTable data = InformationMedicineDAO.Instance.GetListMedicineSellOut();
            dtgvInformationMedicine.DataSource = data;
            guna2Transition1.HideSync(dtgvInformationMedicine);
            guna2Transition1.ShowSync(dtgvInformationMedicine);
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {

            SidePanel.Height = btnQuayLai.Height;
            SidePanel.Top = btnQuayLai.Top;
            ptbxInformationMedicine.Visible = true;
            guna2Transition1.HideSync(ptbxInformationMedicine);
            guna2Transition1.ShowSync(ptbxInformationMedicine);
        }

    }
}
