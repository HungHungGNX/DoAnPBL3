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
using System.Globalization;
using static QuanLyBanThuoc.fAccountProfile;
using QuanLyBanThuoc.GUI;

namespace QuanLyBanThuoc
{
    public delegate void SendMessage(String[] value);
    public partial class fTableManager : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }
        public fTableManager(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            LoadTable();
            LoadCategory();
            LoadComboboxTable(cbSwitchTable);
            guna2AnimateWindow1.SetAnimateWindow(this, Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND, Bottom);

        }
        #region Method
        void ChangeAccount(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1;
            thôngTinTaiKhoanToolStripMenuItem.Text += " (" + LoginAccount.DisplayName + ")";
        }
        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategoty();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";
        }
        void LoadMedicineListByCategoryId(int id)
        {
            List<Medicine> listMedicine = MedicineDAO.Instance.GetMedicineByCategoryId(id);
            cbMedicine.DataSource = listMedicine;
            cbMedicine.DisplayMember = "Name";
        }
        void LoadTable()
        {
            flpTable.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button()
                {
                    Height = TableDAO.TableHeight,
                    Width = TableDAO.TableWidth
                };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += Btn_Click;
                btn.Tag = item;

                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        btn.Image = Image.FromFile("E://Góc Học Tập//Đồ án PBL3//Các Icon//logoyte1.jpg");
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        btn.Image = Image.FromFile("E://Góc Học Tập//Đồ án PBL3//Các Icon//giaodich1.jpg");
                        break;
                }
                flpTable.Controls.Add(btn);
            }
        }
        void ShowBill(int id)
        {
            List<QuanLyBanThuoc.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            lsvBill.Items.Clear();
            float totalPrice = 0;
            foreach (QuanLyBanThuoc.DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvitem = new ListViewItem(item.MedicineName.ToString());
                lsvitem.SubItems.Add(item.Count.ToString());
                lsvitem.SubItems.Add(item.Price.ToString());
                lsvitem.SubItems.Add(item.TotalPrice.ToString());
                lsvitem.SubItems.Add(item.Dosage.ToString());
                totalPrice += item.TotalPrice;
                lsvBill.Items.Add(lsvitem);
            }
            //  CultureInfo culture = new CultureInfo("vi-VN");

            //Thread.CurrentThread.CurrentCulture = culture;
            txbTotalPrice.Text = totalPrice.ToString();
            // LoadTable();
        }
        void Btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).Id;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }
        void LoadComboboxTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
            cb.DisplayMember = "Name";
        }
        #endregion
        #region Event
        private void thôngTinCaNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile(LoginAccount);
            f.UpdateAccount += f_UpdateAccount;
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        void f_UpdateAccount(object sender, AccountEvent e)
        {
            thôngTinTaiKhoanToolStripMenuItem.Text = "Thông tin tài khoản (" + e.Acc.DisplayName + ")";
        }



        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {


            this.Hide();
            Winform.admin.ShowDialog();
            this.Show();
        }

        void f_UpdateMedicine(object sender, EventArgs e)
        {
            LoadMedicineListByCategoryId((cbCategory.SelectedItem as Category).Id);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).Id);
        }

        void f_DeleteMedicine(object sender, EventArgs e)
        {
            LoadMedicineListByCategoryId((cbCategory.SelectedItem as Category).Id);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).Id);
            LoadTable();
        }

        void f_InsertMedicine(object sender, EventArgs e)
        {
            LoadMedicineListByCategoryId((cbCategory.SelectedItem as Category).Id);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).Id);
        }

        private void đăngXuâtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
            {
                return;
            }
            Category selected = cb.SelectedItem as Category;
            id = selected.Id;
            LoadMedicineListByCategoryId(id);
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {


            Table table = lsvBill.Tag as Table;
            if (table == null) { MessageBox.Show("You have not selected table!"); return; }
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.Id);
            int medicineId = (cbMedicine.SelectedItem as Medicine).Id;
            Medicine medicineSelected = MedicineDAO.Instance.GetMedicineById(medicineId);
            int count = (int)nmMedicineCount.Value;
            if (medicineSelected.Quantity == 0 && (int)nmMedicineCount.Value > 0) { MessageBox.Show("Thuốc " + medicineSelected.Name + " đã hết"); return; }
            if (medicineSelected.Quantity < count) { MessageBox.Show("Không đủ thuốc " + medicineSelected.Name + " để bán"); return; }
            if (count == 0) return;
            if (table.Status == "Trống" && count < 0) return;
            if (checkTableContainerMedicine(table.Id, medicineId) == false && count < 0) return;
            if ( count<0 && checkTableContainerMedicineOfListAndCount(table.Id, medicineId,count)==true )
            {
                MessageBox.Show("Không hợp lệ");
                return;
            }
            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.Id);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), medicineId, count);

            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, medicineId, count);
            }
            ShowBill(table.Id);
            LoadTable();


        }
        public void AddMedicineToSick(String[] listMedicine)
        {
            int tableById = 0;
            foreach (string item in listMedicine)
            {
                Table table = lsvBill.Tag as Table;
                if (table == null) { MessageBox.Show("You have not selected table!"); return; }
                tableById = table.Id;
                int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.Id);
                Medicine medicineSelected = MedicineDAO.Instance.GetMedicineByName(item);
                if (medicineSelected == null) { MessageBox.Show("Thuốc " + item + " chưa có trong shop"); continue; }
                int medicineId = medicineSelected.Id;
                int count = 1;
                if (medicineSelected.Quantity == 0) { MessageBox.Show("Thuốc " + medicineSelected.Name + " đã hết"); continue; }

                if (idBill == -1)
                {
                    BillDAO.Instance.InsertBill(table.Id);
                    BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), medicineId, count);
                }
                else
                {
                    BillInfoDAO.Instance.InsertBillInfo(idBill, medicineId, count);
                }

            }
            ShowBill(tableById);
            LoadTable();
        }
        private bool checkTableContainerMedicine(int idTable,int idMedicine)
        {
            List<int> list = TableDAO.Instance.checkTableContainerMedicineOfList(idTable);
            if (list.Contains(idMedicine)) return true;
            else return false;
        }
        private bool checkTableContainerMedicineOfListAndCount(int idTable,int IdMedicine,int count)
        {
            int countMedicine = 0;
            Dictionary<int,int> MyHash = TableDAO.Instance.checkTableContainerMedicineOfListAndCount(idTable);
          foreach(KeyValuePair<int,int> item in MyHash){
                if(item.Key==IdMedicine){ countMedicine = item.Value;
                    break;
                }
            }
            if (countMedicine < Math.Abs( count)) return true;
            return false;
        }

        double finalTotalPriceforLeftover = 0;
        private void btnCheckOut_Click(object sender, EventArgs e)
        {



            Table table = lsvBill.Tag as Table;
            if (table == null) return;
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.Id);
            int discount = (int)nmDiscount.Value;
            double totalPrice = Convert.ToDouble(txbTotalPrice.Text);
            double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;
            finalTotalPriceforLeftover = finalTotalPrice;
            if (idBill != -1)
            {
                if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho bàn {0}\nTổng tiền - (Tổng tiền / 100) x Giảm giá\n=> {1} - ({1} / 100) x {2} = {3}", table.Name, totalPrice, discount, finalTotalPrice), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill, discount, (float)finalTotalPrice);
                    ShowBill(table.Id);
                    LoadTable();
                    btnCaculateLeftOver.PerformClick();
                }
            }

            
        }
        private void btnSwitchTable_Click(object sender, EventArgs e)
        {

            int id1 = (lsvBill.Tag as Table).Id;

            int id2 = (cbSwitchTable.SelectedItem as Table).Id;
            if (MessageBox.Show(string.Format("Bạn có thật sự muốn chuyển bàn {0} qua bàn {1}", (lsvBill.Tag as Table).Name, (cbSwitchTable.SelectedItem as Table).Name), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                TableDAO.Instance.SwitchTable(id1, id2);

                LoadTable();
            }
        }
        private void informationMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fInformationMedicine f = new fInformationMedicine();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void btnCaculateLeftOver_Click(object sender, EventArgs e)
        {
            fCalculateLeftover f = new fCalculateLeftover(finalTotalPriceforLeftover);
            f.ShowDialog();
        }
        private void invoiceDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            fInvoiceDeatils f = new fInvoiceDeatils();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void fTableManager_Load(object sender, EventArgs e)
        {
            Winform.admin = new fAdmin();
            Winform.admin.loginAccount = LoginAccount;
            Winform.admin.InsertMedicine += f_InsertMedicine;
            Winform.admin.DeleteMedicine += f_DeleteMedicine;
            Winform.admin.UpdateMedicine += f_UpdateMedicine;

        }

        public static Medicine medicineSearch = null;
        private void btnHelp_Click(object sender, EventArgs e)
        {
            fSearchMedicine f = new fSearchMedicine();
            Winform.tableManager.Hide();
            f.ShowDialog();
            Winform.tableManager.Show();
            if (medicineSearch == null) return;
            int id = medicineSearch.IdCategory;
            Category category = CategoryDAO.Instance.GetCategoryByID(id);
            for (int i = 0; i < cbCategory.Items.Count; i++)
            {
                cbCategory.SelectedIndex = i;
                Category temp = cbCategory.SelectedItem as Category;
                if (temp.Id == category.Id)
                {
                    break;
                }
            }
            for (int i = 0; i < cbMedicine.Items.Count; i++)
            {
                cbMedicine.SelectedIndex = i;
                Medicine temp = cbMedicine.SelectedItem as Medicine;
                if (temp.Name.Equals(medicineSearch.Name) == true)
                {
                    break;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            int idTable = table.Id;
            BillDAO.Instance.DeleteBillByTableIdStatus(idTable);
            TableDAO.Instance.UpdateTable(table.Name, "Trống", table.Id);
            LoadTable();
            ShowBill(idTable);
        }
        public static fCheck fcheck = null;
        private void btnSale_Click(object sender, EventArgs e)
        {
            if (fcheck == null)
            {
                fcheck = new fCheck(AddMedicineToSick);
                fcheck.Show();
            }
            else
            {
                return;
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion

        private void btnDiscount_Click(object sender, EventArgs e)
        {

        }
    }
}
