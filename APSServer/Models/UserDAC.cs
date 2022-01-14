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

        SqlConnection conn = null;
      
        public UserDAC()
        {
            strConn = WebConfigurationManager.ConnectionStrings["TeamDB"].ConnectionString;
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

        public List<UserVO> GetAllUser() //전체
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(strConn);
                cmd.CommandText = @"select a.empno,a.Id,a.Name,b.auth_name as auth_name
from ASP_Users a
inner join Authority b 
on a.Auth_ID= b.AUTH_ID";
                cmd.CommandType = CommandType.Text;

                cmd.Connection.Open();
                List<UserVO> list = Helper.DataReaderMapToList<UserVO>(cmd.ExecuteReader());
                cmd.Connection.Close();

                return list;
            }
        }

        //public List<UserInfoVO> AllUserList() //전체
        //{
        //    using (SqlCommand cmd = new SqlCommand())
        //    {
        //        cmd.Connection = new SqlConnection(strConn);
        //        cmd.CommandText = "select User_ID, User_Name, User_phone, User_Birth from UserInfo";
        //        cmd.CommandType = CommandType.Text;

        //        cmd.Connection.Open();
        //        List<UserInfoVO> list = Helper.DataReaderMapToList<UserInfoVO>(cmd.ExecuteReader());
        //        cmd.Connection.Close();

        //        return list;
        //    }
        //}

        public List<UserInfoVO> AllUserList()
        {

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(strConn);
                cmd.CommandText = @"select User_ID, User_Name, User_phone, User_Birth from UserInfo";

                cmd.Connection.Open();
                List<UserInfoVO> list = Helper.DataReaderMapToList<UserInfoVO>(cmd.ExecuteReader());
                cmd.Connection.Close();

                return list;
            }

        }
    }
}