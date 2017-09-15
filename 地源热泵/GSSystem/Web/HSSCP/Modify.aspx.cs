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
		GSSystem.BLL.HSSCP bll=new GSSystem.BLL.HSSCP();
		GSSystem.Model.HSSCP model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtProName.Text=model.ProName;
		this.txtWType.Text=model.WType;
		this.txtHSSCPNum.Text=model.HSSCPNum.ToString();
		this.txtHSSCPPower.Text=model.HSSCPPower;
		this.txtHSSCPHead.Text=model.HSSCPHead;
		this.txtHSSCPFlow.Text=model.HSSCPFlow;

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
			int id=int.Parse(this.lblid.Text);
			string ProName=this.txtProName.Text;
			string WType=this.txtWType.Text;
			int HSSCPNum=int.Parse(this.txtHSSCPNum.Text);
			string HSSCPPower=this.txtHSSCPPower.Text;
			string HSSCPHead=this.txtHSSCPHead.Text;
			string HSSCPFlow=this.txtHSSCPFlow.Text;


			GSSystem.Model.HSSCP model=new GSSystem.Model.HSSCP();
			model.id=id;
			model.ProName=ProName;
			model.WType=WType;
			model.HSSCPNum=HSSCPNum;
			model.HSSCPPower=HSSCPPower;
			model.HSSCPHead=HSSCPHead;
			model.HSSCPFlow=HSSCPFlow;

			GSSystem.BLL.HSSCP bll=new GSSystem.BLL.HSSCP();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
