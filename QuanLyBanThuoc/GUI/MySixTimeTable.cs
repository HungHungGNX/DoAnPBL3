using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanThuoc.GUI
{
    public partial class MySixTimeTable : UserControl
    {
        public MySixTimeTable()
        {
            InitializeComponent();
        }

        private void MySixTimeTable_Load(object sender, EventArgs e)
        {
            if (File.Exists($"{ Application.StartupPath}/data1.dat"))
                datatabletime.ReadXml($"{Application.StartupPath}/data1.dat");
        }

        private void txbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                timeTableBindingSource.Filter = $"Name like '*{txbSearch.Text}*' or Date='{txbSearch.Text}'";
            if (e.KeyChar == (char)13)
                timeTableBindingSource.Filter = $"Date like '*{txbSearch.Text}*' or Name='{txbSearch.Text}'";
        }

        private void timeTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            timeTableBindingSource.EndEdit();
            datatabletime.WriteXml($"{ Application.StartupPath}/data1.dat");
            MessageBox.Show("Your data has been successfully saved. ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
