using APSVO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace APSServer.Models
{
    public class MetaDataDAC : IDisposable
    {
        SqlConnection conn = null;

        public MetaDataDAC()
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

        public List<DeleteMetaDataVO> GetData()
        {
            string sql = @"select id, table_name, parent_table_name from MetaData_Delete";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                return Helper.DataReaderMapToList<DeleteMetaDataVO>(reader);
            }


        }

    }
}