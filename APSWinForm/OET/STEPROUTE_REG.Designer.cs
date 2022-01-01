
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
			this.panel4 = new System.Windows.Forms.Panel();
			this.dgvStepRoute = new System.Windows.Forms.DataGridView();
			this.label5 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.cboStepType = new System.Windows.Forms.ComboBox();
			this.cboStdStep = new System.Windows.Forms.ComboBox();
			this.txtProcessID = new System.Windows.Forms.TextBox();
			this.txtStepID = new APSWinForm.CapitalTextBox();
			this.cboProcessID = new System.Windows.Forms.ComboBox();
			this.txtStepSeq = new APSWinForm.NumTextBox();
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
			this.panel1.Size = new System.Drawing.Size(912, 38);
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
			this.panel8.Location = new System.Drawing.Point(902, 10);
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
			this.panel2.Size = new System.Drawing.Size(912, 437);
			this.panel2.TabIndex = 47;
			// 
			// panel9
			// 
			this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
			this.panel9.Controls.Add(this.txtStepSeq);
			this.panel9.Controls.Add(this.cboProcessID);
			this.panel9.Controls.Add(this.txtStepID);
			this.panel9.Controls.Add(this.txtProcessID);
			this.panel9.Controls.Add(this.cboStdStep);
			this.panel9.Controls.Add(this.panel4);
			this.panel9.Controls.Add(this.label5);
			this.panel9.Controls.Add(this.label13);
			this.panel9.Controls.Add(this.label4);
			this.panel9.Controls.Add(this.cboStepType);
			this.panel9.Controls.Add(this.label10);
			this.panel9.Controls.Add(this.label12);
			this.panel9.Controls.Add(this.button3);
			this.panel9.Controls.Add(this.button7);
			this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel9.Location = new System.Drawing.Point(10, 10);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(892, 417);
			this.panel9.TabIndex = 42;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.dgvStepRoute);
			this.panel4.Location = new System.Drawing.Point(0, 28);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(512, 387);
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
			this.dgvStepRoute.Size = new System.Drawing.Size(512, 387);
			this.dgvStepRoute.TabIndex = 51;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label5.Location = new System.Drawing.Point(556, 159);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 14);
			this.label5.TabIndex = 65;
			this.label5.Text = "ㆍ공정 ID";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label13.Location = new System.Drawing.Point(556, 87);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(82, 14);
			this.label13.TabIndex = 63;
			this.label13.Text = "ㆍ프로세스 ID";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label4.Location = new System.Drawing.Point(556, 253);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 14);
			this.label4.TabIndex = 62;
			this.label4.Text = "ㆍ표준공정 ID";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label10.Location = new System.Drawing.Point(556, 300);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(67, 14);
			this.label10.TabIndex = 60;
			this.label10.Text = "ㆍ공정타입";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label12.Location = new System.Drawing.Point(556, 207);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(67, 14);
			this.label12.TabIndex = 59;
			this.label12.Text = "ㆍ공정순서";
			// 
			// button3
			// 
			this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(105)))), ((int)(((byte)(129)))));
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Location = new System.Drawing.Point(728, 359);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(102, 36);
			this.button3.TabIndex = 54;
			this.button3.Text = "취소";
			this.button3.UseVisualStyleBackColor = false;
			// 
			// button7
			// 
			this.button7.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(106)))));
			this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button7.ForeColor = System.Drawing.Color.White;
			this.button7.Location = new System.Drawing.Point(600, 359);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(102, 36);
			this.button7.TabIndex = 45;
			this.button7.Text = "추가";
			this.button7.UseVisualStyleBackColor = false;
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
			// cboStepType
			// 
			this.cboStepType.FormattingEnabled = true;
			this.cboStepType.Items.AddRange(new object[] {
            "IN",
            "OUT"});
			this.cboStepType.Location = new System.Drawing.Point(668, 297);
			this.cboStepType.Name = "cboStepType";
			this.cboStepType.Size = new System.Drawing.Size(121, 20);
			this.cboStepType.TabIndex = 61;
			// 
			// cboStdStep
			// 
			this.cboStdStep.FormattingEnabled = true;
			this.cboStdStep.Items.AddRange(new object[] {
            "IN",
            "OUT"});
			this.cboStdStep.Location = new System.Drawing.Point(668, 251);
			this.cboStdStep.Name = "cboStdStep";
			this.cboStdStep.Size = new System.Drawing.Size(121, 20);
			this.cboStdStep.TabIndex = 72;
			// 
			// txtProcessID
			// 
			this.txtProcessID.Location = new System.Drawing.Point(668, 85);
			this.txtProcessID.Name = "txtProcessID";
			this.txtProcessID.Size = new System.Drawing.Size(189, 21);
			this.txtProcessID.TabIndex = 74;
			// 
			// txtStepID
			// 
			this.txtStepID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtStepID.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txtStepID.Location = new System.Drawing.Point(668, 157);
			this.txtStepID.Name = "txtStepID";
			this.txtStepID.Size = new System.Drawing.Size(121, 21);
			this.txtStepID.TabIndex = 75;
			// 
			// cboProcessID
			// 
			this.cboProcessID.FormattingEnabled = true;
			this.cboProcessID.Items.AddRange(new object[] {
            "IN",
            "OUT"});
			this.cboProcessID.Location = new System.Drawing.Point(668, 112);
			this.cboProcessID.Name = "cboProcessID";
			this.cboProcessID.Size = new System.Drawing.Size(189, 20);
			this.cboProcessID.TabIndex = 76;
			this.cboProcessID.SelectedIndexChanged += new System.EventHandler(this.cboProcessID_SelectedIndexChanged);
			// 
			// txtStepSeq
			// 
			this.txtStepSeq.Location = new System.Drawing.Point(668, 205);
			this.txtStepSeq.Name = "txtStepSeq";
			this.txtStepSeq.Size = new System.Drawing.Size(121, 21);
			this.txtStepSeq.TabIndex = 77;
			// 
			// STEPROUTE_REG
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(912, 437);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "STEPROUTE_REG";
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
		protected System.Windows.Forms.Button button3;
		protected System.Windows.Forms.Button button7;
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
		public System.Windows.Forms.TextBox txtProcessID;
		protected System.Windows.Forms.ComboBox cboStdStep;
		protected System.Windows.Forms.ComboBox cboStepType;
	}
}