using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyBanThuoc.DTO;

namespace QuanLyBanThuoc.DAL
{
    class InformationMedicineDAO
    {
        private static InformationMedicineDAO instance;

        public static InformationMedicineDAO Instance
        {
            get
            {
                if (instance == null) instance = new InformationMedicineDAO();
                return InformationMedicineDAO.instance;
            }
            private set
            {
                InformationMedicineDAO.instance = value;
            }
        }
        private InformationMedicineDAO() { }
        public DataTable GetListMedicineBest()
        {
            string s = "SELECT IdMedicine as 'Mã Thuốc',m.Name as 'Tên Thuốc',COUNT(b.Id) as 'Số Lượng Hóa Đơn' FROM dbo.BillInfo as b,dbo.Medicine as m Where b.IdMedicine = m.Id GROUP BY IdMedicine,Name Order by[Số Lượng Hóa Đơn] DESC";
            DataTable ds = DataProvider.Instance.ExcuteQuery(s);
            return ds;
        }
        public DataTable GetListMedicineBestByMonth(string month, string dayOfMonth, string year)
        {
            if (Convert.ToInt32(month) <= 9) month = "0" + month;
            string s =String.Format("SELECT IdMedicine as 'Mã Thuốc',m.Name as 'Tên Thuốc',COUNT(b.Id) as 'Số Lượng Hóa Đơn' FROM dbo.BillInfo as b,dbo.Medicine as m,dbo.Bill as bi Where bi.Id = b.IdBill AND b.IdMedicine = m.Id AND DateCheckIn >= '{0}{1}{2}' AND DateCheckIn <= '{3}{4}{5}' GROUP BY IdMedicine,Name Order by[Số Lượng Hóa Đơn] DESC", year, month, "01", year, month, dayOfMonth);
            DataTable ds = DataProvider.Instance.ExcuteQuery(s);
            return ds;
        }
        public DataTable GetListMedicineEmpty()
        {
            string s = "SELECT Id as 'Mã Thuốc',Name as 'Tên Thuốc',Quantity as 'Số Lượng' FROM dbo.Medicine Where Quantity=0;";
            DataTable ds = DataProvider.Instance.ExcuteQuery(s);
            return ds;
        }
        public DataTable GetListMedicineSellOut()
        {
            string s = "SELECT Id as 'Mã Thuốc',Name as 'Tên Thuốc',Quantity as 'Số Lượng' FROM dbo.Medicine Where Quantity>0 AND Quantity<5 ;";
            DataTable ds = DataProvider.Instance.ExcuteQuery(s);
            return ds;
        }
        public DataTable GetListInvoiceDetails()
        {
            string s = "select dbo.Bill.Id as 'IDBill',dbo.Medicine.Name as 'NameMedicine',dbo.BillInfo.count as'Quantity',dbo.Medicine.Price,dbo.Medicine.Price * dbo.BillInfo.count as 'TotalMoney',dbo.Bill.DateCheckIn from dbo.Bill,dbo.BillInfo,dbo.Medicine Where dbo.Bill.Id = dbo.BillInfo.IdBill AND dbo.BillInfo.IdMedicine = dbo.Medicine.Id Order by dbo.Bill.Id";
            DataTable ds = DataProvider.Instance.ExcuteQuery(s);
            return ds;
        }
        public DataTable GetListAllMedicine()
        {
            string s = "select * from dbo.Medicine";
            DataTable ds = DataProvider.Instance.ExcuteQuery(s);
            return ds;
        }
        public double GetTotalMonth(string month, string dayOfMonth, string year)
        {
            if (Convert.ToInt32(month) <= 9) month = "0" + month;
            string s = string.Format("select Sum(TotalPrice) from dbo.Bill where DateCheckIn >= '{0}{1}{2}' AND DateCheckIn <= '{3}{4}{5}'", year, month, "01", year, month, dayOfMonth);
            double n = 0;
            try
            {
                object ob = DataProvider.Instance.ExcuteScalar(s);
                n = Convert.ToDouble(ob);
                return n;
            }
            catch
            {
                return n = 0;
            }
        }
        public DataTable GetListSick()
        {
              string s = "select Id,Namesick,Signal from dbo.Sick";
              DataTable ds= DataProvider.Instance.ExcuteQuery(s);
               return ds;
        }
        public Sick GetSickById(int id)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("Select * from dbo.Sick where Id = " + id);
            foreach (DataRow item in data.Rows)
            {
                return new Sick(item);
            }

            return null;
        }
        public bool UpdateSick(int id, string name, string signal, string cure)
        {
            string query = string.Format("UPDATE dbo.Sick SET NameSick = N'{0}', Signal= N'{1}', Cure = N'{2}' WHERE Id = {3}", name, signal, cure, id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteSick(int id)
        {
            string query = string.Format("Delete dbo.Sick where id = {0}", id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
        public bool InsertSick( string name, string signal, string cure)
        {
            string query = string.Format("INSERT dbo.Sick ( NameSick, Signal, Cure )VALUES  ( N'{0}',N'{1}',N'{2}')", name, signal, cure);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
    }
}
