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
namespace QuanLyBanThuoc.GUI
{
    public partial class fMain : Form
    {
        Account account = null;
        public fMain(Account acc)
        {
            account = acc;
            InitializeComponent();
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            myFirstCustom1.BringToFront();
        }
        private void fMain_Load(object sender, EventArgs e)
        {
            guna2AnimateWindow1.SetAnimateWindow(Winform.tableManager, Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND, Bottom);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            mySpaceCustom1.BringToFront();
            guna2Transition1.HideSync(myFirstCustom1); 
            myFirstCustom1.BringToFront();
            guna2Transition1.ShowSync(myFirstCustom1);
        }

        private void btnMedicineNew_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnMedicineNew.Height;
            SidePanel.Top = btnMedicineNew.Top;
            mySpaceCustom1.BringToFront();
            guna2Transition1.HideSync(mySecondCustom1);
            mySecondCustom1.BringToFront();
            guna2Transition1.ShowSync(mySecondCustom1);
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            Winform.tableManager = new fTableManager(account);
            this.Hide();
            Winform.tableManager.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDiagram_Click(object sender, EventArgs e)
        {
            if (account.Type == 0) return;
            SidePanel.Height = btnDiagram.Height;
            SidePanel.Top = btnDiagram.Top;
            mySpaceCustom1.BringToFront();
            guna2Transition1.HideSync(myDiagramCircle1);
            myDiagramCircle1.BringToFront();
            guna2Transition1.ShowSync(myDiagramCircle1);
        }

        private void btnTarget_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnTarget.Height;
            SidePanel.Top = btnTarget.Top;
            mySpaceCustom1.BringToFront();
            guna2Transition1.HideSync(myFourCustom1);
            myFourCustom1.BringToFront();
            guna2Transition1.ShowSync(myFourCustom1);
        }

        private void btnPhone_Click(object sender, EventArgs e)
        {

            SidePanel.Height = btnPhone.Height;
            SidePanel.Top = btnPhone.Top;
            mySpaceCustom1.BringToFront();
            guna2Transition1.HideSync(myFiveCustom1);
            myFiveCustom1.BringToFront();
            guna2Transition1.ShowSync(myFiveCustom1);
        }

        private void btnTimeTable_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnTimeTable.Height;
            SidePanel.Top = btnTimeTable.Top;
            mySpaceCustom1.BringToFront();
            guna2Transition1.HideSync(mySixTimeTable1);
            mySixTimeTable1.BringToFront();
            guna2Transition1.ShowSync(mySixTimeTable1);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            fInformationAccount f = new fInformationAccount(account);
            this.Hide();
            f.ShowDialog();
            this.Show();

        }
    }
}
