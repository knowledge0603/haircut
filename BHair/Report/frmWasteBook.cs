using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BHair.Business.BaseData;
using BHair.Business.Table;

namespace BHair.Report
{
    public partial class frmWasteBook : Form
    {
        private string m_strType = "";
        private decimal m_dWasteBookId = 0;

        /// <summary>新增收支帐目</summary>
        /// <param name="type">收支类型(e支出，i收支)</param>
        public frmWasteBook(string type)
        {
            InitializeComponent();
            this.m_strType = type;
            if (this.m_strType == "i")
            {
                this.Text = "新增收入";
            }
            else
            {
                this.Text = "新增支出";
            }
        }

        /// <summary>修改收支帐目</summary>
        /// <param name="wbid">帐目ID</param>
        public frmWasteBook(decimal wastebookid)
        {
            InitializeComponent();
            this.m_dWasteBookId = wastebookid;
        }

        /// <summary>加载费用名称。</summary>
        private void LoadSubjectList()
        {
            List<Subject> lstSubject = new List<Subject>();
            if (this.m_strType == "i")
            {
                lstSubject = new Subject().SelectList(2, 0);//收入
            }
            else
            {
                lstSubject = new Subject().SelectList(1, 0);//支出
            }
            this.cboSubject.DataSource = lstSubject;
            this.cboSubject.ValueMember = "ID";
            this.cboSubject.DisplayMember = "Name";
            this.cboSubject.SelectedIndex = 0;
        }

        private void frmWasteBook_Load(object sender, EventArgs e)
        {
            if (this.m_dWasteBookId > 0)
            {
                this.LoadWasteBookInfo();
            }
            else
            {
                this.LoadSubjectList();
            }
        }

        /// <summary>加载收支流水帐目</summary>
        private void LoadWasteBookInfo()
        {
            WasteBook objWasteBook = new WasteBook(this.m_dWasteBookId);
            this.m_strType = objWasteBook.Type;
            this.LoadSubjectList();
            if (objWasteBook.Type == "i")
            {
                this.numMoney.Value = objWasteBook.Income;
            }
            else
            {
                this.numMoney.Value = objWasteBook.Expend;
            }
            this.cboSubject.SelectedValue = objWasteBook.SubjectID;
            this.dtpExpend.Value = objWasteBook.Date;
            this.txtRemark.Text = objWasteBook.Remark;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            WasteBook objWasteBook = new WasteBook();
            objWasteBook.SubjectID = int.Parse(this.cboSubject.SelectedValue.ToString());
            objWasteBook.Date = DateTime.Parse(this.dtpExpend.Value.ToShortDateString() + " " + DateTime.Now.ToLongTimeString());
            objWasteBook.Remark = this.txtRemark.Text.Trim();
            if (this.m_strType != "")
            {
                objWasteBook.Type = this.m_strType;
                if (this.m_strType == "i")
                {
                    objWasteBook.Income = this.numMoney.Value;
                    objWasteBook.Expend = 0;
                }
                else
                {
                    objWasteBook.Income = 0;
                    objWasteBook.Expend = this.numMoney.Value;
                }
            }

            if (this.m_dWasteBookId > 0)
            {
                objWasteBook.ID = this.m_dWasteBookId;
                objWasteBook.UpdateExpend();
            }
            else
            {
                objWasteBook.InsertWasteBook();
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>取消</summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
