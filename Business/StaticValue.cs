using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Security.Cryptography;
using XLuSharpLibrary.DbAccess;
using BHair.Business.Table;
using BHair.Business.BaseData;

namespace BHair.Business
{
    /// <summary>全局静态数据。</summary>
    public static class StaticValue
    {
        /// <summary>(全局变量)临时消费明细表。</summary>
        public static List<PayDetail> g_lstTempPayDetails;

        /// <summary>(全局变量)消费折扣。</summary>
        public static double g_dBonus = 1;

        public static string g_strNewPayId = "";

        /// <summary>处理DataTable中重复的数据。</summary>
        /// <param name="dt">需要处理的DataTable</param>
        /// <param name="colname">作为判断重复数据的字段(字段名)</param>
        /// <returns></returns>
        public static DataTable GetDistinctTable(DataTable dt, string colname)
        {
            DataView dv = dt.DefaultView;
            DataTable dtCardNo = dv.ToTable(true, colname);
            DataTable dtPoint = new DataTable();
            dtPoint = dv.ToTable();
            dtPoint.Clear();
            for (int i = 0; i < dtCardNo.Rows.Count; i++)
            {
                DataRow dr = dt.Select(colname + "='" + dtCardNo.Rows[i][0].ToString() + "'")[0];
                dtPoint.Rows.Add(dr.ItemArray);
            }
            return dtPoint;
        }

        /// <summary>查询数据。</summary>
        /// <param name="sql">查询SQL</param>
        /// <returns></returns>
        public static DataTable SelectTable(string sql)
        {
            DataTable objDataTable = new DataTable();
            new SQLHelper().ExecuteSql(sql, out objDataTable);
            return objDataTable;
        }

        /// <summary>为 DataGridView 添加行号。</summary>
        public static void ShowRows_DataGridView_RowPostPaint(DataGridView dgv, object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dgv.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dgv.RowHeadersDefaultCellStyle.Font, rectangle, dgv.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>验证会员信息是否正确</summary>
        /// <param name="memberid">会员卡号</param>
        /// <returns></returns>
        public static string ValidateMember(string memberid)
        {
            try
            {
                Member objMember = new Member(memberid);
                return objMember.ID;
            }
            catch
            { }
            return "";
        }
    }
}
