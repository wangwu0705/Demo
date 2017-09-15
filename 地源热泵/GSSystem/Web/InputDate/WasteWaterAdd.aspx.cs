using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GSSystem.Web.InputDate
{
    public partial class WasteWater : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                GSSystem.Model.WasteWater biModel = new GSSystem.Model.WasteWater();
                biModel.ProName = Request["ProName"];
                biModel.WType = Request["WType"];
                biModel.Type = Request["Type"];
                biModel.Dowtherm = Request["Dowtherm"];
                biModel.SPNum = Request["SPNum"];
                biModel.SPHead = Request["SPHead"];

                biModel.SPFlow = Request["SPFlow"];
                biModel.SPPower = Request["SPPower"];
                biModel.HEType = Request["HEType"];
                biModel.HENum = Request["HENum"];
                biModel.HEHEArea = Request["HEHEArea"];

                biModel.SInTemp = Request["SInTemp"];
                biModel.SOutTemp = Request["SOutTemp"];

                biModel.SFlow = Request["SFlow"];
                biModel.WTIModel = Request["WTIModel"];
                biModel.CPETMode = Request["CPETMode"];
                biModel.CPETNum = Request["CPETNum"];
                biModel.FWTSize = Request["FWTSize"];

                biModel.WSPNum = Request["WSPNum"];
                biModel.WSPPower = Request["WSPPower"];
                biModel.PVFrequ = Request["PVFrequ"];

                GSSystem.BLL.WasteWater biBll = new GSSystem.BLL.WasteWater();
                if (biBll.Add(biModel) > 0)
                {
                    Response.Redirect("WasteWater.aspx");
                }
                else
                {
                    Response.Write("添加失败，请稍候重试");
                }
            }
        }
    }
}