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
            List<EQPGanttData> data = new List<EQPGanttData>();
            List<ChartData> result = new List<ChartData>();

            string sql = @"
select EQP_ID, START_TIME, END_TIME, LOT_ID, MACHINE_STATE, PROCESS_ID
from EQP_PLAN";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    data = Helper.DataReaderMapToList<EQPGanttData>(reader);
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