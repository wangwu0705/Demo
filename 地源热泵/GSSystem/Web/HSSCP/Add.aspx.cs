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
namespace GSSystem.Web.HSSCP
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
			if(!PageValidate.IsNumber(txtHSSCPNum.Text))
			{
				strErr+="HSSCPNum格式错误！\\n";	
			}
			if(this.txtHSSCPPower.Text.Trim().Length==0)
			{
				strErr+="HSSCPPower不能为空！\\n";	
			}
			if(this.txtHSSCPHead.Text.Trim().Length==0)
			{
				strErr+="HSSCPHead不能为空！\\n";	
			}
			if(this.txtHSSCPFlow.Text.Trim().Length==0)
			{
				strErr+="HSSCPFlow不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string ProName=this.txtProName.Text;
			string WType=this.txtWType.Text;
			int HSSCPNum=int.Parse(this.txtHSSCPNum.Text);
			string HSSCPPower=this.txtHSSCPPower.Text;
			string HSSCPHead=this.txtHSSCPHead.Text;
			string HSSCPFlow=this.txtHSSCPFlow.Text;

			GSSystem.Model.HSSCP model=new GSSystem.Model.HSSCP();
			model.ProName=ProName;
			model.WType=WType;
			model.HSSCPNum=HSSCPNum;
			model.HSSCPPower=HSSCPPower;
			model.HSSCPHead=HSSCPHead;
			model.HSSCPFlow=HSSCPFlow;

			GSSystem.BLL.HSSCP bll=new GSSystem.BLL.HSSCP();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
