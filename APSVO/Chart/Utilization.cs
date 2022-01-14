using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSVO
{
    public class ReqUtilizationData
    {
        public string MachineState { get; set; }
        public string VersionNo { get; set; }
    }
    public class ResUtilizationData
    {
        public string EQP_GROUP { get; set; }
        public DateTime TARGET_DATE { get; set; }
        public double RATE { get; set; }
    }
}
