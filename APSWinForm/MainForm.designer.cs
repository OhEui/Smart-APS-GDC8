﻿
namespace APSWinForm
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.메뉴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.엑셀불러오기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.엑셀내보내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.결과정보열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.SidePanel1 = new System.Windows.Forms.Panel();
            this.panelSubMenu4 = new System.Windows.Forms.Panel();
            this.btnUtilization = new System.Windows.Forms.Button();
            this.btnEQPGantt = new System.Windows.Forms.Button();
            this.btnLOTGantt = new System.Windows.Forms.Button();
            this.btnSubMenu4 = new System.Windows.Forms.Button();
            this.SubPanel1 = new System.Windows.Forms.Panel();
            this.btnTime = new System.Windows.Forms.Button();
            this.btnARR = new System.Windows.Forms.Button();
            this.btnEquipment = new System.Windows.Forms.Button();
            this.btnRoute = new System.Windows.Forms.Button();
            this.btnSTD = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnDemand = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnSubMenu1 = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.button22 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.샘플ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.SidePanel1.SuspendLayout();
            this.panelSubMenu4.SuspendLayout();
            this.SubPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(212)))), ((int)(((byte)(226)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메뉴ToolStripMenuItem,
            this.샘플ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1226, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 메뉴ToolStripMenuItem
            // 
            this.메뉴ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.엑셀불러오기ToolStripMenuItem,
            this.엑셀내보내기ToolStripMenuItem,
            this.toolStripSeparator1,
            this.결과정보열기ToolStripMenuItem,
            this.toolStripSeparator2,
            this.종료ToolStripMenuItem});
            this.메뉴ToolStripMenuItem.Name = "메뉴ToolStripMenuItem";
            this.메뉴ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.메뉴ToolStripMenuItem.Text = "메뉴";
            // 
            // 엑셀불러오기ToolStripMenuItem
            // 
            this.엑셀불러오기ToolStripMenuItem.Name = "엑셀불러오기ToolStripMenuItem";
            this.엑셀불러오기ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.엑셀불러오기ToolStripMenuItem.Text = "엑셀 불러오기";
            // 
            // 엑셀내보내기ToolStripMenuItem
            // 
            this.엑셀내보내기ToolStripMenuItem.Name = "엑셀내보내기ToolStripMenuItem";
            this.엑셀내보내기ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.엑셀내보내기ToolStripMenuItem.Text = "엑셀 내보내기";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // 결과정보열기ToolStripMenuItem
            // 
            this.결과정보열기ToolStripMenuItem.Name = "결과정보열기ToolStripMenuItem";
            this.결과정보열기ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.결과정보열기ToolStripMenuItem.Text = "결과 정보 열기";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.종료ToolStripMenuItem.Text = "종료";
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(212)))), ((int)(((byte)(226)))));
            this.panelSideMenu.Controls.Add(this.SidePanel1);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.ForeColor = System.Drawing.Color.Blue;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 24);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Padding = new System.Windows.Forms.Padding(10);
            this.panelSideMenu.Size = new System.Drawing.Size(220, 669);
            this.panelSideMenu.TabIndex = 12;
            // 
            // SidePanel1
            // 
            this.SidePanel1.AutoScroll = true;
            this.SidePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(212)))), ((int)(((byte)(226)))));
            this.SidePanel1.Controls.Add(this.panelSubMenu4);
            this.SidePanel1.Controls.Add(this.btnSubMenu4);
            this.SidePanel1.Controls.Add(this.SubPanel1);
            this.SidePanel1.Controls.Add(this.btnSubMenu1);
            this.SidePanel1.Controls.Add(this.menuStrip2);
            this.SidePanel1.Controls.Add(this.button22);
            this.SidePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SidePanel1.Location = new System.Drawing.Point(10, 10);
            this.SidePanel1.Name = "SidePanel1";
            this.SidePanel1.Size = new System.Drawing.Size(200, 649);
            this.SidePanel1.TabIndex = 1;
            // 
            // panelSubMenu4
            // 
            this.panelSubMenu4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(32)))));
            this.panelSubMenu4.Controls.Add(this.btnUtilization);
            this.panelSubMenu4.Controls.Add(this.btnEQPGantt);
            this.panelSubMenu4.Controls.Add(this.btnLOTGantt);
            this.panelSubMenu4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenu4.Location = new System.Drawing.Point(0, 262);
            this.panelSubMenu4.Name = "panelSubMenu4";
            this.panelSubMenu4.Size = new System.Drawing.Size(200, 77);
            this.panelSubMenu4.TabIndex = 20;
            // 
            // btnUtilization
            // 
            this.btnUtilization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.btnUtilization.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUtilization.FlatAppearance.BorderSize = 0;
            this.btnUtilization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUtilization.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUtilization.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(7)))));
            this.btnUtilization.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUtilization.Location = new System.Drawing.Point(0, 50);
            this.btnUtilization.Name = "btnUtilization";
            this.btnUtilization.Padding = new System.Windows.Forms.Padding(25, 0, 55, 0);
            this.btnUtilization.Size = new System.Drawing.Size(200, 25);
            this.btnUtilization.TabIndex = 2;
            this.btnUtilization.Text = "Utilization";
            this.btnUtilization.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUtilization.UseVisualStyleBackColor = false;
            // 
            // btnEQPGantt
            // 
            this.btnEQPGantt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.btnEQPGantt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEQPGantt.FlatAppearance.BorderSize = 0;
            this.btnEQPGantt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEQPGantt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEQPGantt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.btnEQPGantt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEQPGantt.Location = new System.Drawing.Point(0, 25);
            this.btnEQPGantt.Name = "btnEQPGantt";
            this.btnEQPGantt.Padding = new System.Windows.Forms.Padding(25, 0, 30, 0);
            this.btnEQPGantt.Size = new System.Drawing.Size(200, 25);
            this.btnEQPGantt.TabIndex = 1;
            this.btnEQPGantt.Text = "EQP Gantt";
            this.btnEQPGantt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEQPGantt.UseVisualStyleBackColor = false;
            // 
            // btnLOTGantt
            // 
            this.btnLOTGantt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.btnLOTGantt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLOTGantt.FlatAppearance.BorderSize = 0;
            this.btnLOTGantt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLOTGantt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLOTGantt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(7)))));
            this.btnLOTGantt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLOTGantt.Location = new System.Drawing.Point(0, 0);
            this.btnLOTGantt.Name = "btnLOTGantt";
            this.btnLOTGantt.Padding = new System.Windows.Forms.Padding(25, 0, 55, 0);
            this.btnLOTGantt.Size = new System.Drawing.Size(200, 25);
            this.btnLOTGantt.TabIndex = 0;
            this.btnLOTGantt.Text = "LOT Gantt";
            this.btnLOTGantt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLOTGantt.UseVisualStyleBackColor = false;
            // 
            // btnSubMenu4
            // 
            this.btnSubMenu4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
            this.btnSubMenu4.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenu4.FlatAppearance.BorderSize = 0;
            this.btnSubMenu4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenu4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenu4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btnSubMenu4.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSubMenu4.Location = new System.Drawing.Point(0, 232);
            this.btnSubMenu4.Name = "btnSubMenu4";
            this.btnSubMenu4.Padding = new System.Windows.Forms.Padding(0, 0, 45, 0);
            this.btnSubMenu4.Size = new System.Drawing.Size(200, 30);
            this.btnSubMenu4.TabIndex = 18;
            this.btnSubMenu4.Text = " ㆍResult";
            this.btnSubMenu4.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSubMenu4.UseVisualStyleBackColor = false;
            // 
            // SubPanel1
            // 
            this.SubPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(32)))));
            this.SubPanel1.Controls.Add(this.btnTime);
            this.SubPanel1.Controls.Add(this.btnARR);
            this.SubPanel1.Controls.Add(this.btnEquipment);
            this.SubPanel1.Controls.Add(this.btnRoute);
            this.SubPanel1.Controls.Add(this.btnSTD);
            this.SubPanel1.Controls.Add(this.btnLine);
            this.SubPanel1.Controls.Add(this.btnDemand);
            this.SubPanel1.Controls.Add(this.btnProduct);
            this.SubPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubPanel1.Location = new System.Drawing.Point(0, 30);
            this.SubPanel1.Name = "SubPanel1";
            this.SubPanel1.Size = new System.Drawing.Size(200, 202);
            this.SubPanel1.TabIndex = 2;
            // 
            // btnTime
            // 
            this.btnTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.btnTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTime.FlatAppearance.BorderSize = 0;
            this.btnTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.btnTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTime.Location = new System.Drawing.Point(0, 175);
            this.btnTime.Name = "btnTime";
            this.btnTime.Padding = new System.Windows.Forms.Padding(25, 0, 30, 0);
            this.btnTime.Size = new System.Drawing.Size(200, 25);
            this.btnTime.TabIndex = 7;
            this.btnTime.Text = "SETUP_TIME";
            this.btnTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTime.UseVisualStyleBackColor = false;
            // 
            // btnARR
            // 
            this.btnARR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.btnARR.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnARR.FlatAppearance.BorderSize = 0;
            this.btnARR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnARR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnARR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(7)))));
            this.btnARR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnARR.Location = new System.Drawing.Point(0, 150);
            this.btnARR.Name = "btnARR";
            this.btnARR.Padding = new System.Windows.Forms.Padding(25, 0, 43, 0);
            this.btnARR.Size = new System.Drawing.Size(200, 25);
            this.btnARR.TabIndex = 6;
            this.btnARR.Text = "EQP ARR";
            this.btnARR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnARR.UseVisualStyleBackColor = false;
            // 
            // btnEquipment
            // 
            this.btnEquipment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.btnEquipment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEquipment.FlatAppearance.BorderSize = 0;
            this.btnEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.btnEquipment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEquipment.Location = new System.Drawing.Point(0, 125);
            this.btnEquipment.Name = "btnEquipment";
            this.btnEquipment.Padding = new System.Windows.Forms.Padding(25, 0, 30, 0);
            this.btnEquipment.Size = new System.Drawing.Size(200, 25);
            this.btnEquipment.TabIndex = 5;
            this.btnEquipment.Text = "EQUIPMENT";
            this.btnEquipment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEquipment.UseVisualStyleBackColor = false;
            // 
            // btnRoute
            // 
            this.btnRoute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.btnRoute.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoute.FlatAppearance.BorderSize = 0;
            this.btnRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(7)))));
            this.btnRoute.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoute.Location = new System.Drawing.Point(0, 100);
            this.btnRoute.Name = "btnRoute";
            this.btnRoute.Padding = new System.Windows.Forms.Padding(25, 0, 30, 0);
            this.btnRoute.Size = new System.Drawing.Size(200, 25);
            this.btnRoute.TabIndex = 4;
            this.btnRoute.Text = "STEP ROUTE";
            this.btnRoute.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoute.UseVisualStyleBackColor = false;
            // 
            // btnSTD
            // 
            this.btnSTD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.btnSTD.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSTD.FlatAppearance.BorderSize = 0;
            this.btnSTD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSTD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.btnSTD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSTD.Location = new System.Drawing.Point(0, 75);
            this.btnSTD.Name = "btnSTD";
            this.btnSTD.Padding = new System.Windows.Forms.Padding(25, 0, 55, 0);
            this.btnSTD.Size = new System.Drawing.Size(200, 25);
            this.btnSTD.TabIndex = 3;
            this.btnSTD.Text = "STD STEP";
            this.btnSTD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSTD.UseVisualStyleBackColor = false;
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.btnLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLine.FlatAppearance.BorderSize = 0;
            this.btnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(7)))));
            this.btnLine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLine.Location = new System.Drawing.Point(0, 50);
            this.btnLine.Name = "btnLine";
            this.btnLine.Padding = new System.Windows.Forms.Padding(25, 0, 30, 0);
            this.btnLine.Size = new System.Drawing.Size(200, 25);
            this.btnLine.TabIndex = 2;
            this.btnLine.Text = "LINE_INFO";
            this.btnLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLine.UseVisualStyleBackColor = false;
            // 
            // btnDemand
            // 
            this.btnDemand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.btnDemand.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDemand.FlatAppearance.BorderSize = 0;
            this.btnDemand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDemand.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.btnDemand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDemand.Location = new System.Drawing.Point(0, 25);
            this.btnDemand.Name = "btnDemand";
            this.btnDemand.Padding = new System.Windows.Forms.Padding(25, 0, 55, 0);
            this.btnDemand.Size = new System.Drawing.Size(200, 25);
            this.btnDemand.TabIndex = 1;
            this.btnDemand.Text = "DEMAND";
            this.btnDemand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDemand.UseVisualStyleBackColor = false;
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(7)))));
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.ImageKey = "(없음)";
            this.btnProduct.Location = new System.Drawing.Point(0, 0);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Padding = new System.Windows.Forms.Padding(25, 0, 55, 0);
            this.btnProduct.Size = new System.Drawing.Size(200, 25);
            this.btnProduct.TabIndex = 0;
            this.btnProduct.Text = "PRODUCT";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.UseVisualStyleBackColor = false;
            // 
            // btnSubMenu1
            // 
            this.btnSubMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
            this.btnSubMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMenu1.FlatAppearance.BorderSize = 0;
            this.btnSubMenu1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMenu1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.btnSubMenu1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSubMenu1.Location = new System.Drawing.Point(0, 0);
            this.btnSubMenu1.Name = "btnSubMenu1";
            this.btnSubMenu1.Padding = new System.Windows.Forms.Padding(0, 0, 45, 0);
            this.btnSubMenu1.Size = new System.Drawing.Size(200, 30);
            this.btnSubMenu1.TabIndex = 1;
            this.btnSubMenu1.Text = " ㆍInputs";
            this.btnSubMenu1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSubMenu1.UseVisualStyleBackColor = false;
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.Location = new System.Drawing.Point(17, 353);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(46, 42);
            this.menuStrip2.TabIndex = 21;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemAdded += new System.Windows.Forms.ToolStripItemEventHandler(this.menuStrip2_ItemAdded);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(251)))));
            this.button22.FlatAppearance.BorderSize = 0;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button22.ForeColor = System.Drawing.Color.Blue;
            this.button22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button22.Location = new System.Drawing.Point(3, 1);
            this.button22.Name = "button22";
            this.button22.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button22.Size = new System.Drawing.Size(180, 30);
            this.button22.TabIndex = 1;
            this.button22.Text = "현황보기";
            this.button22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button22.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(220, 24);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1006, 20);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(998, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(998, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // 샘플ToolStripMenuItem
            // 
            this.샘플ToolStripMenuItem.Name = "샘플ToolStripMenuItem";
            this.샘플ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.샘플ToolStripMenuItem.Text = "샘플";
            this.샘플ToolStripMenuItem.Click += new System.EventHandler(this.샘플ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1226, 693);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "MainForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelSideMenu.ResumeLayout(false);
            this.SidePanel1.ResumeLayout(false);
            this.panelSubMenu4.ResumeLayout(false);
            this.SubPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 메뉴ToolStripMenuItem;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel SidePanel1;
        private System.Windows.Forms.Panel panelSubMenu4;
        private System.Windows.Forms.Button btnUtilization;
        private System.Windows.Forms.Button btnEQPGantt;
        private System.Windows.Forms.Button btnLOTGantt;
        private System.Windows.Forms.Button btnSubMenu4;
        private System.Windows.Forms.Panel SubPanel1;
        private System.Windows.Forms.Button btnTime;
        private System.Windows.Forms.Button btnARR;
        private System.Windows.Forms.Button btnEquipment;
        private System.Windows.Forms.Button btnRoute;
        private System.Windows.Forms.Button btnSTD;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnDemand;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnSubMenu1;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 엑셀불러오기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 엑셀내보내기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 결과정보열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 샘플ToolStripMenuItem;
    }
}