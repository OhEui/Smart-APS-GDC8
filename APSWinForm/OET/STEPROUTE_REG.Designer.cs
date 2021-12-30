
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
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel8 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel9 = new System.Windows.Forms.Panel();
			this.button3 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBox5 = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.PROCESS_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.STD_STEP_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.STEP_YIELD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.STEP_SETUP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.STEP_TAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel9.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
			this.panel1.Size = new System.Drawing.Size(857, 38);
			this.panel1.TabIndex = 46;
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
			this.panel8.Location = new System.Drawing.Point(847, 10);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(10, 421);
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
			this.panel2.Size = new System.Drawing.Size(857, 441);
			this.panel2.TabIndex = 47;
			// 
			// panel9
			// 
			this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
			this.panel9.Controls.Add(this.panel4);
			this.panel9.Controls.Add(this.textBox4);
			this.panel9.Controls.Add(this.textBox6);
			this.panel9.Controls.Add(this.textBox1);
			this.panel9.Controls.Add(this.label5);
			this.panel9.Controls.Add(this.textBox5);
			this.panel9.Controls.Add(this.label13);
			this.panel9.Controls.Add(this.label4);
			this.panel9.Controls.Add(this.comboBox5);
			this.panel9.Controls.Add(this.label10);
			this.panel9.Controls.Add(this.label12);
			this.panel9.Controls.Add(this.button3);
			this.panel9.Controls.Add(this.button7);
			this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel9.Location = new System.Drawing.Point(10, 10);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(837, 421);
			this.panel9.TabIndex = 42;
			this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
			// 
			// button3
			// 
			this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(105)))), ((int)(((byte)(129)))));
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Location = new System.Drawing.Point(696, 352);
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
			this.button7.Location = new System.Drawing.Point(568, 352);
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
			this.panel6.Size = new System.Drawing.Size(10, 421);
			this.panel6.TabIndex = 39;
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
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(668, 228);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(121, 21);
			this.textBox4.TabIndex = 68;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(668, 182);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(121, 21);
			this.textBox6.TabIndex = 67;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(668, 134);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(121, 21);
			this.textBox1.TabIndex = 66;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label5.Location = new System.Drawing.Point(556, 137);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 14);
			this.label5.TabIndex = 65;
			this.label5.Text = "ㆍ공정 ID";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(668, 84);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(121, 21);
			this.textBox5.TabIndex = 64;
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
			this.label4.Location = new System.Drawing.Point(556, 231);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 14);
			this.label4.TabIndex = 62;
			this.label4.Text = "ㆍ표준공정 ID";
			// 
			// comboBox5
			// 
			this.comboBox5.FormattingEnabled = true;
			this.comboBox5.Items.AddRange(new object[] {
            "IN",
            "OUT"});
			this.comboBox5.Location = new System.Drawing.Point(668, 275);
			this.comboBox5.Name = "comboBox5";
			this.comboBox5.Size = new System.Drawing.Size(121, 20);
			this.comboBox5.TabIndex = 61;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label10.Location = new System.Drawing.Point(556, 278);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(67, 14);
			this.label10.TabIndex = 60;
			this.label10.Text = "ㆍ공정타입";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label12.Location = new System.Drawing.Point(556, 185);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(67, 14);
			this.label12.TabIndex = 59;
			this.label12.Text = "ㆍ공정순서";
			// 
			// panel3
			// 
			this.panel3.Location = new System.Drawing.Point(10, 38);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(330, 390);
			this.panel3.TabIndex = 69;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.dataGridView2);
			this.panel4.Location = new System.Drawing.Point(0, 28);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(512, 387);
			this.panel4.TabIndex = 69;
			// 
			// dataGridView2
			// 
			this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PROCESS_ID,
            this.STD_STEP_NAME,
            this.STEP_YIELD,
            this.STEP_SETUP,
            this.STEP_TAT});
			this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView2.Location = new System.Drawing.Point(0, 0);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowTemplate.Height = 23;
			this.dataGridView2.Size = new System.Drawing.Size(512, 387);
			this.dataGridView2.TabIndex = 51;
			// 
			// PROCESS_ID
			// 
			this.PROCESS_ID.HeaderText = "프로세스 ID";
			this.PROCESS_ID.Name = "PROCESS_ID";
			// 
			// STD_STEP_NAME
			// 
			this.STD_STEP_NAME.HeaderText = "공정 ID";
			this.STD_STEP_NAME.Name = "STD_STEP_NAME";
			// 
			// STEP_YIELD
			// 
			this.STEP_YIELD.HeaderText = "공정순서";
			this.STEP_YIELD.Name = "STEP_YIELD";
			// 
			// STEP_SETUP
			// 
			this.STEP_SETUP.HeaderText = "표준공정 ID";
			this.STEP_SETUP.Name = "STEP_SETUP";
			// 
			// STEP_TAT
			// 
			this.STEP_TAT.HeaderText = "공정타입";
			this.STEP_TAT.Name = "STEP_TAT";
			// 
			// STEPROUTE_REG
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(857, 441);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Name = "STEPROUTE_REG";
			this.Text = "STEPROUTE_REG";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel9.ResumeLayout(false);
			this.panel9.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
		public System.Windows.Forms.TextBox textBox4;
		public System.Windows.Forms.TextBox textBox6;
		public System.Windows.Forms.TextBox textBox1;
		public System.Windows.Forms.Label label5;
		public System.Windows.Forms.TextBox textBox5;
		public System.Windows.Forms.Label label13;
		protected System.Windows.Forms.Label label4;
		protected System.Windows.Forms.ComboBox comboBox5;
		protected System.Windows.Forms.Label label10;
		protected System.Windows.Forms.Label label12;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridViewTextBoxColumn PROCESS_ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn STD_STEP_NAME;
		private System.Windows.Forms.DataGridViewTextBoxColumn STEP_YIELD;
		private System.Windows.Forms.DataGridViewTextBoxColumn STEP_SETUP;
		private System.Windows.Forms.DataGridViewTextBoxColumn STEP_TAT;
	}
}