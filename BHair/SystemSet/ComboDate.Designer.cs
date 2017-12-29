namespace BHair.SystemSet
{
    partial class ComboDate
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.cboDay = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 43;
            this.label5.Text = "日";
            // 
            // cboDay
            // 
            this.cboDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDay.FormattingEnabled = true;
            this.cboDay.Location = new System.Drawing.Point(161, 0);
            this.cboDay.MaxDropDownItems = 12;
            this.cboDay.Name = "cboDay";
            this.cboDay.Size = new System.Drawing.Size(50, 20);
            this.cboDay.TabIndex = 42;
            this.cboDay.SelectedIndexChanged += new System.EventHandler(this.cboDay_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 41;
            this.label4.Text = "月";
            // 
            // cboMonth
            // 
            this.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.ItemHeight = 12;
            this.cboMonth.Location = new System.Drawing.Point(82, 0);
            this.cboMonth.MaxDropDownItems = 13;
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(50, 20);
            this.cboMonth.TabIndex = 40;
            this.cboMonth.SelectedIndexChanged += new System.EventHandler(this.cboMonth_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 39;
            this.label3.Text = "年";
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(3, 0);
            this.cboYear.MaxDropDownItems = 12;
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(50, 20);
            this.cboYear.TabIndex = 38;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // ComboDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboDay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboMonth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboYear);
            this.Name = "ComboDate";
            this.Size = new System.Drawing.Size(237, 20);
            this.Load += new System.EventHandler(this.ComboDate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboYear;
    }
}
