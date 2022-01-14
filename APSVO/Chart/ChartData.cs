using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSVO
{
    public class ChartData
    {
    
        public string category { get; set; } // y축 데이터 
        public string fromDate { get; set; } // "2018-01-01 15:30"
        public string toDate { get; set; } // "2018-01-01 15:30"
        public string task { get; set; } // bar위에 표시될 텍스트
        public int colorIdx { get; set; } = 0; // amchart colorset에서 color 가져올 때 사용하는 index값
        public double brighten { get; set; } = 0.4; // 0~1 사이의 값만 넣어야 함
    }
    public class ChartCommonData 
    {
        public List<ComboItemVO> ComboItemList { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
    }
}
