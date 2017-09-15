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
namespace GSSystem.Web.SoilSource
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
		GSSystem.BLL.SoilSource bll=new GSSystem.BLL.SoilSource();
		GSSystem.Model.SoilSource model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblProName.Text=model.ProName;
		this.lblWType.Text=model.WType;
		this.lblPHoleNum.Text=model.PHoleNum;
		this.lblHoleDepth.Text=model.HoleDepth;
		this.lblHoleDistance.Text=model.HoleDistance;
		this.lblUHEMaterial.Text=model.UHEMaterial;
		this.lblUHEDiameter.Text=model.UHEDiameter;
		this.lblHeatTime.Text=model.HeatTime;
		this.lblCoolTime.Text=model.CoolTime;
		this.lblBPFormat.Text=model.BPFormat;
		this.lblUHEUType.Text=model.UHEUType;
		this.lblUHESparallel.Text=model.UHESparallel;
		this.lblUHETotalLen.Text=model.UHETotalLen;
		this.lblWTIModel.Text=model.WTIModel;
		this.lblCPETModel.Text=model.CPETModel;
		this.lblCPETNum.Text=model.CPETNum;
		this.lblFWTSize.Text=model.FWTSize;
		this.lblWSPNum.Text=model.WSPNum;
		this.lblWSPPower.Text=model.WSPPower;
		this.lblPVFreque.Text=model.PVFreque;

	}


    }
}
