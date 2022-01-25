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
        #region API
        readonly string DEMAND_SAVE = Properties.ResourceAPI.DEMAND_SAVE;
        #endregion

        ServiceHelp srv = new ServiceHelp();
        List<ComboItemVO> list;
        DemandVO dmadvo;
        //List<DemandVO> prvo;
        bool existDDID = false;

        public DEMANDpop()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            existDDID = true;
            txtID.ImeMode = ImeMode.Disable;
            txtID.CharacterCasing = CharacterCasing.Upper;
        }

        public DEMANDpop(DemandVO demdInfo)
        {
            InitializeComponent();
            this.dmadvo = demdInfo;
            this.MaximizeBox = false;
            txtID.Enabled = false;
            txtVer.Enabled = false;
            existDDID = true;
        }

        public async void Combobinding()
        {
            list = await srv.GetListAsync("api/Common/CommonCode", list);
            CommonUtil.ComboBinding(cboPID, list, "PRODUCT_ID");

            Modify();
        }

        private void Modify()
        {
            if (dmadvo != null)
            {
                txtID.Text = dmadvo.DEMAND_ID;
                txtVer.Text = dmadvo.DEMAND_VER;
                txtQTY.Text = dmadvo.DEMAND_QTY.ToString();
                txtdate.Text = dmadvo.DUE_DATE.ToString();
                cboCID.Text = dmadvo.CUSTOMER_ID;
                cboPID.SelectedValue = dmadvo.PRODUCT_ID;
            }
        }

        private async void button7_Click(object sender, EventArgs e)
        {
            if (!isNotWhiteSpace())
            {
                return;
            }

            DemandVO demandVO = new DemandVO
            {
                DEMAND_VER = txtVer.Text,
                DEMAND_ID = txtID.Text,
                PRODUCT_ID = cboPID.Text,
                CUSTOMER_ID = cboCID.Text,
                DUE_DATE = DateTime.Parse(txtdate.Text),
                DEMAND_QTY = Convert.ToInt32(txtQTY.Text),
                user_id = "test"
            };

            WebMessage wmsg = await srv.PostAsyncNone(DEMAND_SAVE, demandVO);

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
        /*
        private void txtID_Leave(object sender, EventArgs e)
        {
            var ProdID = prvo.Find(p => p.DEMAND_ID == txtID.Text);

            if (ProdID != null)
            {
                lblExist.Visible = true;
                existDDID = false;
                this.ActiveControl = txtID;
            }
            else

                existDDID = true;
        }
        */
        public bool isNotWhiteSpace()
        {
            //유효성 검사
            if (!existDDID || string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(cboPID.Text) || string.IsNullOrWhiteSpace(cboCID.Text) ||
                string.IsNullOrWhiteSpace(txtdate.Text) || string.IsNullOrWhiteSpace(txtQTY.Text))
            {
                txtID.Focus();
                return false;

            }
            return true;

        }

    }
}
