using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddmissionCollege.DTO
{
    public class Major
    {
        private string iD;
        private string TEN_NGANH;
        private string THOI_GIAN_DAO_TAO;
        private string type;

        public string Type { get => type; set => type = value; }
        public string ID { get => iD; set => iD = value; }
        public string TEN_NGANH1 { get => TEN_NGANH; set => TEN_NGANH = value; }
        public string THOI_GIAN_DAO_TAO1 { get => THOI_GIAN_DAO_TAO; set => THOI_GIAN_DAO_TAO = value; }

        public Major(string id, string name, string timeTrain, string type) {
            this.ID = id;
            this.TEN_NGANH = name;   
            this.THOI_GIAN_DAO_TAO = timeTrain; 
            this.type = type;   

        }  

        public Major(DataRow row) {

            this.ID =row["ID"].ToString(); // Giả sử cột ID trong DataRow là kiểu int
            this.TEN_NGANH1 = row["TEN_NGANH"].ToString();
            this.THOI_GIAN_DAO_TAO1 = row["THOI_GIAN_DAO_TAO"].ToString();
            this.type = row["Type"].ToString();
        }  


    }
}
