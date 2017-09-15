using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GSSystem.Web.InputDate
{
    public partial class ProjectCommonCity : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                GSSystem.Model.ProjectCommonCity biModel = new GSSystem.Model.ProjectCommonCity();
                biModel.ProName = Request["ProName"];
                biModel.WType = Request["WType"];
                biModel.ProAdd = Request["ProAdd"];
                biModel.DetailAdd = Request["DetailAdd"];
                biModel.ProType = Request["ProType"];
                biModel.ConUnit = Request["ConUnit"];

                biModel.HpManufacturer = Request["HpManufacturer"];
                biModel.FinTime = Convert.ToDateTime(Request["FinTime"]);
                biModel.CoveredArea = Request["CoveredArea"];
                biModel.HpType= Request["HpType"];
                biModel.EngCharacter = Request["EngCharacter"];

                biModel.UseFormat = Request["UseFormat"];
                biModel.TerminalForm = Request["TerminalForm"];

                biModel.ProjectTHHp =int.Parse(Request["ProjectTHHp"]);
                biModel.ProjectTCHp = int.Parse(Request["ProjectTCHp"]);
                biModel.HpEquipmentType = Request["HpEquipmentType"];
                biModel.HpEquipmentNum = int.Parse(Request["HpEquipmentNum"]);
                biModel.NominalHeat = Request["NominalHeat"];

                biModel.NominalCool = Request["NominalCool"];
                biModel.HeatInputPower = Request["HeatInputPower"];
                biModel.CoolInputPower = Request["CoolInputPower"];

                GSSystem.BLL.ProjectCommonCity biBll = new GSSystem.BLL.ProjectCommonCity();
                if (biBll.Add(biModel) > 0)
                {
                    Response.Redirect("ProjectCommonCity.aspx");
                }
                else
                {
                    Response.Write("添加失败，请稍候重试");
                }
            }
        }
    }
}