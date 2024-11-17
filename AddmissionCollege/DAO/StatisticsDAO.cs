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
    
    internal class StatisticsDAO
    {
        private SqlConnection conn;

        public Statistics GetStatistics()
        {
            Statistics stats = new Statistics();

            string sql1 = "SELECT COUNT(ID) AS TongCTDT FROM CHUONG_TRINH";
            string sql2 = "SELECT COUNT(ID) AS TongNganh FROM NGANH";
            string sql3 = "SELECT COUNT(TEN_PT) AS TongPT FROM PHUONG_THUC_XT";
            string sql4 = "SELECT COUNT(ID) AS TongTH FROM TO_HOP_XT";
            string sql5 = "SELECT COUNT(DISTINCT TEN_DT)  AS TongDT FROM DOI_TUONG";
            string sql6 = "SELECT COUNT(DISTINCT TEN_KV) AS TongKV FROM KHU_VUC";

            try
            {
                // Lấy dữ liệu từ cơ sở dữ liệu thông qua DataProvider
                DataTable result1 = DataProvider.Instance.ExcuteQuery(sql1);
                stats.TongCTDT1 = Convert.ToInt32(result1.Rows[0]["TongCTDT"]);

                DataTable result2 = DataProvider.Instance.ExcuteQuery(sql2);
                stats.TongNganh1 = Convert.ToInt32(result2.Rows[0]["TongNganh"]);

                DataTable result3 = DataProvider.Instance.ExcuteQuery(sql3);
                stats.TongPT1 = Convert.ToInt32(result3.Rows[0]["TongPT"]);

                DataTable result4 = DataProvider.Instance.ExcuteQuery(sql4);
                stats.TongTH1 = Convert.ToInt32(result4.Rows[0]["TongTH"]);

                DataTable result5 = DataProvider.Instance.ExcuteQuery(sql5);
                stats.TongDT1 = Convert.ToInt32(result5.Rows[0]["TongDT"]);

                DataTable result6 = DataProvider.Instance.ExcuteQuery(sql6);
                stats.TongKV1 = Convert.ToInt32(result6.Rows[0]["TongKV"]);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi truy vấn cơ sở dữ liệu: " + ex.Message);
            }

            return stats;
        }
    }
}
