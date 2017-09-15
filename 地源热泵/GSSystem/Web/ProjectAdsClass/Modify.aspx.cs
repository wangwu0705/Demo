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
namespace GSSystem.Web.ProjectAdsClass
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
		GSSystem.BLL.ProjectAdsClass bll=new GSSystem.BLL.ProjectAdsClass();
		GSSystem.Model.ProjectAdsClass model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtProjectAds.Text=model.ProjectAds;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtProjectAds.Text.Trim().Length==0)
			{
				strErr+="ProjectAds不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			string ProjectAds=this.txtProjectAds.Text;


			GSSystem.Model.ProjectAdsClass model=new GSSystem.Model.ProjectAdsClass();
			model.id=id;
			model.ProjectAds=ProjectAds;

			GSSystem.BLL.ProjectAdsClass bll=new GSSystem.BLL.ProjectAdsClass();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
