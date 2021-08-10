using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyBanThuoc.DTO;
namespace QuanLyBanThuoc.DAL
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get
            {
                if (instance == null) instance = new BillInfoDAO();
                return BillInfoDAO.instance;
            }
            private set
            {
                BillInfoDAO.instance = value;
            }
        }
        private BillInfoDAO() { }

        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();
            DataTable data = DataProvider.Instance.ExcuteQuery("Select * From dbo.BillInfo where IdBill =" + id);
            foreach (DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }
            return listBillInfo;
        }
        public void InsertBillInfo(int idBill, int idMedicine, int count)
        {
            DataProvider.Instance.ExcuteNonQuery("EXEC USP_InsertBillInfo @idBill , @idMedicine , @count", new object[] { idBill, idMedicine, count });
        }
        public void DeleteBillInfoByMedicineId(int id)
        {
            DataProvider.Instance.ExcuteNonQuery("Delete from dbo.BillInfo Where IdMedicine=" + id);
        }
        public DataTable GetBillInfoByIdBill(int IdBill)
        {
            string query = string.Format("select me.Name as Name, me.price as Price,bi.Count as Quantity,me.price*bi.Count as Total from "+
                "dbo.BillInfo as bi , dbo.Medicine as me where bi.IdBill = {0} AND bi.IdMedicine=me.Id", IdBill);
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            return data;
        }

    }

}

