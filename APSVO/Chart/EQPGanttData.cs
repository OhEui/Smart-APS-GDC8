using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSVO
{
    public class EQPGanttData
    {
        public string EQP_ID { get; set; }
        public string MACHINE_STATE { get; set; }
        public string STEP_ID { get; set; }
        public string LOT_ID { get; set; }
        public DateTime START_TIME { get; set; }
        public DateTime END_TIME { get; set; }
    }
}
