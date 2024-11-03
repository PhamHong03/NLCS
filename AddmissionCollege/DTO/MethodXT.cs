using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddmissionCollege.DTO
{
    public class MethodXT
    {
        private int iD;

        private string TEN_PT;

        private string MO_TA;
        public int ID { get => iD; set => iD = value; }
        public string TEN_PT1 { get => TEN_PT; set => TEN_PT = value; }
        public string MO_TA1 { get => MO_TA; set => MO_TA = value; }

        public MethodXT(int id, string name, string mo_ta) {
            this.iD = id;   
            this.TEN_PT = name;
            this.MO_TA = mo_ta;
        }

        public MethodXT(DataRow row) { 
            this.ID = (int)row["ID"];
            this.TEN_PT1 = row["TEN_PT"].ToString();
            this.MO_TA1 = row["MO_TA"].ToString();
        }
    }
}
