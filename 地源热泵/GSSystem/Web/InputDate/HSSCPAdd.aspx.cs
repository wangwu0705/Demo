using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GSSystem.Web.InputDate
{
    public partial class HSSCP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                GSSystem.Model.HSSCP biModel = new GSSystem.Model.HSSCP();
                biModel.ProName = Request["ProName"];
                biModel.WType = Request["WType"];
                biModel.HSSCPNum = int.Parse(Request["HSSCPNum"]);
                biModel.HSSCPPower = Request["HSSCPPower"];
                biModel.HSSCPHead = Request["HSSCPHead"];
                biModel.HSSCPHead = Request["HSSCPFlow"];

                GSSystem.BLL.HSSCP biBll = new GSSystem.BLL.HSSCP();
                if (biBll.Add(biModel) > 0)
                {
                    Response.Redirect("HSSCP.aspx");
                }
                else
                {
                    Response.Write("添加失败，请稍候重试");
                }
            }
        }
    }
}