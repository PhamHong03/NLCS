using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddmissionCollege.DTO
{
    public class Combinate
    {
        private string iD;
        private string TEN_TH;

        public string ID { get => iD; set => iD = value; }
        public string TEN_TH1 { get => TEN_TH; set => TEN_TH = value; }

        public Combinate(string id, string ten) { 
            this.TEN_TH1 = ten;
            this.ID = id;   
        }

        public Combinate(DataRow row) {
            this.ID = row["ID"].ToString(); // Giả sử cột ID trong DataRow là kiểu int
            this.TEN_TH1 = row["TEN_TH"].ToString();
        }  
    }
}
