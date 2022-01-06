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
        ServiceHelp srv;
        List<ProductVO> productvo = null;

        public frmPRODUCT()
        {
            InitializeComponent();
        }

        
        private async Task LoadData()
        {
            List<ProductVO> list = null;
            list = await srv.GetListAsync("api/Product/Products", list);
            dgvPR.DataSource = list;
        }

        private async void DataLode()
        {
            DataGridViewUtil.SetInitGridView(dgvPR);
            DataGridViewUtil.AddGridTextColumn(dgvPR, "제품ID", "PRODUCT_ID", colWidth: 105);
            DataGridViewUtil.AddGridTextColumn(dgvPR, "제품타입", "PRODUCT_TYPE", colWidth: 100);
            DataGridViewUtil.AddGridTextColumn(dgvPR, "제품이름", "PRODUCT_NAME", colWidth: 105);
            DataGridViewUtil.AddGridTextColumn(dgvPR, "프로세스ID", "PROCESS_ID", colWidth: 105);
            DataGridViewUtil.AddGridTextColumn(dgvPR, "생산단위크기", "LOT_SIZE", colWidth: 100);

            await LoadData();
        }
        private void frmPRODUCT_Load(object sender, EventArgs e)
        {
            MainForm frm = MdiParent as MainForm;
            srv = new ServiceHelp("", frm.AuthHeader);
            DataLode();
        }

        //추가
        private async void toolStripButton3_Click(object sender, EventArgs e)
        {
            Productpop reg = new Productpop();

            if (reg.ShowDialog() == DialogResult.OK)
            {
                await LoadData();
            }
            else return;
        }

        

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        //수정
        private async void toolStripButton2_Click(object sender, EventArgs e)
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
                await LoadData();
            }
            else return;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            bool bResult = ExcelUtil.ExportExcelToList(dgvPR.DataSource as List<ProductVO>, @".\product.xlsx", "");
            if (bResult)
                MessageBox.Show("저장하였습니다.");
        }
    }
}
