using AddmissionCollege.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddmissionCollege.DAO
{
    public class AreaDAO
    {
        private static AreaDAO instance;

        public static AreaDAO Instance {
            get { if (instance == null) instance = new AreaDAO(); return AreaDAO.instance; }
            private set => instance = value; 
        }

        public AreaDAO() { }

        public List<Area> LoadAreaList()
        {
            List<Area> list = new List<Area>();

            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT DISTINCT * FROM KHU_VUC");

            foreach (DataRow row in data.Rows)
            {
                Area area = new Area(row);
                list.Add(area);
            }


            return list;
        }
        
        public bool InsertArea(string name, string desc)
        {
            string query = "INSERT INTO KHU_VUC VALUES (N'"+name+"', N'"+desc+"')";

            int result = DataProvider.Instance.ExcuteNoneQuery(query);

            return result > 0;
        }

        public bool DeleteArea(int id)
        {
            string query = "DELETE FROM KHU_VUC WHERE Id = '"+id+"'";

            int result = DataProvider.Instance.ExcuteNoneQuery(query);

            return result > 0;
        }

        public bool UpdateArea(int id, string name, string desc)
        {
            string query = "UPDATE KHU_VUC SET TEN_KV = N'"+name+"', MO_TA = N'"+desc+"' WHERE id = '"+id+"'";

            int result = DataProvider.Instance.ExcuteNoneQuery(query);

            return result > 0;
        }

    }
}
