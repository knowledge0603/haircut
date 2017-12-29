namespace BHair.Base
{
    partial class frmMember_Pay
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCash = new System.Windows.Forms.Label();
            this.lblPayBalance = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvPays = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpMember = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCardName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDate = new BHair.SystemSet.ComboDate();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPays)).BeginInit();
            this.grpMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Location = new System.Drawing.Point(396, 373);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(101, 12);
            this.lblCash.TabIndex = 27;
            this.lblCash.Text = "现金消费：￥0.00";
            // 
            // lblPayBalance
            // 
            this.lblPayBalance.AutoSize = true;
            this.lblPayBalance.Location = new System.Drawing.Point(216, 373);
            this.lblPayBalance.Name = "lblPayBalance";
            this.lblPayBalance.Size = new System.Drawing.Size(101, 12);
            this.lblPayBalance.TabIndex = 26;
            this.lblPayBalance.Text = "余额消费：￥0.00";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(18, 373);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(101, 12);
            this.lblSum.TabIndex = 25;
            this.lblSum.Text = "消费合计：￥0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "按日期过滤：";
            // 
            // dgvPays
            // 
            this.dgvPays.AllowUserToAddRows = false;
            this.dgvPays.AllowUserToDeleteRows = false;
            this.dgvPays.AllowUserToResizeRows = false;
            this.dgvPays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPays.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5});
            this.dgvPays.Location = new System.Drawing.Point(12, 101);
            this.dgvPays.Name = "dgvPays";
            this.dgvPays.RowTemplate.Height = 23;
            this.dgvPays.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPays.Size = new System.Drawing.Size(593, 269);
            this.dgvPays.TabIndex = 19;
            this.dgvPays.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvPays_RowPostPaint);
            this.dgvPays.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPays_CellMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PayCode";
            this.Column1.HeaderText = "消费单号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Money";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column2.HeaderText = "消费金额";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "PayDetailText";
            this.Column3.HeaderText = "消费项目";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "消费时间";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "支付方式";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 80;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "备注";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 110;
            // 
            // grpMember
            // 
            this.grpMember.Controls.Add(this.lblStatus);
            this.grpMember.Controls.Add(this.label8);
            this.grpMember.Controls.Add(this.lblBalance);
            this.grpMember.Controls.Add(this.lblPhone);
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
            this.grpMember.TabIndex = 18;
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
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "[lblStatus]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(396, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "当前状态：";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.ForeColor = System.Drawing.Color.Red;
            this.lblBalance.Location = new System.Drawing.Point(275, 39);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(77, 12);
            this.lblBalance.TabIndex = 9;
            this.lblBalance.Text = "[lblBalance]";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.ForeColor = System.Drawing.Color.Red;
            this.lblPhone.Location = new System.Drawing.Point(89, 39);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(65, 12);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "[lblPhone]";
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
            this.label5.Text = "卡内余额：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "联系电话：";
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
            // cboDate
            // 
            this.cboDate.IsAllMonth = true;
            this.cboDate.Location = new System.Drawing.Point(101, 75);
            this.cboDate.Name = "cboDate";
            this.cboDate.ShowMode = BHair.SystemSet.ShowMode.YearAndMonth;
            this.cboDate.Size = new System.Drawing.Size(237, 20);
            this.cboDate.TabIndex = 28;
            this.cboDate.SelectedIndexChanged += new System.EventHandler(this.cboDate_SelectedIndexChanged);
            // 
            // frmMember_Pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 393);
            this.Controls.Add(this.cboDate);
            this.Controls.Add(this.lblCash);
            this.Controls.Add(this.lblPayBalance);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvPays);
            this.Controls.Add(this.grpMember);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMember_Pay";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "会员消费记录";
            this.Load += new System.EventHandler(this.frmMember_Pay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPays)).EndInit();
            this.grpMember.ResumeLayout(false);
            this.grpMember.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label lblPayBalance;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvPays;
        private System.Windows.Forms.GroupBox grpMember;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCardName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private BHair.SystemSet.ComboDate cboDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}