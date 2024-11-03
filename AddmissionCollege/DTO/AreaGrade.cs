using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddmissionCollege.DTO
{
    public class AreaGrade
    {
        private int iD;
        private float diem;
        private string name_area;
        private string nam;



        public int ID { get => iD; set => iD = value; }
        public string Nam { get => nam; set => nam = value; }
        public float Diem { get => diem; set => diem = value; }
        public string Name_area { get => name_area; set => name_area = value; }

        public AreaGrade(int id, float grade, string name_object, string nam)
        {
            this.ID = id;
            this.Diem = grade;
            this.Name_area = name_object;
            this.nam = nam;

        }

        public AreaGrade(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.Diem = Convert.ToSingle(row["Diem"]);
            this.Name_area = row["Name_area"].ToString();
            this.Nam = row["Nam"].ToString();
        }
    }
}
