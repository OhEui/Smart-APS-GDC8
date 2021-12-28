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
    public class UserDAC : IDisposable
    {
        SqlConnection conn = null;

        public UserDAC()
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
        /*
         UserLogin: 유저가 로그인하는동안 유지되는 정보
         UserInfo: 유저의 계정 정보
         */

        public UserLogin Login(string id, string password) 
        {
            throw new NotImplementedException();
        }

        public WebMessage Logout(UserLogin data)
        {
            throw new NotImplementedException();
        }

        public WebMessage CheckID(string id)
        {
            throw new NotImplementedException();
        }

        public WebMessage CheckEmail(string email)
        {
            throw new NotImplementedException();
        }

        public WebMessage SignUp(UserInfo info)
        {
            throw new NotImplementedException();
        }

        public WebMessage ResetPasswort(string id, string email) 
        {
            throw new NotImplementedException();
        }

        public WebMessage UpdateUserInfo(UserInfo info)
        {
            throw new NotImplementedException();
        }

        public WebMessage WithDraw(UserLogin data)
        {
            throw new NotImplementedException();
        }
    }
}
