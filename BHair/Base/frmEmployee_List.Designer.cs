namespace BHair.Base
{
    partial class frmEmployee_List
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
            this.components = new System.ComponentModel.Container();
            this.btnReset = new System.Windows.Forms.Button();
            this.tvwPost = new System.Windows.Forms.TreeView();
            this.cmnuPost = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuPost_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuPost_Modify = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuPost_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnuEmployee = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuEmployee_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuEmployee_Modify = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmnuEmployee_Score = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuEmployee_Log = new System.Windows.Forms.ToolStripMenuItem();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.cmnuPost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.cmnuEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(300, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "清空密码";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Visible = false;
            // 
            // tvwPost
            // 
            this.tvwPost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.tvwPost.ContextMenuStrip = this.cmnuPost;
            this.tvwPost.Location = new System.Drawing.Point(12, 12);
            this.tvwPost.Name = "tvwPost";
            this.tvwPost.Size = new System.Drawing.Size(120, 429);
            this.tvwPost.TabIndex = 8;
            this.tvwPost.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwPost_AfterSelect);
            this.tvwPost.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tvwPost_MouseDown);
            // 
            // cmnuPost
            // 
            this.cmnuPost.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuPost_Add,
            this.cmnuPost_Modify,
            this.cmnuPost_Delete});
            this.cmnuPost.Name = "cmnuPost";
            this.cmnuPost.Size = new System.Drawing.Size(113, 70);
            // 
            // cmnuPost_Add
            // 
            this.cmnuPost_Add.Name = "cmnuPost_Add";
            this.cmnuPost_Add.Size = new System.Drawing.Size(112, 22);
            this.cmnuPost_Add.Text = "新增(&A)";
            this.cmnuPost_Add.Click += new System.EventHandler(this.cmnuPost_Add_Click);
            // 
            // cmnuPost_Modify
            // 
            this.cmnuPost_Modify.Name = "cmnuPost_Modify";
            this.cmnuPost_Modify.Size = new System.Drawing.Size(112, 22);
            this.cmnuPost_Modify.Text = "修改(&M)";
            this.cmnuPost_Modify.Click += new System.EventHandler(this.cmnuPost_Modify_Click);
            // 
            // cmnuPost_Delete
            // 
            this.cmnuPost_Delete.Name = "cmnuPost_Delete";
            this.cmnuPost_Delete.Size = new System.Drawing.Size(112, 22);
            this.cmnuPost_Delete.Text = "删除(&D)";
            this.cmnuPost_Delete.Click += new System.EventHandler(this.cmnuPost_Delete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(219, 12);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 11;
            this.btnModify.Text = "修改(&M)";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(138, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "新增(&A)";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToResizeRows = false;
            this.dgvEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvEmployee.ContextMenuStrip = this.cmnuEmployee;
            this.dgvEmployee.Location = new System.Drawing.Point(138, 41);
            this.dgvEmployee.MultiSelect = false;
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowTemplate.Height = 23;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(633, 400);
            this.dgvEmployee.TabIndex = 9;
            this.dgvEmployee.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvEmployee_MouseDown);
            this.dgvEmployee.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvEmployee_RowPostPaint);
            this.dgvEmployee.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEmployee_CellMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "员工编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Code";
            this.Column2.HeaderText = "员工工号";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Name";
            this.Column3.HeaderText = "姓名";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SexText";
            this.Column4.HeaderText = "性别";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "PostName";
            this.Column5.HeaderText = "职位";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Mobile";
            this.Column6.HeaderText = "手机";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Input";
            this.Column7.HeaderText = "入职日期";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "StatusText";
            this.Column8.HeaderText = "状态";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Remark";
            this.Column9.HeaderText = "备注";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 200;
            // 
            // cmnuEmployee
            // 
            this.cmnuEmployee.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuEmployee_Add,
            this.cmnuEmployee_Modify,
            this.toolStripMenuItem1,
            this.cmnuEmployee_Score,
            this.cmnuEmployee_Log});
            this.cmnuEmployee.Name = "cmnuEmployee";
            this.cmnuEmployee.Size = new System.Drawing.Size(155, 98);
            // 
            // cmnuEmployee_Add
            // 
            this.cmnuEmployee_Add.Name = "cmnuEmployee_Add";
            this.cmnuEmployee_Add.Size = new System.Drawing.Size(154, 22);
            this.cmnuEmployee_Add.Text = "新增(&A)";
            this.cmnuEmployee_Add.Click += new System.EventHandler(this.cmnuEmployee_Add_Click);
            // 
            // cmnuEmployee_Modify
            // 
            this.cmnuEmployee_Modify.Name = "cmnuEmployee_Modify";
            this.cmnuEmployee_Modify.Size = new System.Drawing.Size(154, 22);
            this.cmnuEmployee_Modify.Text = "修改(&M)";
            this.cmnuEmployee_Modify.Click += new System.EventHandler(this.cmnuEmployee_Modify_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(151, 6);
            // 
            // cmnuEmployee_Score
            // 
            this.cmnuEmployee_Score.Name = "cmnuEmployee_Score";
            this.cmnuEmployee_Score.Size = new System.Drawing.Size(154, 22);
            this.cmnuEmployee_Score.Text = "查看业绩(&S)";
            this.cmnuEmployee_Score.Click += new System.EventHandler(this.cmnuEmployee_Score_Click);
            // 
            // cmnuEmployee_Log
            // 
            this.cmnuEmployee_Log.Name = "cmnuEmployee_Log";
            this.cmnuEmployee_Log.Size = new System.Drawing.Size(154, 22);
            this.cmnuEmployee_Log.Text = "奖/扣款记录(&L)";
            this.cmnuEmployee_Log.Click += new System.EventHandler(this.cmnuEmployee_Log_Click);
            // 
            // chkAll
            // 
            this.chkAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(675, 16);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(96, 16);
            this.chkAll.TabIndex = 15;
            this.chkAll.Text = "显示离职员工";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // frmEmployee_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 453);
            this.Controls.Add(this.chkAll);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tvwPost);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvEmployee);
            this.Name = "frmEmployee_List";
            this.TabText = "员工信息管理";
            this.Text = "员工信息管理";
            this.Load += new System.EventHandler(this.frmEmployee_List_Load);
            this.cmnuPost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.cmnuEmployee.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TreeView tvwPost;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.ContextMenuStrip cmnuPost;
        private System.Windows.Forms.ContextMenuStrip cmnuEmployee;
        private System.Windows.Forms.ToolStripMenuItem cmnuPost_Add;
        private System.Windows.Forms.ToolStripMenuItem cmnuPost_Modify;
        private System.Windows.Forms.ToolStripMenuItem cmnuPost_Delete;
        private System.Windows.Forms.ToolStripMenuItem cmnuEmployee_Add;
        private System.Windows.Forms.ToolStripMenuItem cmnuEmployee_Modify;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cmnuEmployee_Score;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.ToolStripMenuItem cmnuEmployee_Log;
    }
}