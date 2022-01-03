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
    public partial class BaseFormSample : Form
    {
        ServiceHelp srv = null;
        public BaseFormSample()
        {
            InitializeComponent();
        }

        private void BaseFormSample_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear(); // 샘플 컬럼 삭제용

            MainForm frm = MdiParent as MainForm;
            srv = new ServiceHelp("api/Sample", frm.AuthHeader);
            LoadDataAsync();
        }

        private async void LoadDataAsync()
        {
            List<SampleVO> list = null;
            string path = "List";

            var message = await srv.PostAsync(path, list);

            if (message!=null && message.IsSuccess)
            {
                list = message.Data;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = list;
            }
            else 
            {
                MessageBox.Show("api 호출 실패");
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //LoadDataAsync();
        }
    }
}
