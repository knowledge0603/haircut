using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BHair.Business;

namespace BHair.SystemSet
{
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            this.LoadDepositConfig();
        }

        /// <summary>加载充值配置参数</summary>
        private void LoadDepositConfig()
        {
            SystemConfig objConfig = new SystemConfig(0, "cfg_deposit_money");//充值基数
            this.numDeposit_Money.Value = decimal.Parse(objConfig.VarValue);
            objConfig = new SystemConfig(1, "cfg_deposit_send");//增送金额
            this.numDeposit_Send.Value = decimal.Parse(objConfig.VarValue);
            objConfig = new SystemConfig(2, "cfg_deposit_start");//开始时间
            this.dtpDeposit_Start.Value = DateTime.Parse(objConfig.VarValue);
            objConfig = new SystemConfig(3, "cfg_deposit_finish");//结束时间
            this.dtpDeposit_Finish.Value = DateTime.Parse(objConfig.VarValue);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SystemConfig objConfig = new SystemConfig();
            int iPage = this.tabConfig.SelectedIndex;
            switch (iPage)
            {
                case 0://保存充值配置
                    objConfig.VarName = "cfg_deposit_money";
                    objConfig.VarValue = this.numDeposit_Money.Value.ToString();
                    objConfig.UpdateValue();
                    objConfig.VarName = "cfg_deposit_send";
                    objConfig.VarValue = this.numDeposit_Send.Value.ToString();
                    objConfig.UpdateValue();
                    objConfig.VarName = "cfg_deposit_start";
                    objConfig.VarValue = this.dtpDeposit_Start.Value.ToShortDateString() + " 00:00:00";
                    objConfig.UpdateValue();
                    objConfig.VarName = "cfg_deposit_finish";
                    objConfig.VarValue = this.dtpDeposit_Finish.Value.ToShortDateString() + " 23:59:59";
                    objConfig.UpdateValue();
                    break;
                case 1:
                    break;
            }
            MessageBox.Show("系统参数配置成功！", "消息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
