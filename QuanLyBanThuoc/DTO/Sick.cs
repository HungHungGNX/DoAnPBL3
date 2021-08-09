using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanThuoc.DTO
{
    class Sick
    {
        private string signal;
        private string cure;
        private int id;
        private string nameSick;
        public string Signal { get => signal; set => signal = value; }
        public string Cure { get => cure; set => cure = value; }
        public int Id { get => id; set => id = value; }
        public string NameSick { get => nameSick; set => nameSick = value; }

        public Sick(string signal, string cure, string namesick, int id)
        {
            this.signal = signal;
            this.cure = cure;
            NameSick = nameSick;
            this.id = id;
        }

        public Sick(DataRow row)
        {
            this.Id = (int)row["Id"];
            this.Cure = row["Cure"].ToString();
            this.Signal = row["Signal"].ToString();
            this.NameSick = row["NameSick"].ToString();
        }
    }
}
