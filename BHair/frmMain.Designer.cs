namespace BHair
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.dPanelMain = new WinFormsUI.Docking.DockPanel();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuMain_Day = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain_Day_Pay = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain_Day_Member = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain_Day_Book = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain_Table = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain_Table_Deposit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain_Table_Salary = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain_Table_Month = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain_System = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain_System_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain_System_Card = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain_System_Subject = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain_System_Employee = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuMain_System_Config = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain_System_Log = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain_System_Pwd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuMain_System_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ssrMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssrMain_Timer = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.menuMain.SuspendLayout();
            this.ssrMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dPanelMain
            // 
            this.dPanelMain.ActiveAutoHideContent = null;
            this.dPanelMain.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dPanelMain.Location = new System.Drawing.Point(0, 24);
            this.dPanelMain.Name = "dPanelMain";
            this.dPanelMain.Size = new System.Drawing.Size(763, 392);
            this.dPanelMain.TabIndex = 0;
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMain_Day,
            this.menuMain_Table,
            this.menuMain_System});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(775, 24);
            this.menuMain.TabIndex = 3;
            this.menuMain.Text = "menuStrip1";
            // 
            // menuMain_Day
            // 
            this.menuMain_Day.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMain_Day_Pay,
            this.menuMain_Day_Member,
            this.menuMain_Day_Book});
            this.menuMain_Day.Name = "menuMain_Day";
            this.menuMain_Day.Size = new System.Drawing.Size(83, 20);
            this.menuMain_Day.Text = "日常操作(&D)";
            // 
            // menuMain_Day_Pay
            // 
            this.menuMain_Day_Pay.Name = "menuMain_Day_Pay";
            this.menuMain_Day_Pay.Size = new System.Drawing.Size(136, 22);
            this.menuMain_Day_Pay.Text = "消费单据(&P)";
            this.menuMain_Day_Pay.Click += new System.EventHandler(this.menuMain_Day_Pay_Click);
            // 
            // menuMain_Day_Member
            // 
            this.menuMain_Day_Member.Name = "menuMain_Day_Member";
            this.menuMain_Day_Member.Size = new System.Drawing.Size(136, 22);
            this.menuMain_Day_Member.Text = "会员管理(&M)";
            this.menuMain_Day_Member.Click += new System.EventHandler(this.menuMain_Day_Member_Click);
            // 
            // menuMain_Day_Book
            // 
            this.menuMain_Day_Book.Name = "menuMain_Day_Book";
            this.menuMain_Day_Book.Size = new System.Drawing.Size(136, 22);
            this.menuMain_Day_Book.Text = "账目清单(&B)";
            this.menuMain_Day_Book.Click += new System.EventHandler(this.menuMain_Day_Book_Click);
            // 
            // menuMain_Table
            // 
            this.menuMain_Table.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMain_Table_Deposit,
            this.menuMain_Table_Salary,
            this.menuMain_Table_Month});
            this.menuMain_Table.Name = "menuMain_Table";
            this.menuMain_Table.Size = new System.Drawing.Size(83, 20);
            this.menuMain_Table.Text = "统计报表(&T)";
            // 
            // menuMain_Table_Deposit
            // 
            this.menuMain_Table_Deposit.Name = "menuMain_Table_Deposit";
            this.menuMain_Table_Deposit.Size = new System.Drawing.Size(160, 22);
            this.menuMain_Table_Deposit.Text = "会员充值统计(&D)";
            this.menuMain_Table_Deposit.Click += new System.EventHandler(this.menuMain_Table_Deposit_Click);
            // 
            // menuMain_Table_Salary
            // 
            this.menuMain_Table_Salary.Name = "menuMain_Table_Salary";
            this.menuMain_Table_Salary.Size = new System.Drawing.Size(160, 22);
            this.menuMain_Table_Salary.Text = "员工工资统计(&S)";
            this.menuMain_Table_Salary.Click += new System.EventHandler(this.menuMain_Table_Salary_Click);
            // 
            // menuMain_Table_Month
            // 
            this.menuMain_Table_Month.Name = "menuMain_Table_Month";
            this.menuMain_Table_Month.Size = new System.Drawing.Size(160, 22);
            this.menuMain_Table_Month.Text = "每月收支汇总(&M)";
            this.menuMain_Table_Month.Click += new System.EventHandler(this.menuMain_Table_Month_Click);
            // 
            // menuMain_System
            // 
            this.menuMain_System.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMain_System_Item,
            this.menuMain_System_Card,
            this.menuMain_System_Subject,
            this.menuMain_System_Employee,
            this.toolStripMenuItem1,
            this.menuMain_System_Config,
            this.menuMain_System_Log,
            this.menuMain_System_Pwd,
            this.toolStripMenuItem2,
            this.menuMain_System_Exit});
            this.menuMain_System.Name = "menuMain_System";
            this.menuMain_System.Size = new System.Drawing.Size(83, 20);
            this.menuMain_System.Text = "系统维护(&S)";
            // 
            // menuMain_System_Item
            // 
            this.menuMain_System_Item.Name = "menuMain_System_Item";
            this.menuMain_System_Item.Size = new System.Drawing.Size(160, 22);
            this.menuMain_System_Item.Text = "商品信息管理(&I)";
            this.menuMain_System_Item.Click += new System.EventHandler(this.menuMain_System_Item_Click);
            // 
            // menuMain_System_Card
            // 
            this.menuMain_System_Card.Name = "menuMain_System_Card";
            this.menuMain_System_Card.Size = new System.Drawing.Size(160, 22);
            this.menuMain_System_Card.Text = "会员卡设置(&M)";
            this.menuMain_System_Card.Click += new System.EventHandler(this.menuMain_System_Card_Click);
            // 
            // menuMain_System_Subject
            // 
            this.menuMain_System_Subject.Name = "menuMain_System_Subject";
            this.menuMain_System_Subject.Size = new System.Drawing.Size(160, 22);
            this.menuMain_System_Subject.Text = "收支科目管理(&S)";
            this.menuMain_System_Subject.Click += new System.EventHandler(this.menuMain_System_Subject_Click);
            // 
            // menuMain_System_Employee
            // 
            this.menuMain_System_Employee.Name = "menuMain_System_Employee";
            this.menuMain_System_Employee.Size = new System.Drawing.Size(160, 22);
            this.menuMain_System_Employee.Text = "员工信息管理(&E)";
            this.menuMain_System_Employee.Click += new System.EventHandler(this.menuMain_System_Employee_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(157, 6);
            // 
            // menuMain_System_Config
            // 
            this.menuMain_System_Config.Name = "menuMain_System_Config";
            this.menuMain_System_Config.Size = new System.Drawing.Size(160, 22);
            this.menuMain_System_Config.Text = "系统设置(&C)";
            this.menuMain_System_Config.Click += new System.EventHandler(this.menuMain_System_Config_Click);
            // 
            // menuMain_System_Log
            // 
            this.menuMain_System_Log.Name = "menuMain_System_Log";
            this.menuMain_System_Log.Size = new System.Drawing.Size(160, 22);
            this.menuMain_System_Log.Text = "查看日志(&L)";
            this.menuMain_System_Log.Click += new System.EventHandler(this.menuMain_System_Log_Click);
            // 
            // menuMain_System_Pwd
            // 
            this.menuMain_System_Pwd.Name = "menuMain_System_Pwd";
            this.menuMain_System_Pwd.Size = new System.Drawing.Size(160, 22);
            this.menuMain_System_Pwd.Text = "修改密码(&P)";
            this.menuMain_System_Pwd.Click += new System.EventHandler(this.menuMain_System_Pwd_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(157, 6);
            // 
            // menuMain_System_Exit
            // 
            this.menuMain_System_Exit.Name = "menuMain_System_Exit";
            this.menuMain_System_Exit.Size = new System.Drawing.Size(160, 22);
            this.menuMain_System_Exit.Text = "退出(&E)";
            this.menuMain_System_Exit.Click += new System.EventHandler(this.menuMain_System_Exit_Click);
            // 
            // ssrMain
            // 
            this.ssrMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tssrMain_Timer});
            this.ssrMain.Location = new System.Drawing.Point(0, 419);
            this.ssrMain.Name = "ssrMain";
            this.ssrMain.Size = new System.Drawing.Size(775, 22);
            this.ssrMain.SizingGrip = false;
            this.ssrMain.TabIndex = 4;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(655, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "美发店管理系统 2012";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tssrMain_Timer
            // 
            this.tssrMain_Timer.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.tssrMain_Timer.Name = "tssrMain_Timer";
            this.tssrMain_Timer.Size = new System.Drawing.Size(105, 17);
            this.tssrMain_Timer.Text = "[tssrMain_Timer]";
            // 
            // tmrMain
            // 
            this.tmrMain.Enabled = true;
            this.tmrMain.Interval = 1000;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 441);
            this.Controls.Add(this.ssrMain);
            this.Controls.Add(this.menuMain);
            this.Controls.Add(this.dPanelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuMain;
            this.MinimumSize = new System.Drawing.Size(783, 475);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "美发店管理系统 2012";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ssrMain.ResumeLayout(false);
            this.ssrMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinFormsUI.Docking.DockPanel dPanelMain;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.StatusStrip ssrMain;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tssrMain_Timer;
        private System.Windows.Forms.ToolStripMenuItem menuMain_Day;
        private System.Windows.Forms.ToolStripMenuItem menuMain_Table;
        private System.Windows.Forms.ToolStripMenuItem menuMain_System;
        private System.Windows.Forms.ToolStripMenuItem menuMain_Day_Pay;
        private System.Windows.Forms.ToolStripMenuItem menuMain_Day_Member;
        private System.Windows.Forms.ToolStripMenuItem menuMain_Day_Book;
        private System.Windows.Forms.ToolStripMenuItem menuMain_Table_Deposit;
        private System.Windows.Forms.ToolStripMenuItem menuMain_Table_Salary;
        private System.Windows.Forms.ToolStripMenuItem menuMain_Table_Month;
        private System.Windows.Forms.ToolStripMenuItem menuMain_System_Item;
        private System.Windows.Forms.ToolStripMenuItem menuMain_System_Card;
        private System.Windows.Forms.ToolStripMenuItem menuMain_System_Subject;
        private System.Windows.Forms.ToolStripMenuItem menuMain_System_Employee;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuMain_System_Config;
        private System.Windows.Forms.ToolStripMenuItem menuMain_System_Log;
        private System.Windows.Forms.ToolStripMenuItem menuMain_System_Pwd;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuMain_System_Exit;
    }
}