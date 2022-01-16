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
    public partial class frmDEMAND : Form
    {
        ServiceHelp srv = new ServiceHelp();
        List<DemandVO> list = null;


        public frmDEMAND()
        {
            InitializeComponent();
            //if (UserInfoStorage.Current.Auth_ID == 3)
            //{
            //    toolStripButton1.Visible = toolStripButton2.Visible = toolStripButton3.Visible = false;
            //}
        }

        private async void LoadData()
        {
            list = await srv.GetListAsync("api/Demand/AllList", list);
            dgvDM.DataSource = list;

        }

        private void frmDEMAND_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitGridView(dgvDM);
            DataGridViewUtil.AddGridTextColumn(dgvDM, "수요버전", "DEMAND_VER", colWidth: 105);
            DataGridViewUtil.AddGridTextColumn(dgvDM, "수요ID", "DEMAND_ID", colWidth: 105);
            DataGridViewUtil.AddGridTextColumn(dgvDM, "제품ID", "PRODUCT_ID", colWidth: 105);
            DataGridViewUtil.AddGridTextColumn(dgvDM, "고객ID", "CUSTOMER_ID", colWidth: 105);
            DataGridViewUtil.AddGridTextColumn(dgvDM, "기한", "DUE_DATE", colWidth: 105);
            DataGridViewUtil.AddGridTextColumn(dgvDM, "수량", "DEMAND_QTY", colWidth: 105);

            LoadData();
        }

        //검색
        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) && string.IsNullOrWhiteSpace(txtPR.Text) && string.IsNullOrWhiteSpace(txtCS.Text))
            {
                MessageBox.Show("검색어를 입력해주세요.");
                txtID.Focus();
                return;
            }

            dgvDM.DataSource = null;
            dgvDM.DataSource = list.FindAll(p => p.DEMAND_ID.Contains(txtID.Text.ToUpper()) && p.PRODUCT_ID.Contains(txtPR.Text.ToUpper()) && p.CUSTOMER_ID.Contains(txtCS.Text.ToUpper()));

        }

        //초기화
        private void button3_Click(object sender, EventArgs e)
        {
            txtID.Text = txtPR.Text = txtCS.Text = null;

            LoadData();
        }

        //추가
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DEMANDpop reg = new DEMANDpop();

            if (reg.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
            else return;
        }

        //수정
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            string demd = dgvDM["DEMAND_ID", dgvDM.CurrentRow.Index].Value.ToString();
            if (demd == null)
            {
                MessageBox.Show("수정할 항목을 선택해주세요.");
                return;
            }
            DemandVO demdInfo = list.Find(p => p.DEMAND_ID == demd);
            DEMANDpop reg = new DEMANDpop(demdInfo);

            if (reg.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
            else return;
        }

        //삭제
        private async void toolStripButton1_Click(object sender, EventArgs e)
        {
                if (dgvDM.SelectedRows.Count < 1)
                {
                    MessageBox.Show("삭제할 제품을 선택하여 주세요.");
                    return;
                }

                string demdID = dgvDM.SelectedRows[0].Cells["DEMAND_ID"].Value.ToString();

                if (MessageBox.Show("        정말 삭제하시겠습니까?", "제품삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    APSVO.WebMessage msg = await srv.GetAsync($"api/Demand/Delete/{demdID}");
                    if (msg.IsSuccess)
                    {
                        LoadData();
                    }
                    MessageBox.Show(msg.ResultMessage);
                }
        }
    }
}
