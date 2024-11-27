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
    public class AddmisionDAO
    {
        private static AddmisionDAO instance;

        public static AddmisionDAO Instance {
            get { if (instance == null) instance = new AddmisionDAO(); return AddmisionDAO.instance; }
            private set => instance = value;
        }

        public AddmisionDAO() { }

        public List<Addmision> listAddmision()
        {
            List<Addmision> list = new List<Addmision>();

            //DataTable data = DataProvider.Instance.ExcuteQuery("SELECT XT.ID_N, N.TEN_NGANH, NX.NAM, PT.TEN_PT AS PhuongThuc, XT.CHI_TIEU, XT.DIEM_TRUNG_TUYEN, CT.TEN_CT AS ChuongTrinh FROM XET_TUYEN XT JOIN NGANH N ON XT.ID_N = N.ID JOIN NAM_XT NX ON XT.ID_NAM = NX.ID JOIN PHUONG_THUC_XT PT ON XT.ID_PT = PT.ID JOIN CHUONG_TRINH CT ON N.ID_CT = CT.ID");
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT XT.ID_N, N.TEN_NGANH, NX.NAM, PT.TEN_PT AS PhuongThuc, XT.CHI_TIEU, XT.DIEM_TRUNG_TUYEN, CT.TEN_CT AS ChuongTrinh FROM XET_TUYEN XT JOIN NGANH N ON XT.ID_N = N.ID JOIN NAM_XT NX ON XT.ID_NAM = NX.ID JOIN PHUONG_THUC_XT PT ON XT.ID_PT = PT.ID JOIN CHUONG_TRINH CT ON N.ID_CT = CT.ID");
            foreach (DataRow row in data.Rows)
            {
                Addmision major = new Addmision(row);
                list.Add(major);
            }

            return list;
        }

        public List<Addmision> listFollowYear(string year)
        {
            List<Addmision> list = new List<Addmision>();

            //DataTable data = DataProvider.Instance.ExcuteQuery("SELECT XT.ID_N, N.TEN_NGANH, NX.NAM, PT.TEN_PT AS PhuongThuc, XT.CHI_TIEU, XT.DIEM_TRUNG_TUYEN, CT.TEN_CT AS ChuongTrinh FROM XET_TUYEN XT JOIN NGANH N ON XT.ID_N = N.ID JOIN NAM_XT NX ON XT.ID_NAM = NX.ID JOIN PHUONG_THUC_XT PT ON XT.ID_PT = PT.ID JOIN CHUONG_TRINH CT ON N.ID_CT = CT.ID");
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT XT.ID_N, N.TEN_NGANH, NX.NAM, PT.TEN_PT AS PhuongThuc, XT.CHI_TIEU, XT.DIEM_TRUNG_TUYEN, CT.TEN_CT AS ChuongTrinh FROM XET_TUYEN XT JOIN NGANH N ON XT.ID_N = N.ID JOIN NAM_XT NX ON XT.ID_NAM = NX.ID JOIN PHUONG_THUC_XT PT ON XT.ID_PT = PT.ID JOIN CHUONG_TRINH CT ON N.ID_CT = CT.ID WHERE NX.ID = '"+year+"'");
            foreach (DataRow row in data.Rows)
            {
                Addmision major = new Addmision(row);
                list.Add(major);
            }

            return list;
        }
        public List<Curriculum> loadComboBoxCurriculum()
        {

            List<Curriculum> list = new List<Curriculum>();

            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT * FROM CHUONG_TRINH");

            foreach (DataRow row in data.Rows)
            {
                Curriculum cur = new Curriculum(row);
                list.Add(cur);
            }
            return list;
        }

   
        public bool insertAdmission(string id_n, string id_pt, string id_nam, int chi_tieu, float diem)
        {
            string quey = "INSERT INTO XET_TUYEN VALUES('" + id_n + "', '" + id_pt + "', '" + id_nam + "', '" + chi_tieu + "', '"+diem+"')";

            int result = DataProvider.Instance.ExcuteNoneQuery(quey);

            return result > 0;
        }

        public bool deleteAdmission(string id_n, string id_pt)
        {
            string quey = "DELETE FROM XET_TUYEN WHERE ID_N = '"+id_n+"' and ID_PT = '"+id_pt+"'";

            int result = DataProvider.Instance.ExcuteNoneQuery(quey);

            return result > 0;
        }
        public bool updateAdmission(string id_n, string id_pt, string id_nam, int chi_tieu, float diem)
        {
            string sql = "UPDATE XET_TUYEN SET ID_NAM = '"+id_nam+"', CHI_TIEU = '"+chi_tieu+"', DIEM_TRUNG_TUYEN = '"+diem+ "' WHERE ID_N = '" + id_n + "' AND ID_PT = '"+id_pt+ "' AND ID_NAM = '"+id_nam+"'";

            int result = DataProvider.Instance.ExcuteNoneQuery(sql);

            return result > 0;  
        }




        public bool selectChangeYear(string id_nam)
        {
            string sql = "SELECT N.ID AS ID_N ,N.TEN_NGANH, PT.TEN_PT AS PhuongThuc, XT.ID_NAM, XT.CHI_TIEU, XT.DIEM_TRUNG_TUYEN FROM XET_TUYEN AS XT JOIN NGANH AS N ON XT.ID_N = N.ID JOIN PHUONG_THUC_XT AS PT ON XT.ID_PT = PT.ID WHERE XT.ID_NAM = '" + id_nam + "';";

            int result = DataProvider.Instance.ExcuteNoneQuery(sql);

            return result > 0;
        }
    }
}
