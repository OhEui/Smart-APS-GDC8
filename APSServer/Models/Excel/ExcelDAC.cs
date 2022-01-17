using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace APSServer.Models
{
    public class ExcelDAC : IDisposable
    {
        SqlConnection conn = null;

        public ExcelDAC()
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

        public DataSet GetAllData() 
        {
            DataSet ds = new DataSet();
            string sql = @"sp_SelectALLData";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            string[] sourceName =
                { "LINE_INFO", "PRODUCT", "STD_STEP_INFO", "DEMAND", "EQUIPMENT", "SETUP_TIME", "STEP_ROUTE","EQP_ARRANGE" };

            for (int i = 0; i < sourceName.Length; i++) 
            {
                string tableName = $"Table{i:#}";
                da.TableMappings.Add(tableName, sourceName[i]);
            }

            da.Fill(ds);
            return ds;
        }

    }


}
