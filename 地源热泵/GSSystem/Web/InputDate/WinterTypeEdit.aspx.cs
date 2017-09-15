using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GSSystem.Web.InputDate
{
    public partial class WinterTypeEdit : System.Web.UI.Page
    {
        protected GSSystem.Model.WinterType BiModel { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = int.Parse(Request["id"]);
                GSSystem.BLL.WinterType biBll = new GSSystem.BLL.WinterType();
                BiModel = biBll.GetModel(id);
            }
            else
            {
                BiModel = new GSSystem.Model.WinterType();
                BiModel.id = int.Parse(Request["id"]);
                BiModel.ProName = Request["ProName"];
                BiModel.WType = Request["WType"];
                BiModel.WWPWTemp = Request["WWPWTemp"];
                BiModel.WWRWTemp = Request["WWRWTemp"];
                BiModel.WHSSInWTemp = Request["WHSSInWTemp"];

                BiModel.WHSSBackWTemp = Request["WHSSBackWTemp"];
                BiModel.WHSSCWater = Request["WHSSCWater"];
                BiModel.WUEWSTemp = Request["WUEWSTemp"];
                BiModel.WUEBWTemp = Request["WUEBWTemp"];
                BiModel.WUECircul = Request["WUECircul"];
                BiModel.WRTempeRange = Request["WRTempeRange"];

                GSSystem.BLL.WinterType biBll = new GSSystem.BLL.WinterType();

                if (biBll.Update(BiModel))
                {
                    Response.Redirect("WinterType.aspx");
                }
                else
                {
                    Response.Write("修改失败，请稍候重试");
                }
            }
        }
    }
}