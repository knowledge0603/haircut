namespace BHair.Base
{
    partial class frmPost
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
            this.cboMode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numSalary = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSort = new System.Windows.Forms.TextBox();
            this.txtReadme = new System.Windows.Forms.TextBox();
            this.numBonus = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSort = new System.Windows.Forms.Label();
            this.lblReadme = new System.Windows.Forms.Label();
            this.lblBonus = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBonus)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMode
            // 
            this.cboMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMode.FormattingEnabled = true;
            this.cboMode.Items.AddRange(new object[] {
            "底薪",
            "提成",
            "底薪+提成"});
            this.cboMode.Location = new System.Drawing.Point(83, 93);
            this.cboMode.Name = "cboMode";
            this.cboMode.Size = new System.Drawing.Size(100, 20);
            this.cboMode.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "结算方式：";
            // 
            // numSalary
            // 
            this.numSalary.DecimalPlaces = 2;
            this.numSalary.Location = new System.Drawing.Point(83, 39);
            this.numSalary.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numSalary.Name = "numSalary";
            this.numSalary.Size = new System.Drawing.Size(100, 21);
            this.numSalary.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "起始底薪：";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(208, 194);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(127, 194);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 32;
            this.btnOk.Text = "确定(&O)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(119, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 12);
            this.label3.TabIndex = 31;
            this.label3.Text = "0-99数字越小越排前";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(189, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 30;
            this.label2.Text = "0.2表示提20%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(189, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 29;
            this.label1.Text = "*";
            // 
            // txtSort
            // 
            this.txtSort.Location = new System.Drawing.Point(83, 167);
            this.txtSort.MaxLength = 2;
            this.txtSort.Name = "txtSort";
            this.txtSort.Size = new System.Drawing.Size(30, 21);
            this.txtSort.TabIndex = 28;
            this.txtSort.Text = "0";
            this.txtSort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSort_KeyPress);
            // 
            // txtReadme
            // 
            this.txtReadme.Location = new System.Drawing.Point(83, 119);
            this.txtReadme.MaxLength = 300;
            this.txtReadme.Multiline = true;
            this.txtReadme.Name = "txtReadme";
            this.txtReadme.Size = new System.Drawing.Size(200, 42);
            this.txtReadme.TabIndex = 27;
            // 
            // numBonus
            // 
            this.numBonus.DecimalPlaces = 2;
            this.numBonus.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numBonus.Location = new System.Drawing.Point(83, 66);
            this.numBonus.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBonus.Name = "numBonus";
            this.numBonus.Size = new System.Drawing.Size(100, 21);
            this.numBonus.TabIndex = 25;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(83, 12);
            this.txtName.MaxLength = 30;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 23;
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(36, 170);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(41, 12);
            this.lblSort.TabIndex = 22;
            this.lblSort.Text = "排列：";
            // 
            // lblReadme
            // 
            this.lblReadme.AutoSize = true;
            this.lblReadme.Location = new System.Drawing.Point(12, 122);
            this.lblReadme.Name = "lblReadme";
            this.lblReadme.Size = new System.Drawing.Size(65, 12);
            this.lblReadme.TabIndex = 21;
            this.lblReadme.Text = "职位描述：";
            // 
            // lblBonus
            // 
            this.lblBonus.AutoSize = true;
            this.lblBonus.Location = new System.Drawing.Point(12, 68);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(65, 12);
            this.lblBonus.TabIndex = 19;
            this.lblBonus.Text = "提成比例：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 12);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "职位名称：";
            // 
            // frmPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 231);
            this.Controls.Add(this.cboMode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numSalary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSort);
            this.Controls.Add(this.txtReadme);
            this.Controls.Add(this.numBonus);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.lblReadme);
            this.Controls.Add(this.lblBonus);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPost";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "新增职位";
            this.Load += new System.EventHandler(this.frmPost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBonus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numSalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSort;
        private System.Windows.Forms.TextBox txtReadme;
        private System.Windows.Forms.NumericUpDown numBonus;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.Label lblReadme;
        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.Label lblName;
    }
}