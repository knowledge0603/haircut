namespace BHair.Base
{
    partial class frmEmployee
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.grpEmployee = new System.Windows.Forms.GroupBox();
            this.dtpOutput = new System.Windows.Forms.DateTimePicker();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtCard = new System.Windows.Forms.TextBox();
            this.lblCard = new System.Windows.Forms.Label();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.grpBase = new System.Windows.Forms.GroupBox();
            this.dtpInput = new System.Windows.Forms.DateTimePicker();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.numBonus = new System.Windows.Forms.NumericUpDown();
            this.numSalary = new System.Windows.Forms.NumericUpDown();
            this.lblBonus = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.cboPost = new System.Windows.Forms.ComboBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblPost = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.grpEmployee.SuspendLayout();
            this.grpBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(283, 316);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 316);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "清空密码";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Visible = false;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(202, 316);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "确定(&O)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // grpEmployee
            // 
            this.grpEmployee.Controls.Add(this.dtpOutput);
            this.grpEmployee.Controls.Add(this.lblOutput);
            this.grpEmployee.Controls.Add(this.txtRemark);
            this.grpEmployee.Controls.Add(this.lblRemark);
            this.grpEmployee.Controls.Add(this.txtAddress);
            this.grpEmployee.Controls.Add(this.lblAddress);
            this.grpEmployee.Controls.Add(this.txtPhone);
            this.grpEmployee.Controls.Add(this.lblPhone);
            this.grpEmployee.Controls.Add(this.txtCard);
            this.grpEmployee.Controls.Add(this.lblCard);
            this.grpEmployee.Controls.Add(this.cboSex);
            this.grpEmployee.Controls.Add(this.lblSex);
            this.grpEmployee.Location = new System.Drawing.Point(12, 150);
            this.grpEmployee.Name = "grpEmployee";
            this.grpEmployee.Size = new System.Drawing.Size(346, 160);
            this.grpEmployee.TabIndex = 6;
            this.grpEmployee.TabStop = false;
            this.grpEmployee.Text = "详细信息(可选)";
            // 
            // dtpOutput
            // 
            this.dtpOutput.CustomFormat = "yyyy-MM-dd";
            this.dtpOutput.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOutput.Location = new System.Drawing.Point(77, 128);
            this.dtpOutput.Name = "dtpOutput";
            this.dtpOutput.Size = new System.Drawing.Size(90, 21);
            this.dtpOutput.TabIndex = 12;
            this.dtpOutput.Visible = false;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(6, 131);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(65, 12);
            this.lblOutput.TabIndex = 10;
            this.lblOutput.Text = "离职日期：";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(77, 101);
            this.txtRemark.MaxLength = 300;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(257, 21);
            this.txtRemark.TabIndex = 9;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(30, 104);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(41, 12);
            this.lblRemark.TabIndex = 8;
            this.lblRemark.Text = "备注：";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(77, 47);
            this.txtAddress.MaxLength = 100;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(257, 21);
            this.txtAddress.TabIndex = 5;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(6, 50);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(65, 12);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "联系地址：";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(244, 20);
            this.txtPhone.MaxLength = 15;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(90, 21);
            this.txtPhone.TabIndex = 3;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(173, 23);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(65, 12);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "其它电话：";
            // 
            // txtCard
            // 
            this.txtCard.Location = new System.Drawing.Point(77, 74);
            this.txtCard.MaxLength = 18;
            this.txtCard.Name = "txtCard";
            this.txtCard.Size = new System.Drawing.Size(257, 21);
            this.txtCard.TabIndex = 7;
            // 
            // lblCard
            // 
            this.lblCard.AutoSize = true;
            this.lblCard.Location = new System.Drawing.Point(18, 77);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(53, 12);
            this.lblCard.TabIndex = 6;
            this.lblCard.Text = "身份证：";
            // 
            // cboSex
            // 
            this.cboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cboSex.Location = new System.Drawing.Point(77, 20);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(90, 20);
            this.cboSex.TabIndex = 1;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(30, 23);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(41, 12);
            this.lblSex.TabIndex = 0;
            this.lblSex.Text = "性别：";
            // 
            // grpBase
            // 
            this.grpBase.Controls.Add(this.dtpInput);
            this.grpBase.Controls.Add(this.txtMobile);
            this.grpBase.Controls.Add(this.lblInput);
            this.grpBase.Controls.Add(this.lblMobile);
            this.grpBase.Controls.Add(this.numBonus);
            this.grpBase.Controls.Add(this.numSalary);
            this.grpBase.Controls.Add(this.lblBonus);
            this.grpBase.Controls.Add(this.lblSalary);
            this.grpBase.Controls.Add(this.cboPost);
            this.grpBase.Controls.Add(this.cboStatus);
            this.grpBase.Controls.Add(this.lblPost);
            this.grpBase.Controls.Add(this.lblStatus);
            this.grpBase.Controls.Add(this.txtName);
            this.grpBase.Controls.Add(this.lblName);
            this.grpBase.Controls.Add(this.txtCode);
            this.grpBase.Controls.Add(this.lblCode);
            this.grpBase.Location = new System.Drawing.Point(12, 12);
            this.grpBase.Name = "grpBase";
            this.grpBase.Size = new System.Drawing.Size(346, 132);
            this.grpBase.TabIndex = 5;
            this.grpBase.TabStop = false;
            this.grpBase.Text = "员工信息(必填)";
            // 
            // dtpInput
            // 
            this.dtpInput.CustomFormat = "yyyy-MM-dd";
            this.dtpInput.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInput.Location = new System.Drawing.Point(244, 99);
            this.dtpInput.Name = "dtpInput";
            this.dtpInput.Size = new System.Drawing.Size(90, 21);
            this.dtpInput.TabIndex = 15;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(77, 100);
            this.txtMobile.MaxLength = 11;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(90, 21);
            this.txtMobile.TabIndex = 13;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(173, 103);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(65, 12);
            this.lblInput.TabIndex = 14;
            this.lblInput.Text = "入职日期：";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(30, 103);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(41, 12);
            this.lblMobile.TabIndex = 12;
            this.lblMobile.Text = "手机：";
            // 
            // numBonus
            // 
            this.numBonus.DecimalPlaces = 2;
            this.numBonus.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numBonus.Location = new System.Drawing.Point(244, 73);
            this.numBonus.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBonus.Name = "numBonus";
            this.numBonus.Size = new System.Drawing.Size(90, 21);
            this.numBonus.TabIndex = 11;
            // 
            // numSalary
            // 
            this.numSalary.DecimalPlaces = 2;
            this.numSalary.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numSalary.Location = new System.Drawing.Point(77, 73);
            this.numSalary.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSalary.Name = "numSalary";
            this.numSalary.Size = new System.Drawing.Size(90, 21);
            this.numSalary.TabIndex = 9;
            // 
            // lblBonus
            // 
            this.lblBonus.AutoSize = true;
            this.lblBonus.Location = new System.Drawing.Point(197, 75);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(41, 12);
            this.lblBonus.TabIndex = 10;
            this.lblBonus.Text = "提成：";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(30, 75);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(41, 12);
            this.lblSalary.TabIndex = 8;
            this.lblSalary.Text = "底薪：";
            // 
            // cboPost
            // 
            this.cboPost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPost.FormattingEnabled = true;
            this.cboPost.Location = new System.Drawing.Point(77, 47);
            this.cboPost.Name = "cboPost";
            this.cboPost.Size = new System.Drawing.Size(90, 20);
            this.cboPost.TabIndex = 5;
            this.cboPost.SelectedIndexChanged += new System.EventHandler(this.cboPost_SelectedIndexChanged);
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "试用",
            "学员",
            "正式"});
            this.cboStatus.Location = new System.Drawing.Point(244, 47);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(90, 20);
            this.cboStatus.TabIndex = 7;
            this.cboStatus.SelectedIndexChanged += new System.EventHandler(this.cboStatus_SelectedIndexChanged);
            // 
            // lblPost
            // 
            this.lblPost.AutoSize = true;
            this.lblPost.Location = new System.Drawing.Point(6, 50);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(65, 12);
            this.lblPost.TabIndex = 4;
            this.lblPost.Text = "所任职务：";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(173, 50);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(65, 12);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "当前状态：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(244, 20);
            this.txtName.MaxLength = 30;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(90, 21);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(173, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 12);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "员工姓名：";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(77, 20);
            this.txtCode.MaxLength = 4;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(90, 21);
            this.txtCode.TabIndex = 1;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(6, 23);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(65, 12);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "员工工号：";
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 353);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grpEmployee);
            this.Controls.Add(this.grpBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmployee";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "新增员工信息";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.grpEmployee.ResumeLayout(false);
            this.grpEmployee.PerformLayout();
            this.grpBase.ResumeLayout(false);
            this.grpBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox grpEmployee;
        private System.Windows.Forms.DateTimePicker dtpOutput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtCard;
        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.GroupBox grpBase;
        private System.Windows.Forms.DateTimePicker dtpInput;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.NumericUpDown numBonus;
        private System.Windows.Forms.NumericUpDown numSalary;
        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.ComboBox cboPost;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblPost;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
    }
}