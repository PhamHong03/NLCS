using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddmissionCollege.DTO
{
    public class GradeObject
    {
        private int iD;
        private float diem;
        private string name_object;
        private string nam;



        public int ID { get => iD; set => iD = value; }
        public string Nam { get => nam; set => nam = value; }
        public string Name_object { get => name_object; set => name_object = value; }
        public float Diem { get => diem; set => diem = value; }

        public GradeObject(int id, float grade, string name_object, string nam) { 
            this.ID = id;   
            this.Diem = grade; 
            this.Name_object = name_object; 
            this.nam = nam;

        } 
        
        public GradeObject(DataRow row) 
        { 
            this.ID = (int)row["ID"];
            this.Diem = Convert.ToSingle(row["Diem"]);
            this.Name_object = row["Name_object"].ToString();
            this.Nam = row["Nam"].ToString();
        }  
    }
}
