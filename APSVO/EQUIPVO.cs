﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSVO
{
   
        public class EQUIPVO
        {
            public string SITE_ID { get; set; }
            public string LINE_ID { get; set; }
            public string EQP_ID { get; set; }
            public string EQP_MODEL { get; set; }
            public string EQP_GROUP { get; set; }

            public string user_id { get; set; }

    }
        public class EqpArrangeVO
        {
            public string PRODUCT_ID { get; set; }
            public string PROCESS_ID { get; set; }
            public string STEP_ID { get; set; }
            public string EQP_ID { get; set; }
            public int TACT_TIME { get; set; }
            public int PROC_TIME { get; set; }

        public string user_id { get; set; }
    }
        public class SetupVO
        {
            public string SITE_ID { get; set; }
            public string LINE_ID { get; set; }
            public string EQP_GROUP { get; set; }
            public string STEP_ID { get; set; }
            public int TIME { get; set; }

        public string user_id { get; set; }

    }
        public class EqpGroupVO
        {
        public string STD_STEP_ID { get; set; }
        public string STD_STEP_NAME { get; set; }
        public int STEP_TAT { get; set; }
       

        }

         public class LineVO
         {
        public string SITE_ID { get; set; }
        public string LINE_ID { get; set; }
        public string LINE_NAME { get; set; }


          }



}
