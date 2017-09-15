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
namespace GSSystem.Web.WinterType
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			if(this.txtWWPWTemp.Text.Trim().Length==0)
			{
				strErr+="WWPWTemp不能为空！\\n";	
			}
			if(this.txtWWRWTemp.Text.Trim().Length==0)
			{
				strErr+="WWRWTemp不能为空！\\n";	
			}
			if(this.txtWHSSInWTemp.Text.Trim().Length==0)
			{
				strErr+="WHSSInWTemp不能为空！\\n";	
			}
			if(this.txtWHSSBackWTemp.Text.Trim().Length==0)
			{
				strErr+="WHSSBackWTemp不能为空！\\n";	
			}
			if(this.txtWHSSCWater.Text.Trim().Length==0)
			{
				strErr+="WHSSCWater不能为空！\\n";	
			}
			if(this.txtWUEWSTemp.Text.Trim().Length==0)
			{
				strErr+="WUEWSTemp不能为空！\\n";	
			}
			if(this.txtWUEBWTemp.Text.Trim().Length==0)
			{
				strErr+="WUEBWTemp不能为空！\\n";	
			}
			if(this.txtWUECircul.Text.Trim().Length==0)
			{
				strErr+="WUECircul不能为空！\\n";	
			}
			if(this.txtWRTempeRange.Text.Trim().Length==0)
			{
				strErr+="WRTempeRange不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string ProName=this.txtProName.Text;
			string WType=this.txtWType.Text;
			string WWPWTemp=this.txtWWPWTemp.Text;
			string WWRWTemp=this.txtWWRWTemp.Text;
			string WHSSInWTemp=this.txtWHSSInWTemp.Text;
			string WHSSBackWTemp=this.txtWHSSBackWTemp.Text;
			string WHSSCWater=this.txtWHSSCWater.Text;
			string WUEWSTemp=this.txtWUEWSTemp.Text;
			string WUEBWTemp=this.txtWUEBWTemp.Text;
			string WUECircul=this.txtWUECircul.Text;
			string WRTempeRange=this.txtWRTempeRange.Text;

			GSSystem.Model.WinterType model=new GSSystem.Model.WinterType();
			model.ProName=ProName;
			model.WType=WType;
			model.WWPWTemp=WWPWTemp;
			model.WWRWTemp=WWRWTemp;
			model.WHSSInWTemp=WHSSInWTemp;
			model.WHSSBackWTemp=WHSSBackWTemp;
			model.WHSSCWater=WHSSCWater;
			model.WUEWSTemp=WUEWSTemp;
			model.WUEBWTemp=WUEBWTemp;
			model.WUECircul=WUECircul;
			model.WRTempeRange=WRTempeRange;

			GSSystem.BLL.WinterType bll=new GSSystem.BLL.WinterType();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
