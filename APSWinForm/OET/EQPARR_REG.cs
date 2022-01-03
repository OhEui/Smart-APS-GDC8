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
    public partial class EQPARR_REG : Form
    {
        ServiceHelp srv = new ServiceHelp("");
        EqpArrangeVO EQPArrvo;



        public EQPARR_REG()
        {
            InitializeComponent();
        }

        public EQPARR_REG(EqpArrangeVO vo)
        {
            InitializeComponent();
            this.EQPArrvo = vo;
        }

        private void EQPARR_REG_Load(object sender, EventArgs e)
        {
            if (EQPArrvo != null)
            {
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



                    WebMessage msg = await srv.PostAsyncNone("api/EQUIPMENT/EQPArrUpdate", vo);


                    if (msg.IsSuccess)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    MessageBox.Show(msg.ResultMessage);

                }
                else
                {
                    newvo.EQP_ID = cboEQP.Text.Trim();
                    newvo.PRODUCT_ID = cboProduct.Text.Trim();
                    newvo.PROCESS_ID = cboProcess.Text.Trim();
                    newvo.STEP_ID = cboStep.Text.Trim();
                    newvo.TACT_TIME = Convert.ToInt32(numStep.Text.Trim());
                    newvo.PROC_TIME = Convert.ToInt32(numProcess.Text.Trim());

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

