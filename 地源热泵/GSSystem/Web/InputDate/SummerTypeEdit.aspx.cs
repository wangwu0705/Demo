using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GSSystem.Web.InputDate
{
    public partial class SummerTypeEdit : System.Web.UI.Page
    {
        protected GSSystem.Model.SummerType BiModel { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = int.Parse(Request["id"]);
                GSSystem.BLL.SummerType biBll = new GSSystem.BLL.SummerType();
                BiModel = biBll.GetModel(id);
            }
            else
            {
                BiModel = new GSSystem.Model.SummerType();
                BiModel.id = int.Parse(Request["id"]);
                BiModel.ProName = Request["ProName"];
                BiModel.WType = Request["WType"];
                BiModel.SHSSInWTemp = Request["SHSSInWTemp"];
                BiModel.SHSSBackWTemp = Request["SHSSBackWTemp"];
                BiModel.SHSSCWater = Request["SHSSCWater"];

                BiModel.SUEWSTemp = Request["SUEWSTemp"];
                BiModel.SUEBWTemp = Request["SUEBWTemp"];
                BiModel.SUECircul = Request["SUECircul"];
                BiModel.SRTempRange = Request["SRTempRange"];

                GSSystem.BLL.SummerType biBll = new GSSystem.BLL.SummerType();

                if (biBll.Update(BiModel))
                {
                    Response.Redirect("SummerType.aspx");
                }
                else
                {
                    Response.Write("修改失败，请稍候重试");
                }
            }
        }
    }
}