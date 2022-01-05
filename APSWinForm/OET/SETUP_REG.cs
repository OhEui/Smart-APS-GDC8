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
        ServiceHelp srv = new ServiceHelp("");
        List<LineVO> Lineinfo;
        List<ComboItemVO> list = null;
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
            
            Lineinfo = await srv.GetListAsync("api/EQUIPMENT/Linelist", Lineinfo);
            list = await srv.GetListAsync("api/Step/getComboItem", list);
            CommonUtil.ComboBinding(cboGroup, list, "STD_STEP_ID");
            CommonUtil.ComboBinding(cboStep, list, "STD_STEP_ID");
            CommonUtil.ComboBinding(cboLine, Lineinfo, "LINE_ID", "LINE_ID");
            CommonUtil.ComboBinding(cboSite, Lineinfo, "SITE_ID", "SITE_ID");
            Modify();
        }
        private void Modify()
        {
            if (SetupVO != null)
            {
                txtGroup.Visible = true;
                txtLine.Visible = true;
                txtSite.Visible = true;
                txtStep.Visible = true;
                cboLine.Text = SetupVO.LINE_ID;
                cboSite.Text = SetupVO.SITE_ID;
                cboGroup.Text = SetupVO.EQP_GROUP;
                cboStep.Text = SetupVO.STEP_ID;
                txtLine.Text = SetupVO.LINE_ID;
                txtSite.Text = SetupVO.SITE_ID;
                txtStep.Text = SetupVO.STEP_ID;
                txtGroup.Text = SetupVO.EQP_GROUP;
                numTime.Text = Convert.ToString(SetupVO.TIME);
            }
        }

        private void SETUP_REG_Load(object sender, EventArgs e)
        {
            combobinding();
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
                    vo.STEP_ID = cboStep.Text.Trim();
                    vo.TIME = Convert.ToInt32(numTime.Text.Trim());
                    vo.user_id = "test";
                    WebMessage msg = await srv.PostAsyncNone("api/SETUP_TIME/SetupNew", vo);


                    if (msg.IsSuccess)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    MessageBox.Show(msg.ResultMessage);

                }
                else
                {
                    newvo.LINE_ID = cboLine.Text.Trim();
                    newvo.SITE_ID = cboSite.Text.Trim();
                    newvo.EQP_GROUP = cboGroup.Text.Trim();
                    newvo.STEP_ID = cboStep.Text.Trim();
                    newvo.TIME = Convert.ToInt32(numTime.Text.Trim());
                    newvo.user_id = "test";
                    WebMessage msg = await srv.PostAsyncNone("api/SETUP_TIME/SetupNew", newvo);

                        
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
