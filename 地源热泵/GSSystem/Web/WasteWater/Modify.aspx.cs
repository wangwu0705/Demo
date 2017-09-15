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
		GSSystem.BLL.WasteWater bll=new GSSystem.BLL.WasteWater();
		GSSystem.Model.WasteWater model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtProName.Text=model.ProName;
		this.txtWType.Text=model.WType;
		this.txtType.Text=model.Type;
		this.txtDowtherm.Text=model.Dowtherm;
		this.txtSPNum.Text=model.SPNum;
		this.txtSPHead.Text=model.SPHead;
		this.txtSPFlow.Text=model.SPFlow;
		this.txtSPPower.Text=model.SPPower;
		this.txtHEType.Text=model.HEType;
		this.txtHENum.Text=model.HENum;
		this.txtHEHEArea.Text=model.HEHEArea;
		this.txtSInTemp.Text=model.SInTemp;
		this.txtSOutTemp.Text=model.SOutTemp;
		this.txtSFlow.Text=model.SFlow;
		this.txtWTIModel.Text=model.WTIModel;
		this.txtCPETMode.Text=model.CPETMode;
		this.txtCPETNum.Text=model.CPETNum;
		this.txtFWTSize.Text=model.FWTSize;
		this.txtWSPNum.Text=model.WSPNum;
		this.txtWSPPower.Text=model.WSPPower;
		this.txtPVFrequ.Text=model.PVFrequ;

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
			int id=int.Parse(this.lblid.Text);
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
			model.id=id;
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
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
