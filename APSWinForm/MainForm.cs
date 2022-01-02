using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APSWinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tabControl1.Visible = false;
            //샘플ToolStripMenuItem.Visible = false;
            new EQUIPMENT() { MdiParent = this }.Show();
        }

        private void menuStrip2_ItemAdded(object sender, ToolStripItemEventArgs e)
        {
            e.Item.Visible = false;
        }

        private void 샘플ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BaseFormSample() { MdiParent = this }.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            var test1 = APSEncrypt.SHA256.GenerateSaltedHash("1234");
            var test2 = APSEncrypt.SHA256.VerifyPassword("1234", test1.hash, test1.salt);
        }

        private void btnDemand_Click(object sender, EventArgs e)
        {

        }

        private void btnEquipment_Click(object sender, EventArgs e)
        {
            new EQUIPMENT() { MdiParent = this }.Show();
        }

        private void btnARR_Click(object sender, EventArgs e)
        {
             new EQP_ARRANGE() { MdiParent = this }.Show();
        }

        private void btnSTD_Click(object sender, EventArgs e)
        {
            new STD_STEP_INFO() { MdiParent = this }.Show();
        }

        private void btnRoute_Click(object sender, EventArgs e)
        {
            new STEP_ROUTE() { MdiParent = this }.Show();
        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            new SETUP_TIME() { MdiParent = this }.Show();
        }
    }
}
