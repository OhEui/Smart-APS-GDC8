
namespace APSWinForm
{
    partial class frmPRODUCT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPRODUCT));
            this.panel5 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.title = new System.Windows.Forms.ToolStripLabel();
            this.BtnDelete = new System.Windows.Forms.ToolStripButton();
            this.BtnEdit = new System.Windows.Forms.ToolStripButton();
            this.BtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.XlsDown = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblUserID = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvPR = new System.Windows.Forms.DataGridView();
            this.toolStrip2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPR)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 628);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1000, 10);
            this.panel5.TabIndex = 54;
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(212)))), ((int)(((byte)(226)))));
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.title,
            this.BtnDelete,
            this.BtnEdit,
            this.BtnAdd,
            this.toolStripSeparator2,
            this.XlsDown});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1000, 49);
            this.toolStrip2.TabIndex = 69;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("ONE 모바일고딕 Title OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title.Image = ((System.Drawing.Image)(resources.GetObject("title.Image")));
            this.title.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(90, 46);
            this.title.Text = "제품정보";
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 49);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panel2.Size = new System.Drawing.Size(1000, 124);
            this.panel2.TabIndex = 70;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(990, 10);
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
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.lblUserID);
            this.panel9.Controls.Add(this.button3);
            this.panel9.Controls.Add(this.txtID);
            this.panel9.Controls.Add(this.button7);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Controls.Add(this.label2);
            this.panel9.Controls.Add(this.txtPID);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 10);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1000, 104);
            this.panel9.TabIndex = 42;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(99, 93);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(0, 12);
            this.lblUserID.TabIndex = 55;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(105)))), ((int)(((byte)(129)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(872, 59);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 30);
            this.button3.TabIndex = 54;
            this.button3.Text = "초기화";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(87, 45);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(121, 21);
            this.txtID.TabIndex = 43;
            this.txtID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtID_KeyDown_1);
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(106)))));
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(872, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(74, 30);
            this.button7.TabIndex = 45;
            this.button7.Text = "검색";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(271, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 14);
            this.label3.TabIndex = 42;
            this.label3.Text = "ㆍ프로세스ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(26, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 41;
            this.label2.Text = "ㆍ제품ID";
            // 
            // txtPID
            // 
            this.txtPID.Location = new System.Drawing.Point(356, 45);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(121, 21);
            this.txtPID.TabIndex = 56;
            this.txtPID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPID_KeyDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 173);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 455);
            this.panel3.TabIndex = 71;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(990, 173);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 455);
            this.panel4.TabIndex = 72;
            // 
            // dgvPR
            // 
            this.dgvPR.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPR.Location = new System.Drawing.Point(10, 173);
            this.dgvPR.Name = "dgvPR";
            this.dgvPR.RowTemplate.Height = 23;
            this.dgvPR.Size = new System.Drawing.Size(980, 455);
            this.dgvPR.TabIndex = 73;
            // 
            // frmPRODUCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 638);
            this.Controls.Add(this.dgvPR);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.panel5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPRODUCT";
            this.Text = "frmPRODUCT";
            this.Load += new System.EventHandler(this.frmPRODUCT_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.ToolStrip toolStrip2;
        protected System.Windows.Forms.ToolStripLabel title;
        public System.Windows.Forms.ToolStripButton BtnDelete;
        public System.Windows.Forms.ToolStripButton BtnEdit;
        public System.Windows.Forms.ToolStripButton BtnAdd;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripButton XlsDown;
        protected System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        protected System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblUserID;
        protected System.Windows.Forms.Button button3;
        protected System.Windows.Forms.TextBox txtID;
        protected System.Windows.Forms.Button button7;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.DataGridView dgvPR;
    }
}