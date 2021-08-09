using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanThuoc.GUI
{
    public partial class MySecondCustom : UserControl
    {
        public MySecondCustom()
        {
            InitializeComponent();
        }

        private void guna2PictureBox7_Click(object sender, EventArgs e)
        {
            guna2Transition1.HideSync(guna2PictureBox_p);
            guna2PictureBox_p.Image = ((Guna2PictureBox)sender).Image;
            guna2Transition1.ShowSync(guna2PictureBox_p);
        }
    }
}
