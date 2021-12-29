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
			DataGridViewUtil.AddGridTextColumn(dgvStepInfoList, Properties.Resources.STD_STEP_ID, "STD_STEP_ID");
			DataGridViewUtil.AddGridTextColumn(dgvStepInfoList, Properties.Resources.STD_STEP_NAME, "STD_STEP_NAME");
			DataGridViewUtil.AddGridTextColumn(dgvStepInfoList, Properties.Resources.STEP_TAT, "STEP_TAT");
			DataGridViewUtil.AddGridTextColumn(dgvStepInfoList, Properties.Resources.STEP_YIELD, "STEP_YIELD");
			DataGridViewUtil.AddGridTextColumn(dgvStepInfoList, Properties.Resources.STEP_SETUP, "STEP_SETUP");


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
			dgvStepInfoList.DataSource = stepList.FindAll(p => p.STD_STEP_ID.Contains(txtStepID.Text.ToUpper()) || p.STD_STEP_NAME.Contains(txtStepName.Text.ToUpper()));
		}

		private void btnInit_Click(object sender, EventArgs e)
		{
			txtStepID.Text = txtStepName.Text = null;

			LoadData();
			
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			STDSTEP_REG reg = new STDSTEP_REG();

			if (reg.ShowDialog() == DialogResult.OK)
			{
				LoadData();
			}
			else return;
		}
	}
}
