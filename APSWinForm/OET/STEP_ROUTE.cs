using APSUtil.Http;
using APSVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APSWinForm
{
	public partial class STEP_ROUTE : frmBaseIcon
	{
		ServiceHelp srv = new ServiceHelp();
		List<StepRouteVO> stepRouteList = null;

		public STEP_ROUTE()
		{
			InitializeComponent();
			//if (UserInfoStorage.Current.Auth_ID == 3)
			//{
			//    BtnAdd.Visible = BtnDelete.Visible = BtnEdit.Visible = false;
			//}
		}

		private void STEP_ROUTE_Load(object sender, EventArgs e)
		{
			DataGridViewUtil.SetInitGridView(dgvStepRoute);
			DataGridViewUtil.AddGridTextColumn(dgvStepRoute, Properties.Resources.PROCESS_ID, "PROCESS_ID", align: DataGridViewContentAlignment.MiddleLeft, colWidth: 300);
			DataGridViewUtil.AddGridTextColumn(dgvStepRoute, Properties.Resources.STEP_ID, "STEP_ID", align: DataGridViewContentAlignment.MiddleCenter, colWidth: 200);
			DataGridViewUtil.AddGridTextColumn(dgvStepRoute, Properties.Resources.STEP_SEQ, "STEP_SEQ", align: DataGridViewContentAlignment.MiddleCenter, colWidth: 160);
			DataGridViewUtil.AddGridTextColumn(dgvStepRoute, Properties.Resources.STD_STEP_ID, "STD_STEP_ID", align: DataGridViewContentAlignment.MiddleCenter, colWidth: 200);
			DataGridViewUtil.AddGridTextColumn(dgvStepRoute, Properties.Resources.STEP_TYPE, "STEP_TYPE", align: DataGridViewContentAlignment.MiddleCenter, colWidth: 160);
			DataGridViewUtil.AddGridTextColumn(dgvStepRoute, Properties.Resources.STEP_TAT, "STEP_TAT", align: DataGridViewContentAlignment.MiddleCenter, colWidth: 140);
			
			SetComboBox();
			LoadData();
		}

		private async void LoadData()
		{
			stepRouteList = await srv.GetListAsync("api/Step/getStepRouteList", stepRouteList);

			dgvStepRoute.DataSource = null;
			dgvStepRoute.DataSource = stepRouteList;
		}

		private async void SetComboBox()
		{
			List<ComboItemVO> list = null;
			list = await srv.GetListAsync("api/Step/getStepType", list);

			CommonUtil.ComboBinding(cboStepType, list, "STEP_TYPE", blankText: "전체");
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtProcessID.Text) && string.IsNullOrWhiteSpace(txtStepID.Text) && cboStepType.SelectedIndex < 1)
			{
				if(cboStepType.SelectedIndex < 1)
				{
					dgvStepRoute.DataSource = null;
					dgvStepRoute.DataSource = stepRouteList;
					return;
				}
				else
				{
					MessageBox.Show("검색어를 입력해주세요.");
					txtProcessID.Focus();
					return;
				}
			}

			List<StepRouteVO> list = null;
			if (cboStepType.SelectedIndex < 1)
			{
				list = stepRouteList.FindAll(p => p.PROCESS_ID.ToLower().Contains(txtProcessID.Text.ToLower()) && p.STEP_ID.Contains(txtStepID.Text));
			}
			else
			{
				list = stepRouteList.FindAll(p => p.PROCESS_ID.ToLower().Contains(txtProcessID.Text.ToLower()) && p.STEP_ID.Contains(txtStepID.Text) && p.STEP_TYPE.Equals(cboStepType.SelectedValue));
			}

			dgvStepRoute.DataSource = null;
			dgvStepRoute.DataSource = list;
		}

		private void btnInit_Click(object sender, EventArgs e)
		{
			txtProcessID.Text = "";
			txtStepID.Text = "";
			cboStepType.SelectedIndex = 0;

			LoadData();
		}

		#region toolStrip
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			//추가
			STEPROUTE_REG reg = new STEPROUTE_REG();

			if (reg.ShowDialog() == DialogResult.OK)
			{
				LoadData();
			}
			else return;
		}

		private void BtnEdit_Click(object sender, EventArgs e)
		{
			//수정
			string curProcID = dgvStepRoute["PROCESS_ID", dgvStepRoute.CurrentRow.Index].Value.ToString();
			string curStepID = dgvStepRoute["STEP_ID", dgvStepRoute.CurrentRow.Index].Value.ToString();
			if (curProcID == null || curStepID == null)
			{
				MessageBox.Show("수정할 항목을 선택해주세요.");
				return;
			}

			StepRouteVO stepRoute = stepRouteList.Find(p => p.PROCESS_ID == curProcID && p.STEP_ID == curStepID);

			STEPROUTE_REG reg = new STEPROUTE_REG(stepRoute);

			if (reg.ShowDialog() == DialogResult.OK)
			{
				LoadData();
			}
			else return;
		}

		private async void BtnDelete_Click(object sender, EventArgs e)
		{
			//삭제
			if (dgvStepRoute.CurrentCell == null) return;

			string curProcID = dgvStepRoute["PROCESS_ID", dgvStepRoute.CurrentRow.Index].Value.ToString();
			string curStepID = dgvStepRoute["STEP_ID", dgvStepRoute.CurrentRow.Index].Value.ToString();

			StepRouteVO curStepRoute = stepRouteList.Find(p => p.PROCESS_ID == curProcID && p.STEP_ID == curStepID);

			DialogResult msgResullt = MessageBox.Show($"{curProcID} / {curStepID} 항목을 삭제 하시겠습니까?", $"{Properties.Resources.STD_STEP_INFO} 삭제", MessageBoxButtons.OKCancel);

			if (msgResullt == DialogResult.Cancel) return;
			else
			{
				string paramStr = $"api/Step/DelStepRoute?PROCESS_ID={curProcID}&STEP_ID={curStepID}";
				//WebMessage msg = await srv.GetAsync($"api/Step/DelStepRoute/{curStepRoute}");
				WebMessage msg = await srv.GetAsync(paramStr);

				if (msg.IsSuccess)
				{
					LoadData();
				}
				MessageBox.Show(msg.ResultMessage);
			}
		}

		private void XlsDown_Click(object sender, EventArgs e)
		{
			ExcelUtil.ExportExcelToList<StepRouteVO>((List<StepRouteVO>)dgvStepRoute.DataSource);
		}
		#endregion
	}
}
