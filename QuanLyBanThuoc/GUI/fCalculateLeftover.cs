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
namespace QuanLyBanThuoc.GUI
{
    public partial class fCalculateLeftover : Form
    {
        double finalTotalPrice = 0;

        public fCalculateLeftover(double money)
        {
            InitializeComponent();
            finalTotalPrice = money;
            lblMoney.Text = money.ToString();
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
            double result = temp - finalTotalPrice;
            txbResult.Text = result.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fCalculateLeftover_Load(object sender, EventArgs e)
        {
            guna2AnimateWindow1.SetAnimateWindow(this, Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_CENTER);
        }
    }
}
