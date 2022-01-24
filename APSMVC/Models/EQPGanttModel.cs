using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APSMVC.Models
{
    public class EQPGanttModel
    {
        public SelectList EqpIDList { get; set; }
        public SelectList EqpGroupList { get; set; }
        public SelectList ProductIDList { get; set; }
        public List<CategoryElement> CategoryList { get; set; }
        public string ChartDataJson { get; set; }

        public Dictionary<string,object> DropDownAttributes { get; set; }
        public string[] QueryParameters { get; set; }

        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        public DateTime Min_Date { get; set; }
        public DateTime Max_Date { get; set; }
    }
}