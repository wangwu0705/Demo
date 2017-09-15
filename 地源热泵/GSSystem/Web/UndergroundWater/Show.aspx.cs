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
namespace GSSystem.Web.UndergroundWater
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
		GSSystem.BLL.UndergroundWater bll=new GSSystem.BLL.UndergroundWater();
		GSSystem.Model.UndergroundWater model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblProName.Text=model.ProName;
		this.lblWType.Text=model.WType;
		this.lblWellNum.Text=model.WellNum;
		this.lblWEWNum.Text=model.WEWNum;
		this.lblRWNum.Text=model.RWNum;
		this.lblWellDepth.Text=model.WellDepth;
		this.lblSWWExtract.Text=model.SWWExtract;
		this.lblHeatTime.Text=model.HeatTime;
		this.lblCoolTime.Text=model.CoolTime;
		this.lblWPDiameter.Text=model.WPDiameter;
		this.lblWPipe.Text=model.WPipe;
		this.lblBWPDiameter.Text=model.BWPDiameter;
		this.lblBWPipe.Text=model.BWPipe;
		this.lblDModel.Text=model.DModel;
		this.lblWTIModel.Text=model.WTIModel;
		this.lblCPETModel.Text=model.CPETModel;
		this.lblCPETNum.Text=model.CPETNum;
		this.lblFWTSize.Text=model.FWTSize;
		this.lblWSPNum.Text=model.WSPNum;
		this.lblWPPower.Text=model.WPPower;
		this.lblPVFreque.Text=model.PVFreque;

	}


    }
}
