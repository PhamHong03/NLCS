using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddmissionCollege.DTO
{
    public class Year
    {
        private int iD;
        private string NAM;

        public string NAM1 { get => NAM; set => NAM = value; }
        public int ID { get => iD; set => iD = value; }

        public Year(int id, string NAM)
        {
            this.ID = id;
            this.NAM = NAM;
        }
        public Year(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.NAM1 = row["NAM"].ToString();
        }
    }
}
