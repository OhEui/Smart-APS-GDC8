﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSVO
{
    public class ReqEQPGantt 
    {
        public string[] EQP_ID { get; set; }
        public string[] EQP_GROUP { get; set; }
        public string[] PRODUCT_ID { get; set; }
        public DateTime? Start_Date { get; set; }
        public DateTime? End_Date { get; set; }
    }
    public class ResEQPGantt
    {
        public string EQP_ID { get; set; }
        public string MACHINE_STATE { get; set; }
        public string PROCESS_ID { get; set; }
        public string LOT_ID { get; set; }
        public DateTime START_TIME { get; set; }
        public DateTime END_TIME { get; set; }
    }
}
