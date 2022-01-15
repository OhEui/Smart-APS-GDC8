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
    public class LineInfoDAC
    {
        SqlConnection conn = null;
        string strConn = string.Empty;

        public LineInfoDAC()
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

        public bool SaveLineInfo(Line_Info_VO line_Info) // 저장
        {
            string sql = @"insert into LINE_INFO (SITE_ID, LINE_ID, LINE_NAME)
			                    values (@SITE_ID, @LINE_ID, @LINE_NAME)";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@SITE_ID", line_Info.SITE_ID);
                cmd.Parameters.AddWithValue("@LINE_ID", line_Info.LINE_ID);
                cmd.Parameters.AddWithValue("@LINE_NAME", line_Info.LINE_NAME);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateLineInfo(Line_Info_VO line_Info) //수정
        {
            string sql = @"update LINE_INFO set SITE_ID = @SITE_ID, LINE_ID =@LINE_ID, LINE_NAME = @LINE_NAME where LINE_ID=@LINE_ID ;";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@SITE_ID", line_Info.SITE_ID);
                cmd.Parameters.AddWithValue("@LINE_ID", line_Info.LINE_ID);
                cmd.Parameters.AddWithValue("@LINE_NAME", line_Info.LINE_NAME);

                return cmd.ExecuteNonQuery() > 0;

            }
        }


        public List<Line_Info_VO> GetAllLineInfo() //전체
        {
            string sql = "select SITE_ID, LINE_ID, LINE_NAME from LINE_INFO";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                return Helper.DataReaderMapToList<Line_Info_VO>(cmd.ExecuteReader());
            }
        }

        public Line_Info_VO GetDetail(string id) // 특정
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(strConn);
                cmd.CommandText = "select SITE_ID, LINE_ID, LINE_NAME from LINE_INFO where LINE_ID=@LINE_ID";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@LINE_ID", id);

                cmd.Connection.Open();
                List<Line_Info_VO> list = Helper.DataReaderMapToList<Line_Info_VO>(cmd.ExecuteReader());
                cmd.Connection.Close();

                if (list != null && list.Count > 0)
                    return list[0];
                else
                    return null;
            }
        }

        public bool DeleteLineInfo(string id) //삭제
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(strConn);
                cmd.CommandText = "delete from LINE_INFO where LINE_ID=@LINE_ID";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@LINE_ID", id);

                cmd.Connection.Open();
                int iRowAffect = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                return (iRowAffect > 0);
            }
        }

    }
}