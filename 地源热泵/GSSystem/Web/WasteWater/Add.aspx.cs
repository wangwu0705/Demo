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
namespace GSSystem.Web.WasteWater
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
			if(this.txtType.Text.Trim().Length==0)
			{
				strErr+="Type不能为空！\\n";	
			}
			if(this.txtDowtherm.Text.Trim().Length==0)
			{
				strErr+="Dowtherm不能为空！\\n";	
			}
			if(this.txtSPNum.Text.Trim().Length==0)
			{
				strErr+="SPNum不能为空！\\n";	
			}
			if(this.txtSPHead.Text.Trim().Length==0)
			{
				strErr+="SPHead不能为空！\\n";	
			}
			if(this.txtSPFlow.Text.Trim().Length==0)
			{
				strErr+="SPFlow不能为空！\\n";	
			}
			if(this.txtSPPower.Text.Trim().Length==0)
			{
				strErr+="SPPower不能为空！\\n";	
			}
			if(this.txtHEType.Text.Trim().Length==0)
			{
				strErr+="HEType不能为空！\\n";	
			}
			if(this.txtHENum.Text.Trim().Length==0)
			{
				strErr+="HENum不能为空！\\n";	
			}
			if(this.txtHEHEArea.Text.Trim().Length==0)
			{
				strErr+="HEHEArea不能为空！\\n";	
			}
			if(this.txtSInTemp.Text.Trim().Length==0)
			{
				strErr+="SInTemp不能为空！\\n";	
			}
			if(this.txtSOutTemp.Text.Trim().Length==0)
			{
				strErr+="SOutTemp不能为空！\\n";	
			}
			if(this.txtSFlow.Text.Trim().Length==0)
			{
				strErr+="SFlow不能为空！\\n";	
			}
			if(this.txtWTIModel.Text.Trim().Length==0)
			{
				strErr+="WTIModel不能为空！\\n";	
			}
			if(this.txtCPETMode.Text.Trim().Length==0)
			{
				strErr+="CPETMode不能为空！\\n";	
			}
			if(this.txtCPETNum.Text.Trim().Length==0)
			{
				strErr+="CPETNum不能为空！\\n";	
			}
			if(this.txtFWTSize.Text.Trim().Length==0)
			{
				strErr+="FWTSize不能为空！\\n";	
			}
			if(this.txtWSPNum.Text.Trim().Length==0)
			{
				strErr+="WSPNum不能为空！\\n";	
			}
			if(this.txtWSPPower.Text.Trim().Length==0)
			{
				strErr+="WSPPower不能为空！\\n";	
			}
			if(this.txtPVFrequ.Text.Trim().Length==0)
			{
				strErr+="PVFrequ不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string ProName=this.txtProName.Text;
			string WType=this.txtWType.Text;
			string Type=this.txtType.Text;
			string Dowtherm=this.txtDowtherm.Text;
			string SPNum=this.txtSPNum.Text;
			string SPHead=this.txtSPHead.Text;
			string SPFlow=this.txtSPFlow.Text;
			string SPPower=this.txtSPPower.Text;
			string HEType=this.txtHEType.Text;
			string HENum=this.txtHENum.Text;
			string HEHEArea=this.txtHEHEArea.Text;
			string SInTemp=this.txtSInTemp.Text;
			string SOutTemp=this.txtSOutTemp.Text;
			string SFlow=this.txtSFlow.Text;
			string WTIModel=this.txtWTIModel.Text;
			string CPETMode=this.txtCPETMode.Text;
			string CPETNum=this.txtCPETNum.Text;
			string FWTSize=this.txtFWTSize.Text;
			string WSPNum=this.txtWSPNum.Text;
			string WSPPower=this.txtWSPPower.Text;
			string PVFrequ=this.txtPVFrequ.Text;

			GSSystem.Model.WasteWater model=new GSSystem.Model.WasteWater();
			model.ProName=ProName;
			model.WType=WType;
			model.Type=Type;
			model.Dowtherm=Dowtherm;
			model.SPNum=SPNum;
			model.SPHead=SPHead;
			model.SPFlow=SPFlow;
			model.SPPower=SPPower;
			model.HEType=HEType;
			model.HENum=HENum;
			model.HEHEArea=HEHEArea;
			model.SInTemp=SInTemp;
			model.SOutTemp=SOutTemp;
			model.SFlow=SFlow;
			model.WTIModel=WTIModel;
			model.CPETMode=CPETMode;
			model.CPETNum=CPETNum;
			model.FWTSize=FWTSize;
			model.WSPNum=WSPNum;
			model.WSPPower=WSPPower;
			model.PVFrequ=PVFrequ;

			GSSystem.BLL.WasteWater bll=new GSSystem.BLL.WasteWater();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
