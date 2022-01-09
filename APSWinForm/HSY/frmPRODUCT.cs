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
        List<ProductVO> list = null;

        public frmPRODUCT()
        {
            InitializeComponent();
        }

        private async void LoadData()
        {
            list = await srv.GetListAsync("api/Product/Products", list);
            dgvPR.DataSource = list;
        }

        private void frmPRODUCT_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitGridView(dgvPR);
            DataGridViewUtil.AddGridTextColumn(dgvPR, "제품ID", "PRODUCT_ID", colWidth: 105);
            DataGridViewUtil.AddGridTextColumn(dgvPR, "제품타입", "PRODUCT_TYPE", colWidth: 105);
            DataGridViewUtil.AddGridTextColumn(dgvPR, "제품이름", "PRODUCT_NAME", colWidth: 105);
            DataGridViewUtil.AddGridTextColumn(dgvPR, "프로세스ID", "PROCESS_ID", colWidth: 105);
            DataGridViewUtil.AddGridTextColumn(dgvPR, "생산단위크기", "LOT_SIZE", colWidth: 105);

            LoadData();
        }

        //검색
        private void button7_Click(object sender, EventArgs e)
        {
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
        private async void dgvPR_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string prodID = dgvPR[0, e.RowIndex].Value.ToString();
            ProductVO user = null;
            user = await srv.GetAsync($"api/Product/{prodID}", user);
            if (user != null)
            {
                lblUserID.Text = user.PRODUCT_ID;
            }
        }

        private async void toolStripButton1_Click(object sender, EventArgs e)
        {
            string prod = dgvPR["PRODUCT_ID", dgvPR.CurrentRow.Index].Value.ToString();
            if (MessageBox.Show($"{prod} 항목을 삭제 하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                await srv.GetAsync($"api/Product/Deleteboard/{lblUserID.Text}");
            }

            LoadData();
        }
    }
}