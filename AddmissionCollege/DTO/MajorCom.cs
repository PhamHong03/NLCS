using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddmissionCollege.DTO
{
    public class MajorCom
    {
        //private string iD_N;
        //private string iD_TH;
        private string tEN_NGANH;
        private string tO_HOP;

        //public string ID_N { get => iD_N; set => iD_N = value; }
        //public string ID_TH { get => iD_TH; set => iD_TH = value; }
        public string TEN_NGANH { get => tEN_NGANH; set => tEN_NGANH = value; }
        public string TO_HOP { get => tO_HOP; set => tO_HOP = value; }

        public MajorCom(string TEN_NGANH, string TO_HOP) { 
            this.TEN_NGANH = TEN_NGANH;
            this.TO_HOP = TO_HOP;
            //this.iD_TH = TO_HOP;    
        }
        public MajorCom(DataRow row)
        {
            this.TEN_NGANH = row["NGANH"].ToString();
            this.TO_HOP = row["TO_HOP"].ToString();
            //this.iD_TH = row["ID_TH"].ToString();
        }
    }
}
