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
    public class ProductDAC : IDisposable
    {
        string strConn = string.Empty;
        SqlConnection conn = null;

        public ProductDAC()
        {
            strConn = WebConfigurationManager.ConnectionStrings["teamDB"].ConnectionString;
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
        public bool SaveProduct(ProductVO product) // 저장
        {
            string sql = @"insert into PRODUCT (PRODUCT_ID, PRODUCT_TYPE, PRODUCT_NAME, PROCESS_ID, LOT_SIZE)
			                    values (@PRODUCT_ID, @PRODUCT_TYPE, @PRODUCT_NAME, @PROCESS_ID, @LOT_SIZE)";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@PRODUCT_ID", product.PRODUCT_ID);
                cmd.Parameters.AddWithValue("@PRODUCT_TYPE", product.PRODUCT_TYPE);
                cmd.Parameters.AddWithValue("@PRODUCT_NAME", product.PRODUCT_NAME);
                cmd.Parameters.AddWithValue("@PROCESS_ID ", product.PROCESS_ID);
                cmd.Parameters.AddWithValue("@LOT_SIZE ", product.LOT_SIZE);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateProduct(ProductVO product) //수정
        {
            string sql = @"update PRODUCT set PRODUCT_ID = @PRODUCT_ID, PRODUCT_TYPE =@PRODUCT_TYPE, PRODUCT_NAME = @PRODUCT_NAME, PROCESS_ID = @PROCESS_ID, LOT_SIZE = @LOT_SIZE where PRODUCT_ID=@PRODUCT_ID ;";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@PRODUCT_ID", product.PRODUCT_ID);
                cmd.Parameters.AddWithValue("@PRODUCT_TYPE", product.PRODUCT_TYPE);
                cmd.Parameters.AddWithValue("@PRODUCT_NAME", product.PRODUCT_NAME);
                cmd.Parameters.AddWithValue("@PROCESS_ID ", product.PROCESS_ID);
                cmd.Parameters.AddWithValue("@LOT_SIZE ", product.LOT_SIZE);

                return cmd.ExecuteNonQuery() > 0;

            }
        }

        public List<ProductVO> GetAllProduct() //전체
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(strConn);
                cmd.CommandText = "select PRODUCT_ID, PRODUCT_TYPE, PRODUCT_NAME, PROCESS_ID, LOT_SIZE from Product";
                cmd.CommandType = CommandType.Text;

                cmd.Connection.Open();
                List<ProductVO> list = Helper.DataReaderMapToList<ProductVO>(cmd.ExecuteReader());
                cmd.Connection.Close();

                return list;
            }
        }

        public ProductVO GetDetail(string id) // 특정
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(strConn);
                cmd.CommandText = "select  PRODUCT_ID, PRODUCT_TYPE, PRODUCT_NAME, PROCESS_ID, LOT_SIZE from Product where PRODUCT_ID=@PRODUCT_ID";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@PRODUCT_ID", id);

                cmd.Connection.Open();
                List<ProductVO> list = Helper.DataReaderMapToList<ProductVO>(cmd.ExecuteReader());
                cmd.Connection.Close();

                if (list != null && list.Count > 0)
                    return list[0];
                else
                    return null;
            }
        }

        public bool DeleteProduct(string id) //삭제
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(strConn);
                cmd.CommandText = "delete from PRODUCT where PRODUCT_ID=@PRODUCT_ID";

                cmd.Parameters.AddWithValue("@PRODUCT_ID", id);

                cmd.Connection.Open();
                int iRowAffect = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                return (iRowAffect > 0);
            }
        }
    }
}

