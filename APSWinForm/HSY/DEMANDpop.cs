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
    public partial class DEMANDpop : frmBaseIcon
    {
        ServiceHelp srv = new ServiceHelp();
        List<ComboItemVO> list;

        public DEMANDpop()
        {
            InitializeComponent();
        }

        public DEMANDpop(DemandVO demdInfo)
        {
            InitializeComponent();

            txtID.Text = demdInfo.DEMAND_ID;
            txtVer.Text = demdInfo.DEMAND_VER;
            txtQTY.Text = demdInfo.DEMAND_QTY.ToString();
            txtdate.Text = demdInfo.DUE_DATE.ToString();
            cboCID.Text = demdInfo.CUSTOMER_ID;
            cboPID.Text = demdInfo.PRODUCT_ID;

            txtID.Enabled = false;
        }

        public async void Combobinding()
        {
            list = await srv.GetListAsync("api/Common/CommonCode", list);
            CommonUtil.ComboBinding(cboPID, list, "PRODUCT_ID");
            CommonUtil.ComboBinding(cboCID, list, "CUSTOMER_ID");

        }

        private async void button7_Click(object sender, EventArgs e)
        {
            DemandVO demandVO = new DemandVO
            {
                DEMAND_VER = txtVer.Text,
                DEMAND_ID = txtID.Text,
                PRODUCT_ID = cboPID.Text,
                CUSTOMER_ID = cboCID.Text,
                DUE_DATE = DateTime.Parse(txtdate.Text),
                DEMAND_QTY = Convert.ToInt32(txtQTY.Text)
            };

            WebMessage wmsg = await srv.PostAsyncNone("api/Demand/SaveDemand", demandVO);

            if (wmsg.IsSuccess)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            MessageBox.Show(wmsg.ResultMessage);
        }

        private async void DEMANDpop_Load(object sender, EventArgs e)
        {
            Combobinding();
            list = await srv.GetListAsync("api/Demand/AllList", list);
        }


        private void txtQTY_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
