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
        EQUIPVO EQPvo;
        public EQUIPMENT_REG()
        {
            InitializeComponent();
        }
        public EQUIPMENT_REG(EQUIPVO vo)
        {
            InitializeComponent();
            this.EQPvo = vo;
        }

        public List<EqpGroupVO> GetEqpGroup()
        {
            EQUIPDAC dac = new EQUIPDAC();
            return dac.GetEqpGroup();
        }

        public List<LineVO> GetLineInfo()
        {
            EQUIPDAC dac = new EQUIPDAC();
            return dac.GetLineInfo();
        }

        public void InsertEquip(EQUIPVO vo)
        {
            EQUIPDAC dac = new EQUIPDAC();
            dac.InsertEquip(vo);
        }

        public void UpdateEquip(EQUIPVO vo)
        {
            EQUIPDAC dac = new EQUIPDAC();
            dac.UpdateEquip(vo);
        }

        private void EQUIPMENT_REG_Load(object sender, EventArgs e)
        {
            CommonUtil.ComboBinding(cboEqpGroup, GetEqpGroup(), "STD_STEP_NAME", "STD_STEP_NAME");
            CommonUtil.ComboBinding(cboLineID, GetLineInfo(), "LINE_ID", "LINE_ID");
            CommonUtil.ComboBinding(cboSiteID, GetLineInfo(), "SITE_ID", "SITE_ID");
            cboEqpGroup.Text = "";
            cboLineID.Text = "";
            cboSiteID.Text = "";

            if (EQPvo != null)
            {
                txtEqpID.Text = EQPvo.EQP_ID;
                txtEqpmodel.Text = EQPvo.EQP_MODEL;
                cboEqpGroup.Text = EQPvo.EQP_GROUP;
                cboLineID.Text = EQPvo.LINE_ID;
                cboSiteID.Text = EQPvo.SITE_ID;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
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

                    UpdateEquip(vo);

                    MessageBox.Show("성공적으로 수정되었습니다");
                    
                }
                else
                {
                    newvo.EQP_ID = txtEqpID.Text.Trim();
                    newvo.EQP_MODEL = txtEqpmodel.Text.Trim();
                    newvo.EQP_GROUP = cboEqpGroup.Text.Trim();
                    newvo.LINE_ID = cboLineID.Text.Trim();
                    newvo.SITE_ID = cboSiteID.Text.Trim();

                    InsertEquip(newvo);

                    MessageBox.Show("성공적으로 등록되었습니다");
                    
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
