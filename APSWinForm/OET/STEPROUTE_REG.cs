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
	public partial class STEPROUTE_REG : Form
	{
		ServiceHelp srv = new ServiceHelp("");
		List<StepRouteVO> stepRouteList = null;

		public STEPROUTE_REG()
		{
			InitializeComponent();
		}

		private async void STEPROUTE_REG_Load(object sender, EventArgs e)
		{
			DataGridViewUtil.SetInitGridView(dgvStepRoute);
			DataGridViewUtil.AddGridTextColumn(dgvStepRoute, Properties.Resources.PROCESS_ID, "PROCESS_ID", colWidth: 145);
			DataGridViewUtil.AddGridTextColumn(dgvStepRoute, Properties.Resources.STEP_ID, "STEP_ID", colWidth: 145);
			DataGridViewUtil.AddGridTextColumn(dgvStepRoute, Properties.Resources.STEP_SEQ, "STEP_SEQ", align: DataGridViewContentAlignment.MiddleCenter, colWidth: 120);
			DataGridViewUtil.AddGridTextColumn(dgvStepRoute, Properties.Resources.STD_STEP_ID, "STD_STEP_ID", align: DataGridViewContentAlignment.MiddleCenter, colWidth: 145);
			DataGridViewUtil.AddGridTextColumn(dgvStepRoute, Properties.Resources.STEP_TYPE, "STEP_TYPE", align: DataGridViewContentAlignment.MiddleCenter, colWidth: 120);

			stepRouteList = await srv.GetListAsync("api/Step/getStepRouteList", stepRouteList);
			SetComboBox();
		}

		private async void SetComboBox()
		{
			List<ComboItemVO> list = null;
			list = await srv.GetListAsync("api/Step/getComboItem", list);

			CommonUtil.ComboBinding(cboStepType, list, "STEP_TYPE", blankText: "선택");
			CommonUtil.ComboBinding(cboProcessID, list, "PROCESS_ID", blankText: "직접입략");
			CommonUtil.ComboBinding(cboStdStep, list, "STD_STEP_ID", blankText: "선택");
		}

		private void cboProcessID_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(cboProcessID.SelectedIndex < 1)
			{
				txtProcessID.Enabled = true;
			}
			else
			{
				txtProcessID.Text = cboProcessID.SelectedValue.ToString();
				txtProcessID.Enabled = false;

				var list = stepRouteList.FindAll(p => p.PROCESS_ID == cboProcessID.SelectedValue.ToString());
				dgvStepRoute.DataSource = null;
				dgvStepRoute.DataSource = list;
			}
		}

	}
}
