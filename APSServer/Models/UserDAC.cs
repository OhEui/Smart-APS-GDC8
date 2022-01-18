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

        public List<UserInfoVO> AllUserList()
        {

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(strConn);
                cmd.CommandText = @"select UserName, Name, phone, Birthday, Email from ASP_Users";

                cmd.Connection.Open();
                List<UserInfoVO> list = Helper.DataReaderMapToList<UserInfoVO>(cmd.ExecuteReader());
                cmd.Connection.Close();

                return list;
            }

        }
        public bool UpdateUserInfo(UserInfoVO product) //수정
        {
            string sql = @"update ASP_Users set UserName = @UserName, Name =@Name, Phone = @Phone, Birthday = @Birthday, Email = @Email where UserName=@UserName ;";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@UserName", product.UserName);
                cmd.Parameters.AddWithValue("@Name", product.Name);
                cmd.Parameters.AddWithValue("@Phone", product.Phone);
                cmd.Parameters.AddWithValue("@Birthday ", product.Birthday);
                cmd.Parameters.AddWithValue("@Email ", product.Email);

                return cmd.ExecuteNonQuery() > 0;

            }
        }

        public UserInfoVO GetDetail(string id) // 특정
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(strConn);
                cmd.CommandText = "select  UserName, Name, Phone, Email, Birthday from ASP_Users where UserName=@UserName";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@UserName", id);

                cmd.Connection.Open();
                List<UserInfoVO> list = Helper.DataReaderMapToList<UserInfoVO>(cmd.ExecuteReader());
                cmd.Connection.Close();

                if (list != null && list.Count > 0)
                    return list[0];
                else
                    return null;
            }
        }

        public bool DeleteUserInfo(string id) //삭제
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(strConn);
                cmd.CommandText = "delete from ASP_Users where UserName=@UserName";

                cmd.Parameters.AddWithValue("@UserName", id);

                cmd.Connection.Open();
                int iRowAffect = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                return (iRowAffect > 0);
            }
        }
    }
}