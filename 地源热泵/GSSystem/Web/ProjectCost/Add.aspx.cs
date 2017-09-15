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
namespace GSSystem.Web.ProjectCost
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
			if(this.txtProTotalCost.Text.Trim().Length==0)
			{
				strErr+="ProTotalCost不能为空！\\n";	
			}
			if(this.txtUnitCost.Text.Trim().Length==0)
			{
				strErr+="UnitCost不能为空！\\n";	
			}
			if(this.txtSystemCost.Text.Trim().Length==0)
			{
				strErr+="SystemCost不能为空！\\n";	
			}
			if(this.txtProTel.Text.Trim().Length==0)
			{
				strErr+="ProTel不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string ProName=this.txtProName.Text;
			string WType=this.txtWType.Text;
			string ProTotalCost=this.txtProTotalCost.Text;
			string UnitCost=this.txtUnitCost.Text;
			string SystemCost=this.txtSystemCost.Text;
			string ProTel=this.txtProTel.Text;

			GSSystem.Model.ProjectCost model=new GSSystem.Model.ProjectCost();
			model.ProName=ProName;
			model.WType=WType;
			model.ProTotalCost=ProTotalCost;
			model.UnitCost=UnitCost;
			model.SystemCost=SystemCost;
			model.ProTel=ProTel;

			GSSystem.BLL.ProjectCost bll=new GSSystem.BLL.ProjectCost();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
