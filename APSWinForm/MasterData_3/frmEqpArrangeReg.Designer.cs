﻿
namespace APSWinForm
{
    partial class EQPARR_REG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EQPARR_REG));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtStep = new System.Windows.Forms.TextBox();
            this.cboStep = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtProcess = new System.Windows.Forms.TextBox();
            this.cboProcess = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtEQP = new System.Windows.Forms.TextBox();
            this.cboEQP = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numStep = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numProcess = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProcess)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.panel2.Size = new System.Drawing.Size(390, 447);
            this.panel2.TabIndex = 47;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
            this.panel9.Controls.Add(this.label2);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.panel5);
            this.panel9.Controls.Add(this.panel4);
            this.panel9.Controls.Add(this.panel3);
            this.panel9.Controls.Add(this.label4);
            this.panel9.Controls.Add(this.label5);
            this.panel9.Controls.Add(this.label8);
            this.panel9.Controls.Add(this.numStep);
            this.panel9.Controls.Add(this.label7);
            this.panel9.Controls.Add(this.numProcess);
            this.panel9.Controls.Add(this.label9);
            this.panel9.Controls.Add(this.label6);
            this.panel9.Controls.Add(this.btnCancel);
            this.panel9.Controls.Add(this.btnAdd);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(10, 10);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(370, 427);
            this.panel9.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(66, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 12);
            this.label2.TabIndex = 180;
            this.label2.Text = "* 이미 존재하는 설비배치입니다!";
            this.label2.Visible = false;
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.txtStep);
            this.panel10.Controls.Add(this.cboStep);
            this.panel10.Location = new System.Drawing.Point(183, 187);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(130, 20);
            this.panel10.TabIndex = 179;
            // 
            // txtStep
            // 
            this.txtStep.Location = new System.Drawing.Point(-1, -2);
            this.txtStep.Name = "txtStep";
            this.txtStep.ReadOnly = true;
            this.txtStep.Size = new System.Drawing.Size(130, 21);
            this.txtStep.TabIndex = 3;
            this.txtStep.Visible = false;
            // 
            // cboStep
            // 
            this.cboStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboStep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboStep.FormattingEnabled = true;
            this.cboStep.Location = new System.Drawing.Point(0, 0);
            this.cboStep.Name = "cboStep";
            this.cboStep.Size = new System.Drawing.Size(128, 20);
            this.cboStep.TabIndex = 2;
            this.cboStep.Leave += new System.EventHandler(this.cboStep_Leave);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtProcess);
            this.panel5.Controls.Add(this.cboProcess);
            this.panel5.Location = new System.Drawing.Point(183, 145);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(130, 20);
            this.panel5.TabIndex = 179;
            // 
            // txtProcess
            // 
            this.txtProcess.Location = new System.Drawing.Point(-1, -2);
            this.txtProcess.Name = "txtProcess";
            this.txtProcess.ReadOnly = true;
            this.txtProcess.Size = new System.Drawing.Size(130, 21);
            this.txtProcess.TabIndex = 2;
            this.txtProcess.Visible = false;
            // 
            // cboProcess
            // 
            this.cboProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboProcess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboProcess.FormattingEnabled = true;
            this.cboProcess.Location = new System.Drawing.Point(0, 0);
            this.cboProcess.Name = "cboProcess";
            this.cboProcess.Size = new System.Drawing.Size(128, 20);
            this.cboProcess.TabIndex = 2;
            this.cboProcess.Leave += new System.EventHandler(this.cboStep_Leave);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtProduct);
            this.panel4.Controls.Add(this.cboProduct);
            this.panel4.Location = new System.Drawing.Point(183, 103);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(130, 20);
            this.panel4.TabIndex = 179;
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(-2, -2);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.ReadOnly = true;
            this.txtProduct.Size = new System.Drawing.Size(131, 21);
            this.txtProduct.TabIndex = 1;
            this.txtProduct.Visible = false;
            // 
            // cboProduct
            // 
            this.cboProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.Location = new System.Drawing.Point(0, 0);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(128, 20);
            this.cboProduct.TabIndex = 2;
            this.cboProduct.Leave += new System.EventHandler(this.cboStep_Leave);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtEQP);
            this.panel3.Controls.Add(this.cboEQP);
            this.panel3.Location = new System.Drawing.Point(183, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 20);
            this.panel3.TabIndex = 178;
            this.panel3.Leave += new System.EventHandler(this.cboStep_Leave);
            // 
            // txtEQP
            // 
            this.txtEQP.Location = new System.Drawing.Point(-1, -2);
            this.txtEQP.Name = "txtEQP";
            this.txtEQP.ReadOnly = true;
            this.txtEQP.Size = new System.Drawing.Size(130, 21);
            this.txtEQP.TabIndex = 0;
            this.txtEQP.Visible = false;
            // 
            // cboEQP
            // 
            this.cboEQP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboEQP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEQP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEQP.FormattingEnabled = true;
            this.cboEQP.Location = new System.Drawing.Point(0, 0);
            this.cboEQP.Name = "cboEQP";
            this.cboEQP.Size = new System.Drawing.Size(128, 20);
            this.cboEQP.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(52, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 14);
            this.label4.TabIndex = 168;
            this.label4.Text = "ㆍ공정ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(52, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 14);
            this.label5.TabIndex = 166;
            this.label5.Text = "ㆍ제품ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(52, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 14);
            this.label8.TabIndex = 164;
            this.label8.Text = "ㆍ설비ID";
            // 
            // numStep
            // 
            this.numStep.Location = new System.Drawing.Point(183, 229);
            this.numStep.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numStep.Name = "numStep";
            this.numStep.Size = new System.Drawing.Size(129, 21);
            this.numStep.TabIndex = 163;
            this.numStep.Tag = "4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(52, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 14);
            this.label7.TabIndex = 162;
            this.label7.Text = "ㆍ공정간격시간";
            // 
            // numProcess
            // 
            this.numProcess.Location = new System.Drawing.Point(183, 271);
            this.numProcess.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numProcess.Name = "numProcess";
            this.numProcess.Size = new System.Drawing.Size(129, 21);
            this.numProcess.TabIndex = 160;
            this.numProcess.Tag = "5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(52, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 14);
            this.label9.TabIndex = 159;
            this.label9.Text = "ㆍ프로세스ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(52, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 14);
            this.label6.TabIndex = 158;
            this.label6.Text = "ㆍ프로세스처리시간";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(105)))), ((int)(((byte)(129)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(196, 342);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 36);
            this.btnCancel.TabIndex = 54;
            this.btnCancel.Tag = "7";
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(106)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(68, 342);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 36);
            this.btnAdd.TabIndex = 45;
            this.btnAdd.Tag = "6";
            this.btnAdd.Text = "저장";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(172)))), ((int)(((byte)(199)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(380, 10);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 427);
            this.panel8.TabIndex = 41;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 427);
            this.panel6.TabIndex = 39;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(172)))), ((int)(((byte)(199)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 427);
            this.panel7.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(172)))), ((int)(((byte)(199)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 38);
            this.panel1.TabIndex = 46;
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
            // EQPARR_REG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 485);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EQPARR_REG";
            this.Text = "설비배치";
            this.Load += new System.EventHandler(this.EQPARR_REG_Load);
            this.panel2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProcess)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel9;
        protected System.Windows.Forms.Button btnCancel;
        protected System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numStep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numProcess;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStep;
        private System.Windows.Forms.TextBox txtProcess;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.TextBox txtEQP;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ComboBox cboStep;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cboProcess;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cboProduct;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cboEQP;
        private System.Windows.Forms.Label label2;
    }
}