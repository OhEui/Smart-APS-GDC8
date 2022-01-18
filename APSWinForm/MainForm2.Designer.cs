
namespace APSWinForm
{
    partial class MainForm2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelSystemSubMenu = new System.Windows.Forms.Panel();
            this.btnAuth = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnSystem = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelExcelSubMenu = new System.Windows.Forms.Panel();
            this.btnExcelin = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.panelResultSubMenu = new System.Windows.Forms.Panel();
            this.btnUtil = new System.Windows.Forms.Button();
            this.btnEQPgant = new System.Windows.Forms.Button();
            this.btnLOT = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.panelInfoSubMenu = new System.Windows.Forms.Panel();
            this.btnSetup = new System.Windows.Forms.Button();
            this.btnARR = new System.Windows.Forms.Button();
            this.btnEquip = new System.Windows.Forms.Button();
            this.btnRoute = new System.Windows.Forms.Button();
            this.btnStdStep = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnDemand = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.tabControl1 = new TabControlZ.TabControlZ();
            this.btnExcelOut = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.panelSystemSubMenu.SuspendLayout();
            this.panelExcelSubMenu.SuspendLayout();
            this.panelResultSubMenu.SuspendLayout();
            this.panelInfoSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(212)))), ((int)(((byte)(226)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.toolStripMenuItem1.Text = "메뉴";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem2.Text = "로그아웃";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem3.Text = "종료";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.panelSideMenu.Controls.Add(this.panelSystemSubMenu);
            this.panelSideMenu.Controls.Add(this.btnSystem);
            this.panelSideMenu.Controls.Add(this.btnExit);
            this.panelSideMenu.Controls.Add(this.panelExcelSubMenu);
            this.panelSideMenu.Controls.Add(this.btnExcel);
            this.panelSideMenu.Controls.Add(this.panelResultSubMenu);
            this.panelSideMenu.Controls.Add(this.btnResult);
            this.panelSideMenu.Controls.Add(this.panelInfoSubMenu);
            this.panelSideMenu.Controls.Add(this.btnInfo);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panelSideMenu.Location = new System.Drawing.Point(0, 24);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(222, 743);
            this.panelSideMenu.TabIndex = 7;
            // 
            // panelSystemSubMenu
            // 
            this.panelSystemSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSystemSubMenu.Controls.Add(this.btnAuth);
            this.panelSystemSubMenu.Controls.Add(this.btnUser);
            this.panelSystemSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSystemSubMenu.Location = new System.Drawing.Point(0, 639);
            this.panelSystemSubMenu.Name = "panelSystemSubMenu";
            this.panelSystemSubMenu.Size = new System.Drawing.Size(205, 63);
            this.panelSystemSubMenu.TabIndex = 11;
            // 
            // btnAuth
            // 
            this.btnAuth.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAuth.FlatAppearance.BorderSize = 0;
            this.btnAuth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnAuth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnAuth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuth.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAuth.ForeColor = System.Drawing.Color.Silver;
            this.btnAuth.Location = new System.Drawing.Point(0, 30);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAuth.Size = new System.Drawing.Size(205, 30);
            this.btnAuth.TabIndex = 1;
            this.btnAuth.Text = "권한 관리";
            this.btnAuth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAuth.UseVisualStyleBackColor = true;
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
            // 
            // btnUser
            // 
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUser.ForeColor = System.Drawing.Color.Silver;
            this.btnUser.Location = new System.Drawing.Point(0, 0);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnUser.Size = new System.Drawing.Size(205, 30);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "사용자 관리";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnSystem
            // 
            this.btnSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.btnSystem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSystem.FlatAppearance.BorderSize = 0;
            this.btnSystem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnSystem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystem.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSystem.ForeColor = System.Drawing.Color.Silver;
            this.btnSystem.Image = global::APSWinForm.Properties.Resources.tools;
            this.btnSystem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSystem.Location = new System.Drawing.Point(0, 594);
            this.btnSystem.Name = "btnSystem";
            this.btnSystem.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSystem.Size = new System.Drawing.Size(205, 45);
            this.btnSystem.TabIndex = 10;
            this.btnSystem.Text = "  시스템 관리";
            this.btnSystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSystem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSystem.UseVisualStyleBackColor = false;
            this.btnSystem.Click += new System.EventHandler(this.btnSystem_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExit.ForeColor = System.Drawing.Color.Silver;
            this.btnExit.Image = global::APSWinForm.Properties.Resources.exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 702);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(205, 45);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "  Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelExcelSubMenu
            // 
            this.panelExcelSubMenu.AutoSize = true;
            this.panelExcelSubMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelExcelSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelExcelSubMenu.Controls.Add(this.btnExcelOut);
            this.panelExcelSubMenu.Controls.Add(this.btnExcelin);
            this.panelExcelSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelExcelSubMenu.Location = new System.Drawing.Point(0, 534);
            this.panelExcelSubMenu.Name = "panelExcelSubMenu";
            this.panelExcelSubMenu.Size = new System.Drawing.Size(205, 60);
            this.panelExcelSubMenu.TabIndex = 7;
            // 
            // btnExcelin
            // 
            this.btnExcelin.AutoSize = true;
            this.btnExcelin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExcelin.FlatAppearance.BorderSize = 0;
            this.btnExcelin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnExcelin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnExcelin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcelin.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExcelin.ForeColor = System.Drawing.Color.Silver;
            this.btnExcelin.Location = new System.Drawing.Point(0, 0);
            this.btnExcelin.Name = "btnExcelin";
            this.btnExcelin.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnExcelin.Size = new System.Drawing.Size(205, 30);
            this.btnExcelin.TabIndex = 0;
            this.btnExcelin.Text = "엑셀 불러오기";
            this.btnExcelin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcelin.UseVisualStyleBackColor = true;
            this.btnExcelin.Visible = false;
            this.btnExcelin.Click += new System.EventHandler(this.btnExcelin_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.btnExcel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExcel.ForeColor = System.Drawing.Color.Silver;
            this.btnExcel.Image = global::APSWinForm.Properties.Resources.xls;
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(0, 489);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnExcel.Size = new System.Drawing.Size(205, 45);
            this.btnExcel.TabIndex = 6;
            this.btnExcel.Text = "  EXCEL";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // panelResultSubMenu
            // 
            this.panelResultSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelResultSubMenu.Controls.Add(this.btnUtil);
            this.panelResultSubMenu.Controls.Add(this.btnEQPgant);
            this.panelResultSubMenu.Controls.Add(this.btnLOT);
            this.panelResultSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelResultSubMenu.Location = new System.Drawing.Point(0, 396);
            this.panelResultSubMenu.Name = "panelResultSubMenu";
            this.panelResultSubMenu.Size = new System.Drawing.Size(205, 93);
            this.panelResultSubMenu.TabIndex = 4;
            // 
            // btnUtil
            // 
            this.btnUtil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUtil.FlatAppearance.BorderSize = 0;
            this.btnUtil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnUtil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnUtil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUtil.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUtil.ForeColor = System.Drawing.Color.Silver;
            this.btnUtil.Location = new System.Drawing.Point(0, 60);
            this.btnUtil.Name = "btnUtil";
            this.btnUtil.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnUtil.Size = new System.Drawing.Size(205, 30);
            this.btnUtil.TabIndex = 2;
            this.btnUtil.Text = "가동률분석";
            this.btnUtil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUtil.UseVisualStyleBackColor = true;
            this.btnUtil.Click += new System.EventHandler(this.btnUtil_Click);
            // 
            // btnEQPgant
            // 
            this.btnEQPgant.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEQPgant.FlatAppearance.BorderSize = 0;
            this.btnEQPgant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnEQPgant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnEQPgant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEQPgant.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEQPgant.ForeColor = System.Drawing.Color.Silver;
            this.btnEQPgant.Location = new System.Drawing.Point(0, 30);
            this.btnEQPgant.Name = "btnEQPgant";
            this.btnEQPgant.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEQPgant.Size = new System.Drawing.Size(205, 30);
            this.btnEQPgant.TabIndex = 1;
            this.btnEQPgant.Text = "EQP 간트차트";
            this.btnEQPgant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEQPgant.UseVisualStyleBackColor = true;
            this.btnEQPgant.Click += new System.EventHandler(this.btnEQPgant_Click);
            // 
            // btnLOT
            // 
            this.btnLOT.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLOT.FlatAppearance.BorderSize = 0;
            this.btnLOT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnLOT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnLOT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLOT.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLOT.ForeColor = System.Drawing.Color.Silver;
            this.btnLOT.Location = new System.Drawing.Point(0, 0);
            this.btnLOT.Name = "btnLOT";
            this.btnLOT.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnLOT.Size = new System.Drawing.Size(205, 30);
            this.btnLOT.TabIndex = 0;
            this.btnLOT.Text = "LOT 간트차트";
            this.btnLOT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLOT.UseVisualStyleBackColor = true;
            this.btnLOT.Click += new System.EventHandler(this.btnLOT_Click);
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.btnResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResult.FlatAppearance.BorderSize = 0;
            this.btnResult.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnResult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResult.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnResult.ForeColor = System.Drawing.Color.Silver;
            this.btnResult.Image = global::APSWinForm.Properties.Resources.Chart;
            this.btnResult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResult.Location = new System.Drawing.Point(0, 351);
            this.btnResult.Name = "btnResult";
            this.btnResult.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnResult.Size = new System.Drawing.Size(205, 45);
            this.btnResult.TabIndex = 3;
            this.btnResult.Text = " 결과 차트 조회";
            this.btnResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResult.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // panelInfoSubMenu
            // 
            this.panelInfoSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelInfoSubMenu.Controls.Add(this.btnSetup);
            this.panelInfoSubMenu.Controls.Add(this.btnARR);
            this.panelInfoSubMenu.Controls.Add(this.btnEquip);
            this.panelInfoSubMenu.Controls.Add(this.btnRoute);
            this.panelInfoSubMenu.Controls.Add(this.btnStdStep);
            this.panelInfoSubMenu.Controls.Add(this.btnLine);
            this.panelInfoSubMenu.Controls.Add(this.btnDemand);
            this.panelInfoSubMenu.Controls.Add(this.btnProduct);
            this.panelInfoSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfoSubMenu.Location = new System.Drawing.Point(0, 108);
            this.panelInfoSubMenu.Name = "panelInfoSubMenu";
            this.panelInfoSubMenu.Size = new System.Drawing.Size(205, 243);
            this.panelInfoSubMenu.TabIndex = 2;
            // 
            // btnSetup
            // 
            this.btnSetup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetup.FlatAppearance.BorderSize = 0;
            this.btnSetup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnSetup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetup.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSetup.ForeColor = System.Drawing.Color.Silver;
            this.btnSetup.Location = new System.Drawing.Point(0, 210);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSetup.Size = new System.Drawing.Size(205, 30);
            this.btnSetup.TabIndex = 7;
            this.btnSetup.Text = "교체준비시간관리";
            this.btnSetup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // btnARR
            // 
            this.btnARR.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnARR.FlatAppearance.BorderSize = 0;
            this.btnARR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnARR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnARR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnARR.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnARR.ForeColor = System.Drawing.Color.Silver;
            this.btnARR.Location = new System.Drawing.Point(0, 180);
            this.btnARR.Name = "btnARR";
            this.btnARR.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnARR.Size = new System.Drawing.Size(205, 30);
            this.btnARR.TabIndex = 6;
            this.btnARR.Text = "설비배치정보관리";
            this.btnARR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnARR.UseVisualStyleBackColor = true;
            this.btnARR.Click += new System.EventHandler(this.btnARR_Click);
            // 
            // btnEquip
            // 
            this.btnEquip.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEquip.FlatAppearance.BorderSize = 0;
            this.btnEquip.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnEquip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnEquip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquip.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEquip.ForeColor = System.Drawing.Color.Silver;
            this.btnEquip.Location = new System.Drawing.Point(0, 150);
            this.btnEquip.Name = "btnEquip";
            this.btnEquip.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEquip.Size = new System.Drawing.Size(205, 30);
            this.btnEquip.TabIndex = 5;
            this.btnEquip.Text = "설비정보관리";
            this.btnEquip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEquip.UseVisualStyleBackColor = true;
            this.btnEquip.Click += new System.EventHandler(this.btnEquip_Click);
            // 
            // btnRoute
            // 
            this.btnRoute.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoute.FlatAppearance.BorderSize = 0;
            this.btnRoute.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnRoute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoute.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRoute.ForeColor = System.Drawing.Color.Silver;
            this.btnRoute.Location = new System.Drawing.Point(0, 120);
            this.btnRoute.Name = "btnRoute";
            this.btnRoute.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRoute.Size = new System.Drawing.Size(205, 30);
            this.btnRoute.TabIndex = 4;
            this.btnRoute.Text = "공정순서관리";
            this.btnRoute.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoute.UseVisualStyleBackColor = true;
            this.btnRoute.Click += new System.EventHandler(this.btnRoute_Click);
            // 
            // btnStdStep
            // 
            this.btnStdStep.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStdStep.FlatAppearance.BorderSize = 0;
            this.btnStdStep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnStdStep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnStdStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStdStep.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStdStep.ForeColor = System.Drawing.Color.Silver;
            this.btnStdStep.Location = new System.Drawing.Point(0, 90);
            this.btnStdStep.Name = "btnStdStep";
            this.btnStdStep.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnStdStep.Size = new System.Drawing.Size(205, 30);
            this.btnStdStep.TabIndex = 3;
            this.btnStdStep.Text = "표준공정정보관리";
            this.btnStdStep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStdStep.UseVisualStyleBackColor = true;
            this.btnStdStep.Click += new System.EventHandler(this.btnStdStep_Click);
            // 
            // btnLine
            // 
            this.btnLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLine.FlatAppearance.BorderSize = 0;
            this.btnLine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLine.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLine.ForeColor = System.Drawing.Color.Silver;
            this.btnLine.Location = new System.Drawing.Point(0, 60);
            this.btnLine.Name = "btnLine";
            this.btnLine.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnLine.Size = new System.Drawing.Size(205, 30);
            this.btnLine.TabIndex = 2;
            this.btnLine.Text = "라인정보관리";
            this.btnLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnDemand
            // 
            this.btnDemand.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDemand.FlatAppearance.BorderSize = 0;
            this.btnDemand.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnDemand.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnDemand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDemand.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDemand.ForeColor = System.Drawing.Color.Silver;
            this.btnDemand.Location = new System.Drawing.Point(0, 30);
            this.btnDemand.Name = "btnDemand";
            this.btnDemand.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDemand.Size = new System.Drawing.Size(205, 30);
            this.btnDemand.TabIndex = 1;
            this.btnDemand.Text = "수요정보관리";
            this.btnDemand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDemand.UseVisualStyleBackColor = true;
            this.btnDemand.Click += new System.EventHandler(this.btnDemand_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProduct.ForeColor = System.Drawing.Color.Silver;
            this.btnProduct.Location = new System.Drawing.Point(0, 0);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnProduct.Size = new System.Drawing.Size(205, 30);
            this.btnProduct.TabIndex = 0;
            this.btnProduct.Tag = "frmPRODUCT";
            this.btnProduct.Text = "제품정보관리";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInfo.ForeColor = System.Drawing.Color.Silver;
            this.btnInfo.Image = global::APSWinForm.Properties.Resources.Manage;
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Location = new System.Drawing.Point(0, 63);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnInfo.Size = new System.Drawing.Size(205, 45);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.Text = "  기준정보관리";
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(205, 63);
            this.panelLogo.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(212)))), ((int)(((byte)(226)))));
            this.lblName.Location = new System.Drawing.Point(762, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 12);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "label1";
            // 
            // tabControl1
            // 
            this.tabControl1.ActiveTabEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(212)))), ((int)(((byte)(226)))));
            this.tabControl1.ActiveTabStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(212)))), ((int)(((byte)(226)))));
            this.tabControl1.CloseButtonColor = System.Drawing.Color.Red;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabControl1.GradientAngle = 90;
            this.tabControl1.Location = new System.Drawing.Point(222, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.NonActiveTabEndColor = System.Drawing.Color.SteelBlue;
            this.tabControl1.NonActiveTabStartColor = System.Drawing.Color.SteelBlue;
            this.tabControl1.Padding = new System.Drawing.Point(22, 4);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(711, 743);
            this.tabControl1.TabIndex = 20;
            this.tabControl1.TextColor = System.Drawing.Color.Black;
            this.tabControl1.Transparent1 = 150;
            this.tabControl1.Transparent2 = 150;
            // 
            // btnExcelOut
            // 
            this.btnExcelOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExcelOut.FlatAppearance.BorderSize = 0;
            this.btnExcelOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnExcelOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.btnExcelOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcelOut.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExcelOut.ForeColor = System.Drawing.Color.Silver;
            this.btnExcelOut.Location = new System.Drawing.Point(0, 30);
            this.btnExcelOut.Name = "btnExcelOut";
            this.btnExcelOut.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnExcelOut.Size = new System.Drawing.Size(205, 30);
            this.btnExcelOut.TabIndex = 2;
            this.btnExcelOut.Text = "엑셀 내보내기";
            this.btnExcelOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcelOut.UseVisualStyleBackColor = true;
            // 
            // MainForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 767);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MainForm2";
            this.Text = "APS";
            this.Load += new System.EventHandler(this.MainForm2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenu.PerformLayout();
            this.panelSystemSubMenu.ResumeLayout(false);
            this.panelExcelSubMenu.ResumeLayout(false);
            this.panelExcelSubMenu.PerformLayout();
            this.panelResultSubMenu.ResumeLayout(false);
            this.panelInfoSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelSystemSubMenu;
        private System.Windows.Forms.Button btnAuth;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnSystem;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelExcelSubMenu;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Panel panelResultSubMenu;
        private System.Windows.Forms.Button btnUtil;
        private System.Windows.Forms.Button btnEQPgant;
        private System.Windows.Forms.Button btnLOT;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Panel panelInfoSubMenu;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.Button btnARR;
        private System.Windows.Forms.Button btnEquip;
        private System.Windows.Forms.Button btnRoute;
        private System.Windows.Forms.Button btnStdStep;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnDemand;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblName;
        private TabControlZ.TabControlZ tabControl1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Button btnExcelin;
        private System.Windows.Forms.Button btnExcelOut;
    }
}