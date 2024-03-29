﻿using System;
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
        #region API
        readonly string USER_INFO_BY_ID = Properties.ResourceAPI.USER_INFO_BY_ID;
        readonly string USER_INFO_DELETE = Properties.ResourceAPI.USER_INFO_DELETE;
        readonly string USER_INFO_LIST = Properties.ResourceAPI.USER_INFO_LIST;
        readonly string USER_INFO_UPDATE = Properties.ResourceAPI.USER_INFO_UPDATE;

        string GetInfoUrl(string id) => string.Format(USER_INFO_BY_ID, id);
        string DeleteUrl(string id) => string.Format(USER_INFO_DELETE, id);
        #endregion

        ServiceHelp srv = new ServiceHelp();
        List<UserInfoVO> list = null;

        public frmUserInfo()
        {
            InitializeComponent();
        }

        private async void LoadData()
        {
            list = await srv.GetListAsync(USER_INFO_LIST, list);
            dgvUI.DataSource = list;
        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            DataGridViewUtil.SetInitGridView(dgvUI);
            DataGridViewUtil.AddGridTextColumn(dgvUI, "ID", "UserName", colWidth: 160, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextColumn(dgvUI, "이름", "Name", colWidth: 100, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextColumn(dgvUI, "이메일", "Email", colWidth: 200, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextColumn(dgvUI, "전화번호", "Phone", colWidth: 200, align: DataGridViewContentAlignment.MiddleCenter);
            DataGridViewUtil.AddGridTextColumn(dgvUI, "생년월일", "Birthday", colWidth: 180, align: DataGridViewContentAlignment.MiddleCenter);

            LoadData();
        }


        //초기화
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            txtID.Text = txtName.Text = txtE.Text = txtB.Text = txtP.Text = null;

            LoadData();
        }

        //수정
        private async void BtnEdit_Click(object sender, EventArgs e)
        {
            UserInfoVO user = new UserInfoVO
            {
                Name = txtName.Text,
                Email = txtE.Text,
                Phone = txtP.Text,
                UserName = txtID.Text,
                Birthday = DateTime.Parse(txtB.Text)
            };

            APSVO.WebMessage msg = await srv.PostAsyncNone(USER_INFO_UPDATE, user);
            if (msg.IsSuccess)
            {
                LoadData();
            }
            MessageBox.Show(msg.ResultMessage);
        }

        //삭제
        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUI.SelectedRows.Count < 1)
            {
                MessageBox.Show("삭제할 유저를 선택해 주세요.");
                return;
            }

            string prodID = dgvUI.SelectedRows[0].Cells["UserName"].Value.ToString();

            if (MessageBox.Show("       정말 삭제하시겠습니까?", "유저삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                APSVO.WebMessage msg = await srv.GetAsync(DeleteUrl(prodID));
                if (msg.IsSuccess)
                {
                    LoadData();
                }
                MessageBox.Show(msg.ResultMessage);
            }
        }

        private async void dgvUI_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string userID = dgvUI[0, e.RowIndex].Value.ToString();
            UserInfoVO user = null;
            user = await srv.GetAsync(GetInfoUrl(userID), user);
            if (user != null)
            {
                txtName.Text = user.Name;
                txtID.Text = user.UserName;
                txtE.Text = user.Email;
                txtP.Text = user.Phone;
                txtB.Text = user.Birthday.ToString();
            }
        }
    }
}
