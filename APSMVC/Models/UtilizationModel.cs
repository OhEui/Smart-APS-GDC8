using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using APSVO;

namespace APSMVC.Models
{
    public class UtilizationModel
    {
        public SelectList VersionNoList { get; set; }
        public SelectList MachineStateList { get; set; }
        public string CurrentMachineState { get; set; }
        public Dictionary<string, List<ResUtilizationData>>  ChartDictionary { get; set; }
    }

}