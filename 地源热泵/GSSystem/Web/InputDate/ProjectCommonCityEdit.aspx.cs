using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GSSystem.Web.InputDate
{
    public partial class ProjectCommonCityEdit : System.Web.UI.Page
    {
        protected GSSystem.Model.ProjectCommonCity BiModel { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = int.Parse(Request["id"]);
                GSSystem.BLL.ProjectCommonCity biBll = new GSSystem.BLL.ProjectCommonCity();
                BiModel = biBll.GetModel(id);
            }
            else
            {
                BiModel = new GSSystem.Model.ProjectCommonCity();
                BiModel.id = int.Parse(Request["id"]);
                BiModel.ProName = Request["ProName"];
                BiModel.WType = Request["WType"];
                BiModel.ProAdd = Request["ProAdd"];
                BiModel.DetailAdd = Request["DetailAdd"];
                BiModel.ProType = Request["ProType"];
                BiModel.ConUnit = Request["ConUnit"];

                BiModel.HpManufacturer = Request["HpManufacturer"];
                BiModel.FinTime = Convert.ToDateTime(Request["FinTime"]);
                BiModel.CoveredArea = Request["CoveredArea"];
                BiModel.HpType = Request["HpType"];
                BiModel.EngCharacter = Request["EngCharacter"];

                BiModel.UseFormat = Request["UseFormat"];
                BiModel.TerminalForm = Request["TerminalForm"];

                BiModel.ProjectTHHp = int.Parse(Request["ProjectTHHp"]);
                BiModel.ProjectTCHp = int.Parse(Request["ProjectTCHp"]);
                BiModel.HpEquipmentType = Request["HpEquipmentType"];
                BiModel.HpEquipmentNum = int.Parse(Request["HpEquipmentNum"]);
                BiModel.NominalHeat = Request["NominalHeat"];

                BiModel.NominalCool = Request["NominalCool"];
                BiModel.HeatInputPower = Request["HeatInputPower"];
                BiModel.CoolInputPower = Request["CoolInputPower"];

                GSSystem.BLL.ProjectCommonCity biBll = new GSSystem.BLL.ProjectCommonCity();

                if (biBll.Update(BiModel))
                {
                    Response.Redirect("ProjectCommonCity.aspx");
                }
                else
                {
                    Response.Write("修改失败，请稍候重试");
                }
            }
        }
    }
}