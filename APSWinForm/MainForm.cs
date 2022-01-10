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
using APSUtil.Http;

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
            lblName.Text = "";
            Login();
        }

        private void Login()
        {
            frmLogin login = new frmLogin();
            Hide();
            if (login.ShowDialog() == DialogResult.OK)
            {
                lblName.Text = UserInfoStorage.Current.Name;
                Show();
            }
            else
            {
                Close();
            }
        }

        private void Logout() 
        {
            TokenStorage.Clear();
            UserInfoStorage.Clear();
            lblName.Text = "";
            Login();
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

        private void 로그아웃ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logout();
        }
    }
}
