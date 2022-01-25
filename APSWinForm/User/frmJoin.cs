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
        #region API
        readonly string ACCOUNT_REGISTER = Properties.ResourceAPI.ACCOUNT_REGISTER;

        #endregion

        public frmJoin()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var req = new RegisterVO()
            { 
                ID = txtID.Text,
                Email = $@"{txtEmail.Text}@{cbEmail.Text}",
                Password = txtPW.Text,
                ConfirmPassword = txtPW2.Text,
                Phone = txtPhone.Text,
                Name = txtName.Text,
                Birthday = Convert.ToDateTime(txtBirth.Text)
            };

            ServiceHelp srv = new ServiceHelp();
            string path = ACCOUNT_REGISTER;
            var result = await srv.PostAsync<RegisterVO, ModelMessage>(path, req);
            if (srv.IsSuccessStatusCode)
            {
                MessageBox.Show("회원가입에 성공하였습니다.");
                Close();
            }
            else
            {
                StringBuilder errStr = new StringBuilder();
                List<string> lst = new List<string>();
                result.ModelState.Values.ToList().ForEach(i => lst.AddRange(i));
                if (lst.Count <= 0)
                    return;
                lst.ForEach((i) => errStr.AppendLine(i));
                MessageBox.Show(errStr.ToString());
            }

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            string path = $"api/Account/CheckID?id={txtID.Text}";
            ServiceHelp srv = new ServiceHelp();
            var _ = await srv.GetListAsync(path, new object());
            if (srv.IsSuccessStatusCode)
            {
                MessageBox.Show("사용 가능한 ID입니다.");
            }
            else 
            {
                MessageBox.Show("사용중인 ID입니다.");
            }
        }
    }
}
