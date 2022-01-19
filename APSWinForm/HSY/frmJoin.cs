using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using System.Windows.Forms;
using APSUtil.Http;
using APSVO;


namespace APSWinForm
{
    public partial class frmJoin : frmBaseIcon
    {


        public frmJoin()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private async void button2_Click(object sender, EventArgs e)
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

            var req = new RegisterVO()
            { 
                ID = $"{txtID}",
                Email = $@"{txtEmail}@{cbEmail}",
                Password = $"{txtPW}",
                ConfirmPassword = $"{txtPW2}",
                Phone = $"{txtPhone}",
                Name = $"{txtName}",
                Birthday = Convert.ToDateTime(txtBirth)
            };

            ServiceHelp srv = new ServiceHelp();
            string path = "api/Account/Register";
            var result = await srv.PostAsync<RegisterVO, ModelStateDictionary>(path, req);
            if (srv.IsSuccessStatusCode)
            {
                MessageBox.Show("회원가입에 성공하였습니다.");
                Close();
            }
            else
            {
                StringBuilder errStr = new StringBuilder();
                var allErrors = result.Values.SelectMany(v => v.Errors.Select(b => b.ErrorMessage));
                if (allErrors == null)
                    return;
                allErrors.ToList().ForEach((i) => errStr.AppendLine(i));
                MessageBox.Show(errStr.ToString());
            }

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            string path = "api/Account/CheckID";
            ServiceHelp srv = new ServiceHelp();
            bool bResult = await srv.GetListAsync<bool>(path);
            if (bResult)
            {
                MessageBox.Show("사용 가능한 ID입니다.");
            }
            else 
            {
                MessageBox.Show("사용중인 ID입니다.");
            }

            /*
             * 
             * 
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
            */
        }
    }
}
