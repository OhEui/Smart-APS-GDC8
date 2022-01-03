using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Data;
using APSVO;
using System.Configuration;


namespace APSServer
{
    public class CommonDAC : IDisposable
    {
        SqlConnection conn = null;
        string strConn = string.Empty;
        public CommonDAC()
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


        public List<CommonVO> GetCommonCode()
        {
            string sql = "select Code, Category, CodeName from vw_Common_Code ";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                return Helper.DataReaderMapToList<CommonVO>(cmd.ExecuteReader());

            }
        }

        public List<ComboItemVO> GetCodeList(string[] categories)
        {
            string category = string.Join("','", categories);
            string sql = $@"
select Code, CodeName, Category 
from vw_CommonCode
where category in ('{category}')";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    return Helper.DataReaderMapToList<ComboItemVO>(reader);
                }
            }
        }
    }
}
