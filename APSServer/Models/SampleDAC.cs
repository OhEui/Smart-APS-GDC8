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
    public class SampleDAC : IDisposable
    {
        SqlConnection conn = null;

        public SampleDAC()
        {
            string strConn = WebConfigurationManager.ConnectionStrings["teamDB"].ConnectionString;
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

        public List<SampleVO> GetSampleList() 
        {
            List<SampleVO> sampleList = new List<SampleVO>();
            string sql = @"SELECT ID, Name FROM Sample";
            
            using (SqlCommand cmd = new SqlCommand(sql, conn)) 
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    sampleList = Helper.DataReaderMapToList<SampleVO>(reader);
                }
            }

            return sampleList;
        }
    }
}