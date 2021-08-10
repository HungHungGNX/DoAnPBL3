using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanThuoc.DTO;
using System.Data;
namespace QuanLyBanThuoc.DAL
{
    public class TableDAO
    {
        private static TableDAO instance;
        public static int TableHeight = 220;
        public static int TableWidth = 205;
        internal static TableDAO Instance
        {
            get
            {
                if (instance == null) instance = new TableDAO();
                return TableDAO.instance;
            }
            private set
            {
                TableDAO.instance = value;
            }
        }
        private TableDAO()
        {

        }
        public void SwitchTable(int id1, int id2)
        {
            DataProvider.Instance.ExcuteQuery("USP_SwitchTabel @idTable1 , @idTabel2", new object[] { id1, id2 });
        }

        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();
            DataTable data = DataProvider.Instance.ExcuteQuery("USP_GetTableList");
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }
        public bool InsertTable(string name, string status)
        {
            string query = string.Format("INSERT dbo.TableMedicine ( Name,Status)VALUES  ( N'{0}', N'{1}')", name, status);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateTable(string name, string status, int id)
        {
            string query = string.Format("UPDATE dbo.TableMedicine SET Name = N'{0}', Status =  N'{1}' WHERE Id = {2}", name, status, id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteTable(int id)
        {
            BillDAO.Instance.DeleteBillByTableId(id);
            string query = string.Format("Delete dbo.TableMedicine where Id = {0}", id);
            int result = DataProvider.Instance.ExcuteNonQuery(query);
            return result > 0;
        }

        public List<int> checkTableContainerMedicineOfList(int idTable)
        {
            List<int> list = new List<int>();
            string query = string.Format("select DISTINCT  m.Id from dbo.Medicine as " +
                "m,dbo.Bill as b,dbo.TableMedicine as t, dbo.BillInfo as bi" +
                " where b.Status = 0 AND b.IdTable = {0} AND b.Id = bi.IdBill AND bi.IdMedicine = m.Id", idTable);
            DataTable table = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in table.Rows)
            {
                list.Add((int)item["Id"]);
            }

            return list;
        }
        public Dictionary<int, int> checkTableContainerMedicineOfListAndCount(int idTable)
        {
            Dictionary<int, int> MyHash = new Dictionary<int,int>();
            string query = string.Format("select DISTINCT  m.Id,bi.count from dbo.Medicine as " +
                "m,dbo.Bill as b,dbo.TableMedicine as t, dbo.BillInfo as bi" +
                " where b.Status = 0 AND b.IdTable = {0} AND b.Id = bi.IdBill AND bi.IdMedicine = m.Id", idTable);
            DataTable table = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in table.Rows)
            {
                MyHash.Add((int)item["Id"], (int)item["count"]);
            }

            return MyHash;
        }

    }
}
