using APSVO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace APSServer.Models
{
    public class ResultDAC : IDisposable
    {
        SqlConnection conn = null;

        public ResultDAC()
        {
            string strConn = APSEncrypt.AES256.Decrypt(WebConfigurationManager.ConnectionStrings["DBInfo"].ConnectionString);
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

        public List<ChartData> GetEQPGanttData()
        {
            List<ResEQPGantt> data = new List<ResEQPGantt>();
            List<ChartData> result = new List<ChartData>();

            string sql = @"
select EQP_ID, START_TIME, END_TIME, LOT_ID, MACHINE_STATE, PROCESS_ID
from EQP_PLAN";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    data = Helper.DataReaderMapToList<ResEQPGantt>(reader);
                }
            }

            foreach (var item in data)
            {
                result.Add(new ChartData()
                {
                    category = item.EQP_ID,
                    fromDate = item.START_TIME.ToString("yyyy-MM-dd HH:mm:ss"),
                    toDate = item.END_TIME.ToString("yyyy-MM-dd HH:mm:ss"),
                    task = item.MACHINE_STATE == "SETUP" ? item.MACHINE_STATE : item.LOT_ID,
                    colorIdx = GetColorIdx(item.PROCESS_ID, item.MACHINE_STATE),
                    brighten = 0.4
                });
            }
            return result;
        }

        public List<ComboItemVO> GetEQPGanttCommonData()
        {
            List<ComboItemVO> data = new List<ComboItemVO>();

            // 설비그룹, 설비ID, 제품ID 가져오기 (equipment)
            string sql = @"
select distinct EQP_ID Code, EQP_ID CodeName, 'EQP_ID' Category 
from EQP_PLAN
union
select distinct PRODUCT_ID Code, PRODUCT_ID CodeName, 'PRODUCT_ID' Category 
from EQP_PLAN
union
select distinct eg.EQP_GROUP Code, eg.EQP_GROUP CodeName,'EQP_GROUP' Category 
from EQP_PLAN ep join vw_EQP_GROUP eg on ep.STEP_ID = eg.STD_STEP_ID
";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    return data = Helper.DataReaderMapToList<ComboItemVO>(reader);
                }
            }

        }

        private int GetColorIdx(string step_id, string machine_state)
        {
            if (machine_state == "SETUP") return 5;
            switch (step_id) 
            {
                case "PROC_Tumbler_KANU": return 1;
                case "PROC_Tumbler_STARBUCKS": return 2;
                case "PROC_Tumbler_TOMNTOMS": return 3;
            }
            return 0;
        }
    }
}