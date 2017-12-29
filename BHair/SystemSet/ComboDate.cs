using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using XLuSharpLibrary.CommonFunction;

namespace BHair.SystemSet
{
    public enum ShowMode
    {
        All, YearAndMonth
    }

    public partial class ComboDate : UserControl
    {
        private bool bRun = false;

        public ComboDate()
        {
            InitializeComponent();
        }

        #region 自定义属性...

        private bool _IsAllYear = false;

        /// <summary>年份是否有“全部”选项。</summary>
        public bool IsAllYear
        {
            get { return _IsAllYear; }
            set { _IsAllYear = value; }
        }

        /// <summary>年</summary>
        public int Year
        {
            get
            {
                if (!this.IsAllYear || (this.cboYear.SelectedIndex > 0 && this.IsAllYear))
                {
                    return int.Parse(this.cboYear.Text);
                }
                return 0;
            }
        }

        private bool _IsAllMonth = false;

        /// <summary>月份是否有“全部”选项。</summary>
        public bool IsAllMonth
        {
            get { return _IsAllMonth; }
            set { _IsAllMonth = value; }
        }

        /// <summary>月</summary>
        public int Month
        {
            get
            {
                if (!this.IsAllMonth)
                {
                    return int.Parse(this.cboMonth.Text); ;
                }
                else if (this.cboMonth.SelectedIndex > 0 && this.IsAllMonth)
                {
                    return int.Parse(this.cboMonth.Text);
                }
                return 0;
            }
        }

        /// <summary>日</summary>
        public int Day
        {
            get
            {
                if (this.cboDay.SelectedIndex > 0)
                {
                    return int.Parse(this.cboDay.Text);
                }
                return 0;
            }
        }

        private ShowMode _ShowMode = ShowMode.All;

        public ShowMode ShowMode
        {
            get { return _ShowMode; }
            set { _ShowMode = value; }
        }

        #endregion

        private void LoadDate()
        {
            if (this.IsAllYear)
            {
                this.cboYear.Items.Add("全部");
            }
            for (int y = 2011; y <= DateTime.Now.Year; y++)
            {
                this.cboYear.Items.Add(y.ToString());
            }
            this.cboYear.Text = DateTime.Now.Year.ToString();
            if (this.IsAllMonth)
            {
                this.cboMonth.Items.Add("全部");
            }
            for (int m = 1; m <= 12; m++)
            {
                this.cboMonth.Items.Add(m.ToString());
            }
            this.cboMonth.Text = DateTime.Now.Month.ToString();
            
            this.LoadMaxDay();
            if (this.ShowMode == ShowMode.All)
            {
                this.cboDay.Text = DateTime.Now.Day.ToString();
            }
        }

        private void LoadMaxDay()
        {
            this.cboDay.Items.Clear();
            this.cboDay.Items.Add("全部");
            if (this.ShowMode == ShowMode.All)
            {
                int year = int.Parse(this.cboYear.Text);
                if (this.cboMonth.Text != "全部")
                {
                    int month = int.Parse(this.cboMonth.Text);
                    int max = DateTimeClass.GetMonthMaxDay(year, month);
                    for (int d = 1; d <= max; d++)
                    {
                        this.cboDay.Items.Add(d.ToString());
                    }
                }
            }
            this.cboDay.SelectedIndex = 0;
        }

        /// <summary>年</summary>
        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.bRun)
            {
                this.LoadMaxDay();
            }
        }

        /// <summary>月</summary>
        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.bRun)
            {
                this.LoadMaxDay();
            }
        }

        public event EventHandler SelectedIndexChanged;

        /// <summary>日</summary>
        private void cboDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedIndexChanged != null)
            {
                SelectedIndexChanged(sender, e);
            }
        }

        private void ComboDate_Load(object sender, EventArgs e)
        {
            this.LoadDate();
            this.bRun = true;
        }
    }
}
