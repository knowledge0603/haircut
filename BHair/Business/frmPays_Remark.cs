using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BHair.Business.Table;

namespace BHair.Business
{
    public partial class frmPays_Remark : Form
    {
        private string _strPayId = "";

        public frmPays_Remark(string payid)
        {
            InitializeComponent();
            this._strPayId = payid;
        }

        private void frmPays_Remark_Load(object sender, EventArgs e)
        {
            Pays objPay = new Pays(this._strPayId);
            this.lblPayID.Text = this._strPayId;
            this.txtRemark.Text = objPay.Remark;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Pays objPay = new Pays();
            objPay.PayID = this._strPayId;
            objPay.Remark = this.txtRemark.Text.Trim();
            if (objPay.UpdatePayRemark() > 0)
            {
                DialogResult = DialogResult.OK;
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
