using AddmissionCollege.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddmissionCollege.DAO
{
    public class YearDAO
    {
        private static YearDAO instance;

        public YearDAO() { }

        public static YearDAO Instance {
            get { if (instance == null) instance = new YearDAO(); return YearDAO.instance; }
            private set => instance = value; 
        }

        public List<Year> LoadYear()
        {
            List<Year> listYear = new List<Year>();

            DataTable dataTable = DataProvider.Instance.ExcuteQuery("SELECT DISTINCT * FROM NAM_XT");

            foreach (DataRow row in dataTable.Rows)
            {
                Year year = new Year(row);
                listYear.Add(year);
            }

            return listYear;
        }

        //public bool SearchObject(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        string tukhoa = txtSearchObjectPriority.Text;
        //        string sql = "SELECT * FROM DOI_TUONG WHERE TEN_DT LIKE N'%" + tukhoa + "%'";
        //    }
        //    int result = DataProvider.Instance.ExcuteNoneQuery(sql);
        //    return result > 0;
        //}
    }
}
