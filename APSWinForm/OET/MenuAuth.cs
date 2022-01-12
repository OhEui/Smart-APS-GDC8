using APSUtil.Http;
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
    public partial class MenuAuth : Form
    {
        List<AuthVO> Authlist = null;
        ServiceHelp srv = new ServiceHelp();
        List<UserVO> Userlist = null;


        public MenuAuth()
        {
            InitializeComponent();
        }

        private void MenuAuth_Load(object sender, EventArgs e)
        {
            
            DataLoad();
        }

        private async void dgvLoad()
        {
            dgvUser.DataSource = null;
            Userlist = await srv.GetListAsync("api/Auth/GetUser", Userlist);
            dgvUser.DataSource = Userlist;

            dgvAuth.DataSource = null;
            Authlist = await srv.GetListAsync("api/Auth/GetAuth", Authlist);
            dgvAuth.DataSource = Authlist;

            
        }

        private void DataLoad()
        {
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();

            chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = " ";
            chk.Frozen = false;
            chk.Name = "chk";
            chk.Width = 50;
            dgvAuth.Columns.Add(chk);

            DataGridViewUtil.SetInitGridView(dgvUser);
            DataGridViewUtil.AddGridTextColumn(dgvUser, "사용자 ID", "User_ID", colWidth: 100);
            DataGridViewUtil.AddGridTextColumn(dgvUser, "사용자 이름", "User_Name", colWidth: 105);
            DataGridViewUtil.AddGridTextColumn(dgvUser, "권한 ", "auth_id", colWidth: 100);

            DataGridViewUtil.SetInitGridView(dgvAuth);
            DataGridViewUtil.AddGridTextColumn(dgvAuth, "권한이름", "Auth_Name", colWidth: 105);
            DataGridViewUtil.AddGridTextColumn(dgvAuth, "권한기능", "auth_Desc", colWidth: 100);
            

            dgvLoad();
        }

        //https://milkoon1.tistory.com/17
        private void dgvAuth_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                foreach (DataGridViewRow row in dgvAuth.Rows)
                {
                    if (row.Index == e.RowIndex)
                    {
                        row.Cells["chk"].Value = !Convert.ToBoolean(row.Cells["chk"].EditedFormattedValue);
                    }
                    else
                    {
                        row.Cells["chk"].Value = false;
                    }
                }
            }

        }
    }
}
