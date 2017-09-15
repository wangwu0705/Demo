using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GSSystem.Web.InputDate
{
    public partial class WasteWaterEdit : System.Web.UI.Page
    {
        protected GSSystem.Model.WasteWater BiModel { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = int.Parse(Request["id"]);
                GSSystem.BLL.WasteWater biBll = new GSSystem.BLL.WasteWater();
                BiModel = biBll.GetModel(id);
            }
            else
            {
                BiModel = new GSSystem.Model.WasteWater();
                BiModel.id = int.Parse(Request["id"]);
                BiModel.ProName = Request["ProName"];
                BiModel.WType = Request["WType"];
                BiModel.Type = Request["Type"];
                BiModel.Dowtherm = Request["Dowtherm"];
                BiModel.SPNum = Request["SPNum"];
                BiModel.SPHead = Request["SPHead"];

                BiModel.SPFlow = Request["SPFlow"];
                BiModel.SPPower = Request["SPPower"];
                BiModel.HEType = Request["HEType"];
                BiModel.HENum = Request["HENum"];
                BiModel.HEHEArea = Request["HEHEArea"];

                BiModel.SInTemp = Request["SInTemp"];
                BiModel.SOutTemp = Request["SOutTemp"];

                BiModel.SFlow = Request["SFlow"];
                BiModel.WTIModel = Request["WTIModel"];
                BiModel.CPETMode = Request["CPETMode"];
                BiModel.CPETNum = Request["CPETNum"];
                BiModel.FWTSize = Request["FWTSize"];

                BiModel.WSPNum = Request["WSPNum"];
                BiModel.WSPPower = Request["WSPPower"];
                BiModel.PVFrequ = Request["PVFrequ"];

                GSSystem.BLL.WasteWater biBll = new GSSystem.BLL.WasteWater();

                if (biBll.Update(BiModel))
                {
                    Response.Redirect("WasteWater.aspx");
                }
                else
                {
                    Response.Write("修改失败，请稍候重试");
                }
            }
        }
    }
}