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
    public class SETUPDAC:IDisposable
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
            string sql = @"";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@SITE_ID", vo.SITE_ID);
                cmd.Parameters.AddWithValue("@LINE_ID", vo.LINE_ID);
                cmd.Parameters.AddWithValue("@EQP_GROUP", vo.EQP_GROUP);
                cmd.Parameters.AddWithValue("@STEP_ID", vo.STEP_ID);
                cmd.Parameters.AddWithValue("@TiME", vo.TIME);
                


                return cmd.ExecuteNonQuery() > 0;
            }

    
        }




        public bool UpdateEquipArr(SetupVO Evo)
        {

            string sql = @"";


            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {

                cmd.Parameters.AddWithValue("@SITE_ID", Evo.SITE_ID);
                cmd.Parameters.AddWithValue("@LINE_ID", Evo.LINE_ID);
                cmd.Parameters.AddWithValue("@EQP_GROUP", Evo.EQP_GROUP);
                cmd.Parameters.AddWithValue("@STEP_ID", Evo.STEP_ID);
                cmd.Parameters.AddWithValue("@TiME", Evo.TIME);


                return cmd.ExecuteNonQuery() > 0;


            }



        }
    }
}
