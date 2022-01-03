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
using APSDAC;

namespace APSWinForm
{
    public partial class EQP_ARRANGE : Form
    {
        List<EqpArrangeVO> ARRList= null;
        ServiceHelp srv = new ServiceHelp("");
        List<ProductVO> ProductList = null;
        List<ProductVO> ProcessList = null;
        List<EQUIPVO> EQPList = null;

        //public List<EqpArrangeVO> GetEquipmentARR()
        //{
        //    EQUIPDAC dac = new EQUIPDAC();
        //    return dac.GetEqipmentARR();
        //}

        public EQP_ARRANGE()
        {
            InitializeComponent();
        }
        
        

        private void EQP_ARRANGE_Load(object sender, EventArgs e)
        {
            combobinding();
            DataLoad();
            
        }

        

        private async void combobinding()
        {
            ProductList = await srv.GetListAsync("api/Product/Products", ProductList);
            ProcessList = await srv.GetListAsync("api/Product/Products", ProcessList);
            EQPList = await srv.GetListAsync("api/EQUIPMENT/EQPlist", EQPList);
            CommonUtil.ComboBinding(cboProduct, ProductList, "PRODUCT_ID", "PRODUCT_NAME", "");
            CommonUtil.ComboBinding(cboProcess, ProcessList, "PRODUCT_ID", "PROCESS_ID", "");
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
            DataGridViewUtil.AddGridTextColumn(dgvEQP, "품목ID", "PRODUCT_ID",colWidth: 130);
            DataGridViewUtil.AddGridTextColumn(dgvEQP, "프로세스ID", "PROCESS_ID", colWidth: 130);
            DataGridViewUtil.AddGridTextColumn(dgvEQP, "공정ID", "STEP_ID", colWidth: 90);
            DataGridViewUtil.AddGridTextColumn(dgvEQP, "설비ID", "EQP_ID", colWidth: 90);
            DataGridViewUtil.AddGridTextColumn(dgvEQP, "공정소요시간", "TACT_TIME", colWidth: 130);
            DataGridViewUtil.AddGridTextColumn(dgvEQP, "프로세스처리시간", "PROC_TIME", colWidth: 130);


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
        private void getSearchEqpList()  // 검색함수 보류
        {
            dgvEQP.DataSource = null;
            dgvEQP.DataSource = ARRList.FindAll(p => p.PRODUCT_ID.Contains(cboProduct.Text) && p.PROCESS_ID.Contains(cboProcess.Text) && p.EQP_ID.Contains(cboEQP.Text));
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

       
    }
}
