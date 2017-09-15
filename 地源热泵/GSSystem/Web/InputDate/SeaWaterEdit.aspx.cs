using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GSSystem.Web.InputDate
{
    public partial class SeaWaterEdit : System.Web.UI.Page
    {
        protected GSSystem.Model.SeaWater BiModel { get; set; }
       protected void Page_Load(object sender, EventArgs e)
       {
           if (!IsPostBack)
           {
               int id = int.Parse(Request["id"]);
               GSSystem.BLL.SeaWater biBll = new GSSystem.BLL.SeaWater();
               BiModel = biBll.GetModel(id);
           }
           else
           {
               BiModel = new GSSystem.Model.SeaWater();
               BiModel.id = int.Parse(Request["id"]);
               BiModel.ProName = Request["ProName"];
               BiModel.WType = Request["WType"];
               BiModel.Type = Request["Type"];
               BiModel.Dowtherm = Request["Dowtherm"];
               BiModel.SWWellNum = Request["SWWellNum"];

               BiModel.SWWellDep = Request["SWWellDep"];
               BiModel.CWPNum =Request["CWPNum"];
               BiModel.CWPHead = Request["CWPHead"];
               BiModel.CWPFlow = Request["CWPFlow"];
               BiModel.CWPPower = Request["CWPPower"];

               BiModel.ExHeatType = Request["ExHeatType"];
               BiModel.ExHeatNum = Request["ExHeatNum"];

               BiModel.ExHeatArea =Request["ExHeatArea"];
               BiModel.SWInTemp =Request["SWInTemp"];
               BiModel.SWOutTemp = Request["SWOutTemp"];
               BiModel.SeaWaterFlow =Request["SeaWaterFlow"];
               BiModel.DesanderNum = Request["DesanderNum"];

               BiModel.DesanderType = Request["DesanderType"];
               BiModel.SoftWTSize = Request["SoftWTSize"];
               BiModel.SoftWType = Request["SoftWType"];
               BiModel.WPNum = Request["WPNum"];
               BiModel.WPpower = Request["WPpower"];
               BiModel.PVariableFre = Request["PVariableFre"];

               GSSystem.BLL.SeaWater biBll = new GSSystem.BLL.SeaWater();

               if (biBll.Update(BiModel))
               {
                   Response.Redirect("SeaWater.aspx");
               }
               else
               {
                   Response.Write("修改失败，请稍候重试");
               }
           }
       }
    }
}