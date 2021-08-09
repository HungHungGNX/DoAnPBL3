using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyBanThuoc.DTO
{
    public class Category
    {
        private string name;
        private int id;

        public Category(int id,string name)
        {
            this.Name = name;
            this.id = id;
        }
        public Category(DataRow Row)
        {
            this.Id = (int)Row["Id"];
            this.Name = Row["Name"].ToString();
        }
        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
    }
}
