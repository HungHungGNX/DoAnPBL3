using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanThuoc.GUI;
namespace QuanLyBanThuoc.GUI
{
    public partial class fCheck : Form
    {
        public SendMessage send;
        public static  string[] arrListStr;
        public fCheck()
        {
            InitializeComponent();
        }
        public fCheck(SendMessage sender)
        {
            InitializeComponent();
            this.send = sender;
        }

        private void fCheck_Load(object sender, EventArgs e)
        {
            picOk.Visible = false;
            dtgvSick.DataSource = fSick.table;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            fTableManager.fcheck = null;
            this.Close();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (fSick.table == null) return;
            fSick.table.Clear();
        }

        private void dtgvSick_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            picOk.Visible = false;
            DataGridViewRow item = dtgvSick.Rows[e.RowIndex];
            try
            {
                txtMedicine.Text = item.Cells["Cure"].Value.ToString();
            }
            catch
            {
                return;
            }
        }

        

        private void btnSell_Click(object sender, EventArgs e)
        {
            if (txtMedicine == null) return;
            string str1 = txtMedicine.Text ;
            string pattern = ",\\s";
            string str2 = ",";
            Regex rgx = new Regex(pattern);
            string result = rgx.Replace(str1, str2);
            arrListStr = result.Split(',');
            picOk.Visible = true;
            this.send(arrListStr);
        }
    }
}
