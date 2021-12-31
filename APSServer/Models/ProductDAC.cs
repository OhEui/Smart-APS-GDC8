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
    public class ProductDAC
    {
        string strConn = string.Empty;

        public ProductDAC()
        {
            strConn = WebConfigurationManager.ConnectionStrings["teamDB"].ConnectionString;
        }

        public bool SaveProduct(ProductVO product) // 저장, 수정
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(strConn);
                cmd.CommandText = "SP_SaveProduct";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PRODUCT_ID", product.PRODUCT_ID);
                cmd.Parameters.AddWithValue("@PRODUCT_TYPE", product.PRODUCT_TYPE);
                cmd.Parameters.AddWithValue("@PRODUCT_NAME", product.PRODUCT_NAME);
                cmd.Parameters.AddWithValue("@PROCESS_ID ", product.PROCESS_ID);
                cmd.Parameters.AddWithValue("@LOT_SIZE ", product.LOT_SIZE);


                cmd.Connection.Open();
                int iRwAffect = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                return (iRwAffect > 0);
            }
        }

        public List<ProductVO> GetAllProduct() //전체
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(strConn);
                cmd.CommandText = "select PRODUCT_ID, PRODUCT_TYPE, PRODUCT_NAME, PROCESS_ID, LOT_SIZE from PRODUCT";
                cmd.CommandType = CommandType.Text;

                cmd.Connection.Open();
                List<ProductVO> list = Helper.DataReaderMapToList<ProductVO>(cmd.ExecuteReader());
                cmd.Connection.Close();

                return list;
            }
        }

    }
}