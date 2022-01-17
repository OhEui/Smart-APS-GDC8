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
    public partial class frmUserInfo : frmBaseIcon
    {
        ServiceHelp srv = new ServiceHelp();
        List<UserInfoVO> list = null;

        public frmUserInfo()
        {
            InitializeComponent();
        }

        private async void LoadData()
        {
            list = await srv.GetListAsync("api/UserInfo/AllList", list);
            dgvUI.DataSource = list;
        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitGridView(dgvUI);
            DataGridViewUtil.AddGridTextColumn(dgvUI, "ID", "ID", colWidth: 160, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextColumn(dgvUI, "이름", "Name", colWidth: 60, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextColumn(dgvUI, "이메일", "Email", colWidth: 90, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextColumn(dgvUI, "전화번호", "Phone", colWidth: 100, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextColumn(dgvUI, "생년월일", "Birthday", colWidth: 120, align: DataGridViewContentAlignment.MiddleCenter);

            LoadData();
        }

        private async void dgvUI_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string userID = dgvUI[0, e.RowIndex].Value.ToString();
            UserInfoVO user = null;
            user = await srv.GetAsync($"api/UserInfo/{userID}", user);
            if (user != null)
            {
                txtName.Text = user.Name;
                txtID.Text = user.Id;
                txtE.Text = user.Email;
                txtP.Text = user.Phone;
                txtB.Text = user.Birthday.ToString();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            txtID.Text = txtName.Text = txtE.Text = txtB.Text = txtP.Text = null;

            LoadData();
        }

        private async void toolStripButton1_Click(object sender, EventArgs e)
        {
             if (dgvUI.SelectedRows.Count < 1)
             {
                 MessageBox.Show("삭제할 유저를 선택해 주세요.");
                 return;
             }

             string prodID = dgvUI.SelectedRows[0].Cells["Id"].Value.ToString();

             if (MessageBox.Show("       정말 삭제하시겠습니까?", "유저삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
             {
                 APSVO.WebMessage msg = await srv.GetAsync($"api/UserInfo/Delete/{prodID}");
                 if (msg.IsSuccess)
                 {
                     LoadData();
                 }
                 MessageBox.Show(msg.ResultMessage);
         }
        }

        private async void toolStripButton2_Click(object sender, EventArgs e)
        {
            UserInfoVO user = new UserInfoVO
            {
                Name = txtName.Text,
                Email = txtE.Text,
                Phone = txtP.Text,
                Id = txtID.Text,
                Birthday = DateTime.Parse(txtB.Text)
            };

            APSVO.WebMessage msg = await srv.PostAsyncNone("api/UserInfo/UserInfoUpdate", user);
            if (msg.IsSuccess)
            {
                LoadData();
            }
            MessageBox.Show(msg.ResultMessage);
        }
    }
}
