using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyBanThuoc.DTO
{
    public class Table
    {
        private int id;
        private string status;
        private string name;
        public Table(int id,string status,string name)
        {
            this.Id = id;
            this.Name = name;
            this.Status = status;
        }
        public Table(DataRow Row)
        {
            this.Id = (int)Row["Id"];
            this.Name = Row["Name"].ToString();
            this.Status = Row["Status"].ToString();

        }

        public int Id { get => id; set => id = value; }
        public string Status { get => status; set => status = value; }
        public string Name { get => name; set => name = value; }
    }
}
