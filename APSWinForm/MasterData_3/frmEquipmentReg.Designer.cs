﻿
namespace APSWinForm
{
    partial class EQUIPMENT_REG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EQUIPMENT_REG));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblExist = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cboLineID = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cboSiteID = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cboEqpGroup = new System.Windows.Forms.ComboBox();
            this.txtEqpmodel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtEQPIDM = new System.Windows.Forms.TextBox();
            this.txtEqpID = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panel2.Size = new System.Drawing.Size(395, 420);
            this.panel2.TabIndex = 49;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
            this.panel9.Controls.Add(this.lblExist);
            this.panel9.Controls.Add(this.panel5);
            this.panel9.Controls.Add(this.panel4);
            this.panel9.Controls.Add(this.panel3);
            this.panel9.Controls.Add(this.txtEqpmodel);
            this.panel9.Controls.Add(this.label2);
            this.panel9.Controls.Add(this.label4);
            this.panel9.Controls.Add(this.label5);
            this.panel9.Controls.Add(this.label8);
            this.panel9.Controls.Add(this.label9);
            this.panel9.Controls.Add(this.btnCancel);
            this.panel9.Controls.Add(this.btnAdd);
            this.panel9.Controls.Add(this.txtEQPIDM);
            this.panel9.Controls.Add(this.txtEqpID);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(10, 10);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(375, 400);
            this.panel9.TabIndex = 42;
            // 
            // lblExist
            // 
            this.lblExist.AutoSize = true;
            this.lblExist.ForeColor = System.Drawing.Color.Red;
            this.lblExist.Location = new System.Drawing.Point(184, 88);
            this.lblExist.Name = "lblExist";
            this.lblExist.Size = new System.Drawing.Size(159, 12);
            this.lblExist.TabIndex = 176;
            this.lblExist.Text = "* 이미 존재하는 설비입니다.";
            this.lblExist.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.cboLineID);
            this.panel5.Location = new System.Drawing.Point(185, 252);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(121, 20);
            this.panel5.TabIndex = 171;
            // 
            // cboLineID
            // 
            this.cboLineID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboLineID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLineID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboLineID.FormattingEnabled = true;
            this.cboLineID.Location = new System.Drawing.Point(0, 0);
            this.cboLineID.Name = "cboLineID";
            this.cboLineID.Size = new System.Drawing.Size(119, 20);
            this.cboLineID.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cboSiteID);
            this.panel4.Location = new System.Drawing.Point(185, 205);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(121, 20);
            this.panel4.TabIndex = 171;
            // 
            // cboSiteID
            // 
            this.cboSiteID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboSiteID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSiteID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSiteID.FormattingEnabled = true;
            this.cboSiteID.Location = new System.Drawing.Point(0, 0);
            this.cboSiteID.Name = "cboSiteID";
            this.cboSiteID.Size = new System.Drawing.Size(119, 20);
            this.cboSiteID.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cboEqpGroup);
            this.panel3.Location = new System.Drawing.Point(185, 158);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(121, 20);
            this.panel3.TabIndex = 174;
            // 
            // cboEqpGroup
            // 
            this.cboEqpGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboEqpGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEqpGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEqpGroup.FormattingEnabled = true;
            this.cboEqpGroup.Location = new System.Drawing.Point(0, 0);
            this.cboEqpGroup.Name = "cboEqpGroup";
            this.cboEqpGroup.Size = new System.Drawing.Size(119, 20);
            this.cboEqpGroup.TabIndex = 2;
            // 
            // txtEqpmodel
            // 
            this.txtEqpmodel.Location = new System.Drawing.Point(185, 111);
            this.txtEqpmodel.Name = "txtEqpmodel";
            this.txtEqpmodel.Size = new System.Drawing.Size(121, 21);
            this.txtEqpmodel.TabIndex = 173;
            this.txtEqpmodel.Tag = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(67, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 14);
            this.label2.TabIndex = 170;
            this.label2.Text = "ㆍ설비처리그룹";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(67, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 14);
            this.label4.TabIndex = 168;
            this.label4.Text = "ㆍ설비모델명";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(67, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 14);
            this.label5.TabIndex = 166;
            this.label5.Text = "ㆍ라인ID";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(67, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 14);
            this.label8.TabIndex = 164;
            this.label8.Text = "ㆍ사이트ID";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(67, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 14);
            this.label9.TabIndex = 159;
            this.label9.Text = "ㆍ설비ID";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(105)))), ((int)(((byte)(129)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(202, 323);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 36);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(106)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(74, 323);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 36);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "저장";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtEQPIDM
            // 
            this.txtEQPIDM.Location = new System.Drawing.Point(184, 64);
            this.txtEQPIDM.Name = "txtEQPIDM";
            this.txtEQPIDM.ReadOnly = true;
            this.txtEQPIDM.Size = new System.Drawing.Size(121, 21);
            this.txtEQPIDM.TabIndex = 175;
            this.txtEQPIDM.Tag = "0";
            this.txtEQPIDM.Visible = false;
            // 
            // txtEqpID
            // 
            this.txtEqpID.Location = new System.Drawing.Point(184, 64);
            this.txtEqpID.Name = "txtEqpID";
            this.txtEqpID.Size = new System.Drawing.Size(121, 21);
            this.txtEqpID.TabIndex = 172;
            this.txtEqpID.Tag = "0";
            this.txtEqpID.Leave += new System.EventHandler(this.txtEqpID_Leave);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(172)))), ((int)(((byte)(199)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(385, 10);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 400);
            this.panel8.TabIndex = 41;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 400);
            this.panel6.TabIndex = 39;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(172)))), ((int)(((byte)(199)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 400);
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
            this.panel1.Size = new System.Drawing.Size(395, 38);
            this.panel1.TabIndex = 48;
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
            // EQUIPMENT_REG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 458);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EQUIPMENT_REG";
            this.Text = "설비정보";
            this.Load += new System.EventHandler(this.EQUIPMENT_REG_Load);
            this.panel2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        protected System.Windows.Forms.Button btnCancel;
        protected System.Windows.Forms.Button btnAdd;
        protected System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEqpID;
        private System.Windows.Forms.TextBox txtEqpmodel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cboLineID;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cboSiteID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cboEqpGroup;
        private System.Windows.Forms.TextBox txtEQPIDM;
        private System.Windows.Forms.Label lblExist;
    }
}