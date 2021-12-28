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
	class STD_STEP_DAC : IDisposable
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

		public List<STD_STEP_VO> getList()
		{
			string sql = "select STD_STEP_ID, STD_STEP_NAME, STEP_TAT, STEP_YIELD, STEP_SETUP from STD_STEP_INFO";

			using (SqlCommand cmd = new SqlCommand(sql, conn))
			{
				return Helper.DataReaderMapToList<STD_STEP_VO>(cmd.ExecuteReader());
			}
		}
	}
}
