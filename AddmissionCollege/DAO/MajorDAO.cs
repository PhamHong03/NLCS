using AddmissionCollege.DTO;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AddmissionCollege.DAO
{
    public class MajorDAO
    {
        private static MajorDAO instance;

        public static MajorDAO Instance {
            get { if (instance == null) instance = new MajorDAO(); return MajorDAO.instance; } 
            private set => instance = value; 
        }

        public MajorDAO() { }

        public List<Major> loadMajorList()
        {
            List<Major> list = new List<Major>();

            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT n.ID, n.TEN_NGANH, n.THOI_GIAN_DAO_TAO , ct.TEN_CT AS Type FROM NGANH n JOIN CHUONG_TRINH ct ON n.ID_CT = ct.ID");

            foreach (DataRow row in data.Rows)
            {
                Major major = new Major(row);
                list.Add(major);
            }

            return list;
        }

        public List<Curriculum> loadComboBoxCurriculum()
        {

            List <Curriculum> list = new List<Curriculum>();

            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT * FROM CHUONG_TRINH");

            foreach (DataRow row in data.Rows)
            {
                Curriculum cur  = new Curriculum(row);
                list.Add(cur);
            }
            return list;
        }
        
        public bool InsertMajor(string id, string name, string timeTrain, int id_ct)

        {
            //if (id != null && name != null && timeTrain != null && id_ct != null)
            //{
            //string quey = "INSERT INTO NGANH VALUES('" + id + "', N'" + name + "', N'" + timeTrain + "', '" + id_ct + "')";

            //int result = DataProvider.Instance.ExcuteNoneQuery(quey);

            //return result > 0;
            //}
            //return false;
            if (!string.IsNullOrWhiteSpace(id) && !string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(timeTrain))
            {
                try
                {
                    string quey = "INSERT INTO NGANH VALUES('" + id + "', N'" + name + "', N'" + timeTrain + "', '" + id_ct + "')";

                    int result = DataProvider.Instance.ExcuteNoneQuery(quey);

                    return result > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi thêm ngành: {ex.Message}");
                    return false;
                }
            }
            return false;
        }

        public bool DeleteMajor(string id)
        {
            string query = "DELETE FROM NGANH WHERE ID = '" + id + "'";

            int result = DataProvider.Instance.ExcuteNoneQuery(query);

            return result > 0;
        }
    
        public bool UpdateMajor(string id, string name, string timeTrain, int id_ct)
        {
            string query = "UPDATE NGANH SET TEN_NGANH = N'" + name + "', THOI_GIAN_DAO_TAO = N'" + timeTrain + "', ID_CT = N'" + id_ct + "' WHERE ID = '" + id + "'";

            int result = DataProvider.Instance.ExcuteNoneQuery(query);

            return result > 0;
        }
    }
}
