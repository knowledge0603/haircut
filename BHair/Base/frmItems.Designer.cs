namespace BHair.Base
{
    partial class frmItems
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
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numCMoney = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numNPrice = new System.Windows.Forms.NumericUpDown();
            this.numMoney = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUPrice = new System.Windows.Forms.Label();
            this.numUPrice = new System.Windows.Forms.NumericUpDown();
            this.numConvert = new System.Windows.Forms.NumericUpDown();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblConvert = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtReadme = new System.Windows.Forms.TextBox();
            this.lblReadme = new System.Windows.Forms.Label();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.lblAmount = new System.Windows.Forms.Label();
            this.numFPrice = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lblFPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.chkNoBonus = new System.Windows.Forms.CheckBox();
            this.chkTiCheng = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numConvert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "可用",
            "下架"});
            this.cboStatus.Location = new System.Drawing.Point(403, 38);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(80, 20);
            this.cboStatus.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "状态：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkTiCheng);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numCMoney);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numNPrice);
            this.groupBox1.Controls.Add(this.numMoney);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblUPrice);
            this.groupBox1.Controls.Add(this.numUPrice);
            this.groupBox1.Controls.Add(this.numConvert);
            this.groupBox1.Controls.Add(this.lblMoney);
            this.groupBox1.Controls.Add(this.lblConvert);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 99);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "商品售价及提成";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(6, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 12);
            this.label1.TabIndex = 30;
            this.label1.Text = "此处提成金额与点牌提成仅指助理的工作提成。";
            // 
            // numCMoney
            // 
            this.numCMoney.DecimalPlaces = 2;
            this.numCMoney.Location = new System.Drawing.Point(234, 49);
            this.numCMoney.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numCMoney.Name = "numCMoney";
            this.numCMoney.Size = new System.Drawing.Size(80, 21);
            this.numCMoney.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "点牌提成：";
            // 
            // numNPrice
            // 
            this.numNPrice.DecimalPlaces = 2;
            this.numNPrice.Location = new System.Drawing.Point(234, 20);
            this.numNPrice.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numNPrice.Name = "numNPrice";
            this.numNPrice.Size = new System.Drawing.Size(80, 21);
            this.numNPrice.TabIndex = 5;
            // 
            // numMoney
            // 
            this.numMoney.DecimalPlaces = 2;
            this.numMoney.Location = new System.Drawing.Point(77, 49);
            this.numMoney.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numMoney.Name = "numMoney";
            this.numMoney.Size = new System.Drawing.Size(80, 21);
            this.numMoney.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "次数单价：";
            // 
            // lblUPrice
            // 
            this.lblUPrice.AutoSize = true;
            this.lblUPrice.Location = new System.Drawing.Point(6, 22);
            this.lblUPrice.Name = "lblUPrice";
            this.lblUPrice.Size = new System.Drawing.Size(65, 12);
            this.lblUPrice.TabIndex = 0;
            this.lblUPrice.Text = "预售单价：";
            // 
            // numUPrice
            // 
            this.numUPrice.DecimalPlaces = 2;
            this.numUPrice.Location = new System.Drawing.Point(77, 20);
            this.numUPrice.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numUPrice.Name = "numUPrice";
            this.numUPrice.Size = new System.Drawing.Size(80, 21);
            this.numUPrice.TabIndex = 1;
            // 
            // numConvert
            // 
            this.numConvert.Location = new System.Drawing.Point(391, 20);
            this.numConvert.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numConvert.Name = "numConvert";
            this.numConvert.Size = new System.Drawing.Size(80, 21);
            this.numConvert.TabIndex = 11;
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(6, 51);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(65, 12);
            this.lblMoney.TabIndex = 6;
            this.lblMoney.Text = "提成金额：";
            // 
            // lblConvert
            // 
            this.lblConvert.AutoSize = true;
            this.lblConvert.Location = new System.Drawing.Point(320, 22);
            this.lblConvert.Name = "lblConvert";
            this.lblConvert.Size = new System.Drawing.Size(65, 12);
            this.lblConvert.TabIndex = 10;
            this.lblConvert.Text = "积分兑换：";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(414, 219);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(333, 219);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 28;
            this.btnOk.Text = "确定(&O)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtReadme
            // 
            this.txtReadme.Location = new System.Drawing.Point(89, 171);
            this.txtReadme.MaxLength = 300;
            this.txtReadme.Multiline = true;
            this.txtReadme.Name = "txtReadme";
            this.txtReadme.Size = new System.Drawing.Size(394, 42);
            this.txtReadme.TabIndex = 27;
            // 
            // lblReadme
            // 
            this.lblReadme.AutoSize = true;
            this.lblReadme.Location = new System.Drawing.Point(18, 174);
            this.lblReadme.Name = "lblReadme";
            this.lblReadme.Size = new System.Drawing.Size(65, 12);
            this.lblReadme.TabIndex = 26;
            this.lblReadme.Text = "商品说明：";
            // 
            // numAmount
            // 
            this.numAmount.Location = new System.Drawing.Point(246, 38);
            this.numAmount.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(80, 21);
            this.numAmount.TabIndex = 22;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(175, 41);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(65, 12);
            this.lblAmount.TabIndex = 21;
            this.lblAmount.Text = "库存数量：";
            // 
            // numFPrice
            // 
            this.numFPrice.DecimalPlaces = 2;
            this.numFPrice.Location = new System.Drawing.Point(89, 39);
            this.numFPrice.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numFPrice.Name = "numFPrice";
            this.numFPrice.Size = new System.Drawing.Size(80, 21);
            this.numFPrice.TabIndex = 20;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(246, 11);
            this.txtName.MaxLength = 30;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(237, 21);
            this.txtName.TabIndex = 18;
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "洗剪吹",
            "烫发",
            "染发",
            "外卖护理"});
            this.cboType.Location = new System.Drawing.Point(89, 12);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(80, 20);
            this.cboType.TabIndex = 16;
            // 
            // lblFPrice
            // 
            this.lblFPrice.AutoSize = true;
            this.lblFPrice.Location = new System.Drawing.Point(18, 40);
            this.lblFPrice.Name = "lblFPrice";
            this.lblFPrice.Size = new System.Drawing.Size(65, 12);
            this.lblFPrice.TabIndex = 19;
            this.lblFPrice.Text = "进货单价：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(175, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 12);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "商品名称：";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(18, 15);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(65, 12);
            this.lblType.TabIndex = 15;
            this.lblType.Text = "所属类别：";
            // 
            // chkNoBonus
            // 
            this.chkNoBonus.AutoSize = true;
            this.chkNoBonus.Location = new System.Drawing.Point(20, 223);
            this.chkNoBonus.Name = "chkNoBonus";
            this.chkNoBonus.Size = new System.Drawing.Size(120, 16);
            this.chkNoBonus.TabIndex = 30;
            this.chkNoBonus.Text = "该商品不参与打折";
            this.chkNoBonus.UseVisualStyleBackColor = true;
            // 
            // chkTiCheng
            // 
            this.chkTiCheng.AutoSize = true;
            this.chkTiCheng.Location = new System.Drawing.Point(363, 77);
            this.chkTiCheng.Name = "chkTiCheng";
            this.chkTiCheng.Size = new System.Drawing.Size(108, 16);
            this.chkTiCheng.TabIndex = 31;
            this.chkTiCheng.Text = "该商品不计提成";
            this.chkTiCheng.UseVisualStyleBackColor = true;
            // 
            // frmItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 254);
            this.Controls.Add(this.chkNoBonus);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtReadme);
            this.Controls.Add(this.lblReadme);
            this.Controls.Add(this.numAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.numFPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.lblFPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmItems";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "商品信息";
            this.Load += new System.EventHandler(this.frmItems_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numConvert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numCMoney;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numNPrice;
        private System.Windows.Forms.NumericUpDown numMoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUPrice;
        private System.Windows.Forms.NumericUpDown numUPrice;
        private System.Windows.Forms.NumericUpDown numConvert;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblConvert;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtReadme;
        private System.Windows.Forms.Label lblReadme;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.NumericUpDown numFPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label lblFPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkNoBonus;
        private System.Windows.Forms.CheckBox chkTiCheng;
    }
}