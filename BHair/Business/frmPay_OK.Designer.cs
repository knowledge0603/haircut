namespace BHair.Business
{
    partial class frmPay_OK
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
            this.numPayBalance = new System.Windows.Forms.NumericUpDown();
            this.lblPayBalance = new System.Windows.Forms.Label();
            this.numPayMoney = new System.Windows.Forms.NumericUpDown();
            this.lblPayMoney = new System.Windows.Forms.Label();
            this.rbtnAnd = new System.Windows.Forms.RadioButton();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPayID = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.rbtnBalance = new System.Windows.Forms.RadioButton();
            this.rbtnCash = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.lblZero = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCash = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPayBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPayMoney)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numPayBalance
            // 
            this.numPayBalance.BackColor = System.Drawing.SystemColors.Window;
            this.numPayBalance.DecimalPlaces = 2;
            this.numPayBalance.Location = new System.Drawing.Point(89, 84);
            this.numPayBalance.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            this.numPayBalance.Name = "numPayBalance";
            this.numPayBalance.ReadOnly = true;
            this.numPayBalance.Size = new System.Drawing.Size(80, 21);
            this.numPayBalance.TabIndex = 21;
            this.numPayBalance.ValueChanged += new System.EventHandler(this.numPayBalance_ValueChanged);
            // 
            // lblPayBalance
            // 
            this.lblPayBalance.AutoSize = true;
            this.lblPayBalance.Location = new System.Drawing.Point(18, 86);
            this.lblPayBalance.Name = "lblPayBalance";
            this.lblPayBalance.Size = new System.Drawing.Size(65, 12);
            this.lblPayBalance.TabIndex = 16;
            this.lblPayBalance.Text = "刷卡金额：";
            // 
            // numPayMoney
            // 
            this.numPayMoney.BackColor = System.Drawing.SystemColors.Window;
            this.numPayMoney.DecimalPlaces = 2;
            this.numPayMoney.Location = new System.Drawing.Point(89, 111);
            this.numPayMoney.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            this.numPayMoney.Name = "numPayMoney";
            this.numPayMoney.Size = new System.Drawing.Size(80, 21);
            this.numPayMoney.TabIndex = 22;
            this.numPayMoney.ValueChanged += new System.EventHandler(this.numPayMoney_ValueChanged);
            this.numPayMoney.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numPayMoney_KeyUp);
            // 
            // lblPayMoney
            // 
            this.lblPayMoney.AutoSize = true;
            this.lblPayMoney.Location = new System.Drawing.Point(18, 113);
            this.lblPayMoney.Name = "lblPayMoney";
            this.lblPayMoney.Size = new System.Drawing.Size(65, 12);
            this.lblPayMoney.TabIndex = 17;
            this.lblPayMoney.Text = "应收金额：";
            // 
            // rbtnAnd
            // 
            this.rbtnAnd.AutoSize = true;
            this.rbtnAnd.Location = new System.Drawing.Point(219, 191);
            this.rbtnAnd.Name = "rbtnAnd";
            this.rbtnAnd.Size = new System.Drawing.Size(77, 16);
            this.rbtnAnd.TabIndex = 27;
            this.rbtnAnd.TabStop = true;
            this.rbtnAnd.Text = "现金+余额";
            this.rbtnAnd.UseVisualStyleBackColor = true;
            this.rbtnAnd.CheckedChanged += new System.EventHandler(this.rbtnAnd_CheckedChanged);
            // 
            // txtCash
            // 
            this.txtCash.Location = new System.Drawing.Point(89, 138);
            this.txtCash.MaxLength = 12;
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(80, 21);
            this.txtCash.TabIndex = 23;
            this.txtCash.TextChanged += new System.EventHandler(this.txtCash_TextChanged);
            this.txtCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCash_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPayID);
            this.groupBox1.Controls.Add(this.lblBalance);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblMoney);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 66);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "顾客/会员信息";
            // 
            // lblPayID
            // 
            this.lblPayID.AutoSize = true;
            this.lblPayID.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPayID.ForeColor = System.Drawing.Color.Red;
            this.lblPayID.Location = new System.Drawing.Point(6, 42);
            this.lblPayID.Name = "lblPayID";
            this.lblPayID.Size = new System.Drawing.Size(70, 12);
            this.lblPayID.TabIndex = 2;
            this.lblPayID.Text = "单费单号：";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(180, 17);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(65, 12);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "卡内余额：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "会员信息：";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMoney.ForeColor = System.Drawing.Color.Red;
            this.lblMoney.Location = new System.Drawing.Point(180, 42);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(70, 12);
            this.lblMoney.TabIndex = 3;
            this.lblMoney.Text = "消费金额：";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(279, 213);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(188, 213);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 28;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // rbtnBalance
            // 
            this.rbtnBalance.AutoSize = true;
            this.rbtnBalance.Location = new System.Drawing.Point(142, 191);
            this.rbtnBalance.Name = "rbtnBalance";
            this.rbtnBalance.Size = new System.Drawing.Size(71, 16);
            this.rbtnBalance.TabIndex = 26;
            this.rbtnBalance.TabStop = true;
            this.rbtnBalance.Text = "卡内余额";
            this.rbtnBalance.UseVisualStyleBackColor = true;
            this.rbtnBalance.CheckedChanged += new System.EventHandler(this.rbtnBalance_CheckedChanged);
            // 
            // rbtnCash
            // 
            this.rbtnCash.AutoSize = true;
            this.rbtnCash.Checked = true;
            this.rbtnCash.Location = new System.Drawing.Point(89, 191);
            this.rbtnCash.Name = "rbtnCash";
            this.rbtnCash.Size = new System.Drawing.Size(47, 16);
            this.rbtnCash.TabIndex = 25;
            this.rbtnCash.TabStop = true;
            this.rbtnCash.Text = "现金";
            this.rbtnCash.UseVisualStyleBackColor = true;
            this.rbtnCash.CheckedChanged += new System.EventHandler(this.rbtnCash_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "支付方式：";
            // 
            // lblZero
            // 
            this.lblZero.AutoSize = true;
            this.lblZero.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblZero.ForeColor = System.Drawing.Color.Red;
            this.lblZero.Location = new System.Drawing.Point(87, 168);
            this.lblZero.Name = "lblZero";
            this.lblZero.Size = new System.Drawing.Size(46, 12);
            this.lblZero.TabIndex = 24;
            this.lblZero.Text = "￥0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "找零金额：";
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Location = new System.Drawing.Point(18, 141);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(65, 12);
            this.lblCash.TabIndex = 18;
            this.lblCash.Text = "实收金额：";
            // 
            // frmPay_OK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 248);
            this.Controls.Add(this.numPayBalance);
            this.Controls.Add(this.lblPayBalance);
            this.Controls.Add(this.numPayMoney);
            this.Controls.Add(this.lblPayMoney);
            this.Controls.Add(this.rbtnAnd);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.rbtnBalance);
            this.Controls.Add(this.rbtnCash);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblZero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPay_OK";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "消费结算";
            this.Load += new System.EventHandler(this.frmPay_OK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPayBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPayMoney)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numPayBalance;
        private System.Windows.Forms.Label lblPayBalance;
        private System.Windows.Forms.NumericUpDown numPayMoney;
        private System.Windows.Forms.Label lblPayMoney;
        private System.Windows.Forms.RadioButton rbtnAnd;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPayID;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.RadioButton rbtnBalance;
        private System.Windows.Forms.RadioButton rbtnCash;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblZero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCash;
    }
}