using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GSSystem.Web.Search
{
    public partial class SearchTime : System.Web.UI.Page
    {
        protected string PagerBar { get; set; }
        SqlConnection sqlcon;
        //string strCon = "server=.;database=GroundSourceSystem;uid=sa;pwd=123";
        string strCon = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];
        protected void Page_Load(object sender, EventArgs e)
        {
            GSSystem.BLL.ProjectCommonCity umBll = new GSSystem.BLL.ProjectCommonCity();

            int pageIndex = 1;
            int pageSize = 10;

            //接收分页信息
            if (!string.IsNullOrEmpty(Request["pIndex"]))
            {
                pageIndex = int.Parse(Request["pIndex"]);
            }
            //验证分页的有效性
            int rowsCount = umBll.GetRecordCount("");
            int pageCount = Convert.ToInt32(Math.Ceiling(rowsCount * 1.0 / pageSize));
            if (pageIndex <= 1)
            {
                pageIndex = 1;
            }
            if (pageIndex >= pageCount)
            {
                pageIndex = pageCount;
            }

            //查询当前页的数据
            int startIndex = (pageIndex - 1) * pageSize + 1;
            int endIndex = pageIndex * pageSize;
            Repeater1.DataSource = umBll.GetListByPage("", "id", startIndex, endIndex);
            Repeater1.DataBind();

            //构建分类字符串
            StringBuilder sb = new StringBuilder();

            //首页 上一页
            if (pageIndex <= 1)
            {
                sb.Append("首页 上一页 ");
            }
            else
            {
                sb.Append("<a href='?pIndex=1'>首页</a> <a href='?pIndex=" + (pageIndex - 1) + "'>上一页</a> ");
            }

            //下一页 末页
            if (pageIndex >= pageCount)
            {
                sb.Append("下一页 末页");
            }
            else
            {
                sb.Append("<a href='?pIndex=" + (pageIndex + 1) + "'>下一页</a> <a href='?pIndex=" + pageCount + "'>末页</a>");
            }

            PagerBar = sb.ToString();
        }

        protected void btnSel_Click(object sender, EventArgs e)
        {
            if(txtKey.Text =="")
            {
                Response.Write("<script>alert('请输入日期！');</script>");
            }
            else
            {
                DateTime MyDate = Convert.ToDateTime(txtKey.Text.ToString());
                string sqlstr = "select * from ProjectCommonCity where FinTime='" + MyDate + "'";
                sqlcon = new SqlConnection(strCon);
                SqlDataAdapter myda = new SqlDataAdapter(sqlstr, sqlcon);
                DataSet myds = new DataSet();
                sqlcon.Open();
                myda.Fill(myds);
                Repeater1.DataSource = myds;
                Repeater1.DataBind();
                sqlcon.Close();
            }            
        }
    }
}