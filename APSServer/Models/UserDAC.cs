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

        public List<UserInfos> GetAllUserInfo() //전체
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(strConn);
                cmd.CommandText = "select User_ID, User_PWD, User_Name, User_IsAdmin from UserInfo";
                cmd.CommandType = CommandType.Text;

                cmd.Connection.Open();
                List<UserInfos> list = Helper.DataReaderMapToList<UserInfos>(cmd.ExecuteReader());
                cmd.Connection.Close();

                return list;
            }
        }
    }
}