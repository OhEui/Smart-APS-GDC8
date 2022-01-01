﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Data;
using APSVO;

namespace APSServer.Models
{
	public class STEP_INFO_DAC : IDisposable
	{
		string strConn = string.Empty;
		public STEP_INFO_DAC()
		{
			strConn = WebConfigurationManager.ConnectionStrings["teamDB"].ConnectionString;
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}

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
				cmd.CommandText = "select STD_STEP_ID, STD_STEP_NAME, STEP_TAT, STEP_YIELD, STEP_SETUP from STD_STEP_INFO";

				cmd.Connection.Open();
				List<STD_STEP_VO> list = Helper.DataReaderMapToList<STD_STEP_VO>(cmd.ExecuteReader());
				cmd.Connection.Close();

				return list;
			}
		}
	}
}