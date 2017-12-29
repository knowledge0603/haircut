namespace BHair.Base
{
    partial class frmItems_List
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
            this.chkNoShow = new System.Windows.Forms.CheckBox();
            this.dgvSPItems = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSPItemId = new System.Windows.Forms.TextBox();
            this.lblSPItemId = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.btnDown = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPItems)).BeginInit();
            this.SuspendLayout();
            // 
            // chkNoShow
            // 
            this.chkNoShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkNoShow.AutoSize = true;
            this.chkNoShow.Location = new System.Drawing.Point(605, 14);
            this.chkNoShow.Name = "chkNoShow";
            this.chkNoShow.Size = new System.Drawing.Size(108, 16);
            this.chkNoShow.TabIndex = 16;
            this.chkNoShow.Text = "显示已下架商品";
            this.chkNoShow.UseVisualStyleBackColor = true;
            this.chkNoShow.CheckedChanged += new System.EventHandler(this.chkNoShow_CheckedChanged);
            // 
            // dgvSPItems
            // 
            this.dgvSPItems.AllowUserToAddRows = false;
            this.dgvSPItems.AllowUserToResizeRows = false;
            this.dgvSPItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSPItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSPItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column10,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvSPItems.Location = new System.Drawing.Point(12, 39);
            this.dgvSPItems.MultiSelect = false;
            this.dgvSPItems.Name = "dgvSPItems";
            this.dgvSPItems.RowTemplate.Height = 23;
            this.dgvSPItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSPItems.Size = new System.Drawing.Size(701, 366);
            this.dgvSPItems.TabIndex = 15;
            this.dgvSPItems.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvSPItems_RowPostPaint);
            this.dgvSPItems.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSPItems_CellMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "商品编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "商品名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column3.HeaderText = "预售单价";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "是否打折";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 80;
            // 
            // Column4
            // 
            dataGridViewCellStyle2.Format = "C2";
            this.Column4.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column4.HeaderText = "次数价";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "库存数量";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "积分兑换";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "TypeText";
            this.Column7.HeaderText = "所属类别";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "状态";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "说明";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 300;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(419, 10);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 14;
            this.btnModify.Text = "修改商品";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(338, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "新增商品";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSPItemId
            // 
            this.txtSPItemId.Location = new System.Drawing.Point(252, 12);
            this.txtSPItemId.MaxLength = 12;
            this.txtSPItemId.Name = "txtSPItemId";
            this.txtSPItemId.Size = new System.Drawing.Size(80, 21);
            this.txtSPItemId.TabIndex = 12;
            this.txtSPItemId.TextChanged += new System.EventHandler(this.txtSPItemId_TextChanged);
            // 
            // lblSPItemId
            // 
            this.lblSPItemId.AutoSize = true;
            this.lblSPItemId.Location = new System.Drawing.Point(181, 15);
            this.lblSPItemId.Name = "lblSPItemId";
            this.lblSPItemId.Size = new System.Drawing.Size(65, 12);
            this.lblSPItemId.TabIndex = 11;
            this.lblSPItemId.Text = "商品编号：";
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "所有类别",
            "洗剪吹",
            "烫发",
            "染发",
            "外卖护理"});
            this.cboType.Location = new System.Drawing.Point(95, 12);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(80, 20);
            this.cboType.TabIndex = 10;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(12, 15);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(77, 12);
            this.lblType.TabIndex = 9;
            this.lblType.Text = "按类型过滤：";
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(500, 10);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 17;
            this.btnDown.Text = "商品下架";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // frmItems_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 417);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.chkNoShow);
            this.Controls.Add(this.dgvSPItems);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSPItemId);
            this.Controls.Add(this.lblSPItemId);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.lblType);
            this.Name = "frmItems_List";
            this.TabText = "商品信息管理";
            this.Text = "商品信息管理";
            this.Load += new System.EventHandler(this.frmItems_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkNoShow;
        private System.Windows.Forms.DataGridView dgvSPItems;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSPItemId;
        private System.Windows.Forms.Label lblSPItemId;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}