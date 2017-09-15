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
namespace GSSystem.Web.SummerType
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
		GSSystem.BLL.SummerType bll=new GSSystem.BLL.SummerType();
		GSSystem.Model.SummerType model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblProName.Text=model.ProName;
		this.lblWType.Text=model.WType;
		this.lblSHSSInWTemp.Text=model.SHSSInWTemp;
		this.lblSHSSBackWTemp.Text=model.SHSSBackWTemp;
		this.lblSHSSCWater.Text=model.SHSSCWater;
		this.lblSUEWSTemp.Text=model.SUEWSTemp;
		this.lblSUEBWTemp.Text=model.SUEBWTemp;
		this.lblSUECircul.Text=model.SUECircul;
		this.lblSRTempRange.Text=model.SRTempRange;

	}


    }
}
