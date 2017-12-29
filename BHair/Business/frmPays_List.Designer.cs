namespace BHair.Business
{
    partial class frmPays_List
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNotPay = new System.Windows.Forms.Label();
            this.lblMember = new System.Windows.Forms.Label();
            this.lblCashMoney = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvPays = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnuPays = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnuPays_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuPays_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuPays_Remark = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmnuPays_OK = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.cmnuPays_Refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.cboDate = new BHair.SystemSet.ComboDate();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPays)).BeginInit();
            this.cmnuPays.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNotPay
            // 
            this.lblNotPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNotPay.AutoSize = true;
            this.lblNotPay.Location = new System.Drawing.Point(679, 468);
            this.lblNotPay.Name = "lblNotPay";
            this.lblNotPay.Size = new System.Drawing.Size(77, 12);
            this.lblNotPay.TabIndex = 30;
            this.lblNotPay.Text = "未结算金额：";
            // 
            // lblMember
            // 
            this.lblMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMember.AutoSize = true;
            this.lblMember.Location = new System.Drawing.Point(482, 468);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(65, 12);
            this.lblMember.TabIndex = 29;
            this.lblMember.Text = "余额消费：";
            // 
            // lblCashMoney
            // 
            this.lblCashMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCashMoney.AutoSize = true;
            this.lblCashMoney.Location = new System.Drawing.Point(292, 468);
            this.lblCashMoney.Name = "lblCashMoney";
            this.lblCashMoney.Size = new System.Drawing.Size(65, 12);
            this.lblCashMoney.TabIndex = 28;
            this.lblCashMoney.Text = "现金消费：";
            // 
            // lblSum
            // 
            this.lblSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(10, 468);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(53, 12);
            this.lblSum.TabIndex = 27;
            this.lblSum.Text = "营业额：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "输入消费单号：";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(105, 12);
            this.txtID.MaxLength = 10;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 21);
            this.txtID.TabIndex = 25;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(531, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "新增消费";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvPays
            // 
            this.dgvPays.AllowUserToAddRows = false;
            this.dgvPays.AllowUserToResizeRows = false;
            this.dgvPays.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPays.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column10,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column4,
            this.Column9,
            this.Column7,
            this.Column8});
            this.dgvPays.ContextMenuStrip = this.cmnuPays;
            this.dgvPays.Location = new System.Drawing.Point(12, 39);
            this.dgvPays.MultiSelect = false;
            this.dgvPays.Name = "dgvPays";
            this.dgvPays.RowTemplate.Height = 23;
            this.dgvPays.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPays.Size = new System.Drawing.Size(795, 426);
            this.dgvPays.TabIndex = 18;
            this.dgvPays.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvPays_MouseDown);
            this.dgvPays.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvPays_RowPostPaint);
            this.dgvPays.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPays_CellMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PayCode";
            this.Column1.HeaderText = "消费单号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "顾客/会员信息";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 160;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "DetailText";
            this.Column10.HeaderText = "消费内容";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 180;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Money";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column3.HeaderText = "消费金额";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Cash";
            dataGridViewCellStyle2.Format = "C2";
            this.Column5.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column5.HeaderText = "实收金额";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Zero";
            dataGridViewCellStyle3.Format = "C2";
            this.Column6.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column6.HeaderText = "找零金额";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "PayDate";
            this.Column4.HeaderText = "消费时间";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "PayTypeText";
            this.Column9.HeaderText = "支付方式";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 80;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "StatusText";
            this.Column7.HeaderText = "状态";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Remark";
            this.Column8.HeaderText = "备注";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 200;
            // 
            // cmnuPays
            // 
            this.cmnuPays.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuPays_Add,
            this.cmnuPays_Delete,
            this.cmnuPays_Remark,
            this.toolStripMenuItem1,
            this.cmnuPays_OK,
            this.toolStripMenuItem5,
            this.cmnuPays_Refresh});
            this.cmnuPays.Name = "cmnuPays";
            this.cmnuPays.Size = new System.Drawing.Size(137, 126);
            // 
            // cmnuPays_Add
            // 
            this.cmnuPays_Add.Name = "cmnuPays_Add";
            this.cmnuPays_Add.Size = new System.Drawing.Size(136, 22);
            this.cmnuPays_Add.Text = "新增消费(&A)";
            this.cmnuPays_Add.Click += new System.EventHandler(this.cmnuPays_Add_Click);
            // 
            // cmnuPays_Delete
            // 
            this.cmnuPays_Delete.Name = "cmnuPays_Delete";
            this.cmnuPays_Delete.Size = new System.Drawing.Size(136, 22);
            this.cmnuPays_Delete.Text = "删除消费(&D)";
            this.cmnuPays_Delete.Click += new System.EventHandler(this.cmnuPays_Delete_Click);
            // 
            // cmnuPays_Remark
            // 
            this.cmnuPays_Remark.Name = "cmnuPays_Remark";
            this.cmnuPays_Remark.Size = new System.Drawing.Size(136, 22);
            this.cmnuPays_Remark.Text = "填写备注(&R)";
            this.cmnuPays_Remark.Click += new System.EventHandler(this.cmnuPays_Remark_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(133, 6);
            // 
            // cmnuPays_OK
            // 
            this.cmnuPays_OK.Name = "cmnuPays_OK";
            this.cmnuPays_OK.Size = new System.Drawing.Size(136, 22);
            this.cmnuPays_OK.Text = "消费结算(&P)";
            this.cmnuPays_OK.Click += new System.EventHandler(this.cmnuPays_OK_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(133, 6);
            // 
            // cmnuPays_Refresh
            // 
            this.cmnuPays_Refresh.Name = "cmnuPays_Refresh";
            this.cmnuPays_Refresh.Size = new System.Drawing.Size(136, 22);
            this.cmnuPays_Refresh.Text = "刷新(&E)";
            this.cmnuPays_Refresh.Click += new System.EventHandler(this.cmnuPays_Refresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 35;
            this.label2.Text = "按年月过滤：";
            // 
            // cboDate
            // 
            this.cboDate.IsAllMonth = false;
            this.cboDate.IsAllYear = false;
            this.cboDate.Location = new System.Drawing.Point(288, 12);
            this.cboDate.Name = "cboDate";
            this.cboDate.ShowMode = BHair.SystemSet.ShowMode.All;
            this.cboDate.Size = new System.Drawing.Size(237, 20);
            this.cboDate.TabIndex = 36;
            this.cboDate.SelectedIndexChanged += new System.EventHandler(this.cboDate_SelectedIndexChanged);
            // 
            // frmPays_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 489);
            this.Controls.Add(this.cboDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNotPay);
            this.Controls.Add(this.lblMember);
            this.Controls.Add(this.lblCashMoney);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvPays);
            this.Name = "frmPays_List";
            this.TabText = "消费单据";
            this.Text = "消费单据";
            this.Load += new System.EventHandler(this.frmPays_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPays)).EndInit();
            this.cmnuPays.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNotPay;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.Label lblCashMoney;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvPays;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private BHair.SystemSet.ComboDate cboDate;
        private System.Windows.Forms.ContextMenuStrip cmnuPays;
        private System.Windows.Forms.ToolStripMenuItem cmnuPays_OK;
        private System.Windows.Forms.ToolStripMenuItem cmnuPays_Add;
        private System.Windows.Forms.ToolStripMenuItem cmnuPays_Delete;
        private System.Windows.Forms.ToolStripMenuItem cmnuPays_Remark;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem cmnuPays_Refresh;
    }
}