using APSDAC;
using APSVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APSWinForm
{
	public partial class STDSTEP_REG : Form
	{
		List<STD_STEP_VO> stepList;
		bool existStepID = false;

		public STDSTEP_REG()
		{
			InitializeComponent();
		}

		private void STDSTEP_REG_Load(object sender, EventArgs e)
		{
			using (STD_STEP_DAC dac = new STD_STEP_DAC())
			{
				stepList = dac.getStepInfoList();
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			isNotWhiteSpace();

			STD_STEP_VO newStep = new STD_STEP_VO
			{
				STD_STEP_ID = txtStepID.Text,
				STD_STEP_NAME = txtStepName.Text,
				STEP_YIELD = Convert.ToInt32(txtYield.Text),
				STEP_TAT = Convert.ToInt32(txtTAT.Text),
				STEP_SETUP = Convert.ToInt32(txtStepSetup.Text)
			};

			using (STD_STEP_DAC dac = new STD_STEP_DAC())
			{
				if (dac.insertStepInfoList(newStep))
				{
					DialogResult dlgResult = MessageBox.Show("추가가 완료되었습니다.\n계속하시겠습니까?", $"{Properties.Resources.STD_STEP_INFO} 추가", MessageBoxButtons.YesNo);
					this.DialogResult = DialogResult.OK;

					if(dlgResult == DialogResult.OK)
					{
						txtStepID.Text = txtStepName.Text = txtStepSetup.Text = txtTAT.Text = txtYield.Text = "";
						txtStepID.Focus();
					}
					else
					{
						this.Close();
					}
				}
				else
				{
					MessageBox.Show("추가 중 오류가 발생했습니다.\n다시 시도하여 주세요.");
					return;
				}
			}
		}

		private void capitalTextBox1_Leave(object sender, EventArgs e)
		{
			//STD_STEP_ID 중복검사

			var stepID = stepList.Find(p => p.STD_STEP_ID == txtStepID.Text);

			if (stepID != null)
			{
				lblStepIDExist.Visible = true;
				existStepID = false;
			}
			else
				existStepID = true;
		}

		public void isNotWhiteSpace()
		{
			//유효성 검사

			if (!existStepID)
			{
				txtStepID.Focus();
				return;
			}

			
		}
	}
}
