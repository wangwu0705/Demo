using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GSSystem.Web.InputDate
{
    public partial class UndergroundWaterEdit : System.Web.UI.Page
    {
        protected GSSystem.Model.UndergroundWater BiModel { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = int.Parse(Request["id"]);
                GSSystem.BLL.UndergroundWater biBll = new GSSystem.BLL.UndergroundWater();
                BiModel = biBll.GetModel(id);
            }
            else
            {
                BiModel = new GSSystem.Model.UndergroundWater();
                BiModel.id = int.Parse(Request["id"]);
                BiModel.ProName = Request["ProName"];
                BiModel.WType = Request["WType"];
                BiModel.WellNum = Request["WellNum"];
                BiModel.WEWNum = Request["WEWNum"];
                BiModel.RWNum = Request["RWNum"];
                BiModel.WellDepth = Request["WellDepth"];

                BiModel.SWWExtract = Request["SWWExtract"];
                BiModel.HeatTime = Request["HeatTime"];
                BiModel.CoolTime = Request["CoolTime"];
                BiModel.WPDiameter = Request["WPDiameter"];
                BiModel.WPipe = Request["WPipe"];

                BiModel.BWPDiameter = Request["BWPDiameter"];
                BiModel.BWPipe = Request["BWPipe"];

                BiModel.DModel = Request["DModel"];
                BiModel.WTIModel = Request["WTIModel"];
                BiModel.CPETModel = Request["CPETModel"];
                BiModel.CPETNum = Request["CPETNum"];
                BiModel.FWTSize = Request["FWTSize"];

                BiModel.WSPNum = Request["WSPNum"];
                BiModel.WPPower = Request["WPPower"];
                BiModel.PVFreque = Request["PVFreque"];

                GSSystem.BLL.UndergroundWater biBll = new GSSystem.BLL.UndergroundWater();

                if (biBll.Update(BiModel))
                {
                    Response.Redirect("UndergroundWater.aspx");
                }
                else
                {
                    Response.Write("修改失败，请稍候重试");
                }
            }
        }
    }
}