using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddmissionCollege.DTO
{
    public class Curriculum
    {
        private int iD;
        private string ten_CT;
        public int ID { get => iD; set => iD = value; }
        public string Ten_CT { get => ten_CT; set => ten_CT = value; }

        public Curriculum(int id, string ten_CT) {
            this.iD = id;   
            this.ten_CT = ten_CT;   
        }

        public Curriculum(DataRow row) { 
            this.iD = (int)row["ID"];   
            this.ten_CT = row["Ten_CT"].ToString();
        }
    }
}
