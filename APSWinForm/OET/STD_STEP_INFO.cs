using APSVO;
using APSDAC;
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
		List<STD_STEP_VO> stepList = null;

		public STD_STEP_INFO()
		{
			InitializeComponent();
		}

		private void STD_STEP_INFO_Load(object sender, EventArgs e)
		{
			DataGridViewUtil.SetInitGridView(dgvStepInfoList);
			DataGridViewUtil.AddGridTextColumn(dgvStepInfoList, Properties.Resources.STD_STEP_ID, "STD_STEP_ID", colWidth:145);
			DataGridViewUtil.AddGridTextColumn(dgvStepInfoList, Properties.Resources.STD_STEP_NAME, "STD_STEP_NAME", colWidth: 145);
			DataGridViewUtil.AddGridTextColumn(dgvStepInfoList, Properties.Resources.STEP_TAT, "STEP_TAT", align:DataGridViewContentAlignment.MiddleCenter, colWidth: 120);
			DataGridViewUtil.AddGridTextColumn(dgvStepInfoList, Properties.Resources.STEP_YIELD, "STEP_YIELD", align: DataGridViewContentAlignment.MiddleCenter, colWidth: 115);
			DataGridViewUtil.AddGridTextColumn(dgvStepInfoList, Properties.Resources.STEP_SETUP, "STEP_SETUP", align: DataGridViewContentAlignment.MiddleCenter, colWidth: 120);

			LoadData();
		}

		public void LoadData()
		{
			using (STD_STEP_DAC dac = new STD_STEP_DAC())
			{
				stepList = dac.getStepInfoList();
			}

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

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			//추가
			STDSTEP_REG reg = new STDSTEP_REG();

			if (reg.ShowDialog() == DialogResult.OK)
			{
				LoadData();
			}
			else return;
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			//수정
		}

		private void pictureBox6_Click(object sender, EventArgs e)
		{
			//삭제
			if (dgvStepInfoList.CurrentCell == null) return;

			string curStep = dgvStepInfoList["STD_STEP_ID", dgvStepInfoList.CurrentRow.Index].Value.ToString();

			DialogResult msgResullt = MessageBox.Show($"{curStep} 항목을 삭제 하시겠습니까?", $"{Properties.Resources.STD_STEP_INFO} 삭제", MessageBoxButtons.OKCancel);
			
			if (msgResullt == DialogResult.Cancel) return;
			else
			{
				using (STD_STEP_DAC dac = new STD_STEP_DAC())
				{
					if (dac.deleteStepInfoList(curStep))
					{
						MessageBox.Show("삭제가 완료되었습니다.");
					}
					else
					{
						MessageBox.Show("삭제 중 오류가 발생했습니다.\n다시 시도하여 주세요.");
						return;
					}
				}
			}

			LoadData();
		}
	}
}
