using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BHair.Business.BaseData;
using BHair.Business;

namespace BHair.Base
{
    public partial class frmSubject_List : WinFormsUI.Docking.DockContent
    {
        public frmSubject_List()
        {
            InitializeComponent();
        }

        /// <summary>加载收支科目列表</summary>
        private void LoadSubjectList()
        {
            int iType = this.cboType.SelectedIndex;
            int iEnabled = 0;
            if (this.chkEnabled.Checked)
            {
                iEnabled = 1;
            }
            List<Subject> lstSubject = new Subject().SelectList(iType, iEnabled);
            this.dgvSubject.AutoGenerateColumns = false;
            this.dgvSubject.Rows.Clear();
            foreach (Subject objSub in lstSubject)
            {
                this.dgvSubject.Rows.Add(new object[] { objSub.ID, objSub.Name, objSub.TypeText, objSub.Readme });
            }
        }

        private void frmSubject_List_Load(object sender, EventArgs e)
        {
            this.cboType.SelectedIndex = 0;
            this.LoadSubjectList();
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadSubjectList();
        }

        private void chkEnabled_CheckedChanged(object sender, EventArgs e)
        {
            this.LoadSubjectList();
            if (this.chkEnabled.Checked)
            {
                this.btnIsEnabled.Text = "启用科目";
            }
            else
            {
                this.btnIsEnabled.Text = "禁用科目";
            }
        }

        /// <summary>新增</summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmSubject objfrmSubject = new frmSubject();
            if (objfrmSubject.ShowDialog() == DialogResult.OK)
            {
                this.LoadSubjectList();
            }
        }

        /// <summary>修改</summary>
        private void btnModify_Click(object sender, EventArgs e)
        {
            this.ShowSubject();
        }

        private void dgvSubject_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                this.ShowSubject();
            }
        }

        /// <summary>显示科目信息窗口</summary>
        private void ShowSubject()
        {
            if (this.dgvSubject.CurrentRow != null)
            {
                int iId = int.Parse(this.dgvSubject.CurrentRow.Cells[0].Value.ToString());
                frmSubject objfrmSubject = new frmSubject(iId);
                if (objfrmSubject.ShowDialog() == DialogResult.OK)
                {
                    this.LoadSubjectList();
                }
            }
        }

        /// <summary>启用/禁用</summary>
        private void btnIsEnabled_Click(object sender, EventArgs e)
        {
            int iEnabled = 1;
            if (this.chkEnabled.Checked)
            {
                iEnabled = 0;
            }
            if (this.dgvSubject.CurrentRow != null)
            {
                int iId = int.Parse(this.dgvSubject.CurrentRow.Cells[0].Value.ToString());
                Subject objSubject = new Subject();
                objSubject.IsEnabled = iEnabled;
                objSubject.ID = iId;
                if (objSubject.UpdateStatus() > 0)
                {
                    this.LoadSubjectList();
                }
            }
        }

        private void dgvSubject_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            StaticValue.ShowRows_DataGridView_RowPostPaint(this.dgvSubject, sender, e);
        }
    }
}
