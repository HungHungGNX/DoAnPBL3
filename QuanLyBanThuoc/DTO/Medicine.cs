using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyBanThuoc.DTO
{
    public class Medicine
    {
        private int id;
        private string name;
        private int idCategory;
        private int quantity;
        private float price;
        private string dosage;
        public Medicine(int id,string name,int idCategory,float price,int quantity,string dosage)
        {
            this.Id = id;
            this.Name = name;
            this.IdCategory = idCategory;
            this.Price = price;
            this.Quantity = quantity;
            this.Dosage = dosage;
        }
        public Medicine(DataRow Row)
        {
            this.Id = (int)Row["Id"];
            this.Name = Row["Name"].ToString();
            this.IdCategory = (int)Row["IdCategory"];
            this.Price = (float)Convert.ToDouble(Row["Price".ToString()]);
            this.Quantity = (int)Row["Quantity"];
            this.Dosage = Row["Dosage"].ToString();
        }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int IdCategory { get => idCategory; set => idCategory = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Dosage { get => dosage; set => dosage = value; }
        public float Price { get => price; set => price = value; }
    }
}
