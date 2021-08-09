using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanThuoc.DAL;
using QuanLyBanThuoc.DTO;
using QuanLyBanThuoc.GUI;

namespace QuanLyBanThuoc
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;
            if (Login(userName,passWord)) {
                this.Hide();
                Winform.main.ShowDialog();
                this.txbUserName.Text = "";
                this.txbPassWord.Text = "";
                this.txbUserName.Focus();
            }
            else
            {
                MessageBox.Show("Your username or password may be incorrect","Fail");
            }
        }
        bool Login(string userName,string passWord)
        {
            return AccountDAO.Instance.Login(userName,passWord);
        }


        private void fLogin_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
      
        }

        private void txbPassWord_MouseClick(object sender, MouseEventArgs e)
        {
            if (txbUserName.Text == "") return;
            Account loginAccount = AccountDAO.Instance.GetAccountByUserName(txbUserName.Text);
            if (loginAccount == null)
            {
                MessageBox.Show("Account is non-existent");
                return;
            }
            else { 
            Winform.main = new fMain(loginAccount);}
        }
    }
}
