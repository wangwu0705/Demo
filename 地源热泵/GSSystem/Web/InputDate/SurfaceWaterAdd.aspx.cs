using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GSSystem.Web.InputDate
{
    public partial class SurfaceWater : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                GSSystem.Model.SurfaceWater biModel = new GSSystem.Model.SurfaceWater();
                biModel.ProName = Request["ProName"];
                biModel.WType = Request["WType"];
                biModel.Type = Request["Type"];
                biModel.Dowtherm = Request["Dowtherm "];
                biModel.WPNum = Request["WPNum"];
                biModel.WPHead = Request["WPHead"];

                biModel.WPFlow = Request["WPFlow"];
                biModel.WPPower = Request["WPPower"];
                biModel.HEType = Request["HEType"];
                biModel.HENum = Request["HENum"];
                biModel.HEHeatArea = Request["HEHeatArea"];

                biModel.SWITemp = Request["SWITemp"];
                biModel.SWOTemp = Request["SWOTemp"];

                biModel.SWFlow = Request["SWFlow"];
                biModel.DNum = Request["DNum"];
                biModel.DType = Request["DType"];
                biModel.SWTSize = Request["SWTSize"];
                biModel.SWTType = Request["SWTType"];

                biModel.WSPNum = Request["WSPNum"];
                biModel.WSPPower = Request["WSPPower"];
                biModel.PVFrequ = Request["PVFrequ"];

                GSSystem.BLL.SurfaceWater biBll = new GSSystem.BLL.SurfaceWater();
                if (biBll.Add(biModel) > 0)
                {
                    Response.Redirect("SurfaceWater.aspx");
                }
                else
                {
                    Response.Write("添加失败，请稍候重试");
                }
            }
        }
    }
}