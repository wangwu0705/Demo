using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GSSystem.Web.InputDate
{
    public partial class SeaWater : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                GSSystem.Model.SeaWater biModel = new GSSystem.Model.SeaWater();          
                biModel.ProName = Request["ProName"];
                biModel.WType = Request["WType"];
                biModel.Type = Request["Type"];
                biModel.Dowtherm = Request["Dowtherm"];
                biModel.SWWellNum = Request["SWWellNum"];

                biModel.SWWellDep = Request["SWWellDep"];
                biModel.CWPNum = Request["CWPNum"];
                biModel.CWPHead = Request["CWPHead"];
                biModel.CWPFlow = Request["CWPFlow"];
                biModel.CWPPower = Request["CWPPower"];

                biModel.ExHeatType = Request["ExHeatType"];
                biModel.ExHeatNum = Request["ExHeatNum"];

                biModel.ExHeatArea = Request["ExHeatArea"];
                biModel.SWInTemp = Request["SWInTemp"];
                biModel.SWOutTemp = Request["SWOutTemp"];
                biModel.SeaWaterFlow = Request["SeaWaterFlow"];
                biModel.DesanderNum = Request["DesanderNum"];

                biModel.DesanderType = Request["DesanderType"];
                biModel.SoftWTSize = Request["SoftWTSize"];
                biModel.SoftWType = Request["SoftWType"];
                biModel.WPNum = Request["WPNum"];
                biModel.WPpower = Request["WPpower"];
                biModel.PVariableFre = Request["PVariableFre"];

                GSSystem.BLL.SeaWater biBll = new GSSystem.BLL.SeaWater();
                if (biBll.Add(biModel) > 0)
                {
                    Response.Redirect("SeaWater.aspx");
                }
                else
                {
                    Response.Write("添加失败，请稍候重试");
                }
            }
        }
    }
}