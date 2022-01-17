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
	public partial class STD_STEP_INFO : Form
	{
		ServiceHelp srv = new ServiceHelp();
		List<STD_STEP_VO> stepList = null;

		public STD_STEP_INFO()
		{
			InitializeComponent();
			//if (UserInfoStorage.Current.Auth_ID == 3)
			//{
			//	pictureBox4.Visible = pictureBox5.Visible = pictureBox6.Visible = false;
			//}
		}

		private void STD_STEP_INFO_Load(object sender, EventArgs e)
		{
			DataGridViewUtil.SetInitGridView(dgvStepInfoList);
			DataGridViewUtil.AddGridTextColumn(dgvStepInfoList, Properties.Resources.STD_STEP_ID, "STD_STEP_ID", colWidth:180);
			DataGridViewUtil.AddGridTextColumn(dgvStepInfoList, Properties.Resources.STD_STEP_NAME, "STD_STEP_NAME", colWidth: 180);
			DataGridViewUtil.AddGridTextColumn(dgvStepInfoList, Properties.Resources.STEP_TAT, "STEP_TAT", align:DataGridViewContentAlignment.MiddleCenter, colWidth: 155);
			DataGridViewUtil.AddGridTextColumn(dgvStepInfoList, Properties.Resources.STEP_YIELD, "STEP_YIELD", align: DataGridViewContentAlignment.MiddleCenter, colWidth: 150);
			DataGridViewUtil.AddGridTextColumn(dgvStepInfoList, Properties.Resources.STEP_SETUP, "STEP_SETUP", align: DataGridViewContentAlignment.MiddleCenter, colWidth: 155);

			LoadData();
		}

		public async void LoadData()
		{
			stepList = await srv.GetListAsync("api/Step/getStepInfoList", stepList);

			dgvStepInfoList.DataSource = null;
			dgvStepInfoList.DataSource = stepList;
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			if(string.IsNullOrWhiteSpace(txtStepID.Text) && string.IsNullOrWhiteSpace(txtStepName.Text))
			{
				MessageBox.Show("검색어를 입력해주세요.");
				txtStepID.Focus();
				return;
			}

			dgvStepInfoList.DataSource = null;
			dgvStepInfoList.DataSource = stepList.FindAll(p => p.STD_STEP_ID.Contains(txtStepID.Text.ToUpper()) && p.STD_STEP_NAME.Contains(txtStepName.Text.ToUpper()));
		}

		private void btnInit_Click(object sender, EventArgs e)
		{
			txtStepID.Text = txtStepName.Text = null;

			LoadData();
		}

		#region toolStrip
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			//추가
			STDSTEP_REG reg = new STDSTEP_REG();

			if (reg.ShowDialog() == DialogResult.OK)
			{
				LoadData();
			}
			else return;
		}

		
		private void BtnEdit_Click(object sender, EventArgs e)
		{
			//수정
			string curStep = dgvStepInfoList["STD_STEP_ID", dgvStepInfoList.CurrentRow.Index].Value.ToString();
			if (curStep == null)
			{
				MessageBox.Show("수정할 항목을 선택해주세요.");
				return;
			}
			STD_STEP_VO stepInfo = stepList.Find(p => p.STD_STEP_ID == curStep);

			STDSTEP_REG reg = new STDSTEP_REG(stepInfo);

			if (reg.ShowDialog() == DialogResult.OK)
			{
				LoadData();
			}
			else return;
		}

		private async void BtnDelete_Click(object sender, EventArgs e)
		{
			//삭제
			if (dgvStepInfoList.CurrentCell == null) return;

			string curStep = dgvStepInfoList["STD_STEP_ID", dgvStepInfoList.CurrentRow.Index].Value.ToString();

			DialogResult msgResullt = MessageBox.Show($"{curStep} 항목을 삭제 하시겠습니까?", $"{Properties.Resources.STD_STEP_INFO} 삭제", MessageBoxButtons.OKCancel);

			if (msgResullt == DialogResult.Cancel) return;
			else
			{
				WebMessage msg = await srv.GetAsync($"api/Step/DelStepInfo/{curStep}");

				if (msg.IsSuccess)
				{
					LoadData();
				}
				MessageBox.Show(msg.ResultMessage);
			}
		}

		private void XlsDown_Click(object sender, EventArgs e)
		{
			ExcelUtil.ExportExcelToList<STD_STEP_VO>((List<STD_STEP_VO>)dgvStepInfoList.DataSource);
		}

		#endregion
	}
}
