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
    public class DemandDAC : IDisposable
    {
        SqlConnection conn = null;
        string strConn = string.Empty;

        public DemandDAC()
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

        public bool SaveDemand(DemandVO demand) // 저장
        {
            string sql = @"insert into DEMAND (DEMAND_VER, DEMAND_ID, PRODUCT_ID, CUSTOMER_ID, DUE_DATE, DEMAND_QTY)
			                    values (@DEMAND_VER, @DEMAND_ID, @PRODUCT_ID, @CUSTOMER_ID, @DUE_DATE, @DEMAND_QTY)";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@DEMAND_VER", demand.DEMAND_VER);
                cmd.Parameters.AddWithValue("@DEMAND_ID", demand.DEMAND_ID);
                cmd.Parameters.AddWithValue("@PRODUCT_ID", demand.PRODUCT_ID);
                cmd.Parameters.AddWithValue("@CUSTOMER_ID ", demand.CUSTOMER_ID);
                cmd.Parameters.AddWithValue("@DUE_DATE ", demand.DUE_DATE);
                cmd.Parameters.AddWithValue("@DEMAND_QTY ", demand.DEMAND_QTY);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateDemand(DemandVO Demd) //수정
        {
            string sql = @"update DEMAND set DEMAND_VER = @DEMAND_VER, DEMAND_ID =@DEMAND_ID, PRODUCT_ID = @PRODUCT_ID, CUSTOMER_ID = @CUSTOMER_ID, DUE_DATE = @DUE_DATE, DEMAND_QTY = @DEMAND_QTY where DEMAND_ID=@DEMAND_ID ;";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@DEMAND_VER", Demd.DEMAND_VER);
                cmd.Parameters.AddWithValue("@DEMAND_ID", Demd.DEMAND_ID);
                cmd.Parameters.AddWithValue("@PRODUCT_ID", Demd.PRODUCT_ID);
                cmd.Parameters.AddWithValue("@CUSTOMER_ID", Demd.CUSTOMER_ID);
                cmd.Parameters.AddWithValue("@DUE_DATE", Demd.DUE_DATE);
                cmd.Parameters.AddWithValue("@DEMAND_QTY", Demd.DEMAND_QTY);

                return cmd.ExecuteNonQuery() > 0;

            }
        }


        public List<DemandVO> GetAllDemand() //전체
        {
                string sql = "select DEMAND_VER, DEMAND_ID, PRODUCT_ID, CUSTOMER_ID, DUE_DATE, DEMAND_QTY from DEMAND";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    return Helper.DataReaderMapToList<DemandVO>(cmd.ExecuteReader());
                }
        }

        public DemandVO GetDetail(string id) // 특정
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(strConn);
                cmd.CommandText = "select DEMAND_VER, DEMAND_ID, PRODUCT_ID, CUSTOMER_ID, DUE_DATE, DEMAND_QTY from DEMAND where DEMAND_ID=@DEMAND_ID";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@DEMAND_ID", id);

                cmd.Connection.Open();
                List<DemandVO> list = Helper.DataReaderMapToList<DemandVO>(cmd.ExecuteReader());
                cmd.Connection.Close();

                if (list != null && list.Count > 0)
                    return list[0];
                else
                    return null;
            }
        }

        public bool DeleteDemand (string id) //삭제
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(strConn);
                cmd.CommandText = "delete from DEMAND where DEMAND_ID=@DEMAND_ID";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@DEMAND_ID", id);

                cmd.Connection.Open();
                int iRowAffect = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                return (iRowAffect > 0);
            }
        }
    }
}