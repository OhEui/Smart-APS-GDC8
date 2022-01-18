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
    public partial class frmLineInfo : Form
    {
        ServiceHelp srv = new ServiceHelp();
        List<Line_Info_VO> list = null;

        public frmLineInfo()
        {
            InitializeComponent();
        }

        private async void LoadData()
        {
            list = await srv.GetListAsync("api/LineInfo/AllList", list);
            dgvLI.DataSource = list;
        }

        private void frmLineInfo_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitGridView(dgvLI);
            DataGridViewUtil.AddGridTextColumn(dgvLI, "현장ID", "SITE_ID", colWidth: 110, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextColumn(dgvLI, "라인ID", "LINE_ID", colWidth: 110, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextColumn(dgvLI, "라인이름", "LINE_NAME", colWidth: 120);

            LoadData();
        }


        //추가
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            LineInfopop reg = new LineInfopop();

            if (reg.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
            else return;
        }

        //수정
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            string line = dgvLI["LINE_ID", dgvLI.CurrentRow.Index].Value.ToString();
            if (line == null)
            {
                MessageBox.Show("수정할 항목을 선택해주세요.");
                return;
            }
            Line_Info_VO LineInfo = list.Find(p => p.LINE_ID == line);
            LineInfopop reg = new LineInfopop(LineInfo);

            if (reg.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
            else return;
        }

        //삭제
        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvLI.SelectedRows.Count < 1)
            {
                MessageBox.Show("삭제할 라인을 선택하여 주세요.");
                return;
            }

            string lineID = dgvLI.SelectedRows[0].Cells["LINE_ID"].Value.ToString();

            if (MessageBox.Show("        정말 삭제하시겠습니까?", "라인삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                APSVO.WebMessage msg = await srv.GetAsync($"api/LineInfo/Delete/{lineID}");
                if (msg.IsSuccess)
                {
                    LoadData();
                }
                MessageBox.Show(msg.ResultMessage);
            }
        }

        //초기화
        private void button3_Click(object sender, EventArgs e)
        {
            txtLID.Text = txtSID.Text = null;

            LoadData();
        }

        //검색
        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLID.Text) && string.IsNullOrWhiteSpace(txtSID.Text))
            {
                MessageBox.Show("검색어를 입력해주세요.");
                txtLID.Focus();
                return;
            }

            dgvLI.DataSource = null;
            dgvLI.DataSource = list.FindAll(p => p.LINE_ID.Contains(txtLID.Text.ToUpper()) && p.SITE_ID.Contains(txtSID.Text.ToUpper()));
        
         }
    }
}
