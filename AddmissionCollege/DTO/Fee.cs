using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddmissionCollege.DTO
{
    public class Fee
    {
        private string Nganh;
        private string CT;
        private string nam;
        private float hp;


        public float Hp { get => hp; set => hp = value; }
        public string Nganh1 { get => Nganh; set => Nganh = value; }
        public string CT1 { get => CT; set => CT = value; }
        public string Nam { get => nam; set => nam = value; }

        public Fee(string nganh, string ct, string nam, float hp) { 
            
            this.Nganh = nganh;  
            this.CT = ct;    
            this.Nam = nam;  
            this.hp = hp;
        }    

        public Fee(DataRow row)
        {
            this.Nganh1 = row["Nganh"].ToString();
            this.CT1 = row["CT"].ToString();
            this.Nam = row["nam"].ToString();
            this.Hp = float.Parse(row["hp"].ToString());
        }
    }
}
