using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GSSystem.Web.InputDate
{
    public partial class USCP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                GSSystem.Model.USCP biModel = new GSSystem.Model.USCP();
                biModel.ProName = Request["ProName"];
                biModel.WType = Request["WType"];
                biModel.USCPNum = int.Parse(Request["USCPNum"]);
                biModel.USCPPower = Request["USCPPower"];
                biModel.USCPHead = Request["USCPHead"];
                biModel.USCPFlow = Request["USCPFlow"];

                GSSystem.BLL.USCP biBll = new GSSystem.BLL.USCP();
                if (biBll.Add(biModel) > 0)
                {
                    Response.Redirect("USCP.aspx");
                }
                else
                {
                    Response.Write("添加失败，请稍候重试");
                }
            }
        }
    }
}