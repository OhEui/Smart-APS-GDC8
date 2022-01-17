using APSUtil.Http;
using APSVO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSWinForm
{
    /// <summary>
    /// DB 삭제 정보를 저장합니다. 
    /// </summary>
    public sealed class DBInfoStorage
    {
        private static readonly Lazy<Task<DBInfoStorage>> _instance =
            new Lazy<Task<DBInfoStorage>>(() => Task.Run(Create), isThreadSafe: true);

        private Dictionary<string, List<string>> _info = null;

        private DBInfoStorage() { }

        private static async Task<DBInfoStorage> Create() 
        {
            var newInstance = new DBInfoStorage();

            // API 호출 후 _info에 저장
            string path = "api/MetaData/Delete";

            ServiceHelp srv = new ServiceHelp();
            var data = await srv.GetListAsync<List<DeleteMetaDataVO>>(path);
            if (data == null)
                return newInstance;

            newInstance._info = data.GroupBy((i) => i.table_name).
                ToDictionary(g => g.Key, g => g.Select(i=>i.parent_table_name).ToList());

            return newInstance;
        }

        private static Dictionary<string, List<string>> Current 
        { 
            get => _instance.Value.Result._info; 
            //set => _instance.Value._info = value; 
        }

        /// <summary>
        /// 해당 테이블의 데이터를 삭제할 경우 영향을 받는 테이블을 사용자에게 알려주는 문자열을 생성합니다.<br/>
        /// 영향을 받는 테이블이 없는 경우 null을 반환합니다.
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public static string GetDeleteMessage(string tableName, string deleteData = null) 
        {
            if (Current == null)
                return null;

            List<string> list = Current[tableName];
            if (list == null)
                return null;


            StringBuilder sb = new StringBuilder();
            foreach (var item in list)
            {
                sb.Append($"{item},");
            }
            
            if (sb.Length == 0)
            {
                return null;
            }
            else 
            {
                string prefix = deleteData != null ? $"{deleteData} 데이터를 삭제하려고 합니다.\n" : null;
                string str = sb.ToString().TrimEnd(',');
                return $"{prefix}현재 테이블의 데이터를 삭제하면 {str} 테이블의 데이터가 같이 삭제될 수 있습니다\n계속하시겠습니까?";
            }
        }
    }
}
