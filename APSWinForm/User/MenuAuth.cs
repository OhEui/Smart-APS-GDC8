﻿using APSUtil.Http;
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
    public partial class MenuAuth : frmBaseIcon
    {
        #region API
        readonly string AUTH_LIST = Properties.ResourceAPI.AUTH_LIST;
        readonly string AUTH_SAVE = Properties.ResourceAPI.AUTH_SAVE;
        #endregion

        List<AuthVO> Authlist = null;
        ServiceHelp srv = new ServiceHelp();
        List<UserVO> Userlist = null;
        CheckBox headerbox = new CheckBox();

        public MenuAuth()
        {
            InitializeComponent();
            BtnAdd.Visible = BtnDelete.Visible =  XlsDown.Visible = false;


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
            Authlist = await srv.GetListAsync(AUTH_LIST, Authlist);
            dgvAuth.DataSource = Authlist;

            dgvAuth.ClearSelection();
            dgvUser.ClearSelection();
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
            DataGridViewUtil.AddGridTextColumn(dgvUser, "사용자 ID", "Id", colWidth: 135 , visibility:false);
            DataGridViewUtil.AddGridTextColumn(dgvUser, "사원번호", "Empno", align: DataGridViewContentAlignment.MiddleCenter, colWidth: 135);
            DataGridViewUtil.AddGridTextColumn(dgvUser, "사용자 이름", "Name", align: DataGridViewContentAlignment.MiddleCenter, colWidth: 180);
            DataGridViewUtil.AddGridTextColumn(dgvUser, "권한 ", "auth_name", colWidth: 200);

            DataGridViewUtil.SetInitGridView(dgvAuth);
            DataGridViewUtil.AddGridTextColumn(dgvAuth, "권한 ID", "Auth_ID", colWidth: 150, visibility: false);
            DataGridViewUtil.AddGridTextColumn(dgvAuth, "권한", "Auth_Name", colWidth: 200);
            DataGridViewUtil.AddGridTextColumn(dgvAuth, "권한기능", "auth_Desc", colWidth: 300);



            dgvLoad();
        }




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

            foreach (DataGridViewRow row in dgvAuth.Rows)
            {
                bool isChecked = Convert.ToBoolean(row.Cells[0].Value);

                if (isChecked)
                {
                    txtno.Text = (row.Cells["Auth_ID"].Value.ToString());
                }

            }
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
                txtID.Text = dgvUser["Id", e.RowIndex].Value.ToString();

        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            UserVO vo = new UserVO();

            if (vo != null)
            {
                vo.Id = txtID.Text;
                vo.Auth_ID = Convert.ToInt32(txtno.Text);

                WebMessage msg = await srv.PostAsyncNone(AUTH_SAVE, vo);


                if (msg.IsSuccess)
                {
                    this.DialogResult = DialogResult.OK;
                }
                MessageBox.Show(msg.ResultMessage);


            }
            dgvUser.DataSource = null;
            Userlist = await srv.GetListAsync("api/Auth/GetUser", Userlist);
            dgvUser.DataSource = Userlist;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                MessageBox.Show("검색어를 입력해주세요.");
                txtID.Focus();
                return;
                } 

            dgvUser.DataSource = null;
            dgvUser.DataSource = Userlist.FindAll(p => p.Name.Contains(txtName.Text));
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text= null;
            dgvLoad();
        }

        
    }
}
    
