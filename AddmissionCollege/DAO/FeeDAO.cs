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

            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT hp.ID AS ID , n.TEN_NGANH AS Nganh, nx.NAM AS nam, ct.TEN_CT as CT, hp.HOC_PHI_BINH_QUAN AS hp FROM HOC_PHI hp JOIN NGANH n ON hp.ID_N = n.ID JOIN NAM_XT nx ON hp.ID_NAM = nx.ID JOIN CHUONG_TRINH ct ON n.ID_CT = ct.ID ");

            foreach (DataRow row in data.Rows)
            {
                Fee fee = new Fee(row);
                list.Add(fee);
            }

            return list;
        }
    }
}
