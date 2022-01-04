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
	public class StepDAC : IDisposable
	{
		string strConn = string.Empty;

		public StepDAC()
		{
			strConn = WebConfigurationManager.ConnectionStrings["teamDB"].ConnectionString;
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}

		//==================================================================================
		//STD_STEP_INFO

		/// <summary>
		/// STD_STEP_INFO 수정, 저장
		/// </summary>
		/// 이미 존재하는 STD_STEP_ID라면 Update, 존재하지 않으면 Insert
		/// <param name="stepInfo"></param>
		/// <returns></returns>
		public bool saveStepInfoList(STD_STEP_VO stepInfo)
		{
			using(SqlCommand cmd = new SqlCommand())
			{
				cmd.Connection = new SqlConnection(strConn);
				cmd.CommandText = "SP_SaveStepInfo";
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("@STD_STEP_ID", stepInfo.STD_STEP_ID);
				cmd.Parameters.AddWithValue("@STD_STEP_NAME", stepInfo.STD_STEP_NAME);
				cmd.Parameters.AddWithValue("@STEP_TAT", stepInfo.STEP_TAT);
				cmd.Parameters.AddWithValue("@STEP_YIELD", stepInfo.STEP_YIELD);
				cmd.Parameters.AddWithValue("@STEP_SETUP", stepInfo.STEP_SETUP);
				cmd.Parameters.AddWithValue("@user_id", stepInfo.user_id);

				cmd.Connection.Open();
				int iRowAffect = cmd.ExecuteNonQuery();
				cmd.Connection.Close();

				return (iRowAffect > 0);
			}
		}

		public List<STD_STEP_VO> getStepInfoList()
		{
			using (SqlCommand cmd = new SqlCommand())
			{
				cmd.Connection = new SqlConnection(strConn);
//				cmd.CommandText = @"select STD_STEP_ID, STD_STEP_NAME, STEP_TAT, STEP_YIELD, STEP_SETUP, isnull(mod_id, '') as user_id 
//from STD_STEP_INFO";
				cmd.CommandText = @"select STD_STEP_ID, STD_STEP_NAME, STEP_TAT, STEP_YIELD, STEP_SETUP, mod_id as user_id 
from STD_STEP_INFO";

				cmd.Connection.Open();
				List<STD_STEP_VO> list = Helper.DataReaderMapToList<STD_STEP_VO>(cmd.ExecuteReader());
				cmd.Connection.Close();

				return list;
			}
		}

		//==================================================================================
		//STEP_ROUTE
		public bool saveStepRouteList(StepRouteVO stepRoute)
		{
			using (SqlCommand cmd = new SqlCommand())
			{
				cmd.Connection = new SqlConnection(strConn);
				cmd.CommandText = "SP_StepRoute";
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("@PROCESS_ID", stepRoute.PROCESS_ID);
				cmd.Parameters.AddWithValue("@STEP_ID", stepRoute.STEP_ID);
				cmd.Parameters.AddWithValue("@STEP_SEQ", stepRoute.STEP_SEQ);
				cmd.Parameters.AddWithValue("@STD_STEP_ID", stepRoute.STD_STEP_ID);
				cmd.Parameters.AddWithValue("@user_id", stepRoute.user_id);
				if(stepRoute.STEP_TYPE == null)
				{
					cmd.Parameters.AddWithValue("@STEP_TYPE", DBNull.Value);
				}
				else
				{
					cmd.Parameters.AddWithValue("@STEP_TYPE", stepRoute.STEP_TYPE);
				}

				cmd.Connection.Open();
				int iRowAffect = cmd.ExecuteNonQuery();
				cmd.Connection.Close();

				return (iRowAffect > 0);
			}
		}

		public List<StepRouteVO> getStepRouteList()
		{
			using (SqlCommand cmd = new SqlCommand())
			{
				cmd.Connection = new SqlConnection(strConn);
				cmd.CommandText = @"select PROCESS_ID, STEP_ID, STEP_SEQ, r.STD_STEP_ID as STD_STEP_ID, isnull(STEP_TYPE, '') as STEP_TYPE, i.STEP_TAT as STEP_TAT, r.mod_id as user_id
				from STEP_ROUTE r left outer join STD_STEP_INFO i on r.STD_STEP_ID=i.STD_STEP_ID
				order by PROCESS_ID, STEP_SEQ";
				//				cmd.CommandText = @"select PROCESS_ID, STEP_ID, STEP_SEQ, r.STD_STEP_ID as STD_STEP_ID, STEP_TYPE, i.STEP_TAT as STEP_TAT, r.mod_id as user_id
				//from STEP_ROUTE r left outer join STD_STEP_INFO i on r.STD_STEP_ID=i.STD_STEP_ID
				//order by PROCESS_ID, STEP_SEQ";

				cmd.Connection.Open();
				List<StepRouteVO> list = Helper.DataReaderMapToList<StepRouteVO>(cmd.ExecuteReader());
				cmd.Connection.Close();

				return list;
			}
		}

		public List<ComboItemVO> getStepType()
		{
			using (SqlCommand cmd = new SqlCommand())
			{
				cmd.Connection = new SqlConnection(strConn);
				//cmd.CommandText = @"select distinct isnull(STEP_TYPE, '') as Code, isnull(STEP_TYPE, '--') as CodeName, 'STEP_TYPE' as category
//from STEP_ROUTE order by code desc";
				cmd.CommandText = @"select distinct isnull(STEP_TYPE, '') as Code, isnull(STEP_TYPE, '--') as CodeName, 'STEP_TYPE' as category
from STEP_ROUTE order by code desc";

				cmd.Connection.Open();
				List<ComboItemVO> list = Helper.DataReaderMapToList<ComboItemVO>(cmd.ExecuteReader());
				cmd.Connection.Close();

				return list;
			}
		}

		public List<ComboItemVO> getComboItem()
		{
			using (SqlCommand cmd = new SqlCommand())
			{
				cmd.Connection = new SqlConnection(strConn);
				cmd.CommandText = @"select distinct STEP_TYPE as Code, isnull(STEP_TYPE, '--') as CodeName, 'STEP_TYPE' as category
from STEP_ROUTE
union 
select STD_STEP_ID as Code, STD_STEP_ID  as CodeName, 'STD_STEP_ID' as category
from STD_STEP_INFO
union
select PROCESS_ID as Code, PROCESS_ID  as CodeName, 'PROCESS_ID' as category
from PRODUCT";

				cmd.Connection.Open();
				List<ComboItemVO> list = Helper.DataReaderMapToList<ComboItemVO>(cmd.ExecuteReader());
				cmd.Connection.Close();

				return list;
			}
		}
	}
}