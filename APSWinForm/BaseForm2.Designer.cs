
namespace APSWinForm
{
    partial class BaseForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm2));
            this.btnReset = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnAdd = new System.Windows.Forms.ToolStripButton();
            this.BtnEdit = new System.Windows.Forms.ToolStripButton();
            this.BtnDelete = new System.Windows.Forms.ToolStripButton();
            this.title = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.XlsDown = new System.Windows.Forms.ToolStripButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.panel9.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(105)))), ((int)(((byte)(129)))));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(653, 59);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(74, 30);
            this.btnReset.TabIndex = 54;
            this.btnReset.Text = "초기화";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.btnReset);
            this.panel9.Controls.Add(this.btnSearch);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(10, 10);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(780, 104);
            this.panel9.TabIndex = 42;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(106)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(653, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 30);
            this.btnSearch.TabIndex = 45;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panel2.Size = new System.Drawing.Size(800, 124);
            this.panel2.TabIndex = 50;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(790, 10);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 49);
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
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("ONE 모바일고딕 Title OTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title.Image = ((System.Drawing.Image)(resources.GetObject("title.Image")));
            this.title.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(90, 46);
            this.title.Text = "메뉴이름";
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
            this.toolStrip1.Size = new System.Drawing.Size(800, 49);
            this.toolStrip1.TabIndex = 49;
            this.toolStrip1.Text = "toolStrip1";
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
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(10, 600);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(790, 10);
            this.panel5.TabIndex = 54;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(790, 173);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 427);
            this.panel4.TabIndex = 52;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 173);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 437);
            this.panel3.TabIndex = 51;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(10, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 363);
            this.panel1.TabIndex = 55;
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(228)))));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(10, 173);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.Size = new System.Drawing.Size(780, 427);
            this.dgv.TabIndex = 55;
            // 
            // BaseForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 610);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "BaseForm2";
            this.Text = "Form1";
            this.panel9.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Button btnReset;
        protected System.Windows.Forms.Panel panel9;
        protected System.Windows.Forms.Button btnSearch;
        protected System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        protected System.Windows.Forms.ToolStripLabel title;
        public System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton BtnAdd;
        public System.Windows.Forms.ToolStripButton BtnEdit;
        public System.Windows.Forms.ToolStripButton BtnDelete;
        public System.Windows.Forms.ToolStripButton XlsDown;
        protected System.Windows.Forms.Panel panel8;
        protected System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Panel panel5;
        protected System.Windows.Forms.Panel panel4;
        protected System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv;
    }
}