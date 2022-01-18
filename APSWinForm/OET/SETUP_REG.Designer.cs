
namespace APSWinForm
{
    partial class SETUP_REG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SETUP_REG));
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.txtStep = new System.Windows.Forms.TextBox();
            this.txtLine = new System.Windows.Forms.TextBox();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.cboStep = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboGroup = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numTime = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.cboSite = new System.Windows.Forms.ComboBox();
            this.cboLine = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(172)))), ((int)(((byte)(199)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 433);
            this.panel7.TabIndex = 40;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 433);
            this.panel6.TabIndex = 39;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(105)))), ((int)(((byte)(129)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(207, 330);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 36);
            this.button3.TabIndex = 54;
            this.button3.Text = "취소";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(172)))), ((int)(((byte)(199)))));
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panel2.Size = new System.Drawing.Size(404, 453);
            this.panel2.TabIndex = 45;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
            this.panel9.Controls.Add(this.txtGroup);
            this.panel9.Controls.Add(this.txtStep);
            this.panel9.Controls.Add(this.txtLine);
            this.panel9.Controls.Add(this.txtSite);
            this.panel9.Controls.Add(this.cboStep);
            this.panel9.Controls.Add(this.label7);
            this.panel9.Controls.Add(this.cboGroup);
            this.panel9.Controls.Add(this.label5);
            this.panel9.Controls.Add(this.numTime);
            this.panel9.Controls.Add(this.label11);
            this.panel9.Controls.Add(this.cboSite);
            this.panel9.Controls.Add(this.cboLine);
            this.panel9.Controls.Add(this.label9);
            this.panel9.Controls.Add(this.label10);
            this.panel9.Controls.Add(this.button3);
            this.panel9.Controls.Add(this.btnAdd);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(10, 10);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(384, 433);
            this.panel9.TabIndex = 42;
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(188, 195);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.ReadOnly = true;
            this.txtGroup.Size = new System.Drawing.Size(121, 21);
            this.txtGroup.TabIndex = 206;
            this.txtGroup.Visible = false;
            // 
            // txtStep
            // 
            this.txtStep.Location = new System.Drawing.Point(188, 152);
            this.txtStep.Name = "txtStep";
            this.txtStep.ReadOnly = true;
            this.txtStep.Size = new System.Drawing.Size(122, 21);
            this.txtStep.TabIndex = 205;
            this.txtStep.Visible = false;
            // 
            // txtLine
            // 
            this.txtLine.Location = new System.Drawing.Point(188, 108);
            this.txtLine.Name = "txtLine";
            this.txtLine.ReadOnly = true;
            this.txtLine.Size = new System.Drawing.Size(122, 21);
            this.txtLine.TabIndex = 204;
            this.txtLine.Visible = false;
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(188, 62);
            this.txtSite.Name = "txtSite";
            this.txtSite.ReadOnly = true;
            this.txtSite.Size = new System.Drawing.Size(121, 21);
            this.txtSite.TabIndex = 203;
            this.txtSite.Visible = false;
            // 
            // cboStep
            // 
            this.cboStep.FormattingEnabled = true;
            this.cboStep.Location = new System.Drawing.Point(189, 153);
            this.cboStep.Name = "cboStep";
            this.cboStep.Size = new System.Drawing.Size(121, 20);
            this.cboStep.TabIndex = 202;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(63, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 14);
            this.label7.TabIndex = 201;
            this.label7.Text = "ㆍ공정ID";
            // 
            // cboGroup
            // 
            this.cboGroup.FormattingEnabled = true;
            this.cboGroup.Location = new System.Drawing.Point(188, 196);
            this.cboGroup.Name = "cboGroup";
            this.cboGroup.Size = new System.Drawing.Size(121, 20);
            this.cboGroup.TabIndex = 200;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(62, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 14);
            this.label5.TabIndex = 199;
            this.label5.Text = "ㆍ설비처리그룹";
            // 
            // numTime
            // 
            this.numTime.Location = new System.Drawing.Point(190, 238);
            this.numTime.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numTime.Name = "numTime";
            this.numTime.Size = new System.Drawing.Size(120, 21);
            this.numTime.TabIndex = 198;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(64, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 14);
            this.label11.TabIndex = 197;
            this.label11.Text = "ㆍ소요시간";
            // 
            // cboSite
            // 
            this.cboSite.FormattingEnabled = true;
            this.cboSite.Location = new System.Drawing.Point(188, 63);
            this.cboSite.Name = "cboSite";
            this.cboSite.Size = new System.Drawing.Size(121, 20);
            this.cboSite.TabIndex = 193;
            // 
            // cboLine
            // 
            this.cboLine.FormattingEnabled = true;
            this.cboLine.Location = new System.Drawing.Point(189, 109);
            this.cboLine.Name = "cboLine";
            this.cboLine.Size = new System.Drawing.Size(121, 20);
            this.cboLine.TabIndex = 192;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(62, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 14);
            this.label9.TabIndex = 191;
            this.label9.Text = "ㆍ라인ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(61, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 14);
            this.label10.TabIndex = 190;
            this.label10.Text = "ㆍ사이트ID";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(106)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(79, 330);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 36);
            this.btnAdd.TabIndex = 45;
            this.btnAdd.Text = "저장";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(172)))), ((int)(((byte)(199)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(394, 10);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 433);
            this.panel8.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(172)))), ((int)(((byte)(199)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 38);
            this.panel1.TabIndex = 44;
            // 
            // SETUP_REG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 491);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SETUP_REG";
            this.Text = "교체준비시간";
            this.Load += new System.EventHandler(this.SETUP_REG_Load);
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        protected System.Windows.Forms.Button button3;
        protected System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel9;
        protected System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboStep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboSite;
        private System.Windows.Forms.ComboBox cboLine;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.TextBox txtStep;
        private System.Windows.Forms.TextBox txtLine;
        private System.Windows.Forms.TextBox txtSite;
    }
}