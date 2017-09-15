using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GSSystem.Web.InputDate
{
    public partial class WinterType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                GSSystem.Model.WinterType biModel = new GSSystem.Model.WinterType();
                biModel.ProName = Request["ProName"];
                biModel.WType = Request["WType"];
                biModel.WWPWTemp = Request["WWPWTemp"];
                biModel.WWRWTemp = Request["WWRWTemp"];
                biModel.WHSSInWTemp = Request["WHSSInWTemp"];

                biModel.WHSSBackWTemp = Request["WHSSBackWTemp"];
                biModel.WHSSCWater = Request["WHSSCWater"];
                biModel.WUEWSTemp = Request["WUEWSTemp"];
                biModel.WUEBWTemp = Request["WUEBWTemp"];
                biModel.WUECircul = Request["WUECircul"];
                biModel.WRTempeRange = Request["WRTempeRange"];             
    
                GSSystem.BLL.WinterType biBll = new GSSystem.BLL.WinterType();
                if (biBll.Add(biModel) > 0)
                {
                    Response.Redirect("WinterType.aspx");
                }
                else
                {
                    Response.Write("添加失败，请稍候重试");
                }
            }
        }
    }
}