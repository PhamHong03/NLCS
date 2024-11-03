using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddmissionCollege.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance {
            get { if (instance == null) instance = new AccountDAO(); return AccountDAO.instance; }
            private set => instance = value; 
        }

        public AccountDAO() { }

        public bool Login(string username, string password)
        {
            string query = "USP_Login @userName , @passWord";
            //string query = "SELECT * FROM dbo.ACCOUNT WHERE USERNAME = N'hong' AND PASSWORD = N'123'";

            DataTable result = DataProvider.Instance.ExcuteQuery(query, new object[] {username, password}); 
            
            return result.Rows.Count == 1;
        }
    }
}
