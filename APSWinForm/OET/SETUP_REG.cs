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

        public SETUP_REG()
        {
            InitializeComponent();
        }

        public SETUP_REG(SetupVO vo)
        {
            InitializeComponent();
            this.SetupVO = vo;
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

    }
}
