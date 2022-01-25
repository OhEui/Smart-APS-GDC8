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
    public partial class frmPRODUCT : frmBaseIcon
    {
        ServiceHelp srv = new ServiceHelp();
        List<ProductVO> list = null;

        public frmPRODUCT()
        {
            InitializeComponent();
            if (UserInfoStorage.Current.Auth_ID == 3)
            {
                BtnAdd.Visible = BtnDelete.Visible = BtnEdit.Visible = false;
            }
        }

        private async void LoadData()
        {
            list = await srv.GetListAsync("api/Product/Products", list);
            dgvPR.DataSource = list;
        }

        private void frmPRODUCT_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitGridView(dgvPR);
            DataGridViewUtil.AddGridTextColumn(dgvPR, "제품ID", "PRODUCT_ID", colWidth: 190);
            DataGridViewUtil.AddGridTextColumn(dgvPR, "제품타입", "PRODUCT_TYPE", colWidth: 100, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextColumn(dgvPR, "제품이름", "PRODUCT_NAME", colWidth: 190);
            DataGridViewUtil.AddGridTextColumn(dgvPR, "프로세스ID", "PROCESS_ID", colWidth: 250);
            DataGridViewUtil.AddGridTextColumn(dgvPR, "생산단위크기", "LOT_SIZE", colWidth: 125, align: DataGridViewContentAlignment.MiddleCenter);
            
            LoadData();
        }

        #region toolstrip
        //추가
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Productpop reg = new Productpop();

            if (reg.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
            else return;
        }

        //수정
        private void BtnEdit_Click(object sender, EventArgs e)
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
        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPR.SelectedRows.Count < 1)
            {
                MessageBox.Show("삭제할 제품을 선택하여 주세요.");
                return;
            }

            string prodID = dgvPR.SelectedRows[0].Cells["PRODUCT_ID"].Value.ToString();

            if (MessageBox.Show("       정말 삭제하시겠습니까?", "제품삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                APSVO.WebMessage msg = await srv.GetAsync($"api/Product/Delete/{prodID}");
                if (msg.IsSuccess)
                {
                    LoadData();
                }
                MessageBox.Show(msg.ResultMessage);
            }
        }

        private void XlsDown_Click(object sender, EventArgs e)
        {
            //bool bResult = ExcelUtil.ExportExcelToList(dgvPR.DataSource as List<ProductVO>, @".\product.xlsx", "");
            //if (bResult)
            //    MessageBox.Show("저장하였습니다.");
        }

        #endregion

        #region 검색창
        //검색
        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) && string.IsNullOrWhiteSpace(txtID.Text) && string.IsNullOrWhiteSpace(txtPID.Text))
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

        //엔터
        private void txtID_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button7_Click(sender, e);
            }
        }

        private void txtPID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button7_Click(sender, e);
            }
        }
        #endregion

    }
}