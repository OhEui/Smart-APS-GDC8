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
    public partial class frmLogin : frmBaseIcon
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string password = txtPW.Text;
            
            ReqUserLogin reqData = new ReqUserLogin() { ID = id, Password = password };
            WebMessage<TokenModel> resToken;
            UserInfo resUserInfo;

            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("아이디와 비밀번호를 입력하세요.");
                return;
            }

            // access_token 가져오기
            using (ServiceHelp srv = new ServiceHelp()) 
            {
                resToken = await srv.PostAsync<ReqUserLogin, WebMessage<TokenModel>>("api/Account/Login", reqData);
                if (resToken != null && resToken.IsSuccess)
                {
                    if (ckLogin.Checked) // 로그인 OK 버튼 실행할 때 저장
                    {
                        Properties.Settings.Default.LoginIDSave = txtID.Text;
                        Properties.Settings.Default.Save();
                    }
                    TokenStorage.AccessToken = resToken.Data.AccessToken;
                }
                else
                {
                    MessageBox.Show(resToken?.ResultMessage ?? "로그인 중 문제가 발생하였습니다.");
                    return;
                }
            }

            using (ServiceHelp srv = new ServiceHelp()) 
            {
                resUserInfo = await srv.GetListAsync("api/Account/UserInfo", new UserInfo());
                if (resUserInfo != null)
                {
                    UserInfoStorage.Current = resUserInfo;
                }
                else
                {
                    MessageBox.Show("회원 정보를 불러오는 중 문제가 발생하였습니다.");
                    return;
                }

            }
            MessageBox.Show(resToken.ResultMessage);
            this.DialogResult = DialogResult.OK;
            this.Close();

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

        private void txtPW_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button1_Click(null, new EventArgs());
            }
        }
    }
}
