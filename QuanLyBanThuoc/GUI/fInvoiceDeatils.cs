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
    public partial class fInvoiceDeatils : Form
    {
        DataTable dt = new DataTable();
        public fInvoiceDeatils()
        {
            InitializeComponent();
            
        }
        private void fInvoiceDeatils_Load(object sender, EventArgs e)
        {
            guna2AnimateWindow1.SetAnimateWindow(this, Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_CENTER, Bottom);
            loadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DataTable data = InformationMedicineDAO.Instance.GetListInvoiceDetails();
            dtgvInvoiceDetails.DataSource = data;
        }
        private void loadData()
        {
            DataTable data = InformationMedicineDAO.Instance.GetListInvoiceDetails();
            dtgvInvoiceDetails.DataSource = data;
            dt = data;
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("convert(DateCheckOut, 'System.String') like '%{0}%'", txtSearch.Text);
                dtgvInvoiceDetails.DataSource = dv.ToTable();
            }
        }
    }
}
