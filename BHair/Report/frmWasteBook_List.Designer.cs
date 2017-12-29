namespace BHair.Report
{
    partial class frmWasteBook_List
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblIncome = new System.Windows.Forms.Label();
            this.lblExpend = new System.Windows.Forms.Label();
            this.dgvWasteBook = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnIncome = new System.Windows.Forms.Button();
            this.btnExpend = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.cboDay = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWasteBook)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMoney
            // 
            this.lblMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMoney.AutoSize = true;
            this.lblMoney.ForeColor = System.Drawing.Color.Blue;
            this.lblMoney.Location = new System.Drawing.Point(429, 453);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(65, 12);
            this.lblMoney.TabIndex = 20;
            this.lblMoney.Text = "盈亏金额：";
            // 
            // lblIncome
            // 
            this.lblIncome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIncome.AutoSize = true;
            this.lblIncome.ForeColor = System.Drawing.Color.Red;
            this.lblIncome.Location = new System.Drawing.Point(236, 453);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(53, 12);
            this.lblIncome.TabIndex = 19;
            this.lblIncome.Text = "总收入：";
            // 
            // lblExpend
            // 
            this.lblExpend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblExpend.AutoSize = true;
            this.lblExpend.ForeColor = System.Drawing.Color.Green;
            this.lblExpend.Location = new System.Drawing.Point(36, 453);
            this.lblExpend.Name = "lblExpend";
            this.lblExpend.Size = new System.Drawing.Size(53, 12);
            this.lblExpend.TabIndex = 18;
            this.lblExpend.Text = "总支出：";
            // 
            // dgvWasteBook
            // 
            this.dgvWasteBook.AllowUserToAddRows = false;
            this.dgvWasteBook.AllowUserToResizeRows = false;
            this.dgvWasteBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWasteBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWasteBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvWasteBook.Location = new System.Drawing.Point(12, 39);
            this.dgvWasteBook.MultiSelect = false;
            this.dgvWasteBook.Name = "dgvWasteBook";
            this.dgvWasteBook.RowTemplate.Height = 23;
            this.dgvWasteBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWasteBook.Size = new System.Drawing.Size(801, 409);
            this.dgvWasteBook.TabIndex = 11;
            this.dgvWasteBook.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvWasteBook_RowPostPaint);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "流水号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Subject.Name";
            this.Column2.HeaderText = "费用名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 160;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Income";
            dataGridViewCellStyle3.Format = "C2";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.HeaderText = "收入金额";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Expend";
            dataGridViewCellStyle4.Format = "C2";
            this.Column4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column4.HeaderText = "支出金额";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Date";
            this.Column5.HeaderText = "交易时间";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Remark";
            this.Column6.HeaderText = "摘要";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 240;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(494, 10);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 17;
            this.btnModify.Text = "修改记录";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnIncome
            // 
            this.btnIncome.Location = new System.Drawing.Point(413, 10);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(75, 23);
            this.btnIncome.TabIndex = 16;
            this.btnIncome.Text = "新增收入";
            this.btnIncome.UseVisualStyleBackColor = true;
            this.btnIncome.Click += new System.EventHandler(this.btnIncome_Click);
            // 
            // btnExpend
            // 
            this.btnExpend.Location = new System.Drawing.Point(332, 10);
            this.btnExpend.Name = "btnExpend";
            this.btnExpend.Size = new System.Drawing.Size(75, 23);
            this.btnExpend.TabIndex = 15;
            this.btnExpend.Text = "新增支出";
            this.btnExpend.UseVisualStyleBackColor = true;
            this.btnExpend.Click += new System.EventHandler(this.btnExpend_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 15);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(77, 12);
            this.lblDate.TabIndex = 21;
            this.lblDate.Text = "按日期过滤：";
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(95, 12);
            this.cboYear.MaxDropDownItems = 12;
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(50, 20);
            this.cboYear.TabIndex = 32;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // cboMonth
            // 
            this.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Location = new System.Drawing.Point(174, 12);
            this.cboMonth.MaxDropDownItems = 12;
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(50, 20);
            this.cboMonth.TabIndex = 33;
            this.cboMonth.SelectedIndexChanged += new System.EventHandler(this.cboMonth_SelectedIndexChanged);
            // 
            // cboDay
            // 
            this.cboDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDay.FormattingEnabled = true;
            this.cboDay.Location = new System.Drawing.Point(253, 12);
            this.cboDay.MaxDropDownItems = 12;
            this.cboDay.Name = "cboDay";
            this.cboDay.Size = new System.Drawing.Size(50, 20);
            this.cboDay.TabIndex = 34;
            this.cboDay.SelectedIndexChanged += new System.EventHandler(this.cboDay_SelectedIndexChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(151, 15);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(17, 12);
            this.lblYear.TabIndex = 35;
            this.lblYear.Text = "年";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(230, 15);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(17, 12);
            this.lblMonth.TabIndex = 36;
            this.lblMonth.Text = "月";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(309, 15);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(17, 12);
            this.lblDay.TabIndex = 37;
            this.lblDay.Text = "日";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(575, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "删除记录";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmWasteBook_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 472);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.cboDay);
            this.Controls.Add(this.cboMonth);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblIncome);
            this.Controls.Add(this.lblExpend);
            this.Controls.Add(this.dgvWasteBook);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnIncome);
            this.Controls.Add(this.btnExpend);
            this.Name = "frmWasteBook_List";
            this.TabText = "账目清单";
            this.Text = "账目清单";
            this.Load += new System.EventHandler(this.frmWasteBook_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWasteBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Label lblExpend;
        private System.Windows.Forms.DataGridView dgvWasteBook;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnIncome;
        private System.Windows.Forms.Button btnExpend;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.ComboBox cboDay;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}