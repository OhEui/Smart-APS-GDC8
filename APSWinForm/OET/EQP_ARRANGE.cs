using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APSDAC;
using APSVO;

namespace APSWinForm
{
    public partial class EQP_ARRANGE : Form
    {
        List<EqpArrangeVO> list;
        public EQP_ARRANGE()
        {
            InitializeComponent();
        }
        
        public List<EqpArrangeVO> GetEqipmentARR()
        {
            EQUIPDAC dac = new EQUIPDAC();
            return dac.GetEqipmentARR();
        }

        private void EQP_ARRANGE_Load(object sender, EventArgs e)
        {
            DataLoad();
            
        }

        private void DataLoad()
        {
            DataGridViewUtil.AddGridTextColumn(dataGridView1, "품목ID", "PRODUCT_ID",colWidth: 130);
            DataGridViewUtil.AddGridTextColumn(dataGridView1, "프로세스ID", "PROCESS_ID", colWidth: 130);
            DataGridViewUtil.AddGridTextColumn(dataGridView1, "공정ID", "STEP_ID", colWidth: 90);
            DataGridViewUtil.AddGridTextColumn(dataGridView1, "설비ID", "EQP_ID", colWidth: 90);
            DataGridViewUtil.AddGridTextColumn(dataGridView1, "공정소요시간", "TACT_TIME", colWidth: 130);
            DataGridViewUtil.AddGridTextColumn(dataGridView1, "프로세스처리시간", "PROC_TIME", colWidth: 130);

            
            dataGridView1.DataSource = list = GetEqipmentARR();

            
        }

        
    }
}
