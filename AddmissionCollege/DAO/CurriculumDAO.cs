using AddmissionCollege.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddmissionCollege.DAO
{
    public class CurriculumDAO
    {
        private static CurriculumDAO instance;

        public static CurriculumDAO Instance {
            get { if (instance == null) instance = new CurriculumDAO(); return CurriculumDAO.instance; }
            private set => instance = value; 
        }

        public CurriculumDAO() { }

        public List<Curriculum> LoadCurriculumList()
        {
            List<Curriculum> curriculumList = new List<Curriculum>();

            DataTable dt = DataProvider.Instance.ExcuteQuery("SELECT * FROM CHUONG_TRINH");

            foreach (DataRow dr in dt.Rows)
            {
                Curriculum curriculum = new Curriculum(dr);
                curriculumList.Add(curriculum);
            }
            return curriculumList;
        }
    }
}
