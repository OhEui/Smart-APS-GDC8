using APSVO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSDAC
{
	public class STD_STEP_DAC : IDisposable
	{
		SqlConnection conn = null;

		public STD_STEP_DAC()
		{
			string strConn = ConfigurationManager.ConnectionStrings["teamDB"].ConnectionString;
			conn = new SqlConnection(strConn);
			conn.Open();
		}

		public void Dispose()
		{
			conn.Close();
		}

		public List<STD_STEP_VO> getStepInfoList()
		{
			string sql = "select STD_STEP_ID, STD_STEP_NAME, STEP_TAT, STEP_YIELD, STEP_SETUP from STD_STEP_INFO";

			using (SqlCommand cmd = new SqlCommand(sql, conn))
			{
				return Helper.DataReaderMapToList<STD_STEP_VO>(cmd.ExecuteReader());
			}
		}

		public bool insertStepInfoList(STD_STEP_VO stepInfoList)
		{
			string sql = @"insert into STD_STEP_INFO (STD_STEP_ID, STD_STEP_NAME, STEP_TAT, STEP_YIELD, STEP_SETUP)
			values(@STD_STEP_ID, @STD_STEP_NAME, @STEP_TAT, @STEP_YIELD, @STEP_SETUP)";

			using(SqlCommand cmd = new SqlCommand(sql, conn))
			{
				cmd.Parameters.AddWithValue("@STD_STEP_ID", stepInfoList.STD_STEP_ID);
				cmd.Parameters.AddWithValue("@STD_STEP_NAME", stepInfoList.STD_STEP_NAME);
				cmd.Parameters.AddWithValue("@STEP_TAT", stepInfoList.STEP_TAT);
				cmd.Parameters.AddWithValue("@STEP_YIELD", stepInfoList.STEP_YIELD);
				cmd.Parameters.AddWithValue("@STEP_SETUP", stepInfoList.STEP_SETUP);

				return cmd.ExecuteNonQuery() > 0;
			}
		}

		public void updateStepInfoList()
		{
			//string sql = "";

		}

		public bool deleteStepInfoList(string stepID)
		{
			string sql = "delete from STD_STEP_INFO where STD_STEP_ID = @STD_STEP_ID";

			using (SqlCommand cmd = new SqlCommand(sql, conn))
			{
				cmd.Parameters.AddWithValue("@STD_STEP_ID", stepID);

				return cmd.ExecuteNonQuery() > 0;
			}
		}
	}
}
