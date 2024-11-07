using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddmissionCollege.DTO
{
    public class Addmision
    {
        private string id_n;
        private string id_pt;
        private string nam;
        private int chiTieu;
        private float diem;

        public string Id_n { get => id_n; set => id_n = value; }
        public string Id_pt { get => id_pt; set => id_pt = value; }
        public string Nam { get => nam; set => nam = value; }
        public int ChiTieu { get => chiTieu; set => chiTieu = value; }
        public float Diem { get => diem; set => diem = value; }

        public Addmision(string id_n, string id_pt, string nam, int chiTieu, float diem)
        {
            this.id_n = id_n;
            this.id_pt = id_pt;
            this.nam = nam;
            this.chiTieu = chiTieu;
            this.diem = diem;

        }
        public Addmision(DataRow row)
        {
            this.Id_n = row["ID_N"].ToString();
            this.Id_pt = row["ID_PT"].ToString();
            this.Nam = row["ID_NAM"].ToString();
            this.ChiTieu = int.Parse(row["CHI_TIEU"].ToString());
            this.Diem = float.Parse(row["DIEM_TRUNG_TUYEN"].ToString());
        }
    }
}
