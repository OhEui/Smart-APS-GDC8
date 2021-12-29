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

    }
}
