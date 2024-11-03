using AddmissionCollege.DTO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddmissionCollege.DAO
{
    public class ObjectPriorityDAO
    {
        private static ObjectPriorityDAO instance;

        public static ObjectPriorityDAO Instance 
        {
            get { if (instance == null) instance = new ObjectPriorityDAO(); return ObjectPriorityDAO.instance; }
            private set => instance = value; 
        }

        public ObjectPriorityDAO() { }

        public List<ObjectPriority> loadObjectPriority()
        {
            List<ObjectPriority> listObject = new List<ObjectPriority> ();

            DataTable dataTable = DataProvider.Instance.ExcuteQuery("SELECT DISTINCT * FROM DOI_TUONG");

            foreach (DataRow row in dataTable.Rows)
            {
                ObjectPriority objPriority = new ObjectPriority(row);
                listObject.Add(objPriority);
            }

            return listObject;
        }

        public bool InsertObject(string name, string policy)
        {
            string query = "INSERT INTO DOI_TUONG (Ten_DT, CHINH_SACH) VALUES (N'" + name + "', N'" + policy + "')";
            //int result = DataProvider.Instance.ExcuteNoneQuery(query);
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ten", name),
                new SqlParameter("@policy", policy)
            };

            int result = DataProvider.Instance.ExcuteNoneQuery(query, parameters);

            return result > 0;
        }

        public bool DeleteObject(string ID)
        {
            string query = "DELETE FROM DOI_TUONG WHERE ID = '"+ID+"'";
            
            int result = DataProvider.Instance.ExcuteNoneQuery(query);

            return result > 0;  

        }
        public bool UpdateObject(string id, string name, string policy)
        {
            string query = "UPDATE DOI_TUONG SET TEN_DT = N'"+name+"', CHINH_SACH = N'"+policy+"' WHERE ID = '"+id+"'";

            int result = DataProvider.Instance.ExcuteNoneQuery(query);

            return result > 0;
        }
        
    }
}
