
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
			this.btnSearch = new System.Windows.Forms.Button();
			this.panel8 = new System.Windows.Forms.Panel();
			this.btnInit = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel9 = new System.Windows.Forms.Panel();
			this.txtStepName = new APSWinForm.CapitalTextBox();
			this.txtStepID = new APSWinForm.CapitalTextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
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
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dgvStepInfoList = new System.Windows.Forms.DataGridView();
			this.panel2.SuspendLayout();
			this.panel9.SuspendLayout();
			this.panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStepInfoList)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSearch
			// 
			this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(106)))));
			this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnSearch.ForeColor = System.Drawing.Color.White;
			this.btnSearch.Location = new System.Drawing.Point(561, 35);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(74, 30);
			this.btnSearch.TabIndex = 45;
			this.btnSearch.Text = "검색";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// panel8
			// 
			this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel8.Location = new System.Drawing.Point(678, 10);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(10, 136);
			this.panel8.TabIndex = 41;
			// 
			// btnInit
			// 
			this.btnInit.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnInit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(105)))), ((int)(((byte)(129)))));
			this.btnInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnInit.ForeColor = System.Drawing.Color.White;
			this.btnInit.Location = new System.Drawing.Point(561, 75);
			this.btnInit.Name = "btnInit";
			this.btnInit.Size = new System.Drawing.Size(74, 30);
			this.btnInit.TabIndex = 54;
			this.btnInit.Text = "초기화";
			this.btnInit.UseVisualStyleBackColor = false;
			this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
			this.panel2.Controls.Add(this.panel9);
			this.panel2.Controls.Add(this.panel8);
			this.panel2.Controls.Add(this.panel6);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(10, 38);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
			this.panel2.Size = new System.Drawing.Size(688, 156);
			this.panel2.TabIndex = 46;
			// 
			// panel9
			// 
			this.panel9.BackColor = System.Drawing.Color.White;
			this.panel9.Controls.Add(this.txtStepName);
			this.panel9.Controls.Add(this.txtStepID);
			this.panel9.Controls.Add(this.label9);
			this.panel9.Controls.Add(this.label2);
			this.panel9.Controls.Add(this.btnInit);
			this.panel9.Controls.Add(this.btnSearch);
			this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel9.Location = new System.Drawing.Point(10, 10);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(668, 136);
			this.panel9.TabIndex = 42;
			// 
			// txtStepName
			// 
			this.txtStepName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtStepName.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txtStepName.Location = new System.Drawing.Point(172, 81);
			this.txtStepName.Name = "txtStepName";
			this.txtStepName.Size = new System.Drawing.Size(121, 21);
			this.txtStepName.TabIndex = 60;
			// 
			// txtStepID
			// 
			this.txtStepID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtStepID.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txtStepID.Location = new System.Drawing.Point(172, 40);
			this.txtStepID.Name = "txtStepID";
			this.txtStepID.Size = new System.Drawing.Size(121, 21);
			this.txtStepID.TabIndex = 59;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label9.Location = new System.Drawing.Point(45, 83);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(91, 14);
			this.label9.TabIndex = 57;
			this.label9.Text = "ㆍ표준공정이름";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label2.Location = new System.Drawing.Point(45, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 14);
			this.label2.TabIndex = 55;
			this.label2.Text = "ㆍ표준공정ID";
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.panel7);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel6.Location = new System.Drawing.Point(0, 10);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(10, 136);
			this.panel6.TabIndex = 39;
			// 
			// panel7
			// 
			this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(10, 136);
			this.panel7.TabIndex = 40;
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
			this.dataGridView1.Location = new System.Drawing.Point(10, 38);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 23;
			this.dataGridView1.Size = new System.Drawing.Size(688, 590);
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
			this.panel5.Size = new System.Drawing.Size(688, 10);
			this.panel5.TabIndex = 49;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
			this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel4.Location = new System.Drawing.Point(698, 38);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(10, 600);
			this.panel4.TabIndex = 48;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
			this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel3.Location = new System.Drawing.Point(0, 38);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(10, 600);
			this.panel3.TabIndex = 47;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(679, 8);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(23, 24);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox6.TabIndex = 59;
			this.pictureBox6.TabStop = false;
			this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
			// 
			// pictureBox5
			// 
			this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(621, 7);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(23, 24);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox5.TabIndex = 58;
			this.pictureBox5.TabStop = false;
			this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
			// 
			// pictureBox4
			// 
			this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(650, 7);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(23, 24);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 57;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(556, 8);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(23, 24);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 56;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(586, 8);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(23, 24);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 55;
			this.pictureBox2.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(35, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 18);
			this.label1.TabIndex = 1;
			this.label1.Text = "표준 공정 정보";
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
			this.panel1.Controls.Add(this.pictureBox6);
			this.panel1.Controls.Add(this.pictureBox5);
			this.panel1.Controls.Add(this.pictureBox4);
			this.panel1.Controls.Add(this.pictureBox3);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(708, 38);
			this.panel1.TabIndex = 45;
			// 
			// dgvStepInfoList
			// 
			this.dgvStepInfoList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(228)))));
			this.dgvStepInfoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStepInfoList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvStepInfoList.Location = new System.Drawing.Point(10, 194);
			this.dgvStepInfoList.Name = "dgvStepInfoList";
			this.dgvStepInfoList.RowTemplate.Height = 23;
			this.dgvStepInfoList.Size = new System.Drawing.Size(688, 434);
			this.dgvStepInfoList.TabIndex = 51;
			// 
			// STD_STEP_INFO
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(708, 638);
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
			this.panel9.ResumeLayout(false);
			this.panel9.PerformLayout();
			this.panel6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStepInfoList)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		protected System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Panel panel8;
		protected System.Windows.Forms.Button btnInit;
		protected System.Windows.Forms.Panel panel2;
		protected System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
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
		protected System.Windows.Forms.PictureBox pictureBox6;
		protected System.Windows.Forms.PictureBox pictureBox5;
		protected System.Windows.Forms.PictureBox pictureBox4;
		protected System.Windows.Forms.PictureBox pictureBox3;
		protected System.Windows.Forms.PictureBox pictureBox2;
		protected System.Windows.Forms.Label label1;
		protected System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.Label label9;
		public System.Windows.Forms.Label label2;
		public System.Windows.Forms.DataGridView dgvStepInfoList;
		private CapitalTextBox txtStepID;
		private CapitalTextBox txtStepName;
	}
}