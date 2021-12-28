using APSServer;
using APSVO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSDAC
{
    public class LoginDAC : IDisposable
    {
        SqlConnection conn = null;

        public LoginDAC()
        {
            string strConn = ConfigurationManager.ConnectionStrings["teamDB"].ConnectionString;
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public void Dispose()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
                conn = null;
            }
        }

        public void Login() 
        {
        }

        public void Logout()
        {
        }

        public void CheckID()
        {
        }

        public void CheckEmail()
        {
        }

        public void SignUp()
        {
        }

        public void ResetPasswort() 
        {
        }
    }
}
