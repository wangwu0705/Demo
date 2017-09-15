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
namespace GSSystem.Web.SurfaceWater
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
		GSSystem.BLL.SurfaceWater bll=new GSSystem.BLL.SurfaceWater();
		GSSystem.Model.SurfaceWater model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblProName.Text=model.ProName;
		this.lblWType.Text=model.WType;
		this.lblType.Text=model.Type;
		this.lblDowtherm.Text=model.Dowtherm;
		this.lblWPNum.Text=model.WPNum;
		this.lblWPHead.Text=model.WPHead;
		this.lblWPFlow.Text=model.WPFlow;
		this.lblWPPower.Text=model.WPPower;
		this.lblHEType.Text=model.HEType;
		this.lblHENum.Text=model.HENum;
		this.lblHEHeatArea.Text=model.HEHeatArea;
		this.lblSWITemp.Text=model.SWITemp;
		this.lblSWOTemp.Text=model.SWOTemp;
		this.lblSWFlow.Text=model.SWFlow;
		this.lblDNum.Text=model.DNum;
		this.lblDType.Text=model.DType;
		this.lblSWTSize.Text=model.SWTSize;
		this.lblSWTType.Text=model.SWTType;
		this.lblWSPNum.Text=model.WSPNum;
		this.lblWSPPower.Text=model.WSPPower;
		this.lblPVFrequ.Text=model.PVFrequ;

	}


    }
}
