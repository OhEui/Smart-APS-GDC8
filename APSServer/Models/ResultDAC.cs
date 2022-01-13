using APSVO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
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

        public List<ChartData> GetEQPGanttData(ReqEQPGantt req)
        {
            List<ResEQPGantt> data = new List<ResEQPGantt>();
            List<ChartData> result = new List<ChartData>();

            StringBuilder sb = new StringBuilder();
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                sb.AppendLine(@"select EQP_ID, START_TIME, END_TIME, LOT_ID, MACHINE_STATE, PROCESS_ID 
from EQP_PLAN where 1=1");
                if (req.EQP_ID != null)
                {
                    sb.AppendLine("and EQP_ID in (select * from STRING_SPLIT(@EQP_ID,','))");
                    cmd.Parameters.AddWithValue("@EQP_ID", string.Join(",", req.EQP_ID));
                }
                if (req.EQP_GROUP != null)
                {
                    sb.AppendLine("and STEP_ID in (select * from STRING_SPLIT(@EQP_GROUP,','))");
                    cmd.Parameters.AddWithValue("@EQP_GROUP", string.Join(",", req.EQP_GROUP));
                }
                if (req.PRODUCT_ID != null)
                {
                    sb.AppendLine("and PRODUCT_ID in (select * from STRING_SPLIT(@PRODUCT_ID,','))");
                    cmd.Parameters.AddWithValue("@PRODUCT_ID", string.Join(",", req.PRODUCT_ID));
                }
                if (req.Start_Date != null && req.End_Date != null)
                {
                    sb.AppendLine("and START_TIME between @START and @END and END_TIME between @START and @END");
                    DateTime start = req.Start_Date.Value.Date;
                    DateTime end = req.End_Date.Value.Date.AddDays(1).AddMilliseconds(-1);
                    cmd.Parameters.AddWithValue("@START", start);
                    cmd.Parameters.AddWithValue("@END", end);
                }
                
                cmd.CommandText = sb.ToString();
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
select distinct ep.STEP_ID Code, eg.EQP_GROUP CodeName,'EQP_GROUP' Category 
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