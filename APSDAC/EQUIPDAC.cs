using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using APSVO;

namespace APSDAC
{

    public class EQUIPDAC : IDisposable
    {
        SqlConnection conn;
        public EQUIPDAC()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["TeamDB"].ConnectionString);
            conn.Open();
        }
        public void Dispose()
        {
            conn.Close();
        }

        public List<EQUIPVO> GetAllEquipment()
        {
            string sql = "select SITE_ID, LINE_ID, EQP_ID, EQP_MODEL, EQP_GROUP from EQUIPMENT";
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
        public void DeleteEquip(string id)
        {

            string sql = @"delete EQUIPMENT where EQP_ID=@EQP_ID";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@EQP_ID", id);

                SqlDataReader reader = cmd.ExecuteReader();
                
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

