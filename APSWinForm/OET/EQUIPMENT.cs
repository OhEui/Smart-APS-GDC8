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
    public partial class EQUIPMENT : frmBaseIcon
    {
        List<EQUIPVO> EQPlist = null;
        ServiceHelp srv = new ServiceHelp();
        List<ComboItemVO> list = null;




        //public void DeleteEquip(string id)
        //{
        //    EQUIPDAC dac = new EQUIPDAC();
        //    dac.DeleteEquip(id);
        //}

        public EQUIPMENT()
        {
            InitializeComponent();
            title.Text = "설비정보";
            if (UserInfoStorage.Current.Auth_ID == 3)
            {
                BtnAdd.Visible = BtnEdit.Visible = BtnDelete.Visible = false;
            }
        }

        private void EQUIPMENT_Load(object sender, EventArgs e)
        {
            combobinding();
            DataLoad();

        }
        

        private async void combobinding()
        {
          
            
            list = await srv.GetListAsync("api/Common/CommonCode", list);
            CommonUtil.ComboBinding(cboEQPgroup, list, "STD_STEP_ID");

        }

        private async void dgvLoad()
        {
            dgvEQP.DataSource = null;
            EQPlist = await srv.GetListAsync("api/EQUIPMENT/EQPlist", EQPlist);
            dgvEQP.DataSource = EQPlist;

           
        }

        private void DataLoad()
        {
            DataGridViewUtil.SetInitGridView(dgvEQP);
            DataGridViewUtil.AddGridTextColumn(dgvEQP, Properties.Resources.EQP_ID, "EQP_ID", colWidth: 200, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextColumn(dgvEQP, Properties.Resources.EQP_MODEL, "EQP_MODEL", colWidth: 200, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextColumn(dgvEQP, Properties.Resources.STEP_ID, "SITE_ID", colWidth: 200, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextColumn(dgvEQP, Properties.Resources.LINE_ID, "LINE_ID", colWidth: 200, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextColumn(dgvEQP, Properties.Resources.EQP_GROUP, "EQP_GROUP", colWidth: 200,align : DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextColumn(dgvEQP, "수정자", "user_id", colWidth: 100,visibility:false);
            dgvLoad();
            




        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSite.Text) && string.IsNullOrWhiteSpace(txtLine.Text) && (cboEQPgroup.Text == "선택"))
            {
                MessageBox.Show("검색어를 입력해주세요.");
                txtSite.Focus();
                return;
            }
            getSearchEqpList();
        }

        private void getSearchEqpList()  // 검색함수
        {
            dgvEQP.DataSource = null;
            dgvEQP.DataSource = EQPlist.FindAll(p => p.SITE_ID.Contains(txtSite.Text) && p.LINE_ID.Contains(txtLine.Text) && p.EQP_GROUP.Contains(cboEQPgroup.Text));
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvEQP.DataSource = null;
            txtLine.Clear();
            txtSite.Clear();
            cboEQPgroup.SelectedIndex = 0;
            dgvLoad();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            EQUIPMENT_REG frm = new EQUIPMENT_REG();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
            dgvLoad();
        }

        DataGridViewCellEventArgs temp;


        private void dgvEQP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            temp = e;
        }

        private async void btn_Delete_Click(object sender, EventArgs e)
        {

            if (temp != null)
            {
                string cur = (Convert.ToString(dgvEQP.Rows[temp.RowIndex].Cells[0].Value));

                if (MessageBox.Show($"{cur}항목을 삭제 하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    WebMessage msg = await srv.GetAsync($"api/EQUIPMENT/DelEQP/{cur}");

                    if (msg.IsSuccess)
                    {
                        dgvLoad();
                    }
                    MessageBox.Show(msg.ResultMessage);
                }
            }
            else
            {
                MessageBox.Show("삭제할 설비를 선택해주세요");
            }

        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            if (temp != null)
            {
                EQUIPVO vo = new EQUIPVO();

                vo.EQP_ID = dgvEQP.Rows[temp.RowIndex].Cells[0].Value.ToString();
                vo.EQP_MODEL = dgvEQP.Rows[temp.RowIndex].Cells[1].Value.ToString();
                vo.SITE_ID = dgvEQP.Rows[temp.RowIndex].Cells[2].Value.ToString();
                vo.LINE_ID = dgvEQP.Rows[temp.RowIndex].Cells[3].Value.ToString();
                vo.EQP_GROUP = dgvEQP.Rows[temp.RowIndex].Cells[4].Value.ToString();

                EQUIPMENT_REG frm = new EQUIPMENT_REG(vo);
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
                dgvLoad();
            }
            else
            {
                MessageBox.Show("수정할 설비를 선택해주세요");
            }
        }

       
    }
  
}
