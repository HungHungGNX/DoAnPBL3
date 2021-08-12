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
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using QuanLyBanThuoc.GUI;

namespace QuanLyBanThuoc
{
    public partial class fAdmin : Form
    {
        BindingSource medicineList = new BindingSource();
        BindingSource categoryList = new BindingSource();
        BindingSource tableList = new BindingSource();
        BindingSource accountList = new BindingSource();
        public Account loginAccount;
        public fAdmin()
        {
            InitializeComponent();
            LoadData();

        }


        #region methods
        List<Medicine> SearchMedicineByName(string name)
        {
            List<Medicine> listFood = MedicineDAO.Instance.SearchMedicineByName(name);

            return listFood;
        }
        void MessageBoxOfMe(string Text)
        {
            MyMessageBox.ShowMessage(Text, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void LoadData()
        {
            dtgvMedicine.DataSource = medicineList;
            dtgvCategory.DataSource = categoryList;
            dtgvTable.DataSource = tableList;
            dtgvAccount.DataSource = accountList;
            LoadDateTimePickerBill();
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            LoadListMedicine();
            LoadListAccount();
            AddAccountBinding();
            LoadCategoryIntoCombobox(cbMedicineCategory);
            AddMedicineBinding();
            LoadListCategory();
            AddCategoryBinding();
            LoadListTable();
            AddTableBinding();
            LoadListTable();
            LoadStatusIntoCombobox(cbTableStatus);
        }
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
           dtgvBill.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
        }
        void LoadListMedicine()
        {
            medicineList.DataSource = MedicineDAO.Instance.GetListMedicine();
        }
        void LoadListCategory()
        {
            categoryList.DataSource = CategoryDAO.Instance.GetListCategoty();
        }
        void LoadListTable()
        {
            tableList.DataSource = TableDAO.Instance.LoadTableList();
        }
        void LoadListAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }
        void AddMedicineBinding()
        {
            txbMedicineName.DataBindings.Add(new Binding("Text", dtgvMedicine.DataSource, "Name",true,DataSourceUpdateMode.Never));
            txbMedicineID.DataBindings.Add(new Binding("Text", dtgvMedicine.DataSource, "ID", true, DataSourceUpdateMode.Never));
            nmMedicinePrice.DataBindings.Add(new Binding("Value", dtgvMedicine.DataSource, "Price", true, DataSourceUpdateMode.Never));
            txbMedicineDosage.DataBindings.Add(new Binding("Text", dtgvMedicine.DataSource, "Dosage", true, DataSourceUpdateMode.Never));
            txbMedicineQuantity.DataBindings.Add(new Binding("Text", dtgvMedicine.DataSource, "Quantity", true, DataSourceUpdateMode.Never));
        }
        void AddCategoryBinding()
        {
            txbCategoryName.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txbCategoryId.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "ID", true, DataSourceUpdateMode.Never));
        }
        void AddTableBinding()
        {
            txbTableName.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txbTableId.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "ID", true, DataSourceUpdateMode.Never));
          
        }
        void AddAccountBinding()
        {
            txbUserName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txbDisplayName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            nmAccountType.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }
        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategoty();
            cb.DisplayMember = "Name";
        }
        void LoadStatusIntoCombobox(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
            cb.DisplayMember = "Status";
        }
        void AddAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.InsertAccount(userName, displayName, type))
            {
                MessageBoxOfMe("Thêm tài khoản thành công");
            }
            else
            {
                MessageBoxOfMe("Thêm tài khoản thất bại");
            }

            LoadListAccount();
        }

        void EditAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.UpdateAccount(userName, displayName, type))
            {
                MessageBoxOfMe("Cập nhật tài khoản thành công");
            }
            else
            {
                MessageBoxOfMe("Cập nhật tài khoản thất bại");
            }

            LoadListAccount();
        }

        void DeleteAccount(string userName)
        {
            if (loginAccount.UserName.Equals(userName))
            {
                MessageBoxOfMe("Vui lòng đừng xóa chính bạn chứ");
                return;
            }
            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBoxOfMe("Xóa tài khoản thành công");
            }
            else
            {
                MessageBoxOfMe("Xóa tài khoản thất bại");
            }

            LoadListAccount();
        }

        void ResetPass(string userName)
        {
            if (AccountDAO.Instance.ResetPassword(userName))
            {
                MessageBoxOfMe("Đặt lại mật khẩu thành công");
            }
            else
            {
                MessageBoxOfMe("Đặt lại mật khẩu thất bại");
            }
        }
        #endregion

        #region Event
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }
         private void btnShowMedicine_Click(object sender, EventArgs e)
        {
            LoadListMedicine();
        }
        private void txbMedicineID_TextChanged(object sender, EventArgs e)
        {
            try { 
            if (dtgvMedicine.SelectedCells.Count > 0)
            {
                int id = (int)dtgvMedicine.SelectedCells[0].OwningRow.Cells["IdCategory"].Value;

                Category cateogory = CategoryDAO.Instance.GetCategoryByID(id);

                cbMedicineCategory.SelectedItem = cateogory;

                int index = -1;
                int i = 0;
                foreach (Category item in cbMedicineCategory.Items)
                {
                    if (item.Id == cateogory.Id)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }

                cbMedicineCategory.SelectedIndex = index;
                }
            }
            catch { }
            
        }
        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            string name = txbMedicineName.Text;
            int categoryID = (cbMedicineCategory.SelectedItem as Category).Id;
            float price = (float)nmMedicinePrice.Value;
            int quantity = Convert.ToInt32(txbMedicineQuantity.Text);
            string dosage = txbMedicineDosage.Text;

            if (MedicineDAO.Instance.InsertMedicine(name, categoryID, price,quantity,dosage))
            {
                MessageBox.Show("Thêm thuốc thành công");
                LoadListMedicine();
                if(insertMedicine != null)
                    insertMedicine(this, new EventArgs());
            }
            else
            {
                MessageBoxOfMe("Có lỗi khi thêm thuốc");
            }

        }

         private void btnEditMedicine_Click(object sender, EventArgs e)
        {
            string name = txbMedicineName.Text;
            int categoryID = (cbMedicineCategory.SelectedItem as Category).Id;
            float price = (float)nmMedicinePrice.Value;
            int id = Convert.ToInt32(txbMedicineID.Text);
            int quantity = Convert.ToInt32(txbMedicineQuantity.Text);
            string dosage = txbMedicineDosage.Text;
            if (MedicineDAO.Instance.UpdateMedicine(id, name, categoryID, price,quantity,dosage))
            {
                MessageBoxOfMe("Sửa thuốc thành công");
                LoadListMedicine();
              if (updateMedicine != null)
                    updateMedicine(this, new EventArgs());
            }
            else
            {
                MessageBoxOfMe("Có lỗi khi sửa thuốc");
            }
        }
        private void btnDeleteMedicine_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbMedicineID.Text);

            if (MedicineDAO.Instance.DeleteMedicine(id))
            {
                MessageBoxOfMe("Xóa thuốc thành công");
                LoadListMedicine();
                 if (deleteMedicine != null)
                     deleteMedicine(this, new EventArgs());
            }
            else
            {
                MessageBoxOfMe("Có lỗi khi xóa thuốc");
            }
        }
        private event EventHandler insertMedicine;
        public event EventHandler InsertMedicine
        {
            add { insertMedicine += value; }
            remove { insertMedicine -= value; }
        }

        private event EventHandler deleteMedicine;
        public event EventHandler DeleteMedicine
        {
            add { deleteMedicine += value; }
            remove { deleteMedicine -= value; }
        }

        private event EventHandler updateMedicine;
        public event EventHandler UpdateMedicine
        {
            add { updateMedicine += value; }
            remove { updateMedicine -= value; }
        }
        private void btnShowCategory_Click(object sender, EventArgs e)
        {
            LoadListCategory();
        }
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string name = txbCategoryName.Text;
            if (CategoryDAO.Instance.InsertCategory(name))
            {
                MessageBoxOfMe("Thêm category thành công");
                LoadListCategory();
                LoadListMedicine();
                LoadCategoryIntoCombobox(cbMedicineCategory);
            }
            else
            {
                MessageBoxOfMe("Có lỗi khi thêm category");
            }
        }
        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            string name = txbCategoryName.Text;
            int id = Convert.ToInt32(txbCategoryId.Text);
           
            if (CategoryDAO.Instance.UpdateCategory(id, name))
            {
                MessageBoxOfMe("Sửa category thành công");
                LoadListCategory();
                LoadListMedicine();
                LoadCategoryIntoCombobox(cbMedicineCategory);
            }
            else
            {
                MessageBoxOfMe("Có lỗi khi sửa category");
            }
        }
        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbCategoryId.Text);

            if (CategoryDAO.Instance.DeleteCategory(id))
            {
                MessageBoxOfMe("Xóa category thành công");
                LoadListCategory();
                LoadListMedicine();
                LoadCategoryIntoCombobox(cbMedicineCategory);
            }
            else
            {
                MessageBoxOfMe("Có lỗi xóa category");
            }
        }
        private void btnShowTable_Click(object sender, EventArgs e)
        {
            LoadListTable();
        }
        private void btnAddTable_Click(object sender, EventArgs e)
        {
            string name = txbTableName.Text;
            string status = "Trống";
            if (TableDAO.Instance.InsertTable(name,status))
            {
                MessageBoxOfMe("Thêm Table thành công khi đăng nhập lần sau table sẽ hiện ở Menu");
                LoadListTable();
            }
            else
            {
                MessageBoxOfMe("Có lỗi khi thêm Table");
            }
        }

        private void btnEditTable_Click(object sender, EventArgs e)
        {
            string name = txbTableName.Text;
            string status = cbTableStatus.SelectedItem.ToString();
            int id = Convert.ToInt32(txbTableId.Text);

            if (TableDAO.Instance.UpdateTable(name,status,id))
            {
                MessageBoxOfMe("Sửa Table thành công khi đăng nhập lần \n sau table bị sửa sẽ hiện ở menu");
                LoadListTable();
            }
            else
            {
                MessageBoxOfMe("Có lỗi khi sửa Table");
            }
        }
        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbTableId.Text);

            if (TableDAO.Instance.DeleteTable(id))
            {
                MessageBoxOfMe("Xóa Table thành công");
                LoadListTable();
            }
            else
            {
                MessageBoxOfMe("Có lỗi xóa table");
            }
        }
         private void btnSeaarchMedicine_Click(object sender, EventArgs e)
        {
           medicineList.DataSource = SearchMedicineByName(txbSearchMedicineName.Text);        
         }
        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            LoadListAccount();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string displayName = txbDisplayName.Text;
            int type = (int)nmAccountType.Value;

            AddAccount(userName, displayName, type);
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;

            DeleteAccount(userName);
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string displayName = txbDisplayName.Text;
            int type = (int)nmAccountType.Value;

            EditAccount(userName, displayName, type);
        }
        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;

            ResetPass(userName);
        }

        private void fAdmin_Load(object sender, EventArgs e)
        {
            DataTable ds= BillDAO.Instance.GetBillListByDateForReport();
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyBanThuoc.ReportHoaDon.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = ds;
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
            guna2AnimateWindow1.SetAnimateWindow(this, Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_CENTER, Bottom);
            btnThongKe.PerformClick();
            btnShowMedicine.PerformClick();
            btnShowTable.PerformClick();
            btnShowAccount.PerformClick();
            btnShowCategory.PerformClick();
        }

        #endregion

    }
}
