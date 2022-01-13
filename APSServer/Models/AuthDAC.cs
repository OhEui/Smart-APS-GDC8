using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Data;
using APSVO;
using System.Configuration;

namespace APSServer.Models
{
    public class AuthDAC:IDisposable
    {
        SqlConnection conn = null;
        string strConn = string.Empty;
        public AuthDAC()
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

        public List<UserVO> GetAllUser()
        {

            string sql = @"select User_name, User_id,auth_id from UserInfo";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                return Helper.DataReaderMapToList<UserVO>(cmd.ExecuteReader());
            }

        }

        public List<AuthVO> GetAllAuth()
        {

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(strConn);
                cmd.CommandText = @"select Auth_id,Auth_Name,auth_Desc from Authority";
                cmd.CommandType = CommandType.Text;

                cmd.Connection.Open();
                List<AuthVO> list = Helper.DataReaderMapToList<AuthVO>(cmd.ExecuteReader());
                cmd.Connection.Close();

                return list;
            }

        }


        public bool SaveAuth(UserVOs vo)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(strConn);
                cmd.CommandText = "SP_SaveAuth";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", vo.Id);
                cmd.Parameters.AddWithValue("@Auth_ID", vo.Auth_ID);
                cmd.Connection.Open();
                int iRowAffect = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                return (iRowAffect > 0);
            }
        }
    }
}