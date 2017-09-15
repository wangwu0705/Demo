using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GSSystem.Web.InputDate
{
    public partial class ProjectCostEdit : System.Web.UI.Page
    {
        protected GSSystem.Model.ProjectCost BiModel { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = int.Parse(Request["id"]);
                GSSystem.BLL.ProjectCost biBll = new GSSystem.BLL.ProjectCost();
                BiModel = biBll.GetModel(id);
            }
            else
            {
                BiModel = new GSSystem.Model.ProjectCost();
                BiModel.id = int.Parse(Request["id"]);
                BiModel.ProName = Request["ProName"];
                BiModel.WType = Request["WType"];
                BiModel.ProTotalCost =Request["ProTotalCost"];
                BiModel.UnitCost = Request["UnitCost"];
                BiModel.SystemCost = Request["SystemCost"];
                BiModel.ProTel = Request["ProTel"];


                GSSystem.BLL.ProjectCost biBll = new GSSystem.BLL.ProjectCost();

                if (biBll.Update(BiModel))
                {
                    Response.Redirect("ProjectCost.aspx");
                }
                else
                {
                    Response.Write("修改失败，请稍候重试");
                }
            }
        }
    }
}