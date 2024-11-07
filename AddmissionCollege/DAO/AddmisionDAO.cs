using AddmissionCollege.DTO;
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

            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT XT.ID_N, N.TEN_NGANH NX.NAM, PT.TEN_PT AS PhuongThuc, XT.CHI_TIEU, XT.DIEM_TRUNG_TUYEN, CT.TEN_CT AS ChuongTrinh FROM XET_TUYEN XT JOIN NGANH N ON XT.ID_N = N.ID JOIN NAM_XT NX ON XT.ID_NAM = NX.ID JOIN PHUONG_THUC_XT PT ON XT.ID_PT = PT.ID JOIN CHUONG_TRINH CT ON N.ID_CT = CT.ID;\r\n");

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
    }
}
