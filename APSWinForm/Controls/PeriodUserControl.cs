using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APSWinForm
{
    public enum PeriodType { OneDay, ThreeDay, OneWeek, OneMonth, ThreeMonth, SixMonth }

    public partial class PeriodUserControl : UserControl
    {
        /// <summary>
        /// Period 속성의 기본값
        /// </summary>
        const PeriodType DEFAULT_PERIOD = PeriodType.OneMonth;

        [Browsable(true)]
        [Category("Custom")]
        [Description("기간을 설정합니다")]
        [DefaultValue(DEFAULT_PERIOD)]
        public PeriodType Period
        {
            get => (PeriodType)cboPeriod.SelectedIndex;
            set => cboPeriod.SelectedIndex = (int)value;
        }

        /// <summary>
        /// 설정된 기간의 시작일을 가져옵니다.
        /// </summary>
        /// 
        [Browsable(true)]
        [Category("Custom")]
        [Description("설정된 기간의 시작일입니다.")]
        public DateTime From
        {
            get { return dtpFrom.Value; }
        }

        /// <summary>
        /// 설정된 기간의 종료일을 가져옵니다.
        /// </summary>
        [Browsable(true)]
        [Category("Custom")]
        [Description("설정된 기간의 종료일입니다.")]
        public DateTime To
        {
            get { return dtpTo.Value; }
        }

        public PeriodUserControl()
        {
            InitializeComponent();
            Period = DEFAULT_PERIOD; 
        }

        private void PeriodUserControl_Load(object sender, EventArgs e)
        {
            Init();
        }
        
        /// <summary>
        /// 컨트롤의 값을 초기값으로 설정합니다
        /// </summary>
        public void Init()
        {
            dtpTo.Value = DateTime.Now;
            Period = DEFAULT_PERIOD;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {            
            switch (cboPeriod.Text)
            {
                case "1일":
                    dtpFrom.Value = dtpTo.Value.AddDays(-1); break;
                case "3일":
                    dtpFrom.Value = dtpTo.Value.AddDays(-3); break;
                case "1주일":
                    dtpFrom.Value = dtpTo.Value.AddDays(-7); break;
                case "1개월":
                    dtpFrom.Value = dtpTo.Value.AddMonths(-1); break;
                case "3개월":
                    dtpFrom.Value = dtpTo.Value.AddMonths(-3); break;
                case "6개월":
                    dtpFrom.Value = dtpTo.Value.AddMonths(-6); break;
            }
        }


    }
}
