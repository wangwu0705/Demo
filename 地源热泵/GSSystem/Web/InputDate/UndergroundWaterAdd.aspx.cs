using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GSSystem.Web.InputDate
{
    public partial class UndergroundWater : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                GSSystem.Model.UndergroundWater biModel = new GSSystem.Model.UndergroundWater();
                biModel.ProName = Request["ProName"];
                biModel.WType = Request["WType"];
                biModel.WellNum = Request["WellNum"];
                biModel.WEWNum = Request["WEWNum"];
                biModel.RWNum = Request["RWNum"];
                biModel.WellDepth = Request["WellDepth"];

                biModel.SWWExtract = Request["SWWExtract"];
                biModel.HeatTime = Request["HeatTime"];
                biModel.CoolTime = Request["CoolTime"];
                biModel.WPDiameter = Request["WPDiameter"];
                biModel.WPipe = Request["WPipe"];

                biModel.BWPDiameter = Request["BWPDiameter"];
                biModel.BWPipe = Request["BWPipe"];

                biModel.DModel = Request["DModel"];
                biModel.WTIModel = Request["WTIModel"];
                biModel.CPETModel = Request["CPETModel"];
                biModel.CPETNum = Request["CPETNum"];
                biModel.FWTSize = Request["FWTSize"];

                biModel.WSPNum = Request["WSPNum"];
                biModel.WPPower = Request["WPPower"];
                biModel.PVFreque = Request["PVFreque"];

                GSSystem.BLL.UndergroundWater biBll = new GSSystem.BLL.UndergroundWater();
                if (biBll.Add(biModel) > 0)
                {
                    Response.Redirect("UndergroundWater.aspx");
                }
                else
                {
                    Response.Write("添加失败，请稍候重试");
                }
            }
        }
    }
}