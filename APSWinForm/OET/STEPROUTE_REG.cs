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
	public partial class STEPROUTE_REG : frmBaseIcon
	{
		ServiceHelp srv = new ServiceHelp();
		List<StepRouteVO> stepRouteList = null;
		StepRouteVO modStepRoute = null;

		public STEPROUTE_REG()
		{
			InitializeComponent();
		}

		public STEPROUTE_REG(StepRouteVO stepRoute)
		{
			InitializeComponent();

			modStepRoute = stepRoute;
		}

		private async void STEPROUTE_REG_Load(object sender, EventArgs e)
		{
			DataGridViewUtil.SetInitGridView(dgvStepRoute);
			DataGridViewUtil.AddGridTextColumn(dgvStepRoute, Properties.Resources.PROCESS_ID, "PROCESS_ID", colWidth: 145);
			DataGridViewUtil.AddGridTextColumn(dgvStepRoute, Properties.Resources.STEP_ID, "STEP_ID", align: DataGridViewContentAlignment.MiddleCenter, colWidth: 120);
			DataGridViewUtil.AddGridTextColumn(dgvStepRoute, Properties.Resources.STEP_SEQ, "STEP_SEQ", align: DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
			DataGridViewUtil.AddGridTextColumn(dgvStepRoute, Properties.Resources.STD_STEP_ID, "STD_STEP_ID", align: DataGridViewContentAlignment.MiddleCenter, colWidth: 120);
			DataGridViewUtil.AddGridTextColumn(dgvStepRoute, Properties.Resources.STEP_TYPE, "STEP_TYPE", align: DataGridViewContentAlignment.MiddleCenter, colWidth: 100);
			DataGridViewUtil.AddGridTextColumn(dgvStepRoute, Properties.Resources.STEP_TAT, "STEP_TAT", align: DataGridViewContentAlignment.MiddleCenter, colWidth: 80);
			dgvStepRoute.RowHeadersVisible = false;

			stepRouteList = await srv.GetListAsync("api/Step/getStepRouteList", stepRouteList);
			SetComboBox();

			
		}

		private void modLoadSet()
		{
			if (modStepRoute == null) return;

			txtStepID.Text = modStepRoute.STEP_ID;
			txtStepSeq.Text = modStepRoute.STEP_SEQ.ToString();
			cboProcessID.SelectedValue = modStepRoute.PROCESS_ID;
			cboStepType.SelectedValue = modStepRoute.STEP_TYPE;
			cboStdStep.SelectedValue = modStepRoute.STD_STEP_ID;
		}

		private async void SetComboBox()
		{
			List<ComboItemVO> list = null;
			list = await srv.GetListAsync("api/Step/getComboItem", list);

			CommonUtil.ComboBinding(cboProcessID, list, "PROCESS_ID", blankText: "선택");
			CommonUtil.ComboBinding(cboStepType, list, "STEP_TYPE", blankText: "선택");
			CommonUtil.ComboBinding(cboStdStep, list, "STD_STEP_ID", blankText: "선택");

			//수정 시 콤보박스 변경
			modLoadSet();
		}

		private void cboProcessID_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(cboProcessID.SelectedIndex < 1)
			{
				dgvStepRoute.DataSource = null;
			}
			else
			{
				var list = stepRouteList.FindAll(p => p.PROCESS_ID == cboProcessID.SelectedValue.ToString());
				dgvStepRoute.DataSource = null;
				dgvStepRoute.DataSource = list;
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private async void btnSave_Click(object sender, EventArgs e)
		{
			StepRouteVO newStep;

			if (!isNotNull()) return;

			if (cboStepType.SelectedValue.ToString() == "--")
			{
				newStep = new StepRouteVO
				{
					PROCESS_ID = cboProcessID.SelectedValue.ToString(),
					STEP_ID = txtStepID.Text,
					STEP_SEQ = Convert.ToInt32(txtStepSeq.Text),
					STD_STEP_ID = cboStdStep.SelectedValue.ToString(),
					STEP_TYPE = null,
					user_id = UserInfoStorage.Current.ID
				};
			}
			else
			{
				newStep = new StepRouteVO
				{
					PROCESS_ID = cboProcessID.SelectedValue.ToString(),
					STEP_ID = txtStepID.Text,
					STEP_SEQ = Convert.ToInt32(txtStepSeq.Text),
					STD_STEP_ID = cboStdStep.SelectedValue.ToString(),
					STEP_TYPE = cboStepType.SelectedValue.ToString(),
					user_id = "Test"
				};
			}

			WebMessage msg = await srv.PostAsyncNone("api/Step/saveStepRoute", newStep);

			if (msg.IsSuccess)
			{
				//this.DialogResult = DialogResult.OK;
				stepRouteList = await srv.GetListAsync("api/Step/getStepRouteList", stepRouteList);
			}

			if(MessageBox.Show(msg.ResultMessage+"\n계속하시겠습니까?", "수정/추가", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				cboProcessID_SelectedIndexChanged(null, null);
				cboStepType.SelectedIndex = 0;
				cboStdStep.SelectedIndex = 0;
				txtStepID.Text = "";
				txtStepSeq.Text = "";
			}
			else
			{
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
		}

		private bool isNotNull()
		{
			//유효성검사
			if (cboStdStep.SelectedIndex < 1 ||
				cboStepType.SelectedIndex < 1 ||
				cboProcessID.SelectedIndex < 1 ||
				string.IsNullOrWhiteSpace(txtStepID.Text) ||
				string.IsNullOrWhiteSpace(txtStepSeq.Text)) return false;
			else return true;
		}

		private void dgvStepRoute_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			txtStepID.Text = dgvStepRoute["STEP_ID", e.RowIndex].Value.ToString();
			txtStepSeq.Text = dgvStepRoute["STEP_SEQ", e.RowIndex].Value.ToString();
			cboStdStep.SelectedValue = dgvStepRoute["STD_STEP_ID", e.RowIndex].Value.ToString();
			cboStepType.SelectedValue = dgvStepRoute["STEP_TYPE", e.RowIndex].Value.ToString();
		}
	}
}
