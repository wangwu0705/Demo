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
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace GSSystem.Web.SummerType
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int id=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(id);
				}
			}
		}
			
	private void ShowInfo(int id)
	{
		GSSystem.BLL.SummerType bll=new GSSystem.BLL.SummerType();
		GSSystem.Model.SummerType model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtProName.Text=model.ProName;
		this.txtWType.Text=model.WType;
		this.txtSHSSInWTemp.Text=model.SHSSInWTemp;
		this.txtSHSSBackWTemp.Text=model.SHSSBackWTemp;
		this.txtSHSSCWater.Text=model.SHSSCWater;
		this.txtSUEWSTemp.Text=model.SUEWSTemp;
		this.txtSUEBWTemp.Text=model.SUEBWTemp;
		this.txtSUECircul.Text=model.SUECircul;
		this.txtSRTempRange.Text=model.SRTempRange;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtProName.Text.Trim().Length==0)
			{
				strErr+="ProName不能为空！\\n";	
			}
			if(this.txtWType.Text.Trim().Length==0)
			{
				strErr+="WType不能为空！\\n";	
			}
			if(this.txtSHSSInWTemp.Text.Trim().Length==0)
			{
				strErr+="SHSSInWTemp不能为空！\\n";	
			}
			if(this.txtSHSSBackWTemp.Text.Trim().Length==0)
			{
				strErr+="SHSSBackWTemp不能为空！\\n";	
			}
			if(this.txtSHSSCWater.Text.Trim().Length==0)
			{
				strErr+="SHSSCWater不能为空！\\n";	
			}
			if(this.txtSUEWSTemp.Text.Trim().Length==0)
			{
				strErr+="SUEWSTemp不能为空！\\n";	
			}
			if(this.txtSUEBWTemp.Text.Trim().Length==0)
			{
				strErr+="SUEBWTemp不能为空！\\n";	
			}
			if(this.txtSUECircul.Text.Trim().Length==0)
			{
				strErr+="SUECircul不能为空！\\n";	
			}
			if(this.txtSRTempRange.Text.Trim().Length==0)
			{
				strErr+="SRTempRange不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			string ProName=this.txtProName.Text;
			string WType=this.txtWType.Text;
			string SHSSInWTemp=this.txtSHSSInWTemp.Text;
			string SHSSBackWTemp=this.txtSHSSBackWTemp.Text;
			string SHSSCWater=this.txtSHSSCWater.Text;
			string SUEWSTemp=this.txtSUEWSTemp.Text;
			string SUEBWTemp=this.txtSUEBWTemp.Text;
			string SUECircul=this.txtSUECircul.Text;
			string SRTempRange=this.txtSRTempRange.Text;


			GSSystem.Model.SummerType model=new GSSystem.Model.SummerType();
			model.id=id;
			model.ProName=ProName;
			model.WType=WType;
			model.SHSSInWTemp=SHSSInWTemp;
			model.SHSSBackWTemp=SHSSBackWTemp;
			model.SHSSCWater=SHSSCWater;
			model.SUEWSTemp=SUEWSTemp;
			model.SUEBWTemp=SUEBWTemp;
			model.SUECircul=SUECircul;
			model.SRTempRange=SRTempRange;

			GSSystem.BLL.SummerType bll=new GSSystem.BLL.SummerType();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
