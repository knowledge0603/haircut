using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using XLuSharpLibrary.CommonFunction;
using BHair.Business.Table;
using BHair.Business;

namespace BHair.Report
{
    public partial class frmWasteBook_List : WinFormsUI.Docking.DockContent
    {
        private bool bRun = false;

        public frmWasteBook_List()
        {
            InitializeComponent();
        }

        private void frmWasteBook_List_Load(object sender, EventArgs e)
        {
            this.LoadDate();//初始化日期数据;
            this.LoadWasteBookList();
            this.bRun = true;
        }

        #region 加载年月日...

        /// <summary>初始化日期数据。</summary>
        private void LoadDate()
        {
            for (int y = 2011; y <= DateTime.Now.Year; y++)
            {
                this.cboYear.Items.Add(y.ToString());
            }
            for (int m = 1; m <= 12; m++)
            {
                this.cboMonth.Items.Add(m.ToString());
            }
            this.cboYear.Text = DateTime.Now.Year.ToString();
            this.cboMonth.Text = DateTime.Now.Month.ToString();
            this.LoadMaxDay();
        }

        private void LoadMaxDay()
        {
            this.cboDay.Items.Clear();
            int year = int.Parse(this.cboYear.Text);
            int month = int.Parse(this.cboMonth.Text);
            int max = DateTimeClass.GetMonthMaxDay(year, month);
            this.cboDay.Items.Add("全部");
            for (int d = 1; d <= max; d++)
            {
                this.cboDay.Items.Add(d.ToString());
            }
            this.cboDay.SelectedIndex = 0;
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.bRun)
            {
                this.LoadMaxDay();
                this.LoadWasteBookList();
            }
        }

        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.bRun)
            {
                this.LoadMaxDay();
                this.LoadWasteBookList();
            }
        }

        private void cboDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.bRun)
            {
                this.LoadWasteBookList();
            }
        }

        #endregion

        /// <summary>加载收支流水帐</summary>
        private void LoadWasteBookList()
        {
            int iYear = int.Parse(this.cboYear.Text);
            int iMonth = int.Parse(this.cboMonth.Text);
            int iDay = 0;
            if (this.cboDay.SelectedIndex > 0)
            {
                iDay = int.Parse(this.cboDay.Text);
            }
            List<WasteBook> lstWasteBook = new WasteBook().SelectList(iYear, iMonth, iDay);
            this.dgvWasteBook.AutoGenerateColumns = false;
            this.dgvWasteBook.Rows.Clear();
            decimal dIncome = 0;//收入
            decimal dExpend = 0;//支出
            foreach (WasteBook objWasteBook in lstWasteBook)
            {
                if (objWasteBook.Type == "e")
                {
                    dExpend += objWasteBook.Expend;//支出
                }
                else
                {
                    dIncome += objWasteBook.Income;//收入
                }
                this.dgvWasteBook.Rows.Add(new object[] { objWasteBook.ID, objWasteBook.Subject.Name, objWasteBook.Income, objWasteBook.Expend, objWasteBook.Date, objWasteBook.Remark });
            }
            this.lblExpend.Text = "总支出：￥" + dExpend.ToString("f2");
            this.lblExpend.Top = this.ClientSize.Height - 18;
            this.lblIncome.Text = "总收入：￥" + dIncome.ToString("f2");
            this.lblIncome.Top = this.ClientSize.Height - 18;
            this.lblMoney.Text = "盈亏金额：￥" + (dIncome - dExpend).ToString("f2");
            this.lblMoney.Top = this.ClientSize.Height - 18;
        }

        /// <summary>新增支出</summary>
        private void btnExpend_Click(object sender, EventArgs e)
        {
            frmWasteBook objfrmWasteBook = new frmWasteBook("e");
            if (objfrmWasteBook.ShowDialog() == DialogResult.OK)
            {
                this.LoadWasteBookList();
            }
        }

        /// <summary>新增收入</summary>
        private void btnIncome_Click(object sender, EventArgs e)
        {
            frmWasteBook objfrmWasteBook = new frmWasteBook("i");
            if (objfrmWasteBook.ShowDialog() == DialogResult.OK)
            {
                this.LoadWasteBookList();
            }
        }

        /// <summary>修改收支记录</summary>
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (this.dgvWasteBook.CurrentRow != null)
            {
                decimal dWbId = decimal.Parse(this.dgvWasteBook.CurrentRow.Cells[0].Value.ToString());
                frmWasteBook objfrmWasteBook = new frmWasteBook(dWbId);
                if (objfrmWasteBook.ShowDialog() == DialogResult.OK)
                {
                    this.LoadWasteBookList();
                }                

                //if (objWasteBook.Type == "e")
                //{
                //    //支出
                //    frmExpend objfrmExpend = new frmExpend(dWbId);
                //    DialogResult = objfrmExpend.ShowDialog();
                //}
                //else if (objWasteBook.Type == "i")
                //{
                //    //收入
                //    frmIncome objfrmIncome = new frmIncome(dWbId);
                //    DialogResult = objfrmIncome.ShowDialog();
                //}
                //if (DialogResult == DialogResult.OK)
                //{
                //    this.LoadWasteBookList();
                //}
            }
        }

        /// <summary>删除记录</summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确实要删除账目记录，删除后将不可恢复。", "消息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                decimal dId = decimal.Parse(this.dgvWasteBook.CurrentRow.Cells[0].Value.ToString());
                if (new WasteBook().Delete(dId) > 0)
                {
                    this.LoadWasteBookList();
                }
            }
        }

        private void dgvWasteBook_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            StaticValue.ShowRows_DataGridView_RowPostPaint(this.dgvWasteBook, sender, e);
        }
    }
}
