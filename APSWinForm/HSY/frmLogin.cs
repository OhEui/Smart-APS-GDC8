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
        public UserInfo LoginUser { get; set; }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtPW.Text))
            {
                MessageBox.Show("아이디와 비밀번호를 입력하세요.");
                return;
            }

            UserDAC dac = new UserDAC();
            UserInfo loginUser = dac.Login(txtID.Text);
            dac.Dispose();
            if (loginUser == null)
            {
                MessageBox.Show("등록된 아이디가 아닙니다. 회원가입을 해주십시오.");
            }
            else if (loginUser.User_PWD != txtPW.Text)
            {
                MessageBox.Show("비밀번호를 다시 입력하여 주십시오.");
            }
            else
            {
                if (ckLogin.Checked) // 로그인 OK 버튼 실행할 때 저장
                {
                    Properties.Settings.Default.LoginIDSave = txtID.Text;
                    Properties.Settings.Default.Save();
                }

                this.LoginUser = loginUser;
                this.DialogResult = DialogResult.OK;
                this.Close();
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
