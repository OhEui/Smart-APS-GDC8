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
    public partial class SETUP_TIME : Form
    {
        List<SetupVO> SetupList;
        ServiceHelp srv = new ServiceHelp();
        List<LineVO> Lineinfo;
        List<ComboItemVO> list = null;

        //public List<SetupVO> GetSetup_time()
        //{
        //    EQUIPDAC dac = new EQUIPDAC();
        //    return dac.GetSetup_time();
        //}

        public SETUP_TIME()
        {
            InitializeComponent();
            if (UserInfoStorage.Current.Auth_ID == 3)
            {
                BtnAdd.Visible = BtnEdit.Visible = BtnDelete.Visible = false;
            }
            title.Text = "교체준비관리";
        }

        private void SETUP_TIME_Load(object sender, EventArgs e)
        {
            combobinding();
            DataLoad();
        }

       

        private async void combobinding()
        {
            
            Lineinfo = await srv.GetListAsync("api/EQUIPMENT/Linelist", Lineinfo);
            list = await srv.GetListAsync("api/Step/getComboItem", list);
            CommonUtil.ComboBinding(cboGroup, list, "STD_STEP_ID");
            CommonUtil.ComboBinding(cboStep, list, "STD_STEP_ID" );
            CommonUtil.ComboBinding(cboLine, Lineinfo, "LINE_ID", "LINE_ID");
            CommonUtil.ComboBinding(cboSite, Lineinfo, "SITE_ID", "SITE_ID");

        }

        private async void dgvLoad()
        {
            dgvSetup.DataSource = null;
            SetupList = await srv.GetListAsync("api/SETUP_TIME/SetupList", SetupList);
            dgvSetup.DataSource = SetupList;
        }

        private void DataLoad()
        {
            DataGridViewUtil.SetInitGridView(dgvSetup);
            DataGridViewUtil.AddGridTextColumn(dgvSetup, Properties.Resources.SITE_ID, "SITE_ID", colWidth: 150, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextColumn(dgvSetup, Properties.Resources.LINE_ID, "LINE_ID", colWidth: 150, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextColumn(dgvSetup, Properties.Resources.EQP_GROUP, "EQP_GROUP", colWidth: 150, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextColumn(dgvSetup, Properties.Resources.STEP_ID, "STEP_ID", colWidth: 150, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextColumn(dgvSetup, Properties.Resources.TIME, "TIME", colWidth: 100, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextColumn(dgvSetup, "수정자", "user_id", colWidth: 100, visibility:false);
            dgvLoad();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if ((cboGroup.Text == "") && (cboStep.Text == "") && (cboLine.Text == "") && (cboSite.Text == "") )
            {
                MessageBox.Show("항목을 선택해주세요.");

                return;
            }
            getSearchSetUpList();
        }

        private void getSearchSetUpList()  // 검색함수
        {
            dgvSetup.DataSource = null;
            dgvSetup.DataSource = SetupList.FindAll(p => p.EQP_GROUP.Contains(cboGroup.Text) && p.STEP_ID.Contains(cboStep.Text) && p.LINE_ID.Contains(cboLine.Text) && p.SITE_ID.Contains(cboSite.Text));
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvSetup.DataSource = null;
            cboGroup.SelectedIndex = 0;
            cboStep.SelectedIndex = 0;
            cboLine.SelectedIndex = 0;
            cboSite.SelectedIndex = 0;
            dgvLoad();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SETUP_REG frm = new SETUP_REG();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
            dgvLoad();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (temp != null)
            {
                SetupVO vo = new SetupVO();

                vo.SITE_ID = dgvSetup.Rows[temp.RowIndex].Cells[0].Value.ToString();
                vo.LINE_ID = dgvSetup.Rows[temp.RowIndex].Cells[1].Value.ToString();
                vo.EQP_GROUP = dgvSetup.Rows[temp.RowIndex].Cells[2].Value.ToString();
                vo.STEP_ID = dgvSetup.Rows[temp.RowIndex].Cells[3].Value.ToString();
                vo.TIME = Convert.ToInt32(dgvSetup.Rows[temp.RowIndex].Cells[4].Value.ToString());

                

                SETUP_REG frm = new SETUP_REG(vo);
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
                dgvLoad();
            }
            else
            {
                MessageBox.Show("수정할 설비를 선택해주세요");
            }
        }
        DataGridViewCellEventArgs temp;

        
        private void dgvSetup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            temp = e;
        }

        private async void pictureBox6_Click(object sender, EventArgs e)
        {
            if (temp != null)
            {
                string curSite = (Convert.ToString(dgvSetup.Rows[temp.RowIndex].Cells[0].Value));
                string curLine = (Convert.ToString(dgvSetup.Rows[temp.RowIndex].Cells[1].Value));
                string curEQPGroup = (Convert.ToString(dgvSetup.Rows[temp.RowIndex].Cells[2].Value));
                string curStep = (Convert.ToString(dgvSetup.Rows[temp.RowIndex].Cells[3].Value));

                SetupVO cursetup = SetupList.Find(p => p.SITE_ID == curSite && p.LINE_ID == curLine && p.EQP_GROUP == curEQPGroup && p.STEP_ID == curStep);


                if (MessageBox.Show($"{curSite}/ {curLine} / {curEQPGroup} / {curStep} 항목을 삭제 하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string DeleteStr = $"api/SETUP_TIME/DelSetup?SITE_ID={curSite}&LINE_ID={curLine}&EQP_GROUP={curEQPGroup}&STEP_ID={curStep}";
                    
                    WebMessage msg = await srv.GetAsync(DeleteStr);

                    if (msg.IsSuccess)
                    {
                        dgvLoad();
                    }
                    MessageBox.Show(msg.ResultMessage);
                }
            }
            else
            {
                MessageBox.Show("삭제할 항목을 선택해주세요");
            }
        }
    }
}
