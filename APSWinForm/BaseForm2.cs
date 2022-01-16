using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APSUtil.Http;
using APSVO;

namespace APSWinForm
{
    public partial class BaseForm2 : Form
    {
        public BaseForm2()
        {
            InitializeComponent();

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            for (int i = 1; i < dgv.Rows.Count; i++)
            {
                if (i % 2 != 0)
                {
                    dgv.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(240, 255, 240);
                }
                else
                {
                    dgv.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }


    }
}
