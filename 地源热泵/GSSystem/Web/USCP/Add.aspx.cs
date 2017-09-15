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
namespace GSSystem.Web.USCP
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
			if(!PageValidate.IsNumber(txtUSCPNum.Text))
			{
				strErr+="USCPNum格式错误！\\n";	
			}
			if(this.txtUSCPPower.Text.Trim().Length==0)
			{
				strErr+="USCPPower不能为空！\\n";	
			}
			if(this.txtUSCPHead.Text.Trim().Length==0)
			{
				strErr+="USCPHead不能为空！\\n";	
			}
			if(this.txtUSCPFlow.Text.Trim().Length==0)
			{
				strErr+="USCPFlow不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string ProName=this.txtProName.Text;
			string WType=this.txtWType.Text;
			int USCPNum=int.Parse(this.txtUSCPNum.Text);
			string USCPPower=this.txtUSCPPower.Text;
			string USCPHead=this.txtUSCPHead.Text;
			string USCPFlow=this.txtUSCPFlow.Text;

			GSSystem.Model.USCP model=new GSSystem.Model.USCP();
			model.ProName=ProName;
			model.WType=WType;
			model.USCPNum=USCPNum;
			model.USCPPower=USCPPower;
			model.USCPHead=USCPHead;
			model.USCPFlow=USCPFlow;

			GSSystem.BLL.USCP bll=new GSSystem.BLL.USCP();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
