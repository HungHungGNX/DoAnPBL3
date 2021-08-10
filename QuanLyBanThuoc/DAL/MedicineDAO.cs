using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanThuoc.DTO;
using System.Data;
namespace QuanLyBanThuoc.DAL
{
    public class MedicineDAO
    {
        private static MedicineDAO instance;

        public static MedicineDAO Instance {
            get
            {
                if (instance == null) instance = new MedicineDAO();
                return MedicineDAO.instance;
            }
            private set
            {
                MedicineDAO.instance = value;
            }
        }
        private MedicineDAO() { }
        public List<Medicine> GetMedicineByCategoryId(int id)
        {
            List<Medicine> list = new List<Medicine>();
            string query = "Select *from dbo.Medicine where IdCategory ="+id;
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                Medicine medicine = new Medicine(item);
                list.Add(medicine);
            }
            return list;
        }
        public Medicine GetMedicineById(int id)
        {
            List<Medicine> list = new List<Medicine>();
            string query = "Select * from dbo.Medicine where Id =" + id;
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Medicine medicine = new Medicine(item);
                list.Add(medicine);
            }
            Medicine medicine1 = list[0];
            return medicine1;
        }
        public Medicine GetMedicineByName(string name)
        {
        
           
            DataTable data = DataProvider.Instance.ExcuteQuery("Select * from dbo.Medicine where Name =" +"'"+ name + "'");
            foreach (DataRow item in data.Rows)
            {
                return new Medicine(item);
            }

            return null;
        }
        public List<Medicine> GetListMedicine()
        {
            List<Medicine> list = new List<Medicine>();

            string query = "select * from Medicine";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Medicine medicine = new Medicine(item);
                list.Add(medicine);
            }

            return list;
        }
        public bool InsertMedicine(string name, int id, float price,int quantity,string dosage)
        {
            string query = string.Format("INSERT dbo.Medicine ( Name, IdCategory, Price, Quantity, Dosage )VALUES  ( N'{0}', {1}, {2},{3},N'{4}')", name, id, price,quantity,dosage);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateMedicine(int idMedicine, string name, int id, float price, int quantity, string dosage)
        {
            string query = string.Format("UPDATE dbo.Medicine SET Name = N'{0}', IdCategory = {1}, Price = {2} , Quantity={3} , Dosage=N'{4}' WHERE Id = {5}", name, id, price,quantity,dosage, idMedicine);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateMedicineQuantityByIdMedicine(int idMedicine,int count)
        {
            string query = string.Format("UPDATE dbo.Medicine SET Quantity=Quantity+{0} WHERE Id = {1}", count,idMedicine);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteMedicine(int idMedicine)
        {


            BillInfoDAO.Instance.DeleteBillInfoByMedicineId(idMedicine);

            string query = string.Format("Delete Medicine where id = {0}", idMedicine);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
        public void DeleteMedicineByCategoryId(int id)
        {
            DataProvider.Instance.ExcuteNonQuery("delete from dbo.BillInfo where IdMedicine in (Select Id from dbo.Medicine Where Idcategory ="+id+")");
            DataProvider.Instance.ExcuteNonQuery("Delete from dbo.Medicine Where IdCategory=" + id);
        }
        public List<Medicine> SearchMedicineByName(string name)
        {
            List<Medicine> list = new List<Medicine>();

            string query = string.Format("SELECT * FROM dbo.Medicine WHERE dbo.fuConvertToUnsign1(name) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Medicine medicine = new Medicine(item);
                list.Add(medicine);
            }

            return list;
        }
        public double GetTotalMoneyStore()
        {
            double money = 0;
            string query = string.Format("select Sum(Price*Quantity) from dbo.Medicine ");
            object ob = DataProvider.Instance.ExcuteScalar(query);
            money = Convert.ToDouble(ob);
           return money;
        }
    }
}
