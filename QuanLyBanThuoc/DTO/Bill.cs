using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyBanThuoc.DTO
{
    public class Bill
    {
        private int status;
        private int id;
        private DateTime? dateTimeCheckIn;
        private DateTime? dateTimeCheckOut;
        private int discount;
        public Bill(int id,DateTime? dateTimeCheckIn,DateTime? dateTimeCheckOut,int status ,int discount)
        {
            this.Id = id;
            this.DateTimeCheckIn = dateTimeCheckIn;
            this.DateTimeCheckOut = dateTimeCheckOut;
            this.Status = status;
            this.Discount = discount;
        }
        public Bill(DataRow Row)
        {
            this.Id = (int)Row["Id"];
            this.DateTimeCheckIn =(DateTime?)Row["DateCheckIn"];
            var DateCheckOutTemp = Row["DateCheckOut"];
            if (DateCheckOutTemp.ToString() != "")
                this.DateTimeCheckOut = (DateTime?)DateCheckOutTemp;
            this.Status = (int)Row["Status"];
            if (Row["discount"].ToString() != "")
                this.Discount = (int)Row["DisCount"];
        }

        public int Status { get => status; set => status = value; }
        public int Id { get => id; set => id = value; }
        public DateTime? DateTimeCheckIn { get => dateTimeCheckIn; set => dateTimeCheckIn = value; }
        public DateTime? DateTimeCheckOut { get => dateTimeCheckOut; set => dateTimeCheckOut = value; }
        public int Discount { get => discount; set => discount = value; }
    }
}
