
namespace APSWinForm
{
    partial class EQP_ARRANGE
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EQP_ARRANGE));
			this.dgvEQP = new System.Windows.Forms.DataGridView();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel9 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.cboEQP = new System.Windows.Forms.ComboBox();
			this.panel10 = new System.Windows.Forms.Panel();
			this.cboProcess = new System.Windows.Forms.ComboBox();
			this.panel11 = new System.Windows.Forms.Panel();
			this.cboProduct = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.panel8 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.title = new System.Windows.Forms.ToolStripLabel();
			this.BtnDelete = new System.Windows.Forms.ToolStripButton();
			this.BtnEdit = new System.Windows.Forms.ToolStripButton();
			this.BtnAdd = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.XlsDown = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvEQP)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel9.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel10.SuspendLayout();
			this.panel11.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvEQP
			// 
			this.dgvEQP.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.dgvEQP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEQP.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvEQP.Location = new System.Drawing.Point(10, 173);
			this.dgvEQP.Name = "dgvEQP";
			this.dgvEQP.ReadOnly = true;
			this.dgvEQP.RowTemplate.Height = 23;
			this.dgvEQP.Size = new System.Drawing.Size(846, 353);
			this.dgvEQP.TabIndex = 61;
			this.dgvEQP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEQP_CellClick);
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
			this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel4.Location = new System.Drawing.Point(856, 173);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(10, 353);
			this.panel4.TabIndex = 59;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
			this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel5.Location = new System.Drawing.Point(10, 526);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(856, 10);
			this.panel5.TabIndex = 60;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(239)))));
			this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel3.Location = new System.Drawing.Point(0, 173);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(10, 363);
			this.panel3.TabIndex = 58;
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
			this.panel2.Size = new System.Drawing.Size(866, 124);
			this.panel2.TabIndex = 57;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Location = new System.Drawing.Point(10, 156);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(846, 363);
			this.panel1.TabIndex = 55;
			// 
			// panel9
			// 
			this.panel9.BackColor = System.Drawing.Color.White;
			this.panel9.Controls.Add(this.panel7);
			this.panel9.Controls.Add(this.panel10);
			this.panel9.Controls.Add(this.panel11);
			this.panel9.Controls.Add(this.label2);
			this.panel9.Controls.Add(this.label3);
			this.panel9.Controls.Add(this.label10);
			this.panel9.Controls.Add(this.btnReset);
			this.panel9.Controls.Add(this.btnSearch);
			this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel9.Location = new System.Drawing.Point(10, 10);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(846, 104);
			this.panel9.TabIndex = 42;
			// 
			// panel7
			// 
			this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel7.Controls.Add(this.cboEQP);
			this.panel7.Location = new System.Drawing.Point(335, 28);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(121, 20);
			this.panel7.TabIndex = 181;
			// 
			// cboEQP
			// 
			this.cboEQP.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cboEQP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboEQP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cboEQP.FormattingEnabled = true;
			this.cboEQP.Location = new System.Drawing.Point(0, 0);
			this.cboEQP.Name = "cboEQP";
			this.cboEQP.Size = new System.Drawing.Size(119, 20);
			this.cboEQP.TabIndex = 167;
			// 
			// panel10
			// 
			this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel10.Controls.Add(this.cboProcess);
			this.panel10.Location = new System.Drawing.Point(115, 64);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(121, 20);
			this.panel10.TabIndex = 182;
			// 
			// cboProcess
			// 
			this.cboProcess.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cboProcess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cboProcess.FormattingEnabled = true;
			this.cboProcess.Location = new System.Drawing.Point(0, 0);
			this.cboProcess.Name = "cboProcess";
			this.cboProcess.Size = new System.Drawing.Size(119, 20);
			this.cboProcess.TabIndex = 167;
			// 
			// panel11
			// 
			this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel11.Controls.Add(this.cboProduct);
			this.panel11.Location = new System.Drawing.Point(114, 28);
			this.panel11.Name = "panel11";
			this.panel11.Size = new System.Drawing.Size(121, 20);
			this.panel11.TabIndex = 183;
			// 
			// cboProduct
			// 
			this.cboProduct.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cboProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cboProduct.FormattingEnabled = true;
			this.cboProduct.Location = new System.Drawing.Point(0, 0);
			this.cboProduct.Name = "cboProduct";
			this.cboProduct.Size = new System.Drawing.Size(119, 20);
			this.cboProduct.TabIndex = 167;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label2.Location = new System.Drawing.Point(27, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 14);
			this.label2.TabIndex = 180;
			this.label2.Text = "ㆍ공정ID";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label3.Location = new System.Drawing.Point(26, 31);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 14);
			this.label3.TabIndex = 179;
			this.label3.Text = "ㆍ제품ID";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("ONE 모바일고딕 OTF Regular", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label10.Location = new System.Drawing.Point(274, 31);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(55, 14);
			this.label10.TabIndex = 178;
			this.label10.Text = "ㆍ설비ID";
			// 
			// btnReset
			// 
			this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(105)))), ((int)(((byte)(129)))));
			this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReset.ForeColor = System.Drawing.Color.White;
			this.btnReset.Location = new System.Drawing.Point(730, 60);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(74, 30);
			this.btnReset.TabIndex = 56;
			this.btnReset.Text = "초기화";
			this.btnReset.UseVisualStyleBackColor = false;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(78)))), ((int)(((byte)(106)))));
			this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.ForeColor = System.Drawing.Color.White;
			this.btnSearch.Location = new System.Drawing.Point(730, 20);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(74, 30);
			this.btnSearch.TabIndex = 55;
			this.btnSearch.Text = "검색";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// panel8
			// 
			this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel8.Location = new System.Drawing.Point(856, 10);
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
			this.toolStrip1.Size = new System.Drawing.Size(866, 49);
			this.toolStrip1.TabIndex = 56;
			this.toolStrip1.Text = "toolStrip1";
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
			this.BtnDelete.Click += new System.EventHandler(this.pictureBox6_Click);
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
			this.BtnEdit.Click += new System.EventHandler(this.btnModify_Click);
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
			this.BtnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 49);
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
			// EQP_ARRANGE
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(866, 536);
			this.Controls.Add(this.dgvEQP);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.toolStrip1);
			this.Name = "EQP_ARRANGE";
			this.Text = "설비배치정보";
			this.Load += new System.EventHandler(this.EQP_ARRANGE_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvEQP)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel9.ResumeLayout(false);
			this.panel9.PerformLayout();
			this.panel7.ResumeLayout(false);
			this.panel10.ResumeLayout(false);
			this.panel11.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEQP;
        protected System.Windows.Forms.Panel panel4;
        protected System.Windows.Forms.Panel panel5;
        protected System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox cboEQP;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.ComboBox cboProcess;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.ComboBox cboProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        protected System.Windows.Forms.Button btnReset;
        protected System.Windows.Forms.Button btnSearch;
        protected System.Windows.Forms.Panel panel8;
        protected System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.ToolStrip toolStrip1;
        protected System.Windows.Forms.ToolStripLabel title;
        public System.Windows.Forms.ToolStripButton BtnDelete;
        public System.Windows.Forms.ToolStripButton BtnEdit;
        public System.Windows.Forms.ToolStripButton BtnAdd;
        protected System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripButton XlsDown;
    }
}