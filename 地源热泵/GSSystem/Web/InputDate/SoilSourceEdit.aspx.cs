using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GSSystem.Web.InputDate
{
    public partial class SoilSourceEdit : System.Web.UI.Page
    {
        protected GSSystem.Model.SoilSource BiModel { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = int.Parse(Request["id"]);
                GSSystem.BLL.SoilSource biBll = new GSSystem.BLL.SoilSource();
                BiModel = biBll.GetModel(id);
            }
            else
            {
                BiModel = new GSSystem.Model.SoilSource();
                BiModel.id = int.Parse(Request["id"]);
                BiModel.ProName = Request["ProName"];
                BiModel.WType = Request["WType"];
                BiModel.PHoleNum = Request["PHoleNum"];
                BiModel.HoleDepth = Request["HoleDepth"];
                BiModel.HoleDistance = Request["HoleDistance"];

                BiModel.UHEMaterial = Request["UHEMaterial"];
                BiModel.UHEDiameter = Request["UHEDiameter"];
                BiModel.HeatTime = Request["HeatTime"];
                BiModel.CoolTime = Request["CoolTime"];
                BiModel.BPFormat = Request["BPFormat"];

                BiModel.UHEUType = Request["UHEUType"];
                BiModel.UHESparallel = Request["UHESparallel"];

                BiModel.UHETotalLen = Request["UHETotalLen"];
                BiModel.WTIModel = Request["WTIModel"];
                BiModel.CPETModel = Request["CPETModel"];
                BiModel.CPETNum = Request["CPETNum"];
                BiModel.FWTSize = Request["FWTSize"];

                BiModel.WSPNum = Request["WSPNum"];
                BiModel.WSPPower = Request["WSPPower"];
                BiModel.PVFreque = Request["PVFreque"];    

                GSSystem.BLL.SoilSource biBll = new GSSystem.BLL.SoilSource();

                if (biBll.Update(BiModel))
                {
                    Response.Redirect("SoilSource.aspx");
                }
                else
                {
                    Response.Write("修改失败，请稍候重试");
                }
            }
        }
    }
}