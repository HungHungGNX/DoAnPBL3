using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyBanThuoc.DTO
{
    public class BillInfo
    {
        private int id;
        private int idMedicine;
        private int idBill;
        private int count;
  
        public int Id { get => id; set => id = value; }
        public int IdMedicine { get => idMedicine; set => idMedicine = value; }
        public int IdBill { get => idBill; set => idBill = value; }
        public int Count { get => count; set => count = value; }
        public BillInfo(int id,int idBill,int idMedicine,int count)
        {    
            this.Id = id;
            this.IdBill = idBill;
            this.IdMedicine = idMedicine;
            this.Count = count;
        }
        public BillInfo(DataRow Row)
        {   this.Id = (int)Row["Id"];
            this.IdBill = (int)Row["IdBill"];   
            this.IdMedicine = (int)Row["IdMedicine"];
            this.Count = (int)Row["Count"];
        }
    }
}
