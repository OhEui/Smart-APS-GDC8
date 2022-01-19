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

        public bool SaveDemand(DemandVO demand)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(strConn);
                cmd.CommandText = "SP_SaveDemand";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@DEMAND_VER", demand.DEMAND_VER);
                cmd.Parameters.AddWithValue("@DEMAND_ID", demand.DEMAND_ID);
                cmd.Parameters.AddWithValue("@PRODUCT_ID", demand.PRODUCT_ID);
                cmd.Parameters.AddWithValue("@CUSTOMER_ID ", demand.CUSTOMER_ID);
                cmd.Parameters.AddWithValue("@DUE_DATE ", demand.DUE_DATE);
                cmd.Parameters.AddWithValue("@DEMAND_QTY ", demand.DEMAND_QTY);
                cmd.Parameters.AddWithValue("@user_id", demand.user_id);
                cmd.Connection.Open();
                int iRowAffect = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                return (iRowAffect > 0);
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

        public List<DemandVO> GetDemandList()
        {
            string sql = @"select DEMAND_ID, DUE_DATE
from DEMAND
where DUE_DATE between('yyyy-mm-dd')
				                    AND ('yyyy-mm-dd')";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                return Helper.DataReaderMapToList<DemandVO>(cmd.ExecuteReader());
            }
        }
    }
}