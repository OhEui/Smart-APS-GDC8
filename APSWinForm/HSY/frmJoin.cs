using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APSVO;
using APSDAC;

namespace APSWinForm
{
    public partial class frmJoin : Form
    {
        UserDAC dac = null;
        public UserInfo UserInfo
        {
            get
            {
                UserInfo uer = new UserInfo();
                uer.User_ID = txtID.Text;
                uer.User_PWD = txtPW.Text;
                uer.User_Name = txtName.Text;
                uer.User_phone = txtPhone.Text;
                uer.User_Birth = DateTime.Parse(txtBirth.Text);
                uer.User_Email = txtEmail.Text;

                return uer;
            }
        }

        public frmJoin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //입력 유효성 체크
            StringBuilder sb = new StringBuilder();
            if (txtID.Text.Length < 6)
            {
                sb.AppendLine("- ID를 입력하세요.");
            }
            if (txtPW.Text.Length < 8)
            {
                sb.AppendLine("- 비밀번호를 입력하세요");
            }
            if (txtPW2.Text != txtPW.Text)
            {
                sb.AppendLine("- 비밀번호가 같지 않습니다. 다시 입력하세요.");
            }
            if (txtName.Text.Length < 2)
            {
                sb.AppendLine("- 이름을 입력하세요.");
            }
            if (txtPhone.Text.Length < 11)
            {
                sb.AppendLine("- 전화번호를 입력하세요.");
            }
            if (txtEmail.Text.Length < 6)
            {
                sb.AppendLine("- 이메일을 입력하세요.");
            }
            if (cbEmail.Text.Length < 7)
            {
                sb.AppendLine("- E-mail 주소를 선택하세요.");
            }
            if (txtBirth.Text.Length < 8)
            {
                sb.AppendLine("- 생년월일을 입력하세요.");
            }
            if (sb.ToString().Length > 1)
            {
                MessageBox.Show(sb.ToString());
                return;
            }
            //처리

            //입력받은 유저정보를 DB에 저장
            
            UserDAC dac = new UserDAC();
            int iResult = dac.Insert(UserInfo);
            dac.Dispose();

            if (iResult > 0)
            {
                MessageBox.Show("유저가 추가되었습니다.");
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtID.Text = txtID.Text.Replace(" ", "");
            bool check = dac.IDCheck(txtID.Text);
            if (!check)
            {
                txtID.ReadOnly = true;
                MessageBox.Show("가능한 아이디 입니다.");
            }
            else
            {
                MessageBox.Show("중복된 아이디 입니다.");
            }
        }
    }
}
