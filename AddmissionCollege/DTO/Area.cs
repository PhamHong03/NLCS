using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddmissionCollege.DTO
{
    public class Area
    {
        private int iD;
        private string TEN_KV;
        private string MO_TA;

        public int ID { get => iD; set => iD = value; }
        public string TEN_KV1 { get => TEN_KV; set => TEN_KV = value; }
        public string MO_TA1 { get => MO_TA; set => MO_TA = value; }

        public Area(int id, string name, string desc) { 
            this.ID = id;
            this.TEN_KV = name; 
            this.MO_TA = desc;  
        }   

        public Area(DataRow row) {
            this.ID = (int)row["ID"];
            this.TEN_KV1 = row["TEN_KV"].ToString();
            this.MO_TA1 = row["MO_TA"].ToString();
        }   
    }
}
