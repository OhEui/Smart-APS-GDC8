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
                cmd.CommandText = "select User_ID, User_Name, user_auth from UserInfo";
                cmd.CommandType = CommandType.Text;

                cmd.Connection.Open();
                List<UserVO> list = Helper.DataReaderMapToList<UserVO>(cmd.ExecuteReader());
                cmd.Connection.Close();

                return list;
            }
        }


    }
}