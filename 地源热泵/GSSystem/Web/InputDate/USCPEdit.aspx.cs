using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GSSystem.Web.InputDate
{
    public partial class USCPEdit : System.Web.UI.Page
    {
        protected GSSystem.Model.USCP BiModel { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
             if (!IsPostBack)
            {
                int id = int.Parse(Request["id"]);
                GSSystem.BLL.USCP biBll = new GSSystem.BLL.USCP();
                BiModel = biBll.GetModel(id);
            }
            else
            {
                BiModel = new GSSystem.Model.USCP();
                BiModel.id = int.Parse(Request["id"]);
                BiModel.ProName = Request["ProName"];
                BiModel.WType = Request["WType"];
                BiModel.USCPNum = int.Parse(Request["USCPNum"]);
                BiModel.USCPPower = Request["USCPPower"];
                BiModel.USCPHead = Request["USCPHead"];
                BiModel.USCPFlow = Request["USCPFlow"];


                GSSystem.BLL.USCP biBll = new GSSystem.BLL.USCP();

                if (biBll.Update(BiModel))
                {
                    Response.Redirect("USCP.aspx");
                }
                else
                {
                    Response.Write("修改失败，请稍候重试");
                }
            }
        }
    }
}