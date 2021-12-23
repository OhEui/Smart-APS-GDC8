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
        ServiceHelp srv = new ServiceHelp("api/Sample");

        public BaseFormSample()
        {
            InitializeComponent();
        }

        private void BaseFormSample_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            LoadDataAsync();
        }

        private async void LoadDataAsync()
        {
            List<SampleVO> list = null;
            string path = "List";

            list = await srv.GetListAsync(path, list);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //LoadDataAsync();
        }
    }
}
