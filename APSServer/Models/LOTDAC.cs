using APSVO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Configuration;

namespace APSServer.Models
{
	public class LOTDAC : IDisposable
    {
        SqlConnection conn = null;
        List<Category> cate = null;
        int i = 0;

        public LOTDAC()
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

        public List<ChartData> GetLOTList(string productID, string lotID)
        {
            List<LOTGanttData> lotList = new List<LOTGanttData>();
            List<ChartData> list = new List<ChartData>();
            cate = new List<Category>();

            //            string sql = @"select s1.LOT_ID, s1.PRODUCT_ID, s1.START_TIME, s2.END_TIME 
            //from EQP_PLAN s1 inner join EQP_PLAN s2 on s1.LOT_ID=s2.LOT_ID
            //where s1.STEP_ID = 'PAINT' and s2.STEP_ID = 'FINISH' and s2.MACHINE_STATE='BUSY'
            //order by LOT_ID";

            using (SqlCommand cmd = new SqlCommand())
			{
                cmd.Connection = conn;

                StringBuilder sb = new StringBuilder();
                sb.Append(@"select s1.LOT_ID, s1.PRODUCT_ID, s1.START_TIME, s2.END_TIME 
from EQP_PLAN s1 inner join EQP_PLAN s2 on s1.LOT_ID=s2.LOT_ID
where s1.STEP_ID = 'PAINT' and s2.STEP_ID = 'FINISH' and s1.MACHINE_STATE='BUSY' and s2.MACHINE_STATE='BUSY' ");

                if (!string.IsNullOrWhiteSpace(productID))
                {
                    sb.Append("and s1.PRODUCT_ID = @PRODUCT_ID ");
                    cmd.Parameters.AddWithValue("@PRODUCT_ID", $"{productID}");
                }
                if (!string.IsNullOrWhiteSpace(lotID))
                {
                    sb.Append("and s1.LOT_ID like @LOT_ID ");
                    cmd.Parameters.AddWithValue("@LOT_ID", $"%{lotID}%");
                }

                sb.Append("order by LOT_ID");
                cmd.CommandText = sb.ToString();
                lotList = Helper.DataReaderMapToList<LOTGanttData>(cmd.ExecuteReader());
            }


            foreach (var item in lotList)
			{
                list.Add(new ChartData()
                {
                    category = item.LOT_ID,
                    fromDate = item.START_TIME.ToString("yyyy-MM-dd HH:mm:ss"),
                    toDate = item.END_TIME.ToString("yyyy-MM-dd HH:mm:ss"),
                    task = item.PRODUCT_ID,
                    colorIdx = GetColor(item.LOT_ID),
                    //colorIdx = 1,
                    brighten = 0.4
                });
			}

            return list;
        }

        private int GetColor(string category)
		{
            if (cate.Find(p => p.category.Equals(category)) == null)
			{
                cate.Add(new Category()
                {
                    category = category,
                    idx = i
                });
                i++;
            }

            return cate.Find(i => i.category.Equals(category)).idx;
        }

        private class Category
		{
			public string category { get; set; }
			public int idx { get; set; }
		}

        public List<LOTGanttCategory> getLOTCategory(string productID, string lotID)
        {
            List<LOTGanttCategory> list = new List<LOTGanttCategory>();

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;

                StringBuilder sb = new StringBuilder();
                sb.Append(@"select distinct LOT_ID as category from EQP_PLAN ");

                if (!string.IsNullOrWhiteSpace(productID))
                {
                    sb.Append("where PRODUCT_ID = @PRODUCT_ID ");
                    cmd.Parameters.AddWithValue("@PRODUCT_ID", $"{productID}");

                    if (!string.IsNullOrWhiteSpace(lotID))
                    {
                        sb.Append("and LOT_ID like @LOT_ID ");
                        cmd.Parameters.AddWithValue("@LOT_ID", $"%{lotID}%");
                    }
                }
				else
				{
                    if (!string.IsNullOrWhiteSpace(lotID))
                    {
                        sb.Append("where LOT_ID like @LOT_ID ");
                        cmd.Parameters.AddWithValue("@LOT_ID", $"%{lotID}%");
                    }
                }

                sb.Append("order by LOT_ID");
                cmd.CommandText = sb.ToString();

                list = Helper.DataReaderMapToList<LOTGanttCategory>(cmd.ExecuteReader());
            }
            return list;
        }

        public List<ComboItemVO> getComboList()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = @"select distinct PRODUCT_ID as Code, PRODUCT_ID as CodeName, 'PRODUCT_ID' as Category 
from EQP_PLAN";

                //cmd.Connection.Open();
                List<ComboItemVO> list = Helper.DataReaderMapToList<ComboItemVO>(cmd.ExecuteReader());
                cmd.Connection.Close();

                return list;
            }
        }
    }
}