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
    partial class ResultDAC
    {
        public List<ResUtilizationData> GetUtilChartData(ReqUtilizationData req)
        {
            string sql = @"sp_LOAD_STAT";

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MACHINE_STATE", req.MachineState);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    return Helper.DataReaderMapToList<ResUtilizationData>(reader);
                }
            }
        }

        public ChartCommonData GetUtilChartCommonData()
        {
            ChartCommonData result = new ChartCommonData();

            // 설비그룹, 설비ID, 제품ID 가져오기 (equipment)
            string sqlCboList = @"
select distinct VERSION_NO Code, VERSION_NO CodeName, 'VERSION_NO' Category  from vw_LOAD_STAT
union
select CODE Code, Name CodeName, CATEGORY Category from COMMON_CODE where CATEGORY = 'machine_state'
";

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;

                cmd.CommandText = sqlCboList;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    result.ComboItemList = Helper.DataReaderMapToList<ComboItemVO>(reader);
                }
            }

            return result;
        }
    }
}