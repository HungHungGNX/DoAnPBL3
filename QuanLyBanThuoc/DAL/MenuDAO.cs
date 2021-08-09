using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanThuoc.DTO;
using System.Data;
namespace QuanLyBanThuoc.DAL
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance {
            get
            {
                if (instance == null) instance = new MenuDAO();
                return MenuDAO.instance;
            }
           private set
            {
                MenuDAO.instance = value;
            }
        }
        private MenuDAO() { }
        public List<Menu> GetListMenuByTable(int id)
        {
            List<Menu> listMenu = new List<Menu>();
            string query = "Select m.Name,bi.Count,m.Dosage,m.Price ,bi.Count* m.Price as TotalPrice from dbo.BillInfo as bi,dbo.Bill as b,dbo.Medicine as m Where bi.IdBill = b.Id AND b.Status=0 AND bi.IdMedicine = m.Id AND b.IdTable =" + id;
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }
            return listMenu;

        }
    }
}
