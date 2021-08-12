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
    public partial class fSick : Form
    {
        DataTable dt = new DataTable();
        public static DataTable table = null;
        private static int idSick;
      
        public fSick()
        {
            InitializeComponent();
            loaDtgvDick();
            idSick = 1;
            
       
        }
        private void loaDtgvDick()
        {
            DataTable data = InformationMedicineDAO.Instance.GetListSick();
            dtgvSick.DataSource = data;
            dtgvSick.Columns["Signal"].Visible = false;
            dtgvSick.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvSick.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void dtgvSick_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Sick temp = null;
            int id;
            DataGridViewRow item = dtgvSick.Rows[e.RowIndex];
            try
            {
                 id = int.Parse(item.Cells["Id"].Value.ToString());
                idSick = id;
            }
            catch 
            {

                return;
            }

            temp = InformationMedicineDAO.Instance.GetSickById(id);
            txtCure.Text = temp.Cure;
            txtSignsOfIllness.Text = temp.Signal;
            txtNameSign.Text = temp.NameSick;
            this.picOk.Visible = false;

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("NameSick like '%{0}%'", txtSearch.Text);
                dtgvSick.DataSource = dv.ToTable();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fSick_Load(object sender, EventArgs e)
        {
            guna2AnimateWindow1.SetAnimateWindow(this, Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_CENTER, Bottom);
             Sick temp = InformationMedicineDAO.Instance.GetSickById(1);
            txtCure.Text = temp.Cure;
            txtSignsOfIllness.Text = temp.Signal;
            txtNameSign.Text = temp.NameSick;
            this.picOk.Visible = false;

        }

        private void btnClearSick_Click(object sender, EventArgs e)
        {
            txtCure.Text = "";
            txtSignsOfIllness.Text = "";
            txtNameSign.Text = "";
            txtNameSign.Focus();
            this.picOk.Visible = false;
        }

        private void txtSerchBySigns_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("Signal like '%{0}%'", txtSearchBySigns.Text);
                dtgvSick.DataSource = dv.ToTable();
            }
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            if (table == null)
            {
                table = new DataTable();
                table.Columns.Add("NameSick", typeof(string));
                table.Columns.Add("Cure", typeof(string));
            }
            if (txtNameSign.Text != "")
            {
                table.Rows.Add(txtNameSign.Text, txtCure.Text);
                this.picOk.Visible = true;
            }
        }

        private void btnEditSick_Click(object sender, EventArgs e)
        {
            int id = idSick;
            string name = txtNameSign.Text;
            string signal = txtSignsOfIllness.Text;
            string cure = txtCure.Text;
            if (InformationMedicineDAO.Instance.UpdateSick(id, name, signal, cure))
            {
                MessageBox.Show("Update Success");
                loaDtgvDick();

            }
            else
            {
                MessageBox.Show("Update Fail");
            }
        }

        private void btnDeleteSick_Click(object sender, EventArgs e)
        {
            int id = idSick;
            if (InformationMedicineDAO.Instance.DeleteSick(id))
            {
                MessageBox.Show("Delete Success");
                loaDtgvDick();

            }
            else
            {
                MessageBox.Show("Delete Fail");
            }
        }

        private void btnAddSick_Click(object sender, EventArgs e)
        {
            string name = txtNameSign.Text;
            string signal = txtSignsOfIllness.Text;
            string cure = txtCure.Text;
            if (InformationMedicineDAO.Instance.InsertSick( name, signal, cure))
            {
                MessageBox.Show("Insert Success");
                loaDtgvDick();

            }
            else
            {
                MessageBox.Show("Insert Fail");
            }
        }
    }
}
