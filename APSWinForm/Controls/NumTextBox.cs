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
	public partial class NumTextBox : TextBox
	{
		public NumTextBox()
		{
			InitializeComponent();
		}

		protected override void OnPaint(PaintEventArgs pe)
		{
			base.OnPaint(pe);
		}

		protected void NumTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			//숫자만 입력되도록 필터링
			if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == 46))
			{//숫자, 백스페이스, 마침표 제외 나머지 처리
				e.Handled = true;
			}
		}
	}
}
