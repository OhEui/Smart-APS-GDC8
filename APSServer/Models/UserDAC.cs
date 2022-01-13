using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Data;
using APSVO;

namespace APSServer.Models
{
    public class UserDAC 
    {
        string strConn = string.Empty;

        public UserDAC()
        {
            strConn = WebConfigurationManager.ConnectionStrings["teamDB"].ConnectionString;
        }

        public List<UserVO> GetAllUser() //전체
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(strConn);
                cmd.CommandText = @"select a.User_ID,a.User_Name,b.auth_name as auth_name
from UserInfo a
inner join Authority b 
on a.auth_id= b.AUTH_ID";
                cmd.CommandType = CommandType.Text;

                cmd.Connection.Open();
                List<UserVO> list = Helper.DataReaderMapToList<UserVO>(cmd.ExecuteReader());
                cmd.Connection.Close();

                return list;
            }
        }


    }
}