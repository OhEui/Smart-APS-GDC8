using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APSWinForm;
using APSVO;
using APSUtil.Http;

namespace APSWinForm
{
    public partial class EQP_ARRANGE : frmBaseIcon
    {
        List<EqpArrangeVO> ARRList= null;
        ServiceHelp srv = new ServiceHelp();
        List<ComboItemVO> ProductList = null;
        List<ComboItemVO> ProcessList = null;
        List<EQUIPVO> EQPList = null;
        


        public EQP_ARRANGE()
        {
            InitializeComponent();
            if (UserInfoStorage.Current.Auth_ID == 3)
            {
                BtnAdd.Visible = BtnEdit.Visible = BtnDelete.Visible = false;
            }
            title.Text = "설비배치정보";

            
            
        }
        
        
        private void EQP_ARRANGE_Load(object sender, EventArgs e)
        {
            combobinding();
            DataLoad();
            
        }

        

        private async void combobinding()
        {
            
            ProductList = await srv.GetListAsync("api/Common/CommonCode", ProductList);
            ProcessList = await srv.GetListAsync("api/Common/CommonCode", ProcessList);
            EQPList = await srv.GetListAsync("api/EQUIPMENT/EQPlist", EQPList);
            CommonUtil.ComboBinding(cboProduct, ProductList, "PRODUCT_ID", blankText: "");
            CommonUtil.ComboBinding(cboProcess, ProcessList, "PROCESS_ID", blankText: "");
            CommonUtil.ComboBinding(cboEQP, EQPList, "EQP_ID", "EQP_MODEL", "");


        }

        private async void dgvLoad()
        {
            dgvEQP.DataSource = null;
            ARRList = await srv.GetListAsync("api/EQUIPMENT/ARRlist", ARRList);
            dgvEQP.DataSource = ARRList;
        }
        private void DataLoad()
        {
            DataGridViewUtil.SetInitGridView(dgvEQP);
            DataGridViewUtil.AddGridTextColumn(dgvEQP, Properties.Resources.PRODUCT_ID, "PRODUCT_ID",colWidth: 250, align: DataGridViewContentAlignment.MiddleLeft);
            DataGridViewUtil.AddGridTextColumn(dgvEQP, Properties.Resources.PROCESS_ID, "PROCESS_ID", colWidth: 300, align: DataGridViewContentAlignment.MiddleLeft);
            DataGridViewUtil.AddGridTextColumn(dgvEQP, Properties.Resources.STEP_ID, "STEP_ID", colWidth: 150, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextColumn(dgvEQP, Properties.Resources.EQP_ID, "EQP_ID", colWidth: 150, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextColumn(dgvEQP, Properties.Resources.TACT_TIME, "TACT_TIME", colWidth: 150,align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextColumn(dgvEQP, Properties.Resources.PROC_TIME, "PROC_TIME", colWidth: 150, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextColumn(dgvEQP, "수정자", "user_id", colWidth: 130,visibility:false);

            dgvLoad();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if ((cboProcess.Text == "") && (cboProduct.Text == "") && (cboEQP.Text == ""))
            {
                MessageBox.Show("항목을 선택해주세요.");

                return;
            }
            getSearchEqpList();
        }
        private void getSearchEqpList()  // 검색함수
        {
            dgvEQP.DataSource = null;
           
            dgvEQP.DataSource = ARRList.FindAll(p => (p.PRODUCT_ID.Contains(cboProduct.Text) && p.PROCESS_ID.Contains(cboProcess.Text)) && (p.PROCESS_ID.Contains(cboProcess.Text) && p.EQP_ID.Contains(cboEQP.Text))
                                                       && (p.PRODUCT_ID.Contains(cboProduct.Text) && p.EQP_ID.Contains(cboEQP.Text)));
             
        
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvEQP.DataSource = null;
            cboProduct.SelectedIndex = 0;
            cboProcess.SelectedIndex = 0;
            cboEQP.SelectedIndex = 0;
            dgvLoad();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EQPARR_REG frm = new EQPARR_REG();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
            dgvLoad();
        }


        DataGridViewCellEventArgs temp;

        private void dgvEQP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            temp = e;
        }
        

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (temp != null)
            {
                EqpArrangeVO vo = new EqpArrangeVO();

                vo.PRODUCT_ID = dgvEQP.Rows[temp.RowIndex].Cells[0].Value.ToString();
                vo.PROCESS_ID = dgvEQP.Rows[temp.RowIndex].Cells[1].Value.ToString();
                vo.STEP_ID = dgvEQP.Rows[temp.RowIndex].Cells[2].Value.ToString();
                vo.EQP_ID = dgvEQP.Rows[temp.RowIndex].Cells[3].Value.ToString();
                vo.TACT_TIME = Convert.ToInt32(dgvEQP.Rows[temp.RowIndex].Cells[4].Value.ToString());
                vo.PROC_TIME = Convert.ToInt32(dgvEQP.Rows[temp.RowIndex].Cells[5].Value.ToString());
                EQPARR_REG frm = new EQPARR_REG(vo);
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
                dgvLoad();
                
            }
            else
            {
                MessageBox.Show("수정할 설비를 선택해주세요");
            }
        }

        private async void pictureBox6_Click(object sender, EventArgs e)
        {
            if (temp != null)
            {
                string curProduct = (Convert.ToString(dgvEQP.Rows[temp.RowIndex].Cells[0].Value));
                string curProcess = (Convert.ToString(dgvEQP.Rows[temp.RowIndex].Cells[1].Value));
                string curStep = (Convert.ToString(dgvEQP.Rows[temp.RowIndex].Cells[2].Value));
                string curEQP = (Convert.ToString(dgvEQP.Rows[temp.RowIndex].Cells[3].Value));

                EqpArrangeVO curEQPARR = ARRList.Find(p => p.PRODUCT_ID == curProduct && p.PROCESS_ID == curProcess && p.STEP_ID == curStep && p.EQP_ID == curEQP);

                string deleteMsg = DBInfoStorage.GetDeleteMessage("EQP_ARRANGE", $"{curProduct}/ {curStep} / {curEQP}")
    ?? $"{curProduct}/ {curStep} / {curEQP}항목을 삭제 하시겠습니까?";
                if (MessageBox.Show(deleteMsg, "삭제 확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string DeleteStr = $"api/EQUIPMENT/DelEQPARR?PRODUCT_ID={curProduct}&PROCESS_ID={curProcess}&STEP_ID={curStep}&EQP_ID={curEQP}";
                    //WebMessage msg = await srv.GetAsync($"api/EQUIPMENT/DelEQPARR/{EQPARRID}}");
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
                MessageBox.Show("삭제할 설비를 선택해주세요");
            }
        }

        private void XlsDown_Click(object sender, EventArgs e)
        {
            bool bResult = ExcelUtil.ExportExcelToList(dgvEQP.DataSource as List<EqpArrangeVO>);
                if (bResult)
                MessageBox.Show("저장하였습니다.");
        }
    }
}
