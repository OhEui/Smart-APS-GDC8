using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSVO
{
    public class DeleteMetaDataVO
    {
        public int id { get; set; }
        public string table_name { get; set; }
        public string parent_table_name { get; set; }
    }
}
