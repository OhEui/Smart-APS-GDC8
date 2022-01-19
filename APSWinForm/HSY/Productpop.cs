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
        ServiceHelp srv = new ServiceHelp();
        List<ComboItemVO> list;
        ProductVO prodvo;

        public Productpop()
        {
            InitializeComponent();
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

        //수정
        private async void button7_Click(object sender, EventArgs e)
        {
            ProductVO productVO = new ProductVO
            {
                PRODUCT_ID = txtID.Text,
                PRODUCT_TYPE = cboType.Text,
                PRODUCT_NAME = txtName.Text,
                PROCESS_ID = txtProcess.Text,
                LOT_SIZE = Convert.ToInt32(txtSize.Text)
            };

            WebMessage msg = await srv.PostAsyncNone("api/Product/UdateProduct", productVO);

            if (msg.IsSuccess)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            MessageBox.Show(msg.ResultMessage);
        }


        private void Productpop_Load(object sender, EventArgs e)
        {
            Combobinding();
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
    }
}

 
