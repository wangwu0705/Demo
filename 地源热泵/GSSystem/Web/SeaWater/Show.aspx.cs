using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
namespace GSSystem.Web.SeaWater
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int id=(Convert.ToInt32(strid));
					ShowInfo(id);
				}
			}
		}
		
	private void ShowInfo(int id)
	{
		GSSystem.BLL.SeaWater bll=new GSSystem.BLL.SeaWater();
		GSSystem.Model.SeaWater model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblProName.Text=model.ProName;
		this.lblWType.Text=model.WType;
		this.lblType.Text=model.Type;
		this.lblDowtherm.Text=model.Dowtherm;
		this.lblSWWellNum.Text=model.SWWellNum;
		this.lblSWWellDep.Text=model.SWWellDep;
		this.lblCWPNum.Text=model.CWPNum;
		this.lblCWPHead.Text=model.CWPHead;
		this.lblCWPFlow.Text=model.CWPFlow;
		this.lblCWPPower.Text=model.CWPPower;
		this.lblExHeatType.Text=model.ExHeatType;
		this.lblExHeatNum.Text=model.ExHeatNum;
		this.lblExHeatArea.Text=model.ExHeatArea;
		this.lblSWInTemp.Text=model.SWInTemp;
		this.lblSWOutTemp.Text=model.SWOutTemp;
		this.lblSeaWaterFlow.Text=model.SeaWaterFlow;
		this.lblDesanderNum.Text=model.DesanderNum;
		this.lblDesanderType.Text=model.DesanderType;
		this.lblSoftWTSize.Text=model.SoftWTSize;
		this.lblSoftWType.Text=model.SoftWType;
		this.lblWPNum.Text=model.WPNum;
		this.lblWPpower.Text=model.WPpower;
		this.lblPVariableFre.Text=model.PVariableFre;

	}


    }
}
