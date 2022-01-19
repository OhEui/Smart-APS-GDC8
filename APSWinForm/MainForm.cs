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
    public partial class MainForm : frmBaseIcon
    {
        public MainForm()
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

                }

                lblName.Text = "로그인된 계정:" + UserInfoStorage.Current.ID;
                Show();
                MessageBox.Show(UserInfoStorage.Current.ToString());

               
            }
            else
            {
                Close();
            }

        }

        public static void Logout()
        {
            MainForm mainForm = null;
            List<Form> collection = new List<Form>();
            collection.AddRange(Application.OpenForms.Cast<Form>());

            foreach (Form frm in collection)
            {
                if (frm is MainForm main) 
                {
                    mainForm = main;
                    continue;
                }
                frm.Close();
            }
            if (mainForm == null) 
                return;
            TokenStorage.Clear();
            UserInfoStorage.Clear();
            mainForm.lblName.Text = "";
            mainForm.Login();
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
            string title = "LOT 간트차트";
            string url = "https://localhost:44397/result/LOTgantt";
            StartWebView(title, url);
            hideResultSubMenu();
        }
        private void btnEQPgant_Click(object sender, EventArgs e)
        {
            string title = "EQP 간트차트";
            string url = "https://localhost:44397/result/EQPgantt";
            StartWebView(title, url);
            hideResultSubMenu();
        }

        private void btnUtil_Click(object sender, EventArgs e)
        {
            string title = "가동률 분석";
            string url = "https://localhost:44397/result/utilization";
            StartWebView(title, url);
            hideResultSubMenu();
        }
        private void StartWebView(string title, string url)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is frmWebView wb)
                {
                    wb.UrlAddress = "https://localhost:44397/result/LOTgantt";
                    wb.UpdateWebView(title, url);
                    return;
                }
            }
            frmWebView newWb = new frmWebView(title, url);
            newWb.Show();
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
            //ExcelImportAll();
        }
        
        private async void btnExcelOut_Click(object sender, EventArgs e)
        {
            hideExcelSubMenu();
            await ExcelExportAll();
        }
        
        private async void ExcelImportAll()
        {
            string oldDataFileName = "oldData.xls";

            if (MessageBox.Show($@"지정한 엑셀 파일로 전체파일을 덮어씁니다.
이전 데이터는 {oldDataFileName}으로 현재 폴더에 저장됩니다.
계속하시겠습니까?", "경고", MessageBoxButtons.YesNo) == DialogResult.No) 
                return;

            if(!await ExcelExportAll(oldDataFileName))
                return;

            // 엑셀파일을 열어서 dataset 형태로 바꿈 -> dataset로 api 호출
            // 서버에서 DB 데이터 전부 삭제 -> 서버에서 DB에 데이터를 insert

            throw new NotImplementedException();
        }

        private async Task<bool> ExcelExportAll(string fileNameFullPath = null) 
        {
            string resultMsg;
            string msgTitle = "엑셀 내보내기";
            string path = "api/Excel/Data";
            string saveFileName;

            if (fileNameFullPath == null) 
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = "Excel Files(*.xls)|*.xls";
                dlg.Title = "엑셀파일로 내보내기";

                if (dlg.ShowDialog() != DialogResult.OK)
                    return false;
                saveFileName = dlg.FileName;
            }
            else
            {
                saveFileName = fileNameFullPath;
            }

            ServiceHelp srv = new ServiceHelp();
            DataSet data = await srv.GetListAsync<DataSet>(path);
            
            if (data == null) return false;
            
            bool bResult = ExcelUtil.ExportExcelToDataSet(data, saveFileName);
            resultMsg = bResult ?
                "엑셀파일을 저장하였습니다." : "엑셀파일 저장 중 문제가 발생하였습니다.";

            MessageBox.Show(resultMsg, msgTitle);
            return bResult;
        }
        #endregion


        private void btnSystem_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSystemSubMenu);
        }

        #region SystemSubMenu
        private void btnUser_Click(object sender, EventArgs e)
        {
            CreateTabPages("유저관리", new frmUserInfo());
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


        
      
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
