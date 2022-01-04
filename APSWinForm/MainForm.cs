using APSVO;
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
        // TODO 토큰 저장
        public string AuthHeader { get; private set; }
        public UserData LoginUser { get; private set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tabControl1.Visible = false;

            // Login Test
            Login();

        }

        private void Login()
        {
            frmLogin login = new frmLogin();
            Hide();
            if (login.ShowDialog() == DialogResult.OK)
            {
                AuthHeader = login.AuthHeader;
                LoginUser = login.LoginUser;
                Show();
            }
            else
            {
                Close();
            }
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
            new frmPRODUCT { MdiParent = this }.Show();
        }

        private void btnDemand_Click(object sender, EventArgs e)
        {
            new frmDEMAND() { MdiParent = this }.Show();
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

        private void btnLine_Click(object sender, EventArgs e)
        {
            new frmLineInfo() { MdiParent = this }.Show();
        }
    }
}
