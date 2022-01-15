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
    public partial class LineInfopop : Form
    {
        ServiceHelp srv = new ServiceHelp();
        List<Line_Info_VO> list;

        public LineInfopop()
        {
            InitializeComponent();
        }

        public LineInfopop(Line_Info_VO lineinfo)
        {
            InitializeComponent();

            txtLID.Text = lineinfo.SITE_ID;
            txtSID.Text = lineinfo.LINE_ID;
            txtName.Text = lineinfo.LINE_NAME;

            txtLID.Enabled = false;
        }

        private async void button7_Click(object sender, EventArgs e)
        {
            Line_Info_VO lineinfovo = new Line_Info_VO
            {
                SITE_ID = txtSID.Text,
                LINE_ID = txtLID.Text,
                LINE_NAME = txtName.Text,
            };

            WebMessage wmsg = await srv.PostAsyncNone("api/LineInfo/SaveLineInfo", lineinfovo);

            if (wmsg.IsSuccess)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            MessageBox.Show(wmsg.ResultMessage);
        }

        private async void LineInfopop_Load(object sender, EventArgs e)
        {
            list = await srv.GetListAsync("api/LineInfo/AllList", list);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
