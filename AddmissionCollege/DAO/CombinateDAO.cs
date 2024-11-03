using AddmissionCollege.DTO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AddmissionCollege.DAO
{
    public class CombinateDAO
    {
        private static CombinateDAO instance;

        public static CombinateDAO Instance {
            get { if (instance == null) instance = new CombinateDAO(); return CombinateDAO.instance; }
            private set => instance = value; 
        }

        public CombinateDAO() { }

        public List<Combinate> LoadListCombinate()
        {
            List<Combinate> combinates = new List<Combinate>();

            DataTable dt = DataProvider.Instance.ExcuteQuery("SELECT * FROM TO_HOP_XT");

            foreach (DataRow row in dt.Rows)
            {
                Combinate combinate = new Combinate(row);
                combinates.Add(combinate);
            }

            return combinates;
        }

        //public List<Major> loadMajorList()
        //{
        //    List<Major> list = new List<Major>();

        //    DataTable data = DataProvider.Instance.ExcuteQuery("SELECT n.ID, n.TEN_NGANH, n.THOI_GIAN_DAO_TAO , ct.TEN_CT AS Type FROM NGANH n JOIN CHUONG_TRINH ct ON n.ID_CT = ct.ID");

        //    foreach (DataRow row in data.Rows)
        //    {
        //        Major major = new Major(row);
        //        list.Add(major);
        //    }

        //    return list;
        //}

        public bool InsertCombinate(string id, string name)
        {
            string query = "INSERT INTO TO_HOP_XT (ID, TEN_TH) VALUES (N'" + id + "', N'" + name + "')";
            //int result = DataProvider.Instance.ExcuteNoneQuery(query);
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", id),
                new SqlParameter("@name", name)
            };

            int result = DataProvider.Instance.ExcuteNoneQuery(query, parameters);

            return result > 0;
        }

        public bool DeleteCombinate(string id)
        {
            string query = "DELETE FROM TO_HOP_XT WHERE ID = '" + id + "'";

            int result = DataProvider.Instance.ExcuteNoneQuery(query);

            return result > 0;
        }

        public bool UpdateCombinate(string id, string name)
        {
            string query = "UPDATE TO_HOP_XT SET TEN_TH = N'" + name + "' WHERE ID = '" + id + "'";

            int result = DataProvider.Instance.ExcuteNoneQuery(query);

            return result > 0;
        }
    }
}
