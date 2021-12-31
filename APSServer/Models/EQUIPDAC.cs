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
    public class EQUIPDAC :IDisposable
    {
        SqlConnection conn = null;
        string strConn = string.Empty;
        public EQUIPDAC()
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
        

        public List<EQUIPVO> GetAllEquipment()
        {
            
            string sql = @"select SITE_ID, LINE_ID, EQP_ID, EQP_MODEL, EQP_GROUP from EQUIPMENT";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                return Helper.DataReaderMapToList<EQUIPVO>(cmd.ExecuteReader());
            }
        
           
        }

        public List<EqpArrangeVO> GetEqipmentARR()
        {
            string sql = "select PRODUCT_ID, PROCESS_ID, STEP_ID, EQP_ID, TACT_TIME,PROC_TIME from EQP_ARRANGE";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                return Helper.DataReaderMapToList<EqpArrangeVO>(cmd.ExecuteReader());
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

        public List<EqpGroupVO> GetEqpGroup()
        {
            string sql = "select  STD_STEP_NAME from STD_STEP_INFO";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                return Helper.DataReaderMapToList<EqpGroupVO>(cmd.ExecuteReader());

            }

        }

        public List<LineVO> GetLineInfo()
        {
            string sql = "select SITE_ID, LINE_ID, LINE_NAME from LINE_INFO";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                return Helper.DataReaderMapToList<LineVO>(cmd.ExecuteReader());

            }

        }

        public void InsertEquip(EQUIPVO vo)
        {
            string sql = @"insert into EQUIPMENT(EQP_ID,SITE_ID,LINE_ID,EQP_MODEL,EQP_GROUP) values(@EQP_ID,@SITE_ID,@LINE_ID,@EQP_MODEL,@EQP_GROUP)";


            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {

                cmd.Parameters.AddWithValue("@EQP_ID", vo.EQP_ID);
                cmd.Parameters.AddWithValue("@SITE_ID", vo.SITE_ID);
                cmd.Parameters.AddWithValue("@LINE_ID", vo.LINE_ID);
                cmd.Parameters.AddWithValue("@EQP_MODEL", vo.EQP_MODEL);
                cmd.Parameters.AddWithValue("@EQP_GROUP", vo.EQP_GROUP);


                SqlDataReader reader = cmd.ExecuteReader();
                List<EQUIPVO> list = Helper.DataReaderMapToList<EQUIPVO>(reader);


            }
        }
        public bool DeleteEquip(string id)
        {

            string sql = @"delete EQUIPMENT where EQP_ID=@EQP_ID";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@EQP_ID", id);

                cmd.Connection.Open();
                int iRowAffect = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return (iRowAffect > 0);
            }



        }



        public void UpdateEquip(EQUIPVO Evo)
        {

            string sql = @"update EQUIPMENT set EQP_ID=@EQP_ID,SITE_ID=@SITE_ID,LINE_ID=@LINE_ID,EQP_MODEL=@EQP_MODEL,EQP_GROUP=@EQP_GROUP where EQP_ID=@EQP_ID ;";


            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {

                cmd.Parameters.AddWithValue("@EQP_ID", Evo.EQP_ID);
                cmd.Parameters.AddWithValue("@SITE_ID", Evo.SITE_ID);
                cmd.Parameters.AddWithValue("@LINE_ID", Evo.LINE_ID);
                cmd.Parameters.AddWithValue("@EQP_MODEL", Evo.EQP_MODEL);
                cmd.Parameters.AddWithValue("@EQP_GROUP", Evo.EQP_GROUP);


                SqlDataReader reader = cmd.ExecuteReader();
                List<EQUIPVO> list = Helper.DataReaderMapToList<EQUIPVO>(reader);


            }



        }
    }
}