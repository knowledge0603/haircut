namespace BHair.Business
{
    partial class frmPayDetail_Bonus
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
            this.numBonused = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.numBonus = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labal1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numBonused)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBonus)).BeginInit();
            this.SuspendLayout();
            // 
            // numBonused
            // 
            this.numBonused.DecimalPlaces = 2;
            this.numBonused.Location = new System.Drawing.Point(252, 46);
            this.numBonused.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numBonused.Name = "numBonused";
            this.numBonused.Size = new System.Drawing.Size(80, 21);
            this.numBonused.TabIndex = 20;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(257, 84);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(176, 84);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 18;
            this.btnOk.Text = "确定(&O)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPrice.ForeColor = System.Drawing.Color.Blue;
            this.lblPrice.Location = new System.Drawing.Point(257, 15);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(75, 12);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.Text = "[lblPrice]";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.ForeColor = System.Drawing.Color.Blue;
            this.lblName.Location = new System.Drawing.Point(83, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 12);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "[lblName]";
            // 
            // numBonus
            // 
            this.numBonus.BackColor = System.Drawing.SystemColors.Window;
            this.numBonus.DecimalPlaces = 2;
            this.numBonus.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numBonus.Location = new System.Drawing.Point(85, 46);
            this.numBonus.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBonus.Name = "numBonus";
            this.numBonus.Size = new System.Drawing.Size(80, 21);
            this.numBonus.TabIndex = 15;
            this.numBonus.ValueChanged += new System.EventHandler(this.numBonus_ValueChanged);
            this.numBonus.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numBonus_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "折后价：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "折扣：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "原单价：";
            // 
            // labal1
            // 
            this.labal1.AutoSize = true;
            this.labal1.Location = new System.Drawing.Point(12, 15);
            this.labal1.Name = "labal1";
            this.labal1.Size = new System.Drawing.Size(65, 12);
            this.labal1.TabIndex = 11;
            this.labal1.Text = "商品名称：";
            // 
            // frmPayDetail_Bonus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 120);
            this.Controls.Add(this.numBonused);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.numBonus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labal1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPayDetail_Bonus";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改消费折扣";
            this.Load += new System.EventHandler(this.frmPayDetail_Bonus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numBonused)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBonus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numBonused;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.NumericUpDown numBonus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labal1;
    }
}