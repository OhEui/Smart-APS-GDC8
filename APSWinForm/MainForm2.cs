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
using APSUtil.Http;
using System.Diagnostics;
namespace APSWinForm
{
    public partial class MainForm2 : Form
    {
        public MainForm2()
        {
            Font = new Font("ONE 모바일고딕 OTF Regular", 11F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(129)));
            InitializeComponent();
            hideSubMenu();
            Login();
        }

        #region hideMenu
        private void hideSubMenu()
        {
            panelInfoSubMenu.Visible = false;
            panelResultSubMenu.Visible = false;
            panelExcelSubMenu.Visible = false;
            panelSystemSubMenu.Visible = false;
        }
        private void hideInfoSubMenu()
        {
            panelResultSubMenu.Visible = false;
            panelExcelSubMenu.Visible = false;
            panelSystemSubMenu.Visible = false;
        }
        private void hideResultSubMenu()
        {
            panelInfoSubMenu.Visible = false;
            panelExcelSubMenu.Visible = false;
            panelSystemSubMenu.Visible = false;
        }
        private void hideExcelSubMenu()
        {
            panelInfoSubMenu.Visible = false;
            panelResultSubMenu.Visible = false;
            panelSystemSubMenu.Visible = false;
        }
        private void hideSystemSubMenu()
        {
            panelInfoSubMenu.Visible = false;
            panelResultSubMenu.Visible = false;
            panelExcelSubMenu.Visible = false;
        }

        #endregion

        private void MainForm2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            tabControl1.Visible = true;
            lblName.Text = "";
            
           
        }



        private void Login()
        {
            frmLogin login = new frmLogin();
            Hide();
            if (login.ShowDialog() == DialogResult.OK)
            {
                if (UserInfoStorage.Current.Auth_ID == 2 || UserInfoStorage.Current.Auth_ID == 3)
                {
                    btnSystem.Visible = false;
                    시스템관리ToolStripMenuItem.Visible = false;
                }

                lblName.Text = UserInfoStorage.Current.Name;
                Show();
                MessageBox.Show(UserInfoStorage.Current.ToString());

               
            }
            else
            {
                Close();
            }

        }

        private void Logout()
        {
            TokenStorage.Clear();
            UserInfoStorage.Clear();
            lblName.Text = "";
            Login();
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            showSubMenu(panelInfoSubMenu);
            
        }

        #region InfoSubMenu
        private void btnProduct_Click(object sender, EventArgs e)
        {
            CreateTabPages("제품정보", new frmPRODUCT());
            hideInfoSubMenu();

        }

        private void btnDemand_Click(object sender, EventArgs e)
        {
            CreateTabPages("수요정보", new frmDEMAND());
            hideInfoSubMenu();
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            CreateTabPages("라인정보", new frmLineInfo());
            hideInfoSubMenu();
        }

        private void btnStdStep_Click(object sender, EventArgs e)
        {
            CreateTabPages("표준공정정보", new STD_STEP_INFO());
            hideInfoSubMenu();
        }

        private void btnRoute_Click(object sender, EventArgs e)
        {
            CreateTabPages("공정순서정보", new STEP_ROUTE());
            hideInfoSubMenu();
        }

        private void btnEquip_Click(object sender, EventArgs e)
        {
            CreateTabPages("설비정보", new EQUIPMENT());
            hideInfoSubMenu();
        }

        private void btnARR_Click(object sender, EventArgs e)
        {
            CreateTabPages("설비배치정보", new EQP_ARRANGE());
            hideInfoSubMenu();
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            CreateTabPages("교체준비시간관리", new SETUP_TIME());
            hideInfoSubMenu();
        }

        #endregion

        private void btnResult_Click(object sender, EventArgs e)
        {
            showSubMenu(panelResultSubMenu);
        }

        #region ResultSubMenu
        private void btnLOT_Click(object sender, EventArgs e)
        {
            Process.Start("https://localhost:44397/result/LOTgantt");
            hideResultSubMenu();
        }

        private void btnEQPgant_Click(object sender, EventArgs e)
        {
            Process.Start("https://localhost:44397/result/EQPgantt");
            hideResultSubMenu();
        }

        private void btnUtil_Click(object sender, EventArgs e)
        {
            Process.Start("https://localhost:44397/result/utilization");
            hideResultSubMenu();
        }

        #endregion

        private void btnExcel_Click(object sender, EventArgs e)
        {
            showSubMenu(panelExcelSubMenu);
        }

        #region ExcelSubMenu

        private void btnExcelin_Click(object sender, EventArgs e)
        {
            hideExcelSubMenu();
        }

        private void btnExcelOut_Click(object sender, EventArgs e)
        {
            hideExcelSubMenu();
        }

        #endregion


        private void btnSystem_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSystemSubMenu);
        }

        #region SystemSubMenu
        private void btnUser_Click(object sender, EventArgs e)
        {
            hideSystemSubMenu();
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            CreateTabPages("권한설정", new MenuAuth());
            hideSystemSubMenu();
        }
        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("프로그램을 종료 하시겠습니까?", "종료", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DialogResult = DialogResult.OK;
                Application.Exit();
            }
            
        }


        private void CreateTabPages(string text, Form OpenForm)
        {
            string first;
            foreach (TabPage childForm in this.tabControl1.TabPages)
            {
                if (childForm.Text == text)
                {
                    tabControl1.SelectedTab = childForm;
                    return;
                }
            }
            TabPage myTabPage = new TabPage();
            myTabPage = new TabPage();
            myTabPage.Text = text;
            myTabPage.ImageIndex = 0;

            first = OpenForm.ToString();
            myTabPage.Tag = first.ToString();

            tabControl1.Controls.Add(myTabPage);


            myTabPage.Focus();

            OpenForm.TopLevel = false;
            OpenForm.Parent = this;
            myTabPage.Controls.Add(OpenForm);
            //창이 열리면서 최대화

            OpenForm.Dock = DockStyle.Fill;
            OpenForm.FormBorderStyle = FormBorderStyle.None;
            OpenForm.Show();

            tabControl1.SelectedTab = myTabPage;
        }


        
        


        private void 로그아웃ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logout();
        }

        
    }
}
