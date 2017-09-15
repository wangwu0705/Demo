using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GSSystem.Web.InputDate
{
    public partial class SummerType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                GSSystem.Model.SummerType biModel = new GSSystem.Model.SummerType();
                biModel.ProName = Request["ProName"];
                biModel.WType = Request["WType"];
                biModel.SHSSInWTemp = Request["SHSSInWTemp"];
                biModel.SHSSBackWTemp = Request["SHSSBackWTemp"];
                biModel.SHSSCWater = Request["SHSSCWater"];

                biModel.SUEWSTemp = Request["SUEWSTemp"];
                biModel.SUEBWTemp = Request["SUEBWTemp"];
                biModel.SUECircul = Request["SUECircul"];
                biModel.SRTempRange = Request["SRTempRange"];

                GSSystem.BLL.SummerType biBll = new GSSystem.BLL.SummerType();
                if (biBll.Add(biModel) > 0)
                {
                    Response.Redirect("SummerType.aspx");
                }
                else
                {
                    Response.Write("添加失败，请稍候重试");
                }
            }
        }
    }
}