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
    public partial class EQUIPMENT : Form
    {
        List<EQUIPVO> list;

        public class EQUIPVO
        {
            public string SITE_ID { get; set; }
            public string LINE_ID { get; set; }
            public string EQP_ID { get; set; }
            public string EQP_MODEL { get; set; }
            public string EQP_GROUP { get; set; }
        }

        
        public EQUIPMENT()
        {
            InitializeComponent();
        }

        private void EQUIPMENT_Load(object sender, EventArgs e)
        {
            DataLoad();

        }

        private void DataLoad()
        {
            
                DataGridViewUtil.AddGridTextColumn(dgvEQP, "사이트ID", "SITE_ID", colWidth: 105);
                DataGridViewUtil.AddGridTextColumn(dgvEQP, "라인ID", "LINE_ID", colWidth: 105);
                DataGridViewUtil.AddGridTextColumn(dgvEQP, "설비ID", "EQP_ID", colWidth: 105);
                DataGridViewUtil.AddGridTextColumn(dgvEQP, "공정모델명", "EQP_MODEL", colWidth: 100);
                DataGridViewUtil.AddGridTextColumn(dgvEQP, "공정처리그룹", "EQP_GROUP", colWidth: 100);

                
             
            
        }
    }
}
