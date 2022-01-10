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
using APSWinForm.Properties;

namespace APSWinForm
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string password = txtPW.Text;
            
            ServiceHelp srv = new ServiceHelp();
            ReqUserLogin reqData = new ReqUserLogin() { ID=id, Password=password };

            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("아이디와 비밀번호를 입력하세요.");
                return;
            }

            var response = await srv.PostAsync<ReqUserLogin, TokenModel>("api/Account/Login", reqData);
            if (response != null) 
            {
                MessageBox.Show(response.ResultMessage);
                if (response.IsSuccess)
                {
                    if (ckLogin.Checked) // 로그인 OK 버튼 실행할 때 저장
                    {
                        Properties.Settings.Default.LoginIDSave = txtID.Text;
                        Properties.Settings.Default.Save();
                    }
                    TokenStorage.AccessToken = response.Data.AccessToken;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtID.Text = Properties.Settings.Default.LoginIDSave;
        }

        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPassWord frm = new frmPassWord();
            frm.ShowDialog();


        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmJoin frm = new frmJoin();
            frm.ShowDialog();
        }
    }
}
