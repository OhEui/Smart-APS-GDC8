
namespace APSWinForm
{
	partial class STD_STEP_INFO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(STD_STEP_INFO));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvStepInfoList = new System.Windows.Forms.DataGridView();
            this.title = new System.Windows.Forms.ToolStripLabel();
            this.BtnDelete = new System.Windows.Forms.ToolStripButton();
            this.BtnEdit = new System.Windows.Forms.ToolStripButton();
            this.BtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.XlsDown = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnInit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStepID = new APSWinForm.CapitalTextBox();
            this.txtStepName = new APSWinForm.CapitalTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStepInfoList)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 49);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panel2.Size = new System.Drawing.Size(980, 124);
            this.panel2.TabIndex = 46;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(228)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(10, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(980, 579);
            this.dataGridView1.TabIndex = 50;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "DEMAND_VER";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "DEMAND_ID";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "PRODUCT_ID";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "CUSTOMER_ID";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "DUE_DATE";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "DEMAND_QTY";
            this.Column6.Name = "Column6";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(10, 628);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(980, 10);
            this.panel5.TabIndex = 49;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(990, 49);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 589);
            this.panel4.TabIndex = 48;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 589);
            this.panel3.TabIndex = 47;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(212)))), ((int)(((byte)(226)))));
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 49);
            this.panel1.TabIndex = 45;
            // 
            // dgvStepInfoList
            // 
            this.dgvStepInfoList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvStepInfoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStepInfoList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStepInfoList.Location = new System.Drawing.Point(10, 173);
            this.dgvStepInfoList.Name = "dgvStepInfoList";
            this.dgvStepInfoList.RowTemplate.Height = 23;
            this.dgvStepInfoList.Size = new System.Drawing.Size(980, 455);
            this.dgvStepInfoList.TabIndex = 51;
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("ONE 모바일고딕 Title OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title.Image = ((System.Drawing.Image)(resources.GetObject("title.Image")));
            this.title.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(128, 46);
            this.title.Text = "표준 공정 정보";
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
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnEdit.Image = global::APSWinForm.Properties.Resources.free_icon_edit_1827933;
            this.BtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(7, 1, 0, 2);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(35, 46);
            this.BtnEdit.Text = "수정";
            this.BtnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
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
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
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
            this.XlsDown.Click += new System.EventHandler(this.XlsDown_Click);
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
            this.toolStrip1.Size = new System.Drawing.Size(1000, 49);
            this.toolStrip1.TabIndex = 50;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(106)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(873, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 30);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnInit
            // 
            this.btnInit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnInit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(105)))), ((int)(((byte)(129)))));
            this.btnInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInit.ForeColor = System.Drawing.Color.White;
            this.btnInit.Location = new System.Drawing.Point(873, 59);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(74, 30);
            this.btnInit.TabIndex = 4;
            this.btnInit.Text = "초기화";
            this.btnInit.UseVisualStyleBackColor = false;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(26, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 14);
            this.label2.TabIndex = 55;
            this.label2.Text = "ㆍ표준공정ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(271, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 14);
            this.label9.TabIndex = 57;
            this.label9.Text = "ㆍ표준공정이름";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStepID
            // 
            this.txtStepID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStepID.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtStepID.Location = new System.Drawing.Point(111, 44);
            this.txtStepID.Name = "txtStepID";
            this.txtStepID.Size = new System.Drawing.Size(121, 21);
            this.txtStepID.TabIndex = 1;
            // 
            // txtStepName
            // 
            this.txtStepName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStepName.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtStepName.Location = new System.Drawing.Point(368, 44);
            this.txtStepName.Name = "txtStepName";
            this.txtStepName.Size = new System.Drawing.Size(121, 21);
            this.txtStepName.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(28, 21);
            this.textBox1.TabIndex = 63;
            this.textBox1.Visible = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.textBox1);
            this.panel9.Controls.Add(this.txtStepName);
            this.panel9.Controls.Add(this.txtStepID);
            this.panel9.Controls.Add(this.label9);
            this.panel9.Controls.Add(this.label2);
            this.panel9.Controls.Add(this.btnInit);
            this.panel9.Controls.Add(this.btnSearch);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 10);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(980, 104);
            this.panel9.TabIndex = 42;
            // 
            // STD_STEP_INFO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 638);
            this.Controls.Add(this.dgvStepInfoList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "STD_STEP_INFO";
            this.Text = "표준 공정 정보";
            this.Load += new System.EventHandler(this.STD_STEP_INFO_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStepInfoList)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		protected System.Windows.Forms.Panel panel2;
		public System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		protected System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.DataGridView dgvStepInfoList;
        public System.Windows.Forms.ToolStrip toolStrip1;
        protected System.Windows.Forms.ToolStripLabel title;
        public System.Windows.Forms.ToolStripButton BtnDelete;
        public System.Windows.Forms.ToolStripButton BtnEdit;
        public System.Windows.Forms.ToolStripButton BtnAdd;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripButton XlsDown;
        protected System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox textBox1;
        private CapitalTextBox txtStepName;
        private CapitalTextBox txtStepID;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Button btnInit;
        protected System.Windows.Forms.Button btnSearch;
    }
}