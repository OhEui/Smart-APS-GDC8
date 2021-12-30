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
        }

        private void menuStrip2_ItemAdded(object sender, ToolStripItemEventArgs e)
        {
            e.Item.Visible = false;
        }

        private void 샘플ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BaseFormSample() { MdiParent = this }.Show();
        }

        private void btnEquipment_Click(object sender, EventArgs e)
        {
            EQUIPMENT frm = new EQUIPMENT();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }
    }
}
