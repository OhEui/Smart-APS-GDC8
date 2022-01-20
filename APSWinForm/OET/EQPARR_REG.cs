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
    public partial class EQPARR_REG : frmBaseIcon
    {
        ServiceHelp srv = new ServiceHelp();
        EqpArrangeVO EQPArrvo;
        // List<EqpArrangeVO> ARRList = null;
        List<ComboItemVO> ProductList = null;
        List<ComboItemVO> ProcessList = null;
        List<EQUIPVO> EQPList = null;
        List<EqpArrangeVO> EQPARRList = null;

        public EQPARR_REG()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        public EQPARR_REG(EqpArrangeVO vo)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.EQPArrvo = vo;
        }

        private void EQPARR_REG_Load(object sender, EventArgs e)
        {
            combobinding();
        }

        private async void combobinding()
        {

            ProductList = await srv.GetListAsync("api/Common/CommonCode", ProductList);
            ProcessList = await srv.GetListAsync("api/Common/CommonCode", ProcessList);
            EQPList = await srv.GetListAsync("api/EQUIPMENT/EQPlist", EQPList);
            CommonUtil.ComboBinding(cboProduct, ProductList, "PRODUCT_ID", blankText: "");
            CommonUtil.ComboBinding(cboProcess, ProcessList, "PROCESS_ID", blankText: "");
            CommonUtil.ComboBinding(cboStep, ProcessList, "STD_STEP_ID", blankText: "");
            CommonUtil.ComboBinding(cboEQP, EQPList, "EQP_ID", "EQP_MODEL", "");
            EQPARRList = await srv.GetListAsync("api/EQUIPMENT/ARRlist", EQPARRList);
            Modify();

        }
        private void Modify()
        {
            if (EQPArrvo != null)
            {
                txtEQP.Visible = true;
                txtProduct.Visible = true;
                txtProcess.Visible = true;
                txtStep.Visible = true;
                txtEQP.Text = EQPArrvo.EQP_ID;
                txtProduct.Text = EQPArrvo.PRODUCT_ID;
                txtProcess.Text = EQPArrvo.PROCESS_ID;
                txtStep.Text = EQPArrvo.STEP_ID;
                cboEQP.Text = EQPArrvo.EQP_ID;
                cboProduct.Text = EQPArrvo.PRODUCT_ID;
                cboProcess.Text = EQPArrvo.PROCESS_ID;
                cboStep.Text = EQPArrvo.STEP_ID;
                numStep.Value = EQPArrvo.TACT_TIME;
                numProcess.Value = EQPArrvo.PROC_TIME;
            }
}

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            EqpArrangeVO newvo = new EqpArrangeVO();

            if (cboEQP.Text.Trim() != "" &&
              cboProduct.Text.Trim() != "" &&
              cboProcess.Text.Trim() != "" &&
              cboStep.Text.Trim() != "" &&
              numStep.Text.Trim() != "" &&
              numProcess.Text.Trim() != "")

            {
                EqpArrangeVO vo = new EqpArrangeVO();
                if (vo != null)
                {
                    vo.EQP_ID = cboEQP.Text.Trim();
                    vo.PRODUCT_ID = cboProduct.Text.Trim();
                    vo.PROCESS_ID = cboProcess.Text.Trim();
                    vo.STEP_ID = cboStep.Text.Trim();
                    vo.TACT_TIME = Convert.ToInt32(numStep.Text.Trim());
                    vo.PROC_TIME = Convert.ToInt32(numProcess.Text.Trim());
                    vo.user_id = "test";

                    

                    WebMessage msg = await srv.PostAsyncNone("api/EQUIPMENT/EQPArrnew", vo);



                    if (msg.IsSuccess)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    MessageBox.Show(msg.ResultMessage);

                }
                else
                {
                    newvo.EQP_ID = txtEQP.Text.Trim();
                    newvo.PRODUCT_ID = txtProduct.Text.Trim();
                    newvo.PROCESS_ID = txtProcess.Text.Trim();
                    newvo.STEP_ID = txtStep.Text.Trim();
                    newvo.TACT_TIME = Convert.ToInt32(numStep.Text.Trim());
                    newvo.PROC_TIME = Convert.ToInt32(numProcess.Text.Trim());
                    newvo.user_id = "test";
                    WebMessage msg = await srv.PostAsyncNone("api/EQUIPMENT/EQPArrnew", newvo);

                   
                    if (msg.IsSuccess)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    MessageBox.Show(msg.ResultMessage);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("필수 사항을 모두 입력해주세요");
            }
        }
    }
}

