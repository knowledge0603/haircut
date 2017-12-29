namespace BHair.Base
{
    partial class frmCard
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
            this.btnOk = new System.Windows.Forms.Button();
            this.grpCard = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numMoney = new System.Windows.Forms.NumericUpDown();
            this.numDiscount = new System.Windows.Forms.NumericUpDown();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.grpCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(155, 137);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(74, 137);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 24;
            this.btnOk.Text = "确定(&O)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // grpCard
            // 
            this.grpCard.Controls.Add(this.label2);
            this.grpCard.Location = new System.Drawing.Point(12, 12);
            this.grpCard.Name = "grpCard";
            this.grpCard.Size = new System.Drawing.Size(218, 38);
            this.grpCard.TabIndex = 23;
            this.grpCard.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "消费折扣：输入0.8表示八折。";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(219, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "*";
            // 
            // numMoney
            // 
            this.numMoney.DecimalPlaces = 2;
            this.numMoney.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numMoney.Location = new System.Drawing.Point(93, 110);
            this.numMoney.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMoney.Name = "numMoney";
            this.numMoney.Size = new System.Drawing.Size(120, 21);
            this.numMoney.TabIndex = 21;
            // 
            // numDiscount
            // 
            this.numDiscount.DecimalPlaces = 2;
            this.numDiscount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numDiscount.Location = new System.Drawing.Point(93, 83);
            this.numDiscount.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDiscount.Name = "numDiscount";
            this.numDiscount.Size = new System.Drawing.Size(120, 21);
            this.numDiscount.TabIndex = 19;
            this.numDiscount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(22, 112);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(65, 12);
            this.lblMoney.TabIndex = 18;
            this.lblMoney.Text = "初始金额：";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(22, 85);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(65, 12);
            this.lblDiscount.TabIndex = 16;
            this.lblDiscount.Text = "消费折扣：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(93, 56);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 21);
            this.txtName.TabIndex = 15;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(10, 59);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(77, 12);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "会员卡类型：";
            // 
            // frmCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 173);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grpCard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numMoney);
            this.Controls.Add(this.numDiscount);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCard";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "会员卡类型";
            this.Load += new System.EventHandler(this.frmCard_Load);
            this.grpCard.ResumeLayout(false);
            this.grpCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox grpCard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numMoney;
        private System.Windows.Forms.NumericUpDown numDiscount;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
    }
}