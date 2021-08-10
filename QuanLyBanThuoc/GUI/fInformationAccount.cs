using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanThuoc.DAL;
using QuanLyBanThuoc.DTO;
using QuanLyBanThuoc.GUI;
namespace QuanLyBanThuoc.GUI
{
    public partial class fInformationAccount : Form
    {
        Account account = null;
        public fInformationAccount(Account acc)
        {
         
            InitializeComponent();   
            account = AccountDAO.Instance.GetAccountByUserName(acc.UserName);
            guna2AnimateWindow1.SetAnimateWindow(this, Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND, Bottom);
            if (account.Type == 0) tabControl.Visible = false;
            LoadData();
        }
       private void LoadData()
        {
            lblUserName.Text = account.UserName.ToString();
            lblName.Text = account.DisplayName;
            lblPassword.Text = account.Password;
            if (account.Type == 0)
            {
                lblType.Text = "STAFF";
            }
            else
            {
                lblType.Text = "ADMIN";
            }
 
            lblValue.Text = MedicineDAO.Instance.GetTotalMoneyStore().ToString()+"đ";
            lblValue.Text= string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", MedicineDAO.Instance.GetTotalMoneyStore())+"đ";
            lblMedicine.Text = GetMedicineTopOfMonth();
            lblValueMonth.Text= string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", GetTotalMoneyOfMonth()) + "đ";
        }

        private string GetMedicineTopOfMonth()
        {
            string medicine=null;
            DateTime aDateTime = DateTime.Now;
            DataSet dataSet = InformationMedicineDAO.Instance.GetListMedicineBestByMonth(aDateTime.Month.ToString(), 
            System.DateTime.DaysInMonth(aDateTime.Year, aDateTime.Month).ToString(), aDateTime.Year.ToString());
            DataTable dataTable = dataSet.Tables[0];
            DataRow dataRow = dataTable.Rows[0];
            medicine = dataRow["Tên Thuốc"].ToString();
            return medicine;
        }
        private double GetTotalMoneyOfMonth()
        {
            DateTime aDateTime = DateTime.Now;
            double total = InformationMedicineDAO.Instance.GetTotalMonth(aDateTime.Month.ToString(), aDateTime.Day.ToString(), aDateTime.Year.ToString());
            return total;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
