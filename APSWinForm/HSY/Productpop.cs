using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APSVO;

namespace APSWinForm
{
    public partial class Productpop : Form
    {
        ServiceHelp srv = new ServiceHelp("");
        // ProductVO Prdvo;
        List<ProductVO> prdList;

        //추가
        public Productpop()
        {
            InitializeComponent();
        }

        private async void button7_Click(object sender, EventArgs e)
        {
            ProductVO product = new ProductVO
            {
                PRODUCT_ID = txtID.Text,
                PRODUCT_TYPE = txtType.Text,
                PRODUCT_NAME = txtName.Text,
                PROCESS_ID = txtProcess.Text,
                LOT_SIZE = txtSize.Text.Length
            };

            WebMessage msg = await srv.PostAsyncNone("api/Product/SaveProduct", product);
            if (msg.IsSuccess)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            MessageBox.Show(msg.ResultMessage);
        }

        //수정
        public Productpop(ProductVO prodinfo)
        {
            InitializeComponent();

            txtID.Text = prodinfo.PRODUCT_ID;
            txtType.Text = prodinfo.PRODUCT_TYPE;
            txtName.Text = prodinfo.PRODUCT_NAME;
            txtProcess.Text = prodinfo.PROCESS_ID;
            txtSize.Text = prodinfo.LOT_SIZE.ToString();


            txtID.Enabled = false;
        }

        private async void Productpop_Load(object sender, EventArgs e)
        {
            prdList = await srv.GetListAsync("api/Product/Products", prdList);
        }
    }
}

 
