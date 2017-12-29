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
    public partial class frmItems_List : WinFormsUI.Docking.DockContent
    {
        public frmItems_List()
        {
            InitializeComponent();
        }

        private void frmItems_List_Load(object sender, EventArgs e)
        {
            this.cboType.SelectedIndex = 0;
            this.LoadItemsList();
        }

        /// <summary>加载商品信息列表</summary>
        private void LoadItemsList()
        {
            int iType = this.cboType.SelectedIndex;
            string strText = this.txtSPItemId.Text.Trim();
            int iStatus = 1;
            if (this.chkNoShow.Checked)
            {
                iStatus = 2;
            }
            List<SPItems> lstItems = new SPItems().SelectList(iType, strText, iStatus);
            this.dgvSPItems.AutoGenerateColumns = false;
            this.dgvSPItems.Rows.Clear();
            foreach (SPItems objItem in lstItems)
            {
                this.dgvSPItems.Rows.Add(new object[] { objItem.ID, objItem.Name, objItem.UnitPrice, objItem.IsBonusText, objItem.NumPrice, objItem.Amount, objItem.Convert, objItem.TypeText, objItem.StatusText, objItem.Readme });
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmItems objfrmItems = new frmItems();
            if (objfrmItems.ShowDialog() == DialogResult.OK)
            {
                this.LoadItemsList();
            }
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadItemsList();
        }

        private void txtSPItemId_TextChanged(object sender, EventArgs e)
        {
            this.LoadItemsList();
        }

        private void chkNoShow_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkNoShow.Checked)
            {
                this.btnDown.Text = "商品上架";
            }
            else
            {
                this.btnDown.Text = "商品下架";
            }
            this.LoadItemsList();
        }

        /// <summary>修改商品信息</summary>
        private void btnModify_Click(object sender, EventArgs e)
        {
            this.ShowSPItems();
        }

        /// <summary>打开商品信息窗口</summary>
        private void ShowSPItems()
        {
            if (this.dgvSPItems.CurrentRow != null)
            {
                int iId = int.Parse(this.dgvSPItems.CurrentRow.Cells[0].Value.ToString());
                frmItems objfrmItems = new frmItems(iId);
                if (objfrmItems.ShowDialog() == DialogResult.OK)
                {
                    this.LoadItemsList();
                }
            }
        }

        private void dgvSPItems_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                this.ShowSPItems();
            }
        }

        /// <summary>商品下架</summary>
        private void btnDown_Click(object sender, EventArgs e)
        {
            if (this.dgvSPItems.CurrentRow != null)
            {
                int iId = int.Parse(this.dgvSPItems.CurrentRow.Cells[0].Value.ToString());
                SPItems objItem = new SPItems(iId);
                if (objItem.Status == 1)
                {
                    objItem.Status = 0;
                }
                else
                {
                    objItem.Status = 1;
                }
                if (objItem.DownSPItems() > 0)
                {
                    this.LoadItemsList();
                }
            }
        }

        private void dgvSPItems_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            StaticValue.ShowRows_DataGridView_RowPostPaint(this.dgvSPItems, sender, e);
        }
    }
}
