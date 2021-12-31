
namespace APSWinForm
{
	partial class STDSTEP_REG
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(STDSTEP_REG));
			this.panel7 = new System.Windows.Forms.Panel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.panel9 = new System.Windows.Forms.Panel();
			this.txtStepName = new APSWinForm.CapitalTextBox();
			this.txtStepID = new APSWinForm.CapitalTextBox();
			this.txtStepSetup = new APSWinForm.NumTextBox();
			this.txtTAT = new APSWinForm.NumTextBox();
			this.lblStepIDExist = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtYield = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel8 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel9.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel6.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(172)))), ((int)(((byte)(199)))));
			this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(10, 421);
			this.panel7.TabIndex = 40;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(105)))), ((int)(((byte)(129)))));
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnCancel.ForeColor = System.Drawing.Color.White;
			this.btnCancel.Location = new System.Drawing.Point(192, 347);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(102, 36);
			this.btnCancel.TabIndex = 54;
			this.btnCancel.Text = "취소";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(106)))));
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.btnAdd.ForeColor = System.Drawing.Color.White;
			this.btnAdd.Location = new System.Drawing.Point(64, 347);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(102, 36);
			this.btnAdd.TabIndex = 45;
			this.btnAdd.Text = "저장";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// panel9
			// 
			this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
			this.panel9.Controls.Add(this.txtStepName);
			this.panel9.Controls.Add(this.txtStepID);
			this.panel9.Controls.Add(this.txtStepSetup);
			this.panel9.Controls.Add(this.txtTAT);
			this.panel9.Controls.Add(this.lblStepIDExist);
			this.panel9.Controls.Add(this.label3);
			this.panel9.Controls.Add(this.txtYield);
			this.panel9.Controls.Add(this.label4);
			this.panel9.Controls.Add(this.label5);
			this.panel9.Controls.Add(this.label10);
			this.panel9.Controls.Add(this.label12);
			this.panel9.Controls.Add(this.label13);
			this.panel9.Controls.Add(this.btnCancel);
			this.panel9.Controls.Add(this.btnAdd);
			this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel9.Location = new System.Drawing.Point(10, 10);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(353, 421);
			this.panel9.TabIndex = 42;
			// 
			// txtStepName
			// 
			this.txtStepName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtStepName.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txtStepName.Location = new System.Drawing.Point(162, 145);
			this.txtStepName.Name = "txtStepName";
			this.txtStepName.Size = new System.Drawing.Size(121, 21);
			this.txtStepName.TabIndex = 72;
			// 
			// txtStepID
			// 
			this.txtStepID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtStepID.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txtStepID.Location = new System.Drawing.Point(162, 87);
			this.txtStepID.Name = "txtStepID";
			this.txtStepID.Size = new System.Drawing.Size(121, 21);
			this.txtStepID.TabIndex = 71;
			this.txtStepID.Leave += new System.EventHandler(this.capitalTextBox1_Leave);
			// 
			// txtStepSetup
			// 
			this.txtStepSetup.Location = new System.Drawing.Point(162, 290);
			this.txtStepSetup.Name = "txtStepSetup";
			this.txtStepSetup.Size = new System.Drawing.Size(121, 21);
			this.txtStepSetup.TabIndex = 70;
			// 
			// txtTAT
			// 
			this.txtTAT.Location = new System.Drawing.Point(162, 195);
			this.txtTAT.Name = "txtTAT";
			this.txtTAT.Size = new System.Drawing.Size(86, 21);
			this.txtTAT.TabIndex = 69;
			// 
			// lblStepIDExist
			// 
			this.lblStepIDExist.AutoSize = true;
			this.lblStepIDExist.ForeColor = System.Drawing.Color.DarkRed;
			this.lblStepIDExist.Location = new System.Drawing.Point(162, 115);
			this.lblStepIDExist.Name = "lblStepIDExist";
			this.lblStepIDExist.Size = new System.Drawing.Size(159, 12);
			this.lblStepIDExist.TabIndex = 68;
			this.lblStepIDExist.Text = "* 이미 존재하는 공정입니다.";
			this.lblStepIDExist.Visible = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(254, 200);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 12);
			this.label3.TabIndex = 67;
			this.label3.Text = "sec";
			// 
			// txtYield
			// 
			this.txtYield.Location = new System.Drawing.Point(162, 242);
			this.txtYield.Name = "txtYield";
			this.txtYield.Size = new System.Drawing.Size(121, 21);
			this.txtYield.TabIndex = 64;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label4.Location = new System.Drawing.Point(49, 246);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 14);
			this.label4.TabIndex = 62;
			this.label4.Text = "ㆍ공정수율";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label5.Location = new System.Drawing.Point(49, 145);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 14);
			this.label5.TabIndex = 61;
			this.label5.Text = "ㆍ표준공정 이름";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label10.Location = new System.Drawing.Point(49, 292);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(91, 14);
			this.label10.TabIndex = 60;
			this.label10.Text = "ㆍ공정준비시간";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label12.Location = new System.Drawing.Point(49, 197);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(91, 14);
			this.label12.TabIndex = 58;
			this.label12.Text = "ㆍ공정소요시간";
			// 
			// label13
			// 
			this.label13.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label13.Location = new System.Drawing.Point(49, 89);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(82, 14);
			this.label13.TabIndex = 57;
			this.label13.Text = "ㆍ표준공정 ID";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(172)))), ((int)(((byte)(199)))));
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(373, 38);
			this.panel1.TabIndex = 48;
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
			this.panel8.Location = new System.Drawing.Point(363, 10);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(10, 421);
			this.panel8.TabIndex = 41;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.panel7);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel6.Location = new System.Drawing.Point(0, 10);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(10, 421);
			this.panel6.TabIndex = 39;
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
			this.panel2.Size = new System.Drawing.Size(373, 441);
			this.panel2.TabIndex = 49;
			// 
			// STDSTEP_REG
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(373, 441);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Name = "STDSTEP_REG";
			this.Text = "STDSTEP_REG";
			this.Load += new System.EventHandler(this.STDSTEP_REG_Load);
			this.panel9.ResumeLayout(false);
			this.panel9.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel6.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel7;
		protected System.Windows.Forms.Button btnCancel;
		protected System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel panel6;
		protected System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label3;
		protected System.Windows.Forms.TextBox txtYield;
		protected System.Windows.Forms.Label label4;
		protected System.Windows.Forms.Label label5;
		protected System.Windows.Forms.Label label10;
		protected System.Windows.Forms.Label label12;
		protected System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label lblStepIDExist;
		private CapitalTextBox txtStepName;
		private CapitalTextBox txtStepID;
		private NumTextBox txtStepSetup;
		private NumTextBox txtTAT;
		//private NumTextBox txtTAT;
		//private NumTextBox txtStepSetup;
	}
}