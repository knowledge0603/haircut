using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using XLuSharpLibrary.CommonFunction;
using BHair.Business.BaseData;
using BHair.Business.Table;

namespace BHair.Business
{
    public partial class frmSelectItems : Form
    {
        /// <summary>消费单号</summary>
        private string _strPayId = "";

        private List<PayDetail> _lstDetail = new List<PayDetail>();

        private bool bRun = false;

        public frmSelectItems()
        {
            InitializeComponent();
        }

        public frmSelectItems(string payid)
        {
            InitializeComponent();
            this._strPayId = payid;
        }

        private void txtSPItemId_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericClass.NumberAccpter(sender, e, false);
        }

        private void frmSelectItems_Load(object sender, EventArgs e)
        {
            //加载原有已选择商品
            //if (this._strPayId == "")
            //{
            //    this._lstDetail.AddRange(StaticValue.g_lstTempPayDetails);
            //}
            //else
            //{
            //    this._lstDetail.AddRange(PayDetail.SelectList(this._strPayId));
            //}

            this._lstDetail.AddRange(StaticValue.g_lstTempPayDetails);
            this.cboType.SelectedIndex = 0;
            this.LoadItemsList();

            this.LoadSeledtedItemsList();//加载已经选择商品
            this.bRun = true;
        }

        #region 加载商品信息列表...

        /// <summary>加载商品信息列表</summary>
        private void LoadItemsList()
        {
            int iType = this.cboType.SelectedIndex;
            string strText = this.txtSPItemId.Text.Trim();
            List<SPItems> lstItems = new SPItems().SelectList(iType, strText, 1);
            this.dgvSPItems.AutoGenerateColumns = false;
            this.dgvSPItems.Rows.Clear();
            foreach (SPItems objItem in lstItems)
            {
                this.dgvSPItems.Rows.Add(new object[] { objItem.ID, objItem.Name, objItem.UnitPrice, objItem.Amount });
            }
        }

        #endregion

        /// <summary>按类型查询商品信息</summary>
        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.bRun)
            {
                this.LoadItemsList();
            }
        }

        /// <summary>按商品编号查询</summary>
        private void txtSPItemId_TextChanged(object sender, EventArgs e)
        {
            this.LoadItemsList();
        }

        #region 选择消费商品...

        /// <summary>单击按钮选择</summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.dgvSPItems.CurrentRow != null)
            {
                this.Add_Click(int.Parse(this.numNumber.Value.ToString()));
            }
        }

        /// <summary>双击选择</summary>
        private void dgvSPItems_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                this.Add_Click(int.Parse(this.numNumber.Value.ToString()));
            }
        }

        /// <summary>添加商品</summary>
        /// <param name="num">数量</param>
        public void Add_Click(int num)
        {
            int iSPItemID = int.Parse(this.dgvSPItems.CurrentRow.Cells[0].Value.ToString());
            SPItems objItem = new SPItems(iSPItemID);

            PayDetail objDetail = new PayDetail();
            objDetail.PayID = "";
            if (this._strPayId != "")
            {
                objDetail.PayID = this._strPayId;
            }
            objDetail.ItemID = iSPItemID;
            if (objItem.IsBonus == 1)
            {
                //不打折
                objDetail.Bonus = 1;
                objDetail.Money = objItem.UnitPrice;
            }
            else
            {
                objDetail.Bonus = StaticValue.g_dBonus;
                //计算折后单价(四舍五入)
                objDetail.Money = decimal.Parse((decimal.Parse(StaticValue.g_dBonus.ToString()) * new SPItems(iSPItemID).UnitPrice).ToString("f0"));
            }
            objDetail.Number = num;
            if (this.ValidateData(objDetail.ItemID))
            {
                this._lstDetail.Add(objDetail);
            }
            this.LoadSeledtedItemsList();
        }

        #endregion

        /// <summary>验证是否存在相同商品</summary>
        /// <param name="itemid"></param>
        /// <returns></returns>
        private bool ValidateData(int itemid)
        {
            foreach (PayDetail obj in this._lstDetail)
            {
                if (obj.ItemID == itemid)
                {
                    return false;
                }
            }
            return true;
        }

        #region 加载已选商品信息列表...

        /// <summary>加载已选择商品信息。</summary>
        private void LoadSeledtedItemsList()
        {
            this.dgvPayDetails.AutoGenerateColumns = false;
            this.dgvPayDetails.Rows.Clear();
            foreach (PayDetail objDetail in this._lstDetail)
            {
                this.dgvPayDetails.Rows.Add(new object[] { objDetail.DetailID, objDetail.SPItem.Name, objDetail.SPItem.UnitPrice, objDetail.Number, objDetail.Sum });
            }
        }

        #endregion

        #region 删除已选择商品...

        /// <summary>单击删除按钮删除已选商品。</summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.DeleteSelected_Click();
        }

        /// <summary>双击删除已选商品</summary>
        private void dgvPayDetails_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                this.DeleteSelected_Click();
            }
        }

        /// <summary>删除已选商品</summary>
        private void DeleteSelected_Click()
        {
            if (this.dgvPayDetails.CurrentRow != null)
            {
                int iIndex = this.dgvPayDetails.CurrentRow.Index;
                this._lstDetail.RemoveAt(iIndex);
                this.LoadSeledtedItemsList();
            }
        }

        #endregion

        /// <summary>确定选择</summary>
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.dgvPayDetails.RowCount == 0)
            {
                MessageBox.Show("未选择任何消费项目！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            StaticValue.g_lstTempPayDetails = this._lstDetail;
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
