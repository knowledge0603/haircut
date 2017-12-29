using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BHair.Business.BaseData;

namespace BHair.Base
{
    public partial class frmSubject : Form
    {
        private int m_iSubjectId = 0;

        /// <summary>收支科目</summary>
        public frmSubject()
        {
            InitializeComponent();
        }

        /// <summary>收支科目</summary>
        /// <param name="sid">科目ID</param>
        public frmSubject(int sid)
        {
            InitializeComponent();
            this.m_iSubjectId = sid;
            this.Text = "修改收支科目";
        }

        private void frmSubject_Load(object sender, EventArgs e)
        {
            this.cboType.SelectedIndex = 0;
            if (this.m_iSubjectId > 0)
            {
                Subject objSub = new Subject(this.m_iSubjectId);
                this.cboType.SelectedIndex = objSub.Type;
                this.txtName.Text = objSub.Name;
                this.txtReadme.Text = objSub.Readme;

                this.cboType.Enabled = false;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.txtName.Text.Trim() == "")
            {
                MessageBox.Show("科目名称不能为空，请输入！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtName.Focus();
                return;
            }
            Subject objSub = new Subject();
            objSub.Name = this.txtName.Text.Trim();
            objSub.Type = this.cboType.SelectedIndex;
            objSub.Readme = this.txtReadme.Text.Trim();

            int iTempId = objSub.ExistsSubjectName(objSub.Name);
            if (this.m_iSubjectId > 0)
            {
                objSub.ID = this.m_iSubjectId;
                if (iTempId > 0 && iTempId != this.m_iSubjectId)
                {
                    MessageBox.Show("请重新输入科目名称。\n收支科目列表中已经存在同名科目。", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtName.Focus();
                    return;
                }
                objSub.UpdateSubject();
            }
            else
            {
                if (iTempId > 0)
                {
                    MessageBox.Show("请重新输入科目名称。\n收支科目列表中已经存在同名科目。", "消息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtName.Focus();
                    return;
                }
                objSub.InsertSubject();
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
