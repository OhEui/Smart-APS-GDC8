
using APSUtil.Http;
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
	public partial class STDSTEP_REG : frmBaseIcon
	{
		ServiceHelp srv = new ServiceHelp();
		List<STD_STEP_VO> stepList;
		bool existStepID = false;

		public STDSTEP_REG()
		{
			InitializeComponent();
			this.MaximizeBox = false;
		}

		public STDSTEP_REG(STD_STEP_VO stepInfo)
		{
			InitializeComponent();
			this.MaximizeBox = false;
			txtStepID.Text = stepInfo.STD_STEP_ID;
			txtStepName.Text = stepInfo.STD_STEP_NAME;
			txtStepSetup.Text = stepInfo.STEP_SETUP.ToString();
			txtTAT.Text = stepInfo.STEP_TAT.ToString();
			txtYield.Text = stepInfo.STEP_YIELD.ToString();

			txtStepID.Enabled = false;
			existStepID = true;
		}

		private async void STDSTEP_REG_Load(object sender, EventArgs e)
		{
			stepList = await srv.GetListAsync("api/Step/getStepInfoList", stepList);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private async void btnAdd_Click(object sender, EventArgs e)
		{
			//추가/수정

			if (!isNotWhiteSpace())
			{
				return;
			}

			STD_STEP_VO newStep = new STD_STEP_VO
			{
				STD_STEP_ID = txtStepID.Text,
				STD_STEP_NAME = txtStepName.Text,
				STEP_YIELD = Convert.ToDouble(txtYield.Text),
				STEP_TAT = Convert.ToInt32(txtTAT.Text),
				STEP_SETUP = Convert.ToInt32(txtStepSetup.Text),
				user_id = UserInfoStorage.Current.ID
			};

			WebMessage msg = await srv.PostAsyncNone("api/Step/saveStdStep", newStep);

			if (msg.IsSuccess)
			{
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			MessageBox.Show(msg.ResultMessage);
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
				lblStepIDExist.Visible = false;
			    existStepID = true;
		}

		public bool isNotWhiteSpace()
		{
			//유효성 검사
			if (!existStepID || string.IsNullOrWhiteSpace(txtStepID.Text) || string.IsNullOrWhiteSpace(txtStepName.Text) || string.IsNullOrWhiteSpace(txtStepSetup.Text) ||
				string.IsNullOrWhiteSpace(txtTAT.Text) || string.IsNullOrWhiteSpace(txtYield.Text))
			{
				txtStepID.Focus();
				return false;
			}
			else return true;
			
		}
	}
}
