
namespace APSWinForm
{
    partial class MenuAuth
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAuth));
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel9 = new System.Windows.Forms.Panel();
			this.txtID = new System.Windows.Forms.Label();
			this.txtno = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.panel8 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.title = new System.Windows.Forms.ToolStripLabel();
			this.BtnDelete = new System.Windows.Forms.ToolStripButton();
			this.BtnEdit = new System.Windows.Forms.ToolStripButton();
			this.BtnAdd = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.XlsDown = new System.Windows.Forms.ToolStripButton();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitter4 = new System.Windows.Forms.Splitter();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.dgvUser = new System.Windows.Forms.DataGridView();
			this.splitter3 = new System.Windows.Forms.Splitter();
			this.splitter2 = new System.Windows.Forms.Splitter();
			this.dgvAuth = new System.Windows.Forms.DataGridView();
			this.panel2.SuspendLayout();
			this.panel9.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvAuth)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
			this.panel2.Controls.Add(this.panel1);
			this.panel2.Controls.Add(this.panel9);
			this.panel2.Controls.Add(this.panel8);
			this.panel2.Controls.Add(this.panel6);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 49);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
			this.panel2.Size = new System.Drawing.Size(1005, 124);
			this.panel2.TabIndex = 67;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Location = new System.Drawing.Point(10, 156);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(985, 363);
			this.panel1.TabIndex = 55;
			// 
			// panel9
			// 
			this.panel9.BackColor = System.Drawing.Color.White;
			this.panel9.Controls.Add(this.txtID);
			this.panel9.Controls.Add(this.txtno);
			this.panel9.Controls.Add(this.txtName);
			this.panel9.Controls.Add(this.label5);
			this.panel9.Controls.Add(this.btnReset);
			this.panel9.Controls.Add(this.btnSearch);
			this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel9.Location = new System.Drawing.Point(10, 10);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(985, 104);
			this.panel9.TabIndex = 42;
			// 
			// txtID
			// 
			this.txtID.AutoSize = true;
			this.txtID.Location = new System.Drawing.Point(152, 88);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(0, 12);
			this.txtID.TabIndex = 182;
			this.txtID.Visible = false;
			// 
			// txtno
			// 
			this.txtno.AutoSize = true;
			this.txtno.Location = new System.Drawing.Point(372, 89);
			this.txtno.Name = "txtno";
			this.txtno.Size = new System.Drawing.Size(0, 12);
			this.txtno.TabIndex = 181;
			this.txtno.Visible = false;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(116, 43);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(121, 21);
			this.txtName.TabIndex = 180;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label5.Location = new System.Drawing.Point(28, 46);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 14);
			this.label5.TabIndex = 177;
			this.label5.Text = "ㆍ사원명";
			// 
			// btnReset
			// 
			this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(105)))), ((int)(((byte)(129)))));
			this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReset.ForeColor = System.Drawing.Color.White;
			this.btnReset.Location = new System.Drawing.Point(869, 60);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(74, 30);
			this.btnReset.TabIndex = 56;
			this.btnReset.Text = "초기화";
			this.btnReset.UseVisualStyleBackColor = false;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(106)))));
			this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.ForeColor = System.Drawing.Color.White;
			this.btnSearch.Location = new System.Drawing.Point(869, 20);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(74, 30);
			this.btnSearch.TabIndex = 55;
			this.btnSearch.Text = "검색";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// panel8
			// 
			this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel8.Location = new System.Drawing.Point(995, 10);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(10, 104);
			this.panel8.TabIndex = 41;
			// 
			// panel6
			// 
			this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel6.Location = new System.Drawing.Point(0, 10);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(10, 104);
			this.panel6.TabIndex = 39;
			// 
			// toolStrip1
			// 
			this.toolStrip1.AutoSize = false;
			this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(212)))), ((int)(((byte)(226)))));
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.title,
            this.BtnDelete,
            this.BtnEdit,
            this.BtnAdd,
            this.toolStripSeparator1,
            this.XlsDown});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1005, 49);
			this.toolStrip1.TabIndex = 66;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// title
			// 
			this.title.Font = new System.Drawing.Font("ONE 모바일고딕 Title OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.title.Image = ((System.Drawing.Image)(resources.GetObject("title.Image")));
			this.title.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(90, 46);
			this.title.Text = "권한관리";
			// 
			// BtnDelete
			// 
			this.BtnDelete.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.BtnDelete.Image = global::APSWinForm.Properties.Resources.del;
			this.BtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnDelete.Margin = new System.Windows.Forms.Padding(7, 1, 0, 2);
			this.BtnDelete.Name = "BtnDelete";
			this.BtnDelete.Size = new System.Drawing.Size(35, 46);
			this.BtnDelete.Text = "삭제";
			this.BtnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.BtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// BtnEdit
			// 
			this.BtnEdit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.BtnEdit.Image = global::APSWinForm.Properties.Resources.free_icon_edit_1827933;
			this.BtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnEdit.Margin = new System.Windows.Forms.Padding(7, 1, 0, 2);
			this.BtnEdit.Name = "BtnEdit";
			this.BtnEdit.Size = new System.Drawing.Size(35, 46);
			this.BtnEdit.Text = "저장";
			this.BtnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.BtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.BtnEdit.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// BtnAdd
			// 
			this.BtnAdd.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.BtnAdd.Image = global::APSWinForm.Properties.Resources.premium_icon_add_button_4904022;
			this.BtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnAdd.Margin = new System.Windows.Forms.Padding(7, 1, 0, 2);
			this.BtnAdd.Name = "BtnAdd";
			this.BtnAdd.Size = new System.Drawing.Size(35, 46);
			this.BtnAdd.Text = "추가";
			this.BtnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.BtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 49);
			// 
			// XlsDown
			// 
			this.XlsDown.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.XlsDown.Image = global::APSWinForm.Properties.Resources.free_icon_save_file_2810399;
			this.XlsDown.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.XlsDown.Margin = new System.Windows.Forms.Padding(7, 1, 0, 2);
			this.XlsDown.Name = "XlsDown";
			this.XlsDown.Size = new System.Drawing.Size(59, 46);
			this.XlsDown.Text = "엑셀받기";
			this.XlsDown.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.XlsDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// splitContainer1
			// 
			this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.splitter4);
			this.splitContainer1.Panel1.Controls.Add(this.splitter1);
			this.splitContainer1.Panel1.Controls.Add(this.dgvUser);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitter3);
			this.splitContainer1.Panel2.Controls.Add(this.splitter2);
			this.splitContainer1.Panel2.Controls.Add(this.dgvAuth);
			this.splitContainer1.Size = new System.Drawing.Size(1005, 637);
			this.splitContainer1.SplitterDistance = 460;
			this.splitContainer1.SplitterWidth = 5;
			this.splitContainer1.TabIndex = 68;
			// 
			// splitter4
			// 
			this.splitter4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
			this.splitter4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.splitter4.Location = new System.Drawing.Point(10, 627);
			this.splitter4.Name = "splitter4";
			this.splitter4.Size = new System.Drawing.Size(450, 10);
			this.splitter4.TabIndex = 57;
			this.splitter4.TabStop = false;
			// 
			// splitter1
			// 
			this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
			this.splitter1.Location = new System.Drawing.Point(0, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(10, 637);
			this.splitter1.TabIndex = 54;
			this.splitter1.TabStop = false;
			// 
			// dgvUser
			// 
			this.dgvUser.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.dgvUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUser.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvUser.Location = new System.Drawing.Point(0, 0);
			this.dgvUser.Name = "dgvUser";
			this.dgvUser.RowTemplate.Height = 23;
			this.dgvUser.Size = new System.Drawing.Size(460, 637);
			this.dgvUser.TabIndex = 53;
			this.dgvUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
			// 
			// splitter3
			// 
			this.splitter3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
			this.splitter3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.splitter3.Location = new System.Drawing.Point(0, 627);
			this.splitter3.Name = "splitter3";
			this.splitter3.Size = new System.Drawing.Size(530, 10);
			this.splitter3.TabIndex = 56;
			this.splitter3.TabStop = false;
			// 
			// splitter2
			// 
			this.splitter2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
			this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
			this.splitter2.Location = new System.Drawing.Point(530, 0);
			this.splitter2.Name = "splitter2";
			this.splitter2.Size = new System.Drawing.Size(10, 637);
			this.splitter2.TabIndex = 55;
			this.splitter2.TabStop = false;
			// 
			// dgvAuth
			// 
			this.dgvAuth.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.dgvAuth.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvAuth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAuth.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvAuth.Location = new System.Drawing.Point(0, 0);
			this.dgvAuth.Name = "dgvAuth";
			this.dgvAuth.RowHeadersVisible = false;
			this.dgvAuth.RowTemplate.Height = 23;
			this.dgvAuth.Size = new System.Drawing.Size(540, 637);
			this.dgvAuth.TabIndex = 54;
			this.dgvAuth.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAuth_CellClick);
			// 
			// MenuAuth
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1005, 637);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.splitContainer1);
			this.Name = "MenuAuth";
			this.Text = "권한관리";
			this.Load += new System.EventHandler(this.MenuAuth_Load);
			this.panel2.ResumeLayout(false);
			this.panel9.ResumeLayout(false);
			this.panel9.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvAuth)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ToolStrip toolStrip1;
        protected System.Windows.Forms.ToolStripLabel title;
        public System.Windows.Forms.ToolStripButton BtnDelete;
        public System.Windows.Forms.ToolStripButton BtnEdit;
        public System.Windows.Forms.ToolStripButton BtnAdd;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripButton XlsDown;
        protected System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Button btnReset;
        protected System.Windows.Forms.Button btnSearch;
        protected System.Windows.Forms.Panel panel8;
        protected System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.Label txtno;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Splitter splitter4;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.DataGridView dgvUser;
		private System.Windows.Forms.Splitter splitter3;
		private System.Windows.Forms.Splitter splitter2;
		private System.Windows.Forms.DataGridView dgvAuth;
	}
}