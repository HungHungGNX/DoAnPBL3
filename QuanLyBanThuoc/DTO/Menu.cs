using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyBanThuoc.DTO
{
    public class Menu
    {
        private int count;
        private string medicineName;
        private float price;
        private float totalPrice;
        private string dosage;
        public Menu(string medicineName,int count,float price,string dosage,float totalPrice=0)
        {
            this.MedicineName = medicineName;
            this.Count = count; 
            this.Dosage = dosage;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }
        public Menu(DataRow Row)
        {
            this.MedicineName = Row["Name"].ToString();
            this.Count = (int)Row["Count"];
            this.Dosage = Row["Dosage"].ToString();
            this.Price = (float)Convert.ToDouble(Row["Price"].ToString());
            this.TotalPrice = (float)Convert.ToDouble(Row["TotalPrice"].ToString());
        }
        public int Count { get => count; set => count = value; }
        public string MedicineName { get => medicineName; set => medicineName = value; }
        public float Price { get => price; set => price = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
        public string Dosage { get => dosage; set => dosage = value; }
    }
}
