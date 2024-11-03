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
    public class MethodDAO
    {
        private static MethodDAO instance;

        public static MethodDAO Instance {
            get { if (instance == null) instance = new MethodDAO(); return MethodDAO.instance; }
            private set => instance = value; 
        }

        public MethodDAO() { }

        public List<MethodXT> LoadMethodList()
        {
            List<MethodXT> list = new List<MethodXT>();

            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT DISTINCT * FROM PHUONG_THUC_XT");

            foreach (DataRow row in data.Rows)
            {
                MethodXT method = new MethodXT(row);
                list.Add(method);
            }

            return list;
        }

        public bool InsertMethod(string name, string description) 
        {
            string query = "INSERT INTO PHUONG_THUC_XT VALUES (N'"+name+"', N'"+description+"')";
            
            //SqlParameter[] parameters = new SqlParameter[]
            //{
            //    new SqlParameter("@name", name),
            //    new SqlParameter("@description", description)
            //};

            int result = DataProvider.Instance.ExcuteNoneQuery(query);

            return result > 0;
        }

        public bool DeleteMethod(int id)
        {
            string query = "DELETE FROM PHUONG_THUC_XT WHERE ID = '" + id + "'";

            int result = DataProvider.Instance.ExcuteNoneQuery(query);

            return result > 0;

        }


        public bool UpdateMethod(int id, string name, string description) {
            string query = "UPDATE PHUONG_THUC_XT SET TEN_PT = N'" + name + "', MO_TA = N'" + description + "' WHERE ID = '" + id + "'";

            int result = DataProvider.Instance.ExcuteNoneQuery(query);

            return result > 0;
        }

    }
}
