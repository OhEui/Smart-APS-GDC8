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
    public partial class LineInfopop : frmBaseIcon
    {
        ServiceHelp srv = new ServiceHelp();
        List<Line_Info_VO> list;
        bool existLID = false;
        Line_Info_VO linevo;


        public LineInfopop()
        {
            InitializeComponent();
            existLID = true;
            this.MaximizeBox = false;
            txtLID.ImeMode = ImeMode.Disable;
            txtLID.CharacterCasing = CharacterCasing.Upper;
        }

        public LineInfopop(Line_Info_VO lineinfo)
        {
            InitializeComponent();
            this.linevo = lineinfo;
            txtLID.Enabled = false;
            this.MaximizeBox = false;
        }

        private void Modify()
        {
            if (linevo != null)
            {
                txtLID.Text = linevo.LINE_ID;
                txtName.Text = linevo.LINE_NAME;
                txtSID.Text = linevo.SITE_ID;
               
            }
        }

        private async void button7_Click(object sender, EventArgs e)
        {
            if (!isNotWhiteSpace())
            {
                return;
            }

            Line_Info_VO lineinfovo = new Line_Info_VO
            {
                SITE_ID = txtSID.Text,
                LINE_ID = txtLID.Text,
                LINE_NAME = txtName.Text,
                user_id = "test"
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
            Modify();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtLID_Leave(object sender, EventArgs e)
        {
            var ProdID = list.Find(p => p.LINE_ID == txtLID.Text);

            if (ProdID != null)
            {
                lblExist.Visible = true;
                existLID = false;
                this.ActiveControl = txtLID;
            }
            else

                existLID = true;
        }

        public bool isNotWhiteSpace()
        {
            //유효성 검사
            if (!existLID || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSID.Text) || string.IsNullOrWhiteSpace(txtLID.Text))
            {
                txtLID.Focus();
                return false;

            }
            return true;

        }
    }
}
