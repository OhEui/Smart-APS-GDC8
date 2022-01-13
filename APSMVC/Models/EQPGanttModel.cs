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

    }
    public class CategoryElement
    {
        public string category { get; set; }
        public CategoryElement(string category)
        {
            this.category = category;
        }
    }
}