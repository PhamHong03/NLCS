using AddmissionCollege.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace AddmissionCollege.DAO
{
    public class GradeObjectDAO
    {
        private static GradeObjectDAO instance;

        public static GradeObjectDAO Instance {
            get { if (instance == null) instance = new GradeObjectDAO(); return GradeObjectDAO.instance; }
            private set => instance = value; 
        }

        public GradeObjectDAO() { }

        public List<GradeObject> loadGradeObject()
        {
            List<GradeObject> listObject = new List<GradeObject>();

            DataTable dataTable = DataProvider.Instance.ExcuteQuery("SELECT dd.ID, dd.DIEM, dt.TEN_DT Name_object, nx.NAM Nam FROM DIEM_DOI_TUONG dd JOIN DOI_TUONG dt ON dd.ID_DT = dt.ID JOIN NAM_XT nx ON dd.ID_NAM = nx.ID");

            foreach (DataRow row in dataTable.Rows)
            {
                GradeObject gradeOb = new GradeObject(row);
                listObject.Add(gradeOb);
            }

            return listObject;

        }

        public bool InsertGradeObject(float grade,  int id_object, int nam)
        {
            string quey = "INSERT INTO DIEM_DOI_TUONG VALUES('"+grade+"', '"+id_object+"', '"+nam+"')";

            int result = DataProvider.Instance.ExcuteNoneQuery(quey);   

            return result > 0;
        }

        public bool DeleteGradeObject(int id_object)
        {
            string query = "DELETE FROM DIEM_DOI_TUONG WHERE ID = '" + id_object + "'";

            int result = DataProvider.Instance.ExcuteNoneQuery(query);

            return result > 0;
        }

        public bool UpdateGradeObject(string id, float grade, int id_object, int nam)
        {
            string query = "UPDATE DIEM_DOI_TUONG SET DIEM = '"+grade+"', ID_DT = '"+id_object+"', ID_NAM = '"+nam+"' WHERE ID = '"+id+"'";

            int result = DataProvider.Instance.ExcuteNoneQuery(query);

            return result > 0;
        }
    }
}
