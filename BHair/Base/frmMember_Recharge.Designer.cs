namespace BHair.Base
{
    partial class frmMember_Recharge
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
            this.lblSum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpMember = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPoint = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblCardName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDeposit = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnuDeposit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuDeposit_Recharge = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuDeposit_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuDeposit_Refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRecharge = new System.Windows.Forms.Button();
            this.cboDate = new BHair.SystemSet.ComboDate();
            this.grpMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeposit)).BeginInit();
            this.cmnuDeposit.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSum.ForeColor = System.Drawing.Color.Blue;
            this.lblSum.Location = new System.Drawing.Point(129, 377);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(55, 14);
            this.lblSum.TabIndex = 17;
            this.lblSum.Text = "[lblSum]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "按日期过滤：";
            // 
            // grpMember
            // 
            this.grpMember.Controls.Add(this.lblStatus);
            this.grpMember.Controls.Add(this.label8);
            this.grpMember.Controls.Add(this.lblPoint);
            this.grpMember.Controls.Add(this.lblBalance);
            this.grpMember.Controls.Add(this.lblCardName);
            this.grpMember.Controls.Add(this.lblName);
            this.grpMember.Controls.Add(this.lblMemberID);
            this.grpMember.Controls.Add(this.label5);
            this.grpMember.Controls.Add(this.label4);
            this.grpMember.Controls.Add(this.label3);
            this.grpMember.Controls.Add(this.label2);
            this.grpMember.Controls.Add(this.label1);
            this.grpMember.Location = new System.Drawing.Point(12, 12);
            this.grpMember.Name = "grpMember";
            this.grpMember.Size = new System.Drawing.Size(593, 57);
            this.grpMember.TabIndex = 11;
            this.grpMember.TabStop = false;
            this.grpMember.Text = "会员信息";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(467, 39);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(71, 12);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "[lblStatus]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(396, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "当前状态：";
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.ForeColor = System.Drawing.Color.Red;
            this.lblPoint.Location = new System.Drawing.Point(275, 39);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(65, 12);
            this.lblPoint.TabIndex = 9;
            this.lblPoint.Text = "[lblPoint]";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.ForeColor = System.Drawing.Color.Red;
            this.lblBalance.Location = new System.Drawing.Point(89, 39);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(77, 12);
            this.lblBalance.TabIndex = 8;
            this.lblBalance.Text = "[lblBalance]";
            // 
            // lblCardName
            // 
            this.lblCardName.AutoSize = true;
            this.lblCardName.ForeColor = System.Drawing.Color.Red;
            this.lblCardName.Location = new System.Drawing.Point(467, 17);
            this.lblCardName.Name = "lblCardName";
            this.lblCardName.Size = new System.Drawing.Size(83, 12);
            this.lblCardName.TabIndex = 7;
            this.lblCardName.Text = "[lblCardName]";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Red;
            this.lblName.Location = new System.Drawing.Point(275, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 12);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "[lblName]";
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.ForeColor = System.Drawing.Color.Red;
            this.lblMemberID.Location = new System.Drawing.Point(89, 17);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(83, 12);
            this.lblMemberID.TabIndex = 5;
            this.lblMemberID.Text = "[lblMemberID]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "当前积分：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "当前余额：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "会员卡级别：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "会员姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "会员卡号：";
            // 
            // dgvDeposit
            // 
            this.dgvDeposit.AllowUserToAddRows = false;
            this.dgvDeposit.AllowUserToDeleteRows = false;
            this.dgvDeposit.AllowUserToResizeColumns = false;
            this.dgvDeposit.AllowUserToResizeRows = false;
            this.dgvDeposit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeposit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
            this.dgvDeposit.ContextMenuStrip = this.cmnuDeposit;
            this.dgvDeposit.Location = new System.Drawing.Point(12, 104);
            this.dgvDeposit.Name = "dgvDeposit";
            this.dgvDeposit.RowTemplate.Height = 23;
            this.dgvDeposit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeposit.Size = new System.Drawing.Size(593, 267);
            this.dgvDeposit.TabIndex = 10;
            this.dgvDeposit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvDeposit_MouseDown);
            this.dgvDeposit.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvDeposit_RowPostPaint);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "流水号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Money";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column2.HeaderText = "金额";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 90;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Date";
            this.Column3.HeaderText = "日期";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 120;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ModeText";
            this.Column5.HeaderText = "续费方式";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Remark";
            this.Column4.HeaderText = "备注";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 160;
            // 
            // cmnuDeposit
            // 
            this.cmnuDeposit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuDeposit_Recharge,
            this.cmnuDeposit_Delete,
            this.cmnuDeposit_Refresh});
            this.cmnuDeposit.Name = "cmnuDeposit";
            this.cmnuDeposit.Size = new System.Drawing.Size(137, 70);
            // 
            // cmnuDeposit_Recharge
            // 
            this.cmnuDeposit_Recharge.Name = "cmnuDeposit_Recharge";
            this.cmnuDeposit_Recharge.Size = new System.Drawing.Size(136, 22);
            this.cmnuDeposit_Recharge.Text = "充值(&R)";
            this.cmnuDeposit_Recharge.Click += new System.EventHandler(this.cmnuDeposit_Recharge_Click);
            // 
            // cmnuDeposit_Delete
            // 
            this.cmnuDeposit_Delete.Name = "cmnuDeposit_Delete";
            this.cmnuDeposit_Delete.Size = new System.Drawing.Size(136, 22);
            this.cmnuDeposit_Delete.Text = "删除记录(&D)";
            this.cmnuDeposit_Delete.Click += new System.EventHandler(this.cmnuDeposit_Delete_Click);
            // 
            // cmnuDeposit_Refresh
            // 
            this.cmnuDeposit_Refresh.Name = "cmnuDeposit_Refresh";
            this.cmnuDeposit_Refresh.Size = new System.Drawing.Size(136, 22);
            this.cmnuDeposit_Refresh.Text = "刷新(&E)";
            this.cmnuDeposit_Refresh.Click += new System.EventHandler(this.cmnuDeposit_Refresh_Click);
            // 
            // btnRecharge
            // 
            this.btnRecharge.Location = new System.Drawing.Point(336, 75);
            this.btnRecharge.Name = "btnRecharge";
            this.btnRecharge.Size = new System.Drawing.Size(75, 23);
            this.btnRecharge.TabIndex = 18;
            this.btnRecharge.Text = "充值(&R)";
            this.btnRecharge.UseVisualStyleBackColor = true;
            this.btnRecharge.Click += new System.EventHandler(this.btnRecharge_Click);
            // 
            // cboDate
            // 
            this.cboDate.IsAllMonth = true;
            this.cboDate.IsAllYear = false;
            this.cboDate.Location = new System.Drawing.Point(93, 75);
            this.cboDate.Name = "cboDate";
            this.cboDate.ShowMode = BHair.SystemSet.ShowMode.YearAndMonth;
            this.cboDate.Size = new System.Drawing.Size(237, 20);
            this.cboDate.TabIndex = 19;
            this.cboDate.SelectedIndexChanged += new System.EventHandler(this.cboDate_SelectedIndexChanged);
            // 
            // frmMember_Recharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 399);
            this.Controls.Add(this.cboDate);
            this.Controls.Add(this.btnRecharge);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grpMember);
            this.Controls.Add(this.dgvDeposit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMember_Recharge";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "会员充值记录";
            this.Load += new System.EventHandler(this.frmMember_Recharge_Load);
            this.grpMember.ResumeLayout(false);
            this.grpMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeposit)).EndInit();
            this.cmnuDeposit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpMember;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblCardName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDeposit;
        private System.Windows.Forms.Button btnRecharge;
        private BHair.SystemSet.ComboDate cboDate;
        private System.Windows.Forms.ContextMenuStrip cmnuDeposit;
        private System.Windows.Forms.ToolStripMenuItem cmnuDeposit_Recharge;
        private System.Windows.Forms.ToolStripMenuItem cmnuDeposit_Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ToolStripMenuItem cmnuDeposit_Refresh;
    }
}