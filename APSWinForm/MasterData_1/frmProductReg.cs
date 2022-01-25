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
    public partial class Productpop : frmBaseIcon
    {
        #region API
        readonly string PRODUCT_LIST = Properties.ResourceAPI.PRODUCT_LIST;
        readonly string PRODUCT_SAVE = Properties.ResourceAPI.PRODUCT_SAVE;
        #endregion

        ServiceHelp srv = new ServiceHelp();
        List<ComboItemVO> list;
        ProductVO prodvo;
        List<ProductVO> prvo;
        bool existPdID = false;

        public Productpop()
        {
            InitializeComponent();
            existPdID = true;
            txtID.ImeMode = ImeMode.Disable;
            txtID.CharacterCasing = CharacterCasing.Upper;
            this.MaximizeBox = false;
        }

        public async void Combobinding()
        {
            list = await srv.GetListAsync("api/Common/CommonCode", list);
            CommonUtil.ComboBinding(cboType, list, "PRODUCT_TYPE", blankText: "선택");


            Modify();
        }

        public Productpop(ProductVO prodInfo)
        {
            InitializeComponent();
            this.prodvo = prodInfo;
            this.MaximizeBox = false;
            txtID.Enabled = false;
            existPdID = true;
        }

        private void Modify()
        {
            if (prodvo != null)
            {
                txtID.Text = prodvo.PRODUCT_ID;
                txtName.Text = prodvo.PRODUCT_NAME;
                txtProcess.Text = prodvo.PROCESS_ID;
                txtSize.Text = prodvo.LOT_SIZE.ToString();
                cboType.SelectedValue = prodvo.PRODUCT_TYPE;
            }
        }


        private async void button7_Click(object sender, EventArgs e)
        {
            if (!isNotWhiteSpace())
            {
                return;
            }

            ProductVO newStep = new ProductVO
            {
                PRODUCT_ID = txtID.Text,
                PRODUCT_TYPE = cboType.Text,
                PRODUCT_NAME = txtName.Text,
                PROCESS_ID = txtProcess.Text,
                LOT_SIZE = Convert.ToInt32(txtSize.Text),
                user_id = "test"
            };

            WebMessage msg = await srv.PostAsyncNone(PRODUCT_SAVE, newStep);

            if (msg.IsSuccess)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            MessageBox.Show(msg.ResultMessage);
        }


        private async void Productpop_Load(object sender, EventArgs e)
        {
            Combobinding();
            prvo = await srv.GetListAsync(PRODUCT_LIST, prvo);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        private void txtSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            var ProdID = prvo.Find(p => p.PRODUCT_ID == txtID.Text);

            if (ProdID != null)
            {
                lblExist.Visible = true;
                existPdID = false;
                this.ActiveControl = txtID;
            }
            else
                
            existPdID = true;
        
        }

        public bool isNotWhiteSpace()
        {
            //유효성 검사
            if (!existPdID || string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtProcess.Text) ||
                string.IsNullOrWhiteSpace(txtSize.Text) || string.IsNullOrWhiteSpace(cboType.Text))
            {
                txtID.Focus();
                return false;

            }
            return true;

        }
    }
}

 
