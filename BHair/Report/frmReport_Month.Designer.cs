namespace BHair.Report
{
    partial class frmReport_Month
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblProfitSum = new System.Windows.Forms.Label();
            this.lblExpendSum = new System.Windows.Forms.Label();
            this.lblIncomeSum = new System.Windows.Forms.Label();
            this.dgvMonth = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.cboYear = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProfitSum
            // 
            this.lblProfitSum.AutoSize = true;
            this.lblProfitSum.Location = new System.Drawing.Point(598, 15);
            this.lblProfitSum.Name = "lblProfitSum";
            this.lblProfitSum.Size = new System.Drawing.Size(65, 12);
            this.lblProfitSum.TabIndex = 15;
            this.lblProfitSum.Text = "本月盈亏：";
            // 
            // lblExpendSum
            // 
            this.lblExpendSum.AutoSize = true;
            this.lblExpendSum.Location = new System.Drawing.Point(430, 15);
            this.lblExpendSum.Name = "lblExpendSum";
            this.lblExpendSum.Size = new System.Drawing.Size(65, 12);
            this.lblExpendSum.TabIndex = 14;
            this.lblExpendSum.Text = "合计支出：";
            // 
            // lblIncomeSum
            // 
            this.lblIncomeSum.AutoSize = true;
            this.lblIncomeSum.Location = new System.Drawing.Point(261, 15);
            this.lblIncomeSum.Name = "lblIncomeSum";
            this.lblIncomeSum.Size = new System.Drawing.Size(65, 12);
            this.lblIncomeSum.TabIndex = 13;
            this.lblIncomeSum.Text = "合计收入：";
            // 
            // dgvMonth
            // 
            this.dgvMonth.AllowUserToAddRows = false;
            this.dgvMonth.AllowUserToDeleteRows = false;
            this.dgvMonth.AllowUserToResizeRows = false;
            this.dgvMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMonth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonth.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvMonth.Location = new System.Drawing.Point(12, 38);
            this.dgvMonth.Name = "dgvMonth";
            this.dgvMonth.RowTemplate.Height = 23;
            this.dgvMonth.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonth.Size = new System.Drawing.Size(715, 398);
            this.dgvMonth.TabIndex = 12;
            this.dgvMonth.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvMonth_RowPostPaint);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Day";
            this.Column1.HeaderText = "日期";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "星期";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            dataGridViewCellStyle1.Format = "C2";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column3.HeaderText = "会员充值";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            dataGridViewCellStyle2.Format = "C2";
            this.Column4.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column4.HeaderText = "现金消费";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            dataGridViewCellStyle3.Format = "C2";
            this.Column5.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column5.HeaderText = "其它收入";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            dataGridViewCellStyle4.Format = "C2";
            this.Column6.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column6.HeaderText = "小计收入";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            dataGridViewCellStyle5.Format = "C2";
            this.Column7.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column7.HeaderText = "支出金额";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            dataGridViewCellStyle6.Format = "C2";
            this.Column8.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column8.HeaderText = "盈亏";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(147, 15);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(17, 12);
            this.lblMonth.TabIndex = 11;
            this.lblMonth.Text = "月";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(68, 15);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(17, 12);
            this.lblYear.TabIndex = 9;
            this.lblYear.Text = "年";
            // 
            // cboMonth
            // 
            this.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Location = new System.Drawing.Point(91, 12);
            this.cboMonth.MaxDropDownItems = 12;
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(50, 20);
            this.cboMonth.TabIndex = 10;
            this.cboMonth.SelectedIndexChanged += new System.EventHandler(this.cboMonth_SelectedIndexChanged);
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(12, 12);
            this.cboYear.MaxDropDownItems = 12;
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(50, 20);
            this.cboYear.TabIndex = 8;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // frmReport_Month
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 448);
            this.Controls.Add(this.lblProfitSum);
            this.Controls.Add(this.lblExpendSum);
            this.Controls.Add(this.lblIncomeSum);
            this.Controls.Add(this.dgvMonth);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.cboMonth);
            this.Controls.Add(this.cboYear);
            this.Name = "frmReport_Month";
            this.TabText = "每月收支汇总";
            this.Text = "每月收支汇总";
            this.Load += new System.EventHandler(this.frmReport_Month_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProfitSum;
        private System.Windows.Forms.Label lblExpendSum;
        private System.Windows.Forms.Label lblIncomeSum;
        private System.Windows.Forms.DataGridView dgvMonth;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}