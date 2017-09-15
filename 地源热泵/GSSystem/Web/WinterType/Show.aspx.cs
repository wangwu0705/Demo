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
namespace GSSystem.Web.WinterType
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
		GSSystem.BLL.WinterType bll=new GSSystem.BLL.WinterType();
		GSSystem.Model.WinterType model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblProName.Text=model.ProName;
		this.lblWType.Text=model.WType;
		this.lblWWPWTemp.Text=model.WWPWTemp;
		this.lblWWRWTemp.Text=model.WWRWTemp;
		this.lblWHSSInWTemp.Text=model.WHSSInWTemp;
		this.lblWHSSBackWTemp.Text=model.WHSSBackWTemp;
		this.lblWHSSCWater.Text=model.WHSSCWater;
		this.lblWUEWSTemp.Text=model.WUEWSTemp;
		this.lblWUEBWTemp.Text=model.WUEBWTemp;
		this.lblWUECircul.Text=model.WUECircul;
		this.lblWRTempeRange.Text=model.WRTempeRange;

	}


    }
}
