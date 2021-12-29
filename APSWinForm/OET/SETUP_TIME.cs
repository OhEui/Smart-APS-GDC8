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
    public partial class SETUP_TIME : Form
    {
        
        public SETUP_TIME()
        {
            InitializeComponent();
        }

        private void SETUP_TIME_Load(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void DataLoad()
        {
            DataGridViewUtil.AddGridTextColumn(dataGridView1, "사이트ID", "SITE_ID", colWidth: 70);
            DataGridViewUtil.AddGridTextColumn(dataGridView1, "라인ID", "LINE_ID", colWidth: 105);
            DataGridViewUtil.AddGridTextColumn(dataGridView1, "설비처리그룹", "EQP_GROUP", colWidth: 110);
            DataGridViewUtil.AddGridTextColumn(dataGridView1, "공정ID", "STEP_ID", colWidth: 105);
            DataGridViewUtil.AddGridTextColumn(dataGridView1, "소요시간", "TIME", colWidth: 100);

         
        }

        
    }
}
