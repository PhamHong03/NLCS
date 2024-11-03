using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddmissionCollege.DTO
{
    public class ObjectPriority
    {
        private int id;
        private string Ten_DT;
        private string CHINH_SACH;

        public int Id { get => id; set => id = value; }
        public string Ten_DT1 { get => Ten_DT; set => Ten_DT = value; }
        public string CHINH_SACH1 { get => CHINH_SACH; set => CHINH_SACH = value; }

        public ObjectPriority(int id, string name, string policy) {
            this.id = id;   
            this.Ten_DT = name;   
            this.CHINH_SACH = policy;       
        }

        public ObjectPriority(DataRow row) {    
            this.Id = (int)row["Id"];   
            this.Ten_DT1 = row["Ten_DT"].ToString();
            this.CHINH_SACH1 = row["CHINH_SACH"].ToString();
            
        } 
    }
}
