using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APSUtil.Http;
using APSVO;


namespace APSWinForm
{
    public partial class frmPRODUCT : Form
    {
        ServiceHelp srv = new ServiceHelp();
        List<ProductVO> list = null;

        public frmPRODUCT()
        {
            InitializeComponent();
            //if (UserInfoStorage.Current.Auth_ID == 3)
            //{
            //    toolStripButton1.Visible = toolStripButton2.Visible = toolStripButton3.Visible = false;
            //}
        }

        private async void LoadData()
        {
            list = await srv.GetListAsync("api/Product/Products", list);
            dgvPR.DataSource = list;
        }

        private void DataLode() { }
        private void frmPRODUCT_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitGridView(dgvPR);
            DataGridViewUtil.AddGridTextColumn(dgvPR, "제품ID", "PRODUCT_ID", colWidth: 105);
            DataGridViewUtil.AddGridTextColumn(dgvPR, "제품타입", "PRODUCT_TYPE", colWidth: 100);
            DataGridViewUtil.AddGridTextColumn(dgvPR, "제품이름", "PRODUCT_NAME", colWidth: 105);
            DataGridViewUtil.AddGridTextColumn(dgvPR, "프로세스ID", "PROCESS_ID", colWidth: 105);
            DataGridViewUtil.AddGridTextColumn(dgvPR, "생산단위크기", "LOT_SIZE", colWidth: 100);
            
            LoadData();
        }

        //검색
        private void button7_Click(object sender, EventArgs e)
        {
            MainForm frm = MdiParent as MainForm;
            srv = new ServiceHelp();
            DataLode();
        
            if (string.IsNullOrWhiteSpace(txtID.Text) && string.IsNullOrWhiteSpace(txtPID.Text))
            {
                MessageBox.Show("검색어를 입력해주세요.");
                txtID.Focus();
                return;
            }

            dgvPR.DataSource = null;
            dgvPR.DataSource = list.FindAll(p => p.PRODUCT_ID.Contains(txtID.Text.ToUpper()) && p.PROCESS_ID.Contains(txtPID.Text.ToUpper()));
        }

        //초기화
        private void button3_Click(object sender, EventArgs e)
        {
            txtID.Text = txtPID.Text = null;

            LoadData();
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

        //수정
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            string prod = dgvPR["PRODUCT_ID", dgvPR.CurrentRow.Index].Value.ToString();
            if (prod == null)
            {
                MessageBox.Show("수정할 항목을 선택해주세요.");
                return;
            }
            ProductVO prodInfo = list.Find(p => p.PRODUCT_ID == prod);
            Productpop reg = new Productpop(prodInfo);

            if (reg.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
            else return;
        }
        

        //삭제
        private async void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dgvPR.SelectedRows.Count < 1)
            {
                MessageBox.Show("삭제할 제품을 선택하여 주세요.");
                return;
            }

            string prodID = dgvPR.SelectedRows[0].Cells["PRODUCT_ID"].Value.ToString();

            if (MessageBox.Show("        정말 삭제하시겠습니까?", "제품삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
            { 
                APSVO.WebMessage msg = await srv.GetAsync($"api/Product/Delete/{prodID}");
                if (msg.IsSuccess)
                {
                    LoadData();
                }
                MessageBox.Show(msg.ResultMessage);
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            bool bResult = ExcelUtil.ExportExcelToList(dgvPR.DataSource as List<ProductVO>, @".\product.xlsx", "");
            if (bResult)
                MessageBox.Show("저장하였습니다.");
        }
    }
}