using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GSSystem.Web.InputDate
{
    public partial class SoilSource : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                GSSystem.Model.SoilSource biModel = new GSSystem.Model.SoilSource();
                biModel.ProName = Request["ProName"];
                biModel.WType = Request["WType"];
                biModel.PHoleNum = Request["PHoleNum"];
                biModel.HoleDepth = Request["HoleDepth"];
                biModel.HoleDistance = Request["HoleDistance"];

                biModel.UHEMaterial = Request["UHEMaterial"];
                biModel.UHEDiameter = Request["UHEDiameter"];
                biModel.HeatTime = Request["HeatTime"];
                biModel.CoolTime = Request["CoolTime"];
                biModel.BPFormat = Request["BPFormat"];

                biModel.UHEUType = Request["UHEUType"];
                biModel.UHESparallel = Request["UHESparallel"];

                biModel.UHETotalLen = Request["UHETotalLen"];
                biModel.WTIModel = Request["WTIModel"];
                biModel.CPETModel = Request["CPETModel"];
                biModel.CPETNum = Request["CPETNum"];
                biModel.FWTSize = Request["FWTSize"];

                biModel.WSPNum = Request["WSPNum"];
                biModel.WSPPower = Request["WSPPower"];
                biModel.PVFreque = Request["PVFreque"];          

                GSSystem.BLL.SoilSource biBll = new GSSystem.BLL.SoilSource();
                if (biBll.Add(biModel) > 0)
                {
                    Response.Redirect("SoilSource.aspx");
                }
                else
                {
                    Response.Write("添加失败，请稍候重试");
                }
            }
        }
    }
}