namespace BHair.SystemSet
{
    partial class frmConfig
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
            this.tabConfig = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDeposit_Finish = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDeposit_Start = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numDeposit_Send = new System.Windows.Forms.NumericUpDown();
            this.numDeposit_Money = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabConfig.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDeposit_Send)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeposit_Money)).BeginInit();
            this.SuspendLayout();
            // 
            // tabConfig
            // 
            this.tabConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabConfig.Controls.Add(this.tabPage1);
            this.tabConfig.Controls.Add(this.tabPage2);
            this.tabConfig.Location = new System.Drawing.Point(12, 12);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.SelectedIndex = 0;
            this.tabConfig.Size = new System.Drawing.Size(399, 328);
            this.tabConfig.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.dtpDeposit_Finish);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.dtpDeposit_Start);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.numDeposit_Send);
            this.tabPage1.Controls.Add(this.numDeposit_Money);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(391, 303);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "充值";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(299, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "当【增送金额】为0时，即使在有效期内也不会执行增送";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "注：【增送金额】权限大于【有效日期】";
            // 
            // dtpDeposit_Finish
            // 
            this.dtpDeposit_Finish.CustomFormat = "yyyy-MM-dd";
            this.dtpDeposit_Finish.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeposit_Finish.Location = new System.Drawing.Point(227, 60);
            this.dtpDeposit_Finish.Name = "dtpDeposit_Finish";
            this.dtpDeposit_Finish.Size = new System.Drawing.Size(120, 21);
            this.dtpDeposit_Finish.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "至";
            // 
            // dtpDeposit_Start
            // 
            this.dtpDeposit_Start.CustomFormat = "yyyy-MM-dd";
            this.dtpDeposit_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeposit_Start.Location = new System.Drawing.Point(77, 60);
            this.dtpDeposit_Start.Name = "dtpDeposit_Start";
            this.dtpDeposit_Start.Size = new System.Drawing.Size(120, 21);
            this.dtpDeposit_Start.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "有效日期：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "当输入值为 0 时表示不增送";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "表示每充值 100 元增送 N 元";
            // 
            // numDeposit_Send
            // 
            this.numDeposit_Send.Location = new System.Drawing.Point(77, 33);
            this.numDeposit_Send.Name = "numDeposit_Send";
            this.numDeposit_Send.Size = new System.Drawing.Size(120, 21);
            this.numDeposit_Send.TabIndex = 3;
            // 
            // numDeposit_Money
            // 
            this.numDeposit_Money.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDeposit_Money.Location = new System.Drawing.Point(77, 6);
            this.numDeposit_Money.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numDeposit_Money.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numDeposit_Money.Name = "numDeposit_Money";
            this.numDeposit_Money.Size = new System.Drawing.Size(120, 21);
            this.numDeposit_Money.TabIndex = 2;
            this.numDeposit_Money.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "增送金额：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "充值基数：";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(391, 303);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "安全";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(255, 346);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(336, 346);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 381);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tabConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfig";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "系统设置";
            this.Load += new System.EventHandler(this.frmConfig_Load);
            this.tabConfig.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDeposit_Send)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeposit_Money)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabConfig;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown numDeposit_Send;
        private System.Windows.Forms.NumericUpDown numDeposit_Money;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDeposit_Start;
        private System.Windows.Forms.DateTimePicker dtpDeposit_Finish;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}