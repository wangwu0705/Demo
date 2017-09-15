using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GSSystem.Web.InputDate
{
    public partial class HSSCPEdit : System.Web.UI.Page
    {
        protected GSSystem.Model.HSSCP BiModel { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = int.Parse(Request["id"]);
                GSSystem.BLL.HSSCP biBll = new GSSystem.BLL.HSSCP();
                BiModel = biBll.GetModel(id);
            }
            else
            {
                BiModel = new GSSystem.Model.HSSCP();
                BiModel.id = int.Parse(Request["id"]);
                BiModel.ProName = Request["ProName"];
                BiModel.WType = Request["WType"];
                BiModel.HSSCPNum = int.Parse(Request["HSSCPNum"]);
                BiModel.HSSCPPower = Request["HSSCPPower"];
                BiModel.HSSCPHead = Request["HSSCPHead"];
                BiModel.HSSCPFlow = Request["HSSCPFlow"];


                GSSystem.BLL.HSSCP biBll = new GSSystem.BLL.HSSCP();

                if (biBll.Update(BiModel))
                {
                    Response.Redirect("HSSCP.aspx");
                }
                else
                {
                    Response.Write("修改失败，请稍候重试");
                }
            }
        }
    }
}