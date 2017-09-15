using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GSSystem.Web.InputDate
{
    public partial class SeaWater1 : System.Web.UI.Page
    {
        protected string PageBar { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            GSSystem.BLL.SeaWater biBll = new GSSystem.BLL.SeaWater();
            int pageIndex = 1, pageSize = 5;
            //接收分页信息
            if (!string.IsNullOrEmpty(Request["pIndex"]))
            {
                pageIndex = int.Parse(Request["pIndex"]);
            }

            int rowsCount = biBll.GetRecordCount("");//查询总行数
            int pageCount = Convert.ToInt32(Math.Ceiling(rowsCount * 1.0 / pageSize));//计算总页数

            //验证分页的有效性
            if (pageIndex <= 1)
            {
                pageIndex = 1;
            }
            if (pageIndex >= pageCount)
            {
                pageIndex = pageCount;
            }
            //查询当前页
            int startIndex = (pageIndex - 1) * pageSize + 1;
            int endIndex = pageIndex * pageSize;
            //顺序排
            //Repeater1.DataSource = biBll.GetListByPage("", "bid", startIndex, endIndex);
            //逆序排
            Repeater1.DataSource = biBll.GetListByPage("", " ", startIndex, endIndex);
            Repeater1.DataBind();
            PageBar = GSSystem.DBUtility.PageHelper.GetNumberPage(pageIndex, pageCount);
        }
    }
}