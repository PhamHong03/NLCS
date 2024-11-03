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
        private string iD;
        private string Nganh;
        private string nam;
        private string hp;

        public string ID { get => iD; set => iD = value; }
        public string Nganh1 { get => Nganh; set => Nganh = value; }
        public string Nam { get => nam; set => nam = value; }
        public string Hp { get => hp; set => hp = value; }

        public Fee(string iD, string nganh, string nam, string hp)
        {
            this.ID = iD;
            this.Nganh = nganh;
            this.Nam = nam;
            this.Hp = hp;
        }

        public Fee(DataRow row)
        {
            this.ID = row["ID"].ToString();
            this.Nganh1 = row["Nganh"].ToString();
            this.Nam = row["Nam"].ToString();
            this.Hp = row["Hp"].ToString();
        }
    }
}
