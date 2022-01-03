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
    public partial class EQUIPMENT_REG : Form
    {
        ServiceHelp srv = new ServiceHelp("");
        EQUIPVO EQPvo;
        List<STD_STEP_VO> eqpgroup;
        List<LineVO> Lineinfo;
        
        public EQUIPMENT_REG()
        {
            InitializeComponent();
        }
        public EQUIPMENT_REG(EQUIPVO vo)
        {
            InitializeComponent();
            this.EQPvo = vo;
        }

        
        //public void UpdateEquip(EQUIPVO vo)
        //{
        //    EQUIPDAC dac = new EQUIPDAC();
        //    dac.UpdateEquip(vo);
        //}

        public async void Combobinding()
        {
            
            eqpgroup = await srv.GetListAsync("api/Step/getStepInfoList", eqpgroup);
            Lineinfo = await srv.GetListAsync("api/EQUIPMENT/Linelist", Lineinfo);
            CommonUtil.ComboBinding(cboEqpGroup, eqpgroup, "STD_STEP_NAME", "STD_STEP_NAME");
            CommonUtil.ComboBinding(cboLineID, Lineinfo, "LINE_ID", "LINE_ID");
            CommonUtil.ComboBinding(cboSiteID, Lineinfo, "SITE_ID", "SITE_ID");
            cboEqpGroup.Text = "";
            cboLineID.Text = "";
            cboSiteID.Text = "";
        }


        private  void EQUIPMENT_REG_Load(object sender, EventArgs e)
        {
            Combobinding();

            if (EQPvo != null)
            {
                txtEqpID.Text = EQPvo.EQP_ID;
                txtEqpmodel.Text = EQPvo.EQP_MODEL;
                cboEqpGroup.Text = EQPvo.EQP_GROUP;
                cboLineID.Text = EQPvo.LINE_ID;
                cboSiteID.Text = EQPvo.SITE_ID;
            }

        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            EQUIPVO newvo = new EQUIPVO();

            if (txtEqpID.Text.Trim() != "" &&
              txtEqpmodel.Text.Trim() != "" &&
              cboEqpGroup.Text.Trim() != "" &&
              cboLineID.Text.Trim() != "" &&
              cboSiteID.Text.Trim() != "")

            {
                EQUIPVO vo = new EQUIPVO();
                if (vo != null)
                {
                    vo.EQP_ID = txtEqpID.Text.Trim();
                    vo.EQP_MODEL = txtEqpmodel.Text.Trim();
                    vo.EQP_GROUP = cboEqpGroup.Text.Trim();
                    vo.LINE_ID = cboLineID.Text.Trim();
                    vo.SITE_ID = cboSiteID.Text.Trim();

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
                    newvo.EQP_ID = txtEqpID.Text.Trim();
                    newvo.EQP_MODEL = txtEqpmodel.Text.Trim();
                    newvo.EQP_GROUP = cboEqpGroup.Text.Trim();
                    newvo.LINE_ID = cboLineID.Text.Trim();
                    newvo.SITE_ID = cboSiteID.Text.Trim();

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
