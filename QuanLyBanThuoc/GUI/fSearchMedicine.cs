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
using QuanLyBanThuoc.DTO;
namespace QuanLyBanThuoc.GUI
{
    public partial class fSearchMedicine : Form
    {
        Medicine temp = null;
        public fSearchMedicine()
        {
            InitializeComponent();
            LoadData();
            guna2AnimateWindow1.SetAnimateWindow(this, Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_SLIDE, Bottom);
        }
        DataTable dt = new DataTable();
        void LoadData()
        {
            DataTable data = InformationMedicineDAO.Instance.GetListAllMedicine();
            dtgvMedicine.DataSource = data;
            dt = data;
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("Name like '%{0}%'",txtSearch.Text);
                dtgvMedicine.DataSource = dv.ToTable();
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            fTableManager.medicineSearch = temp;
            this.Close();
        }

        private void dtgvMedicine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow item = dtgvMedicine.Rows[e.RowIndex];
            lblNameMedicine.Text = item.Cells["Name"].Value.ToString();
            int id =int.Parse(item.Cells["Id"].Value.ToString());
             temp = MedicineDAO.Instance.GetMedicineById(id);
        }
    }
}
