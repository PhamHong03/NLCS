using AddmissionCollege.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddmissionCollege.DAO
{
    public class MajorComDAO
    {
        private static MajorComDAO instance;

        public static MajorComDAO Instance {
            get { if (instance == null) instance = new MajorComDAO(); return MajorComDAO.instance; }
            private set => instance = value;
        }

        public MajorComDAO() { }
        public List<MajorCom> loadMajorCombinate()
        {
            List<MajorCom> list = new List<MajorCom>();

            //DataTable data = DataProvider.Instance.ExcuteQuery("SELECT N.TEN_NGANH AS NGANH, STRING_AGG(TH.TEN_TH, '; ') AS TO_HOP FROM NGANH_TO_HOP NTH JOIN NGANH N ON NTH.ID_N = N.ID JOIN TO_HOP_XT TH ON NTH.ID_TH = TH.ID GROUP BY N.TEN_NGANH");
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT N.TEN_NGANH AS NGANH, STRING_AGG(TH.ID, ', ') AS TO_HOP FROM NGANH_TO_HOP NTH JOIN NGANH N ON NTH.ID_N = N.ID JOIN TO_HOP_XT TH ON NTH.ID_TH = TH.ID GROUP BY N.TEN_NGANH");
            foreach (DataRow dr in data.Rows) {
                MajorCom majorCom = new MajorCom(dr);
                list.Add(majorCom);
            }
            return list;        
        }

        public bool InsertMajorCom(string id_N, string id_TH)
        {
            string query = "insert into NGANH_TO_HOP VALUES ('"+id_N+"', '"+id_TH+"')";

            int result = DataProvider.Instance.ExcuteNoneQuery(query);

            return result > 0;
        }

        public bool DeleteMajorCom(string id_N)
        {
            string query = "DELETE FROM NGANH_TO_HOP WHERE ID_N = '"+id_N+"'";

            int result = DataProvider.Instance.ExcuteNoneQuery(query);

            return result > 0;
        }

    }
}
