namespace BHair.Base
{
    partial class frmMember
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
            this.btnSave = new System.Windows.Forms.Button();
            this.tabMember = new System.Windows.Forms.TabControl();
            this.tabDetail = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDCard = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpJoin = new System.Windows.Forms.DateTimePicker();
            this.lblJoin = new System.Windows.Forms.Label();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.lblOther = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cboDay = new System.Windows.Forms.ComboBox();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.grpNotNull = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numBalance = new System.Windows.Forms.NumericUpDown();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.txtAffirm = new System.Windows.Forms.TextBox();
            this.lblAffirm = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.cboLevel = new System.Windows.Forms.ComboBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtCard = new System.Windows.Forms.TextBox();
            this.lblCard = new System.Windows.Forms.Label();
            this.tabMember.SuspendLayout();
            this.tabDetail.SuspendLayout();
            this.grpNotNull.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(414, 326);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(333, 326);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabMember
            // 
            this.tabMember.Controls.Add(this.tabDetail);
            this.tabMember.Location = new System.Drawing.Point(12, 152);
            this.tabMember.Name = "tabMember";
            this.tabMember.SelectedIndex = 0;
            this.tabMember.Size = new System.Drawing.Size(477, 168);
            this.tabMember.TabIndex = 5;
            // 
            // tabDetail
            // 
            this.tabDetail.Controls.Add(this.label3);
            this.tabDetail.Controls.Add(this.txtIDCard);
            this.tabDetail.Controls.Add(this.label1);
            this.tabDetail.Controls.Add(this.dtpJoin);
            this.tabDetail.Controls.Add(this.lblJoin);
            this.tabDetail.Controls.Add(this.txtOther);
            this.tabDetail.Controls.Add(this.lblOther);
            this.tabDetail.Controls.Add(this.txtAddress);
            this.tabDetail.Controls.Add(this.lblAddress);
            this.tabDetail.Controls.Add(this.txtPhone);
            this.tabDetail.Controls.Add(this.lblPhone);
            this.tabDetail.Controls.Add(this.lblDay);
            this.tabDetail.Controls.Add(this.lblMonth);
            this.tabDetail.Controls.Add(this.cboDay);
            this.tabDetail.Controls.Add(this.cboMonth);
            this.tabDetail.Controls.Add(this.lblBirthday);
            this.tabDetail.Controls.Add(this.cboSex);
            this.tabDetail.Controls.Add(this.lblSex);
            this.tabDetail.Location = new System.Drawing.Point(4, 21);
            this.tabDetail.Name = "tabDetail";
            this.tabDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetail.Size = new System.Drawing.Size(469, 143);
            this.tabDetail.TabIndex = 0;
            this.tabDetail.Text = "详细信息(可选)";
            this.tabDetail.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(234, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "用于换卡、挂失时使用的凭证";
            // 
            // txtIDCard
            // 
            this.txtIDCard.Location = new System.Drawing.Point(77, 59);
            this.txtIDCard.MaxLength = 18;
            this.txtIDCard.Name = "txtIDCard";
            this.txtIDCard.Size = new System.Drawing.Size(151, 21);
            this.txtIDCard.TabIndex = 12;
            this.txtIDCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDCard_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "身份证：";
            // 
            // dtpJoin
            // 
            this.dtpJoin.CustomFormat = "yyyy-MM-dd";
            this.dtpJoin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpJoin.Location = new System.Drawing.Point(77, 113);
            this.dtpJoin.Name = "dtpJoin";
            this.dtpJoin.Size = new System.Drawing.Size(85, 21);
            this.dtpJoin.TabIndex = 16;
            // 
            // lblJoin
            // 
            this.lblJoin.AutoSize = true;
            this.lblJoin.Location = new System.Drawing.Point(3, 117);
            this.lblJoin.Name = "lblJoin";
            this.lblJoin.Size = new System.Drawing.Size(65, 12);
            this.lblJoin.TabIndex = 15;
            this.lblJoin.Text = "加入日期：";
            // 
            // txtOther
            // 
            this.txtOther.Location = new System.Drawing.Point(77, 86);
            this.txtOther.MaxLength = 400;
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(388, 21);
            this.txtOther.TabIndex = 14;
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.Location = new System.Drawing.Point(6, 89);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(65, 12);
            this.lblOther.TabIndex = 13;
            this.lblOther.Text = "其它信息：";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(234, 32);
            this.txtAddress.MaxLength = 100;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(231, 21);
            this.txtAddress.TabIndex = 10;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(163, 35);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(65, 12);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "联系地址：";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(77, 32);
            this.txtPhone.MaxLength = 13;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(80, 21);
            this.txtPhone.TabIndex = 8;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(6, 35);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(65, 12);
            this.lblPhone.TabIndex = 7;
            this.lblPhone.Text = "联系电话：";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(341, 9);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(17, 12);
            this.lblDay.TabIndex = 6;
            this.lblDay.Text = "日";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(276, 9);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(17, 12);
            this.lblMonth.TabIndex = 4;
            this.lblMonth.Text = "月";
            // 
            // cboDay
            // 
            this.cboDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDay.FormattingEnabled = true;
            this.cboDay.Location = new System.Drawing.Point(299, 6);
            this.cboDay.MaxDropDownItems = 12;
            this.cboDay.Name = "cboDay";
            this.cboDay.Size = new System.Drawing.Size(36, 20);
            this.cboDay.TabIndex = 5;
            // 
            // cboMonth
            // 
            this.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.ItemHeight = 12;
            this.cboMonth.Location = new System.Drawing.Point(234, 6);
            this.cboMonth.MaxDropDownItems = 13;
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(36, 20);
            this.cboMonth.TabIndex = 3;
            this.cboMonth.SelectedIndexChanged += new System.EventHandler(this.cboMonth_SelectedIndexChanged);
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(163, 9);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(65, 12);
            this.lblBirthday.TabIndex = 2;
            this.lblBirthday.Text = "出生日期：";
            // 
            // cboSex
            // 
            this.cboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Items.AddRange(new object[] {
            "女",
            "男"});
            this.cboSex.Location = new System.Drawing.Point(77, 6);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(80, 20);
            this.cboSex.TabIndex = 1;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(6, 9);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(65, 12);
            this.lblSex.TabIndex = 0;
            this.lblSex.Text = "会员性别：";
            // 
            // grpNotNull
            // 
            this.grpNotNull.Controls.Add(this.label2);
            this.grpNotNull.Controls.Add(this.numBalance);
            this.grpNotNull.Controls.Add(this.txtRemark);
            this.grpNotNull.Controls.Add(this.lblRemark);
            this.grpNotNull.Controls.Add(this.txtAffirm);
            this.grpNotNull.Controls.Add(this.lblAffirm);
            this.grpNotNull.Controls.Add(this.txtPassword);
            this.grpNotNull.Controls.Add(this.lblPassword);
            this.grpNotNull.Controls.Add(this.lblBalance);
            this.grpNotNull.Controls.Add(this.cboLevel);
            this.grpNotNull.Controls.Add(this.lblLevel);
            this.grpNotNull.Controls.Add(this.cboStatus);
            this.grpNotNull.Controls.Add(this.lblStatus);
            this.grpNotNull.Controls.Add(this.txtName);
            this.grpNotNull.Controls.Add(this.lblName);
            this.grpNotNull.Controls.Add(this.txtCard);
            this.grpNotNull.Controls.Add(this.lblCard);
            this.grpNotNull.Location = new System.Drawing.Point(12, 12);
            this.grpNotNull.Name = "grpNotNull";
            this.grpNotNull.Size = new System.Drawing.Size(477, 134);
            this.grpNotNull.TabIndex = 4;
            this.grpNotNull.TabStop = false;
            this.grpNotNull.Text = "会员信息(必填)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(321, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "初始密码：0";
            // 
            // numBalance
            // 
            this.numBalance.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numBalance.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numBalance.Location = new System.Drawing.Point(234, 46);
            this.numBalance.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numBalance.Name = "numBalance";
            this.numBalance.Size = new System.Drawing.Size(80, 21);
            this.numBalance.TabIndex = 9;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(77, 100);
            this.txtRemark.MaxLength = 400;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(394, 21);
            this.txtRemark.TabIndex = 17;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(30, 103);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(41, 12);
            this.lblRemark.TabIndex = 16;
            this.lblRemark.Text = "备注：";
            // 
            // txtAffirm
            // 
            this.txtAffirm.Location = new System.Drawing.Point(234, 73);
            this.txtAffirm.MaxLength = 20;
            this.txtAffirm.Name = "txtAffirm";
            this.txtAffirm.PasswordChar = '*';
            this.txtAffirm.ReadOnly = true;
            this.txtAffirm.Size = new System.Drawing.Size(80, 21);
            this.txtAffirm.TabIndex = 15;
            this.txtAffirm.Text = "0";
            // 
            // lblAffirm
            // 
            this.lblAffirm.AutoSize = true;
            this.lblAffirm.Location = new System.Drawing.Point(163, 76);
            this.lblAffirm.Name = "lblAffirm";
            this.lblAffirm.Size = new System.Drawing.Size(65, 12);
            this.lblAffirm.TabIndex = 14;
            this.lblAffirm.Text = "确认密码：";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(77, 73);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(80, 21);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.Text = "0";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 76);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(65, 12);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "会员密码：";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(163, 50);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(65, 12);
            this.lblBalance.TabIndex = 8;
            this.lblBalance.Text = "初始金额：";
            // 
            // cboLevel
            // 
            this.cboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLevel.FormattingEnabled = true;
            this.cboLevel.Location = new System.Drawing.Point(77, 47);
            this.cboLevel.Name = "cboLevel";
            this.cboLevel.Size = new System.Drawing.Size(80, 20);
            this.cboLevel.TabIndex = 7;
            this.cboLevel.SelectedIndexChanged += new System.EventHandler(this.cboLevel_SelectedIndexChanged);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(6, 50);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(65, 12);
            this.lblLevel.TabIndex = 6;
            this.lblLevel.Text = "会员级别：";
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "正常",
            "停用"});
            this.cboStatus.Location = new System.Drawing.Point(391, 20);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(80, 20);
            this.cboStatus.TabIndex = 5;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(320, 23);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(65, 12);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "当前状态：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(234, 20);
            this.txtName.MaxLength = 30;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(80, 21);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(163, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 12);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "会员姓名：";
            // 
            // txtCard
            // 
            this.txtCard.Location = new System.Drawing.Point(77, 20);
            this.txtCard.MaxLength = 12;
            this.txtCard.Name = "txtCard";
            this.txtCard.Size = new System.Drawing.Size(80, 21);
            this.txtCard.TabIndex = 1;
            this.txtCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCard_KeyPress);
            // 
            // lblCard
            // 
            this.lblCard.AutoSize = true;
            this.lblCard.Location = new System.Drawing.Point(6, 23);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(65, 12);
            this.lblCard.TabIndex = 0;
            this.lblCard.Text = "会员卡号：";
            // 
            // frmMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 362);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabMember);
            this.Controls.Add(this.grpNotNull);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMember";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "会员信息";
            this.Load += new System.EventHandler(this.frmMember_Load);
            this.tabMember.ResumeLayout(false);
            this.tabDetail.ResumeLayout(false);
            this.tabDetail.PerformLayout();
            this.grpNotNull.ResumeLayout(false);
            this.grpNotNull.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBalance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tabMember;
        private System.Windows.Forms.TabPage tabDetail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpJoin;
        private System.Windows.Forms.Label lblJoin;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.Label lblOther;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cboDay;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.GroupBox grpNotNull;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numBalance;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.TextBox txtAffirm;
        private System.Windows.Forms.Label lblAffirm;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.ComboBox cboLevel;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtCard;
        private System.Windows.Forms.Label lblCard;
    }
}