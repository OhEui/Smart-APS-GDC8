using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSVO
{
	public class LOTGanttData
	{
		public string LOT_ID { get; set; }
		public string PRODUCT_ID { get; set; }
		public DateTime START_TIME { get; set; }
		public DateTime END_TIME { get; set; }
	}

	public class LOTGanttCategory
	{
		public string category { get; set; }
	}
}
