using AddmissionCollege.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddmissionCollege.DAO
{
    public class AreaGradeDAO
    {
        private static AreaGradeDAO instance;

        public static AreaGradeDAO Instance {
            get { if (instance == null) instance = new AreaGradeDAO(); return AreaGradeDAO.instance; }
            private set => instance = value; 
        }

        public AreaGradeDAO() { }

        public List<AreaGrade> LoadAreaGradeList()
        {
            List<AreaGrade> list = new List<AreaGrade>();

            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT dd.ID, dd.DIEM, dt.TEN_KV Name_area, nx.NAM Nam FROM DIEM_KHU_VUc dd JOIN KHU_VUC dt ON dd.ID_KV = dt.ID JOIN NAM_XT nx ON dd.ID_NAM = nx.ID");

            foreach (DataRow row in data.Rows)
            {
                AreaGrade area = new AreaGrade(row);
                list.Add(area);
            }

            return list;    
        }

        public bool InsertGradeArea(float grade, int id_object, int nam)
        {
            string quey = "INSERT INTO DIEM_KHU_VUC VALUES('" + grade + "', '" + id_object + "', '" + nam + "')";

            int result = DataProvider.Instance.ExcuteNoneQuery(quey);

            return result > 0;
        }

        public bool DeleteGradeArea(int id)
        {
            string query = "DELETE FROM DIEM_KHU_VUC WHERE ID = '" + id + "'";

            int result = DataProvider.Instance.ExcuteNoneQuery(query);

            return result > 0;
        }

        public bool UpdateGradeArea(int id, float grade, int id_area, int nam)
        {
            string query = "UPDATE DIEM_KHU_VUC SET DIEM = '" + grade + "', ID_KV = '" + id_area + "', ID_NAM = '" + nam + "' WHERE ID = '" + id + "'";

            int result = DataProvider.Instance.ExcuteNoneQuery(query);

            return result > 0;
        }

    }
}
