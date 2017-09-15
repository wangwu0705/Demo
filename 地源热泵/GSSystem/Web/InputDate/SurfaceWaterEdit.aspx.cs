using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GSSystem.Web.InputDate
{
    public partial class SurfaceWaterEdit : System.Web.UI.Page
    {
        protected GSSystem.Model.SurfaceWater BiModel { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = int.Parse(Request["id"]);
                GSSystem.BLL.SurfaceWater biBll = new GSSystem.BLL.SurfaceWater();
                BiModel = biBll.GetModel(id);
            }
            else
            {
                BiModel = new GSSystem.Model.SurfaceWater();
                BiModel.id = int.Parse(Request["id"]);
                BiModel.ProName = Request["ProName"];
                BiModel.WType = Request["WType"];
                BiModel.Type = Request["Type"];
                BiModel.Dowtherm = Request["Dowtherm "];
                BiModel.WPNum = Request["WPNum"];
                BiModel.WPHead = Request["WPHead"];

                BiModel.WPFlow = Request["WPFlow"];
                BiModel.WPPower = Request["WPPower"];
                BiModel.HEType = Request["HEType"];
                BiModel.HENum = Request["HENum"];
                BiModel.HEHeatArea = Request["HEHeatArea"];

                BiModel.SWITemp = Request["SWITemp"];
                BiModel.SWOTemp = Request["SWOTemp"];

                BiModel.SWFlow = Request["SWFlow"];
                BiModel.DNum = Request["DNum"];
                BiModel.DType = Request["DType"];
                BiModel.SWTSize = Request["SWTSize"];
                BiModel.SWTType = Request["SWTType"];

                BiModel.WSPNum = Request["WSPNum"];
                BiModel.WSPPower = Request["WSPPower"];
                BiModel.PVFrequ = Request["PVFrequ"];

                GSSystem.BLL.SurfaceWater biBll = new GSSystem.BLL.SurfaceWater();

                if (biBll.Update(BiModel))
                {
                    Response.Redirect("SoilSource.aspx");
                }
                else
                {
                    Response.Write("修改失败，请稍候重试");
                }
            }
        }
    }
}