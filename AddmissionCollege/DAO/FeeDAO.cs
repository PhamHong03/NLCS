using AddmissionCollege.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddmissionCollege.DAO
{
    public class FeeDAO
    {
        private static FeeDAO instance;

        public static FeeDAO Instance {
            get { if (instance == null) instance = new FeeDAO(); return FeeDAO.instance; }
            private set => instance = value; 
        }

        public FeeDAO() { }

        public List<Fee> loadListFee()
        {
            List<Fee> list = new List<Fee>();

            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT n.TEN_NGANH AS Nganh, nx.NAM AS nam, ct.TEN_CT as CT, hp.HOC_PHI_BINH_QUAN AS hp FROM HOC_PHI hp JOIN NGANH n ON hp.ID_N = n.ID JOIN NAM_XT nx ON hp.ID_NAM = nx.ID JOIN CHUONG_TRINH ct ON n.ID_CT = ct.ID");
            //DataTable data = DataProvider.Instance.ExcuteQuery("SELECT HP.ID, HP.HOC_PHI_BINH_QUAN, NX.NAM, N.TEN_NGANH, CT.TEN_CT FROM HOC_PHI HP JOIN NAM_XT NX ON HP.ID_NAM = NX.ID JOIN NGANH N ON HP.ID_N = N.ID JOIN CHUONG_TRINH CT ON HP.ID_CT = CT.ID;\r\n");
            foreach (DataRow row in data.Rows)
            {
                Fee fee = new Fee(row);
                list.Add(fee);
            }

            return list;
        }
        public List<Fee> loadListFeeFollowYear(string year)
        {
            List<Fee> list = new List<Fee>();

            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT n.TEN_NGANH AS Nganh, nx.NAM AS nam, ct.TEN_CT as CT, hp.HOC_PHI_BINH_QUAN AS hp FROM HOC_PHI hp JOIN NGANH n ON hp.ID_N = n.ID JOIN NAM_XT nx ON hp.ID_NAM = nx.ID JOIN CHUONG_TRINH ct ON n.ID_CT = ct.ID WHERE nx.NAM = '"+year+"'");
            foreach (DataRow row in data.Rows)
            {
                Fee fee = new Fee(row);
                list.Add(fee);
            }

            return list;
        }

        public bool InsertFee(string id_N, string id_CT, string nam, float hp)
        {
            string query = "insert into HOC_PHI VALUES ('" + id_N + "', '" + id_CT + "', '"+nam+"', '"+hp+"')";

            int result = DataProvider.Instance.ExcuteNoneQuery(query);

            return result > 0;
        }
        public bool DeleteFee(string id_N)
        {
            string query = "DELETE FROM HOC_PHI WHERE ID_N = '"+id_N+"'";

            int result = DataProvider.Instance.ExcuteNoneQuery(query);

            return result > 0;
        }
        public bool EditFee(string id_N, string id_CT, string nam, float hp)
        {
            string query = "UPDATE HOC_PHI SET ID_CT = '" + id_CT + "',ID_NAM = '" + nam + "',HOC_PHI_BINH_QUAN = '" + hp + "' where ID_N = '" + id_N + "'";

            int result = DataProvider.Instance.ExcuteNoneQuery(query);

            return result > 0;
        }

        public decimal GetTotalFeeByYear(string year)
        {
            string query = "SELECT SUM(HOC_PHI_BINH_QUAN) FROM HOC_PHI WHERE ID_NAM = '"+year+"'";
            object result = DataProvider.Instance.ExecuteScalar(query);

            return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
        }
    }
}
