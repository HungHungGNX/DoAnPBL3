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
    public partial class MyFiveCustom : UserControl
    {
        public MyFiveCustom()
        {
            InitializeComponent();
        }

        private void txbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
              phoneBooksBindingSource.Filter = $"Name like '*{txbSearch.Text}*' or Mobile='{txbSearch.Text}'";
            if (e.KeyChar == (char)13)
             phoneBooksBindingSource.Filter = $"Mobile like '*{txbSearch.Text}*' or Name='{txbSearch.Text}'";
        }

        private void MyFiveCustom_Load(object sender, EventArgs e)
        {
            if (File.Exists($"{ Application.StartupPath}/data.dat"))
                database.ReadXml($"{Application.StartupPath}/data.dat");
        }

        private void phoneBooksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            phoneBooksBindingSource.EndEdit();
            database.WriteXml($"{ Application.StartupPath}/data.dat");
            MessageBox.Show("Your data has been successfully saved. ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
