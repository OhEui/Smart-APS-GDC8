using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APSVO;
using APSDAC;

namespace APSWinForm
{
    public partial class frmPRODUCT : Form
    {
        ServiceHelp srv = new ServiceHelp("");
        List<ProductVO> productvo = null;

        public frmPRODUCT()
        {
            InitializeComponent();
        }

        
        private async void LoadData()
        {
            List<ProductVO> list = null;
            list = await srv.GetListAsync("api/Product/Products", list);
            dgvPR.DataSource = list;
        }

        private async void DataLode()
        {
            DataGridViewUtil.SetInitGridView(dgvPR);
            DataGridViewUtil.AddGridTextColumn(dgvPR, "설비ID", "PRODUCT_ID", colWidth: 105);
            DataGridViewUtil.AddGridTextColumn(dgvPR, "공정모델명", "PRODUCT_TYPE", colWidth: 100);
            DataGridViewUtil.AddGridTextColumn(dgvPR, "사이트ID", "PRODUCT_NAME", colWidth: 105);
            DataGridViewUtil.AddGridTextColumn(dgvPR, "라인ID", "PROCESS_ID", colWidth: 105);
            DataGridViewUtil.AddGridTextColumn(dgvPR, "공정처리그룹", "LOT_SIZE", colWidth: 100);

            LoadData();
        }
        private void frmPRODUCT_Load(object sender, EventArgs e)
        {
            DataLode();
        }

        //추가
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Productpop reg = new Productpop();

            if (reg.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
            else return;
        }

        

        private async void button7_Click(object sender, EventArgs e)
        {
            
        }

        //수정
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            string prd = dgvPR["PRODUCT_ID", dgvPR.CurrentRow.Index].Value.ToString();
            if (prd == null)
            {
                MessageBox.Show("수정할 항목을 선택해주세요.");
                return;
            }

            ProductVO prodinfo = productvo.Find(p => p.PRODUCT_ID == prd);

            Productpop reg = new Productpop(prodinfo);

            if (reg.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
            else return;
        }
    }
}
