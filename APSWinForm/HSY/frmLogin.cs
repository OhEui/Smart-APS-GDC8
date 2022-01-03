using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APSDAC;
using APSVO;
using APSWinForm.Properties;

namespace APSWinForm
{
    public partial class frmLogin : Form
    {
        ServiceHelp srv = new ServiceHelp("api/User");
       
        public string AuthHeader { get; private set; }
        public UserData LoginUser { get; private set; }

        public frmLogin()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string password = txtPW.Text;
            string path = "Login";
            ReqUserLogin data = new ReqUserLogin() { ID=id, Password=password};

            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("아이디와 비밀번호를 입력하세요.");
                return;
            }

            WebMessage<UserVerify> message = await srv.PostAsync<ReqUserLogin, UserVerify>(path, data);
            if (message != null) 
            {
                MessageBox.Show(message.ResultMessage);
                if (message.IsSuccess)
                {
                    if (ckLogin.Checked) // 로그인 OK 버튼 실행할 때 저장
                    {
                        Properties.Settings.Default.LoginIDSave = txtID.Text;
                        Properties.Settings.Default.Save();
                    }
                    LoginUser = message.Data;
                    AuthHeader = message.Data.AuthHeader;
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
            frm.Show();


        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmJoin frm = new frmJoin();
            frm.Show();
        }
    }
}
