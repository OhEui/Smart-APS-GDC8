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
	public partial class STEP_ROUTE : Form
	{
		ServiceHelp srv = new ServiceHelp("");
		List<StepRouteVO> stepRouteList = null;

		public STEP_ROUTE()
		{
			InitializeComponent();
		}

		private void STEP_ROUTE_Load(object sender, EventArgs e)
		{
			DataGridViewUtil.SetInitGridView(dgvStepRoute);
			DataGridViewUtil.AddGridTextColumn(dgvStepRoute, Properties.Resources.PROCESS_ID, "PROCESS_ID", colWidth: 145);
			DataGridViewUtil.AddGridTextColumn(dgvStepRoute, Properties.Resources.STEP_ID, "STEP_ID", colWidth: 145);
			DataGridViewUtil.AddGridTextColumn(dgvStepRoute, Properties.Resources.STEP_SEQ, "STEP_SEQ", align: DataGridViewContentAlignment.MiddleCenter, colWidth: 120);
			DataGridViewUtil.AddGridTextColumn(dgvStepRoute, Properties.Resources.STD_STEP_ID, "STD_STEP_ID", align: DataGridViewContentAlignment.MiddleCenter, colWidth: 115);
			DataGridViewUtil.AddGridTextColumn(dgvStepRoute, Properties.Resources.STEP_TYPE, "STEP_TYPE", align: DataGridViewContentAlignment.MiddleCenter, colWidth: 120);
			DataGridViewUtil.AddGridTextColumn(dgvStepRoute, Properties.Resources.STEP_SETUP, "user_id", align: DataGridViewContentAlignment.MiddleCenter, colWidth: 120);

			LoadData();
		}

		private async void LoadData()
		{
			stepRouteList = await srv.GetListAsync("api/Step/getStepRouteList", stepRouteList);
		}
	}
}
