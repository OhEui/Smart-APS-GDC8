﻿using System;
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
    public class EQUIPDAC : IDisposable
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

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(strConn);
                cmd.CommandText = @"select SITE_ID, LINE_ID, EQP_ID, EQP_MODEL, EQP_GROUP from EQUIPMENT";

                cmd.Connection.Open();
                List<EQUIPVO> list = Helper.DataReaderMapToList<EQUIPVO>(cmd.ExecuteReader());
                cmd.Connection.Close();

                return list;
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

        //public bool InsertEquip(EQUIPVO vo)
        //{
        //    string sql = @"insert into EQUIPMENT(EQP_ID,SITE_ID,LINE_ID,EQP_MODEL,EQP_GROUP) 
        //                    values(@EQP_ID,@SITE_ID,@LINE_ID,@EQP_MODEL,@EQP_GROUP)";

        //    using (SqlCommand cmd = new SqlCommand(sql, conn))
        //    {
        //        cmd.Parameters.AddWithValue("@EQP_ID", vo.EQP_ID);
        //        cmd.Parameters.AddWithValue("@SITE_ID", vo.SITE_ID);
        //        cmd.Parameters.AddWithValue("@LINE_ID", vo.LINE_ID);
        //        cmd.Parameters.AddWithValue("@EQP_MODEL", vo.EQP_MODEL);
        //        cmd.Parameters.AddWithValue("@EQP_GROUP", vo.EQP_GROUP);

        //        return cmd.ExecuteNonQuery() > 0;
        //    }
        //}

        public bool InsertEquip(EQUIPVO vo)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(strConn);
                cmd.CommandText = "SP_SaveEQUIPMENT";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@EQP_ID", vo.EQP_ID);
                cmd.Parameters.AddWithValue("@SITE_ID", vo.SITE_ID);
                cmd.Parameters.AddWithValue("@LINE_ID", vo.LINE_ID);
                cmd.Parameters.AddWithValue("@EQP_MODEL", vo.EQP_MODEL);
                cmd.Parameters.AddWithValue("@EQP_GROUP", vo.EQP_GROUP);
                cmd.Parameters.AddWithValue("@user_id", vo.user_id);
                cmd.Connection.Open();
                int iRowAffect = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                return (iRowAffect > 0);
            }
        }


        //public bool UpdateEquip(EQUIPVO Evo)
        //{

        //    string sql = @"update EQUIPMENT set EQP_ID=@EQP_ID,SITE_ID=@SITE_ID,LINE_ID=@LINE_ID,EQP_MODEL=@EQP_MODEL,EQP_GROUP=@EQP_GROUP where EQP_ID=@EQP_ID ;";


        //    using (SqlCommand cmd = new SqlCommand(sql, conn))
        //    {

        //        cmd.Parameters.AddWithValue("@EQP_ID", Evo.EQP_ID);
        //        cmd.Parameters.AddWithValue("@SITE_ID", Evo.SITE_ID);
        //        cmd.Parameters.AddWithValue("@LINE_ID", Evo.LINE_ID);
        //        cmd.Parameters.AddWithValue("@EQP_MODEL", Evo.EQP_MODEL);
        //        cmd.Parameters.AddWithValue("@EQP_GROUP", Evo.EQP_GROUP);


        //        return cmd.ExecuteNonQuery() > 0;
        //    }
        //}


        public bool deleteEQP(string EQPID)
        {
            //삭제
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(strConn);
                cmd.CommandText = "delete from EQUIPMENT where EQP_ID=@EQP_ID ";

                cmd.Parameters.AddWithValue("@EQP_ID", EQPID);

                cmd.Connection.Open();
                int result = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                return result > 0;
            }
        }
        //-------------------------------------------------------------------------------------------//


        public bool InsertEquipArr(EqpArrangeVO vo)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(strConn);
                cmd.CommandText = "SP_SaveEQPARR";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PRODUCT_ID", vo.PRODUCT_ID);
                cmd.Parameters.AddWithValue("@PROCESS_ID", vo.PROCESS_ID);
                cmd.Parameters.AddWithValue("@STEP_ID", vo.STEP_ID);
                cmd.Parameters.AddWithValue("@EQP_ID", vo.EQP_ID);
                cmd.Parameters.AddWithValue("@TACT_TIME", vo.TACT_TIME);
                cmd.Parameters.AddWithValue("@PROC_TIME", vo.PROC_TIME);
                cmd.Parameters.AddWithValue("@user_id", vo.user_id);
                cmd.Connection.Open();
                int iRowAffect = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                return (iRowAffect > 0);
            }
        }



        //public bool UpdateEquipArr(EqpArrangeVO Evo)
        //{

        //    string sql = @"update EQP_ARRANGE set PRODUCT_ID=@PRODUCT_ID,PROCESS_ID=@PROCESS_ID,STEP_ID=@STEP_ID,EQP_ID=@EQP_ID,TACT_TIME=@TACT_TIME,PROC_TIME=@PROC_TIME where EQP_ID=@EQP_ID ;";


        //    using (SqlCommand cmd = new SqlCommand(sql, conn))
        //    {

        //        cmd.Parameters.AddWithValue("@PRODUCT_ID", Evo.PRODUCT_ID);
        //        cmd.Parameters.AddWithValue("@PROCESS_ID", Evo.PROCESS_ID);
        //        cmd.Parameters.AddWithValue("@STEP_ID", Evo.STEP_ID);
        //        cmd.Parameters.AddWithValue("@EQP_ID", Evo.EQP_ID);
        //        cmd.Parameters.AddWithValue("@TACT_TIME", Evo.TACT_TIME);
        //        cmd.Parameters.AddWithValue("@PROC_TIME", Evo.PROC_TIME);


        //        return cmd.ExecuteNonQuery() > 0;


        //    }

        //}


        public bool deleteEQPARR(EqpArrangeVO EQPARR)
        {
            //삭제
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(strConn);
                cmd.CommandText = @"delete from EQP_ARRANGE where PRODUCT_ID=@PRODUCT_ID and PROCESS_ID=@PROCESS_ID and STEP_ID=@STEP_ID and EQP_ID=@EQP_ID ";

                cmd.Parameters.AddWithValue("@PRODUCT_ID", EQPARR.PRODUCT_ID);
                cmd.Parameters.AddWithValue("@PROCESS_ID", EQPARR.PROCESS_ID);
                cmd.Parameters.AddWithValue("@STEP_ID", EQPARR.STEP_ID);
                cmd.Parameters.AddWithValue("@EQP_ID", EQPARR.EQP_ID);

                cmd.Connection.Open();
                int result = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                return result > 0;
            }
        }
    }   
}