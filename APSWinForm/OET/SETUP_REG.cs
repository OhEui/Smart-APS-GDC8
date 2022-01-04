using System;
using System.Collections.Generic;
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
    public partial class SETUP_REG : Form
    {
        SetupVO SetupVO;
        List<SetupVO> SetupList;
        ServiceHelp srv = new ServiceHelp("");
        List<STD_STEP_VO> eqpgroup;
        List<LineVO> Lineinfo;
        public SETUP_REG()
        {
            InitializeComponent();
        }

        public SETUP_REG(SetupVO vo)
        {
            InitializeComponent();
            this.SetupVO = vo;
        }

        private async void combobinding()
        {
            eqpgroup = await srv.GetListAsync("api/Step/getStepInfoList", eqpgroup);
            Lineinfo = await srv.GetListAsync("api/EQUIPMENT/Linelist", Lineinfo);
            CommonUtil.ComboBinding(cboGroup, eqpgroup, "STD_STEP_NAME", "STD_STEP_NAME");
            CommonUtil.ComboBinding(cboStep, eqpgroup, "STD_STEP_ID", "STD_STEP_ID");
            CommonUtil.ComboBinding(cboLine, Lineinfo, "LINE_ID", "LINE_ID");
            CommonUtil.ComboBinding(cboSite, Lineinfo, "SITE_ID", "SITE_ID");

        }
        private void SETUP_REG_Load(object sender, EventArgs e)
        {
            if (SetupVO != null)
            {
                cboLine.Text = SetupVO.LINE_ID;
                cboSite.Text = SetupVO.SITE_ID;
                cboGroup.Text = SetupVO.EQP_GROUP;
                cboStep.Text = SetupVO.STEP_ID;
                numTime.Text = SetupVO.SITE_ID;
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            SetupVO newvo = new SetupVO();

            if (cboLine.Text.Trim() != "" &&
              cboSite.Text.Trim() != "" &&
              cboGroup.Text.Trim() != "" &&
              cboStep.Text.Trim() != "" &&
              numTime.Text.Trim() != "")

            {
                SetupVO vo = new SetupVO();
                if (vo != null)
                {
                    vo.LINE_ID = cboLine.Text.Trim();
                    vo.SITE_ID = cboSite.Text.Trim();
                    vo.EQP_GROUP = cboGroup.Text.Trim();
                    vo.SITE_ID = cboStep.Text.Trim();
                    vo.TIME = Convert.ToInt32(numTime.Text.Trim());

                    WebMessage msg = await srv.PostAsyncNone("api/EQUIPMENT/EQPUpdate", vo);


                    if (msg.IsSuccess)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    MessageBox.Show(msg.ResultMessage);

                }
                else
                {
                    vo.LINE_ID = cboLine.Text.Trim();
                    vo.SITE_ID = cboSite.Text.Trim();
                    vo.EQP_GROUP = cboGroup.Text.Trim();
                    vo.SITE_ID = cboStep.Text.Trim();
                    vo.TIME = Convert.ToInt32(numTime.Text.Trim());

                    WebMessage msg = await srv.PostAsyncNone("api/EQUIPMENT/EQPnew", newvo);


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
