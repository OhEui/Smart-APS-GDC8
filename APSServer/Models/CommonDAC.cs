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


        public List<ComboItemVO> GetComboItem()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(strConn);
                cmd.CommandText = @"select STD_STEP_ID as Code, STD_STEP_ID  as CodeName, 'STD_STEP_ID' as category
from STD_STEP_INFO
union 
select PRODUCT_ID as Code, PRODUCT_NAME  as CodeName, 'PRODUCT_ID' as category
from PRODUCT
union
select PROCESS_ID as Code, PROCESS_ID  as CodeName, 'PROCESS_ID' as category
from PRODUCT
union
select LINE_ID as Code, LINE_ID  as CodeName, 'LINE_ID' as category
from LINE_INFO
union
select SITE_ID as Code, SITE_ID  as CodeName, 'SITE_ID' as category
from LINE_INFO
union
select PRODUCT_TYPE as Code, PRODUCT_TYPE  as CodeName, 'PRODUCT_TYPE' as category
from PRODUCT
union
select CUSTOMER_ID as Code, CUSTOMER_ID  as CodeName, 'CUSTOMER_ID' as category
from DEMAND
union
select PRODUCT_ID as Code, PRODUCT_ID  as CodeName, 'PRODUCT_ID' as category
from DEMAND";

                cmd.Connection.Open();
                List<ComboItemVO> list = Helper.DataReaderMapToList<ComboItemVO>(cmd.ExecuteReader());
                cmd.Connection.Close();

                return list;
            }
        }
    }
}
