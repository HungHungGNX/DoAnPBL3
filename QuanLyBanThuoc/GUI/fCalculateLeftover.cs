using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanThuoc.GUI;
using QuanLyBanThuoc.DAL;
namespace QuanLyBanThuoc.GUI
{
    public partial class fCalculateLeftover : Form
    {
        double finalTotalPrice = 0;

        public fCalculateLeftover(double discount, double totalPrice, double finalTotalPrice, int idBill,string nameTable,string displayName)
        {
            InitializeComponent();
            LoadData(discount,totalPrice,finalTotalPrice,idBill,nameTable,displayName);
        
        }
        public void LoadData(double discount, double totalPrice, double finalTotalPrice, int idBill,string nameTable,string disPlayName)
        {
             this.finalTotalPrice = finalTotalPrice;
            lblMoney.Text = finalTotalPrice.ToString();
            lblDiscount.Text = discount.ToString()+"%";
            lblMoneyBeforeDiscount.Text = totalPrice.ToString();
            lblIdBill.Text = idBill.ToString();
            lblTable.Text = nameTable;
            lblStaff.Text = disPlayName;
            lblDate.Text = BillDAO.Instance.getDateCheckOutByIdBill(idBill);
            dtgvBillInfo.DataSource = BillInfoDAO.Instance.GetBillInfoByIdBill(idBill);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (txbMoneyEnter.Text =="") return;
            double temp = 0;
            try { 
             temp = Convert.ToDouble(txbMoneyEnter.Text);}
            catch
            {
                MessageBox.Show("Số liệu nhập vào không đúng");
            }
       
            lblResult.Text =(temp - finalTotalPrice).ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fCalculateLeftover_Load(object sender, EventArgs e)
        {
            guna2AnimateWindow1.SetAnimateWindow(this, Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND, Bottom);
        }
    }
}
