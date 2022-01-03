using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using APSVO;

namespace APSDAC
{
    public class PRODUCTDAC : IDisposable
    {
        SqlConnection conn;
        public PRODUCTDAC()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["TeamDB"].ConnectionString);
            conn.Open();
        }
        public void Dispose()
        {
            conn.Close();
        }

        public List<ProductVO> GetAllList()
        {
            string sql = "select PRODUCT_ID, PRODUCT_TYPE, PRODUCT_NAME, PROCESS_ID, LOT_SIZE from PRODUCT";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                return Helper.DataReaderMapToList<ProductVO>(cmd.ExecuteReader());
            }
        }
    }
}
