using Azure.Core;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddmissionCollege.DAO
{
    public class DataProvider
    {

        private static DataProvider instance;

        public static DataProvider Instance {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set => instance = value; 
        }

        private string connectionSTR = "Data Source=LAPTOP-9S1O4HRM\\SQLEXPRESS;Initial Catalog=QuanLyTuyenSinhDaiHoc;Integrated Security=True;Trust Server Certificate=True";


        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {

            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query,connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i++]);
                        }
                    }
                }


                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(dataTable);

                connection.Close();
            }
            return dataTable;
        }

        public int ExcuteNoneQuery(string query, object[] parameter = null)
        {

            int dataTable = 0;

            using (SqlConnection sqlConnectio = new SqlConnection(connectionSTR))
            {
                sqlConnectio.Open();

                //SqlCommand cmd = new SqlCommand();

                using (SqlCommand cmd = new SqlCommand(query, sqlConnectio))
                {
                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains("@"))
                            {
                                cmd.Parameters.AddWithValue(item, parameter[i++]);
                            }
                        }
                    }
                    dataTable = cmd.ExecuteNonQuery();
                }                  

                sqlConnectio.Close();
            }
            return dataTable;
        }

        //select count *
        public object ExcuteScalar(string query, object[] parameter = null)
        {

            object dataTable = 0;

            using (SqlConnection sqlConnectio = new SqlConnection(connectionSTR))
            {
                sqlConnectio.Open();

                SqlCommand cmd = new SqlCommand();

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i++]);
                        }
                    }
                }

                dataTable = cmd.ExecuteScalar();

                sqlConnectio.Close();
            }
            return dataTable;
        }
    }
}
