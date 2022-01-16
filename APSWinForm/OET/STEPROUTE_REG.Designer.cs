
namespace APSWinForm
{
	partial class STEPROUTE_REG
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(STEPROUTE_REG));
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel8 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel9 = new System.Windows.Forms.Panel();
			this.txtStepSeq = new APSWinForm.NumTextBox();
			this.cboProcessID = new System.Windows.Forms.ComboBox();
			this.txtStepID = new APSWinForm.CapitalTextBox();
			this.cboStdStep = new System.Windows.Forms.ComboBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.dgvStepRoute = new System.Windows.Forms.DataGridView();
			this.label5 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cboStepType = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel9.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStepRoute)).BeginInit();
			this.panel6.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(172)))), ((int)(((byte)(199)))));
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(969, 38);
			this.panel1.TabIndex = 46;
			// 
			// panel3
			// 
			this.panel3.Location = new System.Drawing.Point(10, 38);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(330, 390);
			this.panel3.TabIndex = 69;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(35, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "추가/수정";
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
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(172)))), ((int)(((byte)(199)))));
			this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel8.Location = new System.Drawing.Point(959, 10);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(10, 417);
			this.panel8.TabIndex = 41;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(172)))), ((int)(((byte)(199)))));
			this.panel2.Controls.Add(this.panel9);
			this.panel2.Controls.Add(this.panel8);
			this.panel2.Controls.Add(this.panel6);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
			this.panel2.Size = new System.Drawing.Size(969, 437);
			this.panel2.TabIndex = 47;
			// 
			// panel9
			// 
			this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
			this.panel9.Controls.Add(this.txtStepSeq);
			this.panel9.Controls.Add(this.cboProcessID);
			this.panel9.Controls.Add(this.txtStepID);
			this.panel9.Controls.Add(this.cboStdStep);
			this.panel9.Controls.Add(this.panel4);
			this.panel9.Controls.Add(this.label5);
			this.panel9.Controls.Add(this.label13);
			this.panel9.Controls.Add(this.label4);
			this.panel9.Controls.Add(this.cboStepType);
			this.panel9.Controls.Add(this.label10);
			this.panel9.Controls.Add(this.label12);
			this.panel9.Controls.Add(this.btnCancel);
			this.panel9.Controls.Add(this.btnSave);
			this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel9.Location = new System.Drawing.Point(10, 10);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(949, 417);
			this.panel9.TabIndex = 42;
			// 
			// txtStepSeq
			// 
			this.txtStepSeq.Location = new System.Drawing.Point(725, 184);
			this.txtStepSeq.Name = "txtStepSeq";
			this.txtStepSeq.Size = new System.Drawing.Size(121, 21);
			this.txtStepSeq.TabIndex = 77;
			// 
			// cboProcessID
			// 
			this.cboProcessID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboProcessID.FormattingEnabled = true;
			this.cboProcessID.Items.AddRange(new object[] {
            "IN",
            "OUT"});
			this.cboProcessID.Location = new System.Drawing.Point(725, 82);
			this.cboProcessID.Name = "cboProcessID";
			this.cboProcessID.Size = new System.Drawing.Size(189, 20);
			this.cboProcessID.TabIndex = 76;
			this.cboProcessID.SelectedIndexChanged += new System.EventHandler(this.cboProcessID_SelectedIndexChanged);
			// 
			// txtStepID
			// 
			this.txtStepID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtStepID.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txtStepID.Location = new System.Drawing.Point(725, 133);
			this.txtStepID.Name = "txtStepID";
			this.txtStepID.Size = new System.Drawing.Size(121, 21);
			this.txtStepID.TabIndex = 75;
			// 
			// cboStdStep
			// 
			this.cboStdStep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboStdStep.FormattingEnabled = true;
			this.cboStdStep.Items.AddRange(new object[] {
            "IN",
            "OUT"});
			this.cboStdStep.Location = new System.Drawing.Point(725, 235);
			this.cboStdStep.Name = "cboStdStep";
			this.cboStdStep.Size = new System.Drawing.Size(121, 20);
			this.cboStdStep.TabIndex = 72;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.dgvStepRoute);
			this.panel4.Location = new System.Drawing.Point(0, 28);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(558, 387);
			this.panel4.TabIndex = 69;
			// 
			// dgvStepRoute
			// 
			this.dgvStepRoute.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvStepRoute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStepRoute.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvStepRoute.Location = new System.Drawing.Point(0, 0);
			this.dgvStepRoute.Name = "dgvStepRoute";
			this.dgvStepRoute.RowTemplate.Height = 23;
			this.dgvStepRoute.Size = new System.Drawing.Size(558, 387);
			this.dgvStepRoute.TabIndex = 51;
			this.dgvStepRoute.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStepRoute_CellDoubleClick);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label5.Location = new System.Drawing.Point(613, 135);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 14);
			this.label5.TabIndex = 65;
			this.label5.Text = "ㆍ공정 ID";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label13.Location = new System.Drawing.Point(613, 84);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(82, 14);
			this.label13.TabIndex = 63;
			this.label13.Text = "ㆍ프로세스 ID";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label4.Location = new System.Drawing.Point(613, 237);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 14);
			this.label4.TabIndex = 62;
			this.label4.Text = "ㆍ표준공정 ID";
			// 
			// cboStepType
			// 
			this.cboStepType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboStepType.FormattingEnabled = true;
			this.cboStepType.Items.AddRange(new object[] {
            "IN",
            "OUT"});
			this.cboStepType.Location = new System.Drawing.Point(725, 286);
			this.cboStepType.Name = "cboStepType";
			this.cboStepType.Size = new System.Drawing.Size(121, 20);
			this.cboStepType.TabIndex = 61;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label10.Location = new System.Drawing.Point(613, 288);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(67, 14);
			this.label10.TabIndex = 60;
			this.label10.Text = "ㆍ공정타입";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label12.Location = new System.Drawing.Point(613, 186);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(67, 14);
			this.label12.TabIndex = 59;
			this.label12.Text = "ㆍ공정순서";
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(105)))), ((int)(((byte)(129)))));
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnCancel.ForeColor = System.Drawing.Color.White;
			this.btnCancel.Location = new System.Drawing.Point(774, 349);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(102, 36);
			this.btnCancel.TabIndex = 54;
			this.btnCancel.Text = "취소";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(106)))));
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(646, 349);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(102, 36);
			this.btnSave.TabIndex = 45;
			this.btnSave.Text = "저장";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.panel7);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel6.Location = new System.Drawing.Point(0, 10);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(10, 417);
			this.panel6.TabIndex = 39;
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(172)))), ((int)(((byte)(199)))));
			this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(10, 417);
			this.panel7.TabIndex = 40;
			// 
			// STEPROUTE_REG
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(969, 437);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "STEPROUTE_REG";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "공정순서";
			this.Load += new System.EventHandler(this.STEPROUTE_REG_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel9.ResumeLayout(false);
			this.panel9.PerformLayout();
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvStepRoute)).EndInit();
			this.panel6.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel8;
		protected System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel9;
		protected System.Windows.Forms.Button btnCancel;
		protected System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		public System.Windows.Forms.Label label5;
		public System.Windows.Forms.Label label13;
		protected System.Windows.Forms.Label label4;
		protected System.Windows.Forms.Label label10;
		protected System.Windows.Forms.Label label12;
		private System.Windows.Forms.DataGridView dgvStepRoute;
		private NumTextBox txtStepSeq;
		protected System.Windows.Forms.ComboBox cboProcessID;
		private CapitalTextBox txtStepID;
		protected System.Windows.Forms.ComboBox cboStdStep;
		protected System.Windows.Forms.ComboBox cboStepType;
	}
}