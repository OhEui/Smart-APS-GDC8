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
    public class SETUPDAC : IDisposable
    {
        SqlConnection conn = null;
        string strConn = string.Empty;
        public SETUPDAC()
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

        public List<SetupVO> GetSetup_time()
        {
            string sql = "select SITE_ID, LINE_ID, STEP_ID, TIME, EQP_GROUP from SETUP_TIME";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                return Helper.DataReaderMapToList<SetupVO>(cmd.ExecuteReader());

            }

        }
        public bool InsertSetup(SetupVO vo)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(strConn);
                cmd.CommandText = "SP_SaveSETUP";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@SITE_ID", vo.SITE_ID);
                cmd.Parameters.AddWithValue("@LINE_ID", vo.LINE_ID);
                cmd.Parameters.AddWithValue("@EQP_GROUP", vo.EQP_GROUP);
                cmd.Parameters.AddWithValue("@STEP_ID", vo.STEP_ID);
                cmd.Parameters.AddWithValue("@TiME", vo.TIME);
                cmd.Parameters.AddWithValue("@user_id", vo.user_id);
                cmd.Connection.Open();
                int iRowAffect = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                return (iRowAffect > 0);
            }
        }

        public bool deleteSetup(SetupVO Setup)
        {
            //삭제
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(strConn);
                cmd.CommandText = @"delete from SETUP_TIME where SITE_ID=@SITE_ID and LINE_ID=@LINE_ID and EQP_GROUP=@EQP_GROUP and STEP_ID=@STEP_ID ";

                cmd.Parameters.AddWithValue("@SITE_ID", Setup.SITE_ID);
                cmd.Parameters.AddWithValue("@LINE_ID", Setup.LINE_ID);
                cmd.Parameters.AddWithValue("@EQP_GROUP", Setup.EQP_GROUP);
                cmd.Parameters.AddWithValue("@STEP_ID", Setup.STEP_ID);

                cmd.Connection.Open();
                int result = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                return result > 0;
            }




        }
    }
}
