using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GSSystem.Web.InputDate
{
    public partial class ProjectCost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                GSSystem.Model.ProjectCost biModel = new GSSystem.Model.ProjectCost();
                biModel.ProName = Request["ProName"];
                biModel.WType = Request["WType"];
                biModel.ProTotalCost =Request["ProTotalCost"];
                biModel.UnitCost = Request["UnitCost"];
                biModel.SystemCost = Request["SystemCost"];
                biModel.ProTel = Request["ProTel"];

                GSSystem.BLL.ProjectCost biBll = new GSSystem.BLL.ProjectCost();
                if (biBll.Add(biModel) > 0)
                {
                    Response.Redirect("ProjectCost.aspx");
                }
                else
                {
                    Response.Write("添加失败，请稍候重试");
                }
            }
        }
    }
}