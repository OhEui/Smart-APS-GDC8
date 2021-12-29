using APSVO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSServer.Models
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

        public UserLogin Login(string id, string password)
        {
            string sql = @"
select u.User_NO, u.User_ID, u.User_Name, u.Dept_ID, d.Dept_Name
from UserInfo u left outer join Department d on u.Dept_ID = d.Dept_ID
where u.User_ID = @ID and u.User_PWD = @Password and u.Delete = 0";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Password", password);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    return Helper.DataReaderMapToList<UserLogin>(reader)?.FirstOrDefault();
                }
            }

        }
    }
}