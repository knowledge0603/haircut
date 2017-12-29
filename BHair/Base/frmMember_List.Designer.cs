namespace BHair.Base
{
    partial class frmMember_List
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblMember = new System.Windows.Forms.Label();
            this.txtMember = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnRecharge = new System.Windows.Forms.Button();
            this.chkEnabled = new System.Windows.Forms.CheckBox();
            this.dgvMember = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnuMember = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuMember_Recharge = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuMember_Transfer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmnuMember_PaysLog = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuMember_RechargeLog = new System.Windows.Forms.ToolStripMenuItem();
            this.记录记录ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.cmnuMember_Exchange = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuMember_Back = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuMember_Refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblSumBalance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            this.cmnuMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Location = new System.Drawing.Point(10, 15);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(125, 12);
            this.lblMember.TabIndex = 0;
            this.lblMember.Text = "输入会员卡号或姓名：";
            // 
            // txtMember
            // 
            this.txtMember.Location = new System.Drawing.Point(141, 12);
            this.txtMember.Name = "txtMember";
            this.txtMember.Size = new System.Drawing.Size(100, 21);
            this.txtMember.TabIndex = 1;
            this.txtMember.TextChanged += new System.EventHandler(this.txtMember_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(247, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "新增会员(&A)";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(338, 10);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(85, 23);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "编辑会员(&M)";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnRecharge
            // 
            this.btnRecharge.Location = new System.Drawing.Point(429, 10);
            this.btnRecharge.Name = "btnRecharge";
            this.btnRecharge.Size = new System.Drawing.Size(85, 23);
            this.btnRecharge.TabIndex = 4;
            this.btnRecharge.Text = "会员充值(&R)";
            this.btnRecharge.UseVisualStyleBackColor = true;
            this.btnRecharge.Click += new System.EventHandler(this.btnRecharge_Click);
            // 
            // chkEnabled
            // 
            this.chkEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkEnabled.AutoSize = true;
            this.chkEnabled.Location = new System.Drawing.Point(604, 14);
            this.chkEnabled.Name = "chkEnabled";
            this.chkEnabled.Size = new System.Drawing.Size(108, 16);
            this.chkEnabled.TabIndex = 5;
            this.chkEnabled.Text = "显示已停用会员";
            this.chkEnabled.UseVisualStyleBackColor = true;
            this.chkEnabled.CheckedChanged += new System.EventHandler(this.chkEnabled_CheckedChanged);
            // 
            // dgvMember
            // 
            this.dgvMember.AllowUserToAddRows = false;
            this.dgvMember.AllowUserToDeleteRows = false;
            this.dgvMember.AllowUserToResizeRows = false;
            this.dgvMember.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dgvMember.ContextMenuStrip = this.cmnuMember;
            this.dgvMember.Location = new System.Drawing.Point(12, 39);
            this.dgvMember.MultiSelect = false;
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.RowTemplate.Height = 23;
            this.dgvMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMember.Size = new System.Drawing.Size(700, 361);
            this.dgvMember.TabIndex = 6;
            this.dgvMember.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvMember_MouseDown);
            this.dgvMember.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvMember_RowPostPaint);
            this.dgvMember.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMember_CellMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "会员卡号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "会员类型";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "会员姓名";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "会员性别";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "会员生日";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column6.HeaderText = "当前余额";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "当前积分";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "联系电话";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.Column9.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column9.HeaderText = "最近光顾";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "会员状态";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "其它信息";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "备注";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // cmnuMember
            // 
            this.cmnuMember.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuMember_Recharge,
            this.cmnuMember_Transfer,
            this.toolStripMenuItem1,
            this.cmnuMember_PaysLog,
            this.cmnuMember_RechargeLog,
            this.记录记录ToolStripMenuItem,
            this.cmnuMember_Exchange,
            this.cmnuMember_Back,
            this.cmnuMember_Refresh});
            this.cmnuMember.Name = "cmnuMember";
            this.cmnuMember.Size = new System.Drawing.Size(153, 192);
            // 
            // cmnuMember_Recharge
            // 
            this.cmnuMember_Recharge.Name = "cmnuMember_Recharge";
            this.cmnuMember_Recharge.Size = new System.Drawing.Size(152, 22);
            this.cmnuMember_Recharge.Text = "会员值充(&R)";
            this.cmnuMember_Recharge.Click += new System.EventHandler(this.cmnuMember_Recharge_Click);
            // 
            // cmnuMember_Transfer
            // 
            this.cmnuMember_Transfer.Name = "cmnuMember_Transfer";
            this.cmnuMember_Transfer.Size = new System.Drawing.Size(152, 22);
            this.cmnuMember_Transfer.Text = "余额转账(&T)";
            this.cmnuMember_Transfer.Click += new System.EventHandler(this.cmnuMember_Transfer_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // cmnuMember_PaysLog
            // 
            this.cmnuMember_PaysLog.Name = "cmnuMember_PaysLog";
            this.cmnuMember_PaysLog.Size = new System.Drawing.Size(152, 22);
            this.cmnuMember_PaysLog.Text = "查看消费记录";
            this.cmnuMember_PaysLog.Click += new System.EventHandler(this.cmnuMember_PaysLog_Click);
            // 
            // cmnuMember_RechargeLog
            // 
            this.cmnuMember_RechargeLog.Name = "cmnuMember_RechargeLog";
            this.cmnuMember_RechargeLog.Size = new System.Drawing.Size(152, 22);
            this.cmnuMember_RechargeLog.Text = "查看值充记录";
            this.cmnuMember_RechargeLog.Click += new System.EventHandler(this.cmnuMember_RechargeLog_Click);
            // 
            // 记录记录ToolStripMenuItem
            // 
            this.记录记录ToolStripMenuItem.Name = "记录记录ToolStripMenuItem";
            this.记录记录ToolStripMenuItem.Size = new System.Drawing.Size(149, 6);
            // 
            // cmnuMember_Exchange
            // 
            this.cmnuMember_Exchange.Name = "cmnuMember_Exchange";
            this.cmnuMember_Exchange.Size = new System.Drawing.Size(152, 22);
            this.cmnuMember_Exchange.Text = "会员换卡(&X)";
            this.cmnuMember_Exchange.Click += new System.EventHandler(this.cmnuMember_Exchange_Click);
            // 
            // cmnuMember_Back
            // 
            this.cmnuMember_Back.Name = "cmnuMember_Back";
            this.cmnuMember_Back.Size = new System.Drawing.Size(152, 22);
            this.cmnuMember_Back.Text = "会员退卡(&B)";
            this.cmnuMember_Back.Click += new System.EventHandler(this.cmnuMember_Back_Click);
            // 
            // cmnuMember_Refresh
            // 
            this.cmnuMember_Refresh.Name = "cmnuMember_Refresh";
            this.cmnuMember_Refresh.Size = new System.Drawing.Size(152, 22);
            this.cmnuMember_Refresh.Text = "刷新(&E)";
            this.cmnuMember_Refresh.Click += new System.EventHandler(this.cmnuMember_Refresh_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(10, 403);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(77, 12);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "会员数统计：";
            // 
            // lblType
            // 
            this.lblType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(602, 403);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(59, 12);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "[lblType]";
            // 
            // lblSumBalance
            // 
            this.lblSumBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSumBalance.AutoSize = true;
            this.lblSumBalance.Location = new System.Drawing.Point(326, 403);
            this.lblSumBalance.Name = "lblSumBalance";
            this.lblSumBalance.Size = new System.Drawing.Size(89, 12);
            this.lblSumBalance.TabIndex = 9;
            this.lblSumBalance.Text = "合计会员余额：";
            // 
            // frmMember_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 424);
            this.Controls.Add(this.lblSumBalance);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvMember);
            this.Controls.Add(this.chkEnabled);
            this.Controls.Add(this.btnRecharge);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMember);
            this.Controls.Add(this.lblMember);
            this.Name = "frmMember_List";
            this.TabText = "会员管理";
            this.Text = "会员管理";
            this.Load += new System.EventHandler(this.frmMember_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
            this.cmnuMember.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.TextBox txtMember;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnRecharge;
        private System.Windows.Forms.CheckBox chkEnabled;
        private System.Windows.Forms.DataGridView dgvMember;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblSumBalance;
        private System.Windows.Forms.ContextMenuStrip cmnuMember;
        private System.Windows.Forms.ToolStripMenuItem cmnuMember_Recharge;
        private System.Windows.Forms.ToolStripMenuItem cmnuMember_Transfer;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cmnuMember_PaysLog;
        private System.Windows.Forms.ToolStripMenuItem cmnuMember_RechargeLog;
        private System.Windows.Forms.ToolStripSeparator 记录记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmnuMember_Exchange;
        private System.Windows.Forms.ToolStripMenuItem cmnuMember_Refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.ToolStripMenuItem cmnuMember_Back;
    }
}