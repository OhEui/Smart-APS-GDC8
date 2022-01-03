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
    public partial class EQUIPMENT : Form
    {
        List<EQUIPVO> EQPlist = null;
        List<STD_STEP_VO> stepList = null;
        ServiceHelp srv = new ServiceHelp("");



        

        //public void DeleteEquip(string id)
        //{
        //    EQUIPDAC dac = new EQUIPDAC();
        //    dac.DeleteEquip(id);
        //}

        public EQUIPMENT()
        {
            InitializeComponent();
        }

        private void EQUIPMENT_Load(object sender, EventArgs e)
        {
            combobinding();
            DataLoad();

        }

        private async void combobinding()
        {
            stepList = await srv.GetListAsync("api/Step/getStepInfoList", stepList);
            CommonUtil.ComboBinding(cboEQPgroup, stepList, "STD_STEP_ID", "STD_STEP_NAME", "선택");

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
            DataGridViewUtil.AddGridTextColumn(dgvEQP, "설비ID", "EQP_ID", colWidth: 105);
            DataGridViewUtil.AddGridTextColumn(dgvEQP, "공정모델명", "EQP_MODEL", colWidth: 100);
            DataGridViewUtil.AddGridTextColumn(dgvEQP, "사이트ID", "SITE_ID", colWidth: 105);
            DataGridViewUtil.AddGridTextColumn(dgvEQP, "라인ID", "LINE_ID", colWidth: 105);
            DataGridViewUtil.AddGridTextColumn(dgvEQP, "설비처리그룹", "EQP_GROUP", colWidth: 100);

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
        private  void getSearchEqpList()  // 검색함수
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
        private void dgvEQP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            temp = e;
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {

            //if (temp != null)
            //{
            //    if (MessageBox.Show("정말 삭제하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //    {

            //        DeleteEquip(Convert.ToString(dgvEQP.Rows[temp.RowIndex].Cells[0].Value));
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("삭제할 설비를 선택해주세요");
            //}
            //dgvLoad();
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
