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
    public partial class EQUIPMENT_REG : frmBaseIcon
    {
        ServiceHelp srv = new ServiceHelp();
        EQUIPVO EQPvo;
        List<ComboItemVO> list;
        List<LineVO> Lineinfo;
        List<EQUIPVO> EQPlist;
        bool existEQPID = false;
        public EQUIPMENT_REG()
        {
            InitializeComponent();
            existEQPID = true;
            txtEqpID.ImeMode = ImeMode.Disable;
            txtEqpID.CharacterCasing = CharacterCasing.Upper;
            this.MaximizeBox = false;
        }
        public EQUIPMENT_REG(EQUIPVO vo)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.EQPvo = vo;
        }

        
        //public void UpdateEquip(EQUIPVO vo)
        //{
        //    EQUIPDAC dac = new EQUIPDAC();
        //    dac.UpdateEquip(vo);
        //}

        public async void Combobinding()
        {
            list = await srv.GetListAsync("api/Common/CommonCode", list);
            Lineinfo = await srv.GetListAsync("api/EQUIPMENT/Linelist", Lineinfo);
            //Lineinfo = await srv.GetListAsync("api/EQUIPMENT/Linelist", Lineinfo);
            //Siteinfo = await srv.GetListAsync("api/EQUIPMENT/Linelist", Siteinfo)
            CommonUtil.ComboBinding(cboSiteID, Lineinfo, "SITE_ID", "SITE_ID");
            CommonUtil.ComboBinding(cboLineID, Lineinfo, "LINE_ID", "LINE_ID");
            CommonUtil.ComboBinding(cboEqpGroup, list, "STD_STEP_ID" , blankText: "선택");
            //CommonUtil.ComboBinding(cboLineID, list, "LINE_ID", blankText: "선택");
            //CommonUtil.ComboBinding(cboSiteID, list, "SITE_ID", blankText: "선택");
            EQPlist = await srv.GetListAsync("api/EQUIPMENT/EQPlist", EQPlist);
            Modify();
        }


        private  void EQUIPMENT_REG_Load(object sender, EventArgs e)
        {
            Combobinding();
            
            
        }

        private void Modify()
        {
            if (EQPvo != null)
            {
                txtEQPIDM.Visible = true;
                txtEQPIDM.Text = EQPvo.EQP_ID;
                txtEqpID.Text = EQPvo.EQP_ID;
                txtEqpmodel.Text = EQPvo.EQP_MODEL;
                cboEqpGroup.SelectedValue = EQPvo.EQP_GROUP;
                cboLineID.SelectedValue = EQPvo.LINE_ID;
                cboSiteID.SelectedValue = EQPvo.SITE_ID;
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
                    vo.EQP_GROUP = cboEqpGroup.SelectedValue.ToString();
                    vo.LINE_ID = cboLineID.SelectedValue.ToString();
                    vo.SITE_ID = cboSiteID.SelectedValue.ToString();
                    vo.user_id = "test";
                    WebMessage msg = await srv.PostAsyncNone("api/EQUIPMENT/EQPnew", vo);
                    var EQPID = EQPlist.Find(p => p.EQP_ID == txtEqpID.Text);

                    if (EQPID != null)
                    {
                        MessageBox.Show("중복되는 데이터입니다.다른 데이터를 입력해주십시오");
                        return;
                    }
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
                    newvo.EQP_GROUP = cboEqpGroup.SelectedValue.ToString();
                    newvo.LINE_ID = cboLineID.SelectedValue.ToString();
                    newvo.SITE_ID = cboSiteID.SelectedValue.ToString();
                    newvo.user_id = "test";

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

        private void txtEqpID_Leave(object sender, EventArgs e)
        {
            var EQPID = EQPlist.Find(p => p.EQP_ID == txtEqpID.Text);

            if (EQPID != null)
            {
                lblExist.Visible = true;
                existEQPID = false;
                this.ActiveControl = txtEqpID;
            }
            else
                lblExist.Visible = false;
                existEQPID = true;
        }
    }
}
