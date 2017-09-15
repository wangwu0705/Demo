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
namespace GSSystem.Web.WasteWater
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
		GSSystem.BLL.WasteWater bll=new GSSystem.BLL.WasteWater();
		GSSystem.Model.WasteWater model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblProName.Text=model.ProName;
		this.lblWType.Text=model.WType;
		this.lblType.Text=model.Type;
		this.lblDowtherm.Text=model.Dowtherm;
		this.lblSPNum.Text=model.SPNum;
		this.lblSPHead.Text=model.SPHead;
		this.lblSPFlow.Text=model.SPFlow;
		this.lblSPPower.Text=model.SPPower;
		this.lblHEType.Text=model.HEType;
		this.lblHENum.Text=model.HENum;
		this.lblHEHEArea.Text=model.HEHEArea;
		this.lblSInTemp.Text=model.SInTemp;
		this.lblSOutTemp.Text=model.SOutTemp;
		this.lblSFlow.Text=model.SFlow;
		this.lblWTIModel.Text=model.WTIModel;
		this.lblCPETMode.Text=model.CPETMode;
		this.lblCPETNum.Text=model.CPETNum;
		this.lblFWTSize.Text=model.FWTSize;
		this.lblWSPNum.Text=model.WSPNum;
		this.lblWSPPower.Text=model.WSPPower;
		this.lblPVFrequ.Text=model.PVFrequ;

	}


    }
}
