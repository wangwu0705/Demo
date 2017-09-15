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
namespace GSSystem.Web.SurfaceWater
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
		GSSystem.BLL.SurfaceWater bll=new GSSystem.BLL.SurfaceWater();
		GSSystem.Model.SurfaceWater model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtProName.Text=model.ProName;
		this.txtWType.Text=model.WType;
		this.txtType.Text=model.Type;
		this.txtDowtherm.Text=model.Dowtherm;
		this.txtWPNum.Text=model.WPNum;
		this.txtWPHead.Text=model.WPHead;
		this.txtWPFlow.Text=model.WPFlow;
		this.txtWPPower.Text=model.WPPower;
		this.txtHEType.Text=model.HEType;
		this.txtHENum.Text=model.HENum;
		this.txtHEHeatArea.Text=model.HEHeatArea;
		this.txtSWITemp.Text=model.SWITemp;
		this.txtSWOTemp.Text=model.SWOTemp;
		this.txtSWFlow.Text=model.SWFlow;
		this.txtDNum.Text=model.DNum;
		this.txtDType.Text=model.DType;
		this.txtSWTSize.Text=model.SWTSize;
		this.txtSWTType.Text=model.SWTType;
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
			if(this.txtWPNum.Text.Trim().Length==0)
			{
				strErr+="WPNum不能为空！\\n";	
			}
			if(this.txtWPHead.Text.Trim().Length==0)
			{
				strErr+="WPHead不能为空！\\n";	
			}
			if(this.txtWPFlow.Text.Trim().Length==0)
			{
				strErr+="WPFlow不能为空！\\n";	
			}
			if(this.txtWPPower.Text.Trim().Length==0)
			{
				strErr+="WPPower不能为空！\\n";	
			}
			if(this.txtHEType.Text.Trim().Length==0)
			{
				strErr+="HEType不能为空！\\n";	
			}
			if(this.txtHENum.Text.Trim().Length==0)
			{
				strErr+="HENum不能为空！\\n";	
			}
			if(this.txtHEHeatArea.Text.Trim().Length==0)
			{
				strErr+="HEHeatArea不能为空！\\n";	
			}
			if(this.txtSWITemp.Text.Trim().Length==0)
			{
				strErr+="SWITemp不能为空！\\n";	
			}
			if(this.txtSWOTemp.Text.Trim().Length==0)
			{
				strErr+="SWOTemp不能为空！\\n";	
			}
			if(this.txtSWFlow.Text.Trim().Length==0)
			{
				strErr+="SWFlow不能为空！\\n";	
			}
			if(this.txtDNum.Text.Trim().Length==0)
			{
				strErr+="DNum不能为空！\\n";	
			}
			if(this.txtDType.Text.Trim().Length==0)
			{
				strErr+="DType不能为空！\\n";	
			}
			if(this.txtSWTSize.Text.Trim().Length==0)
			{
				strErr+="SWTSize不能为空！\\n";	
			}
			if(this.txtSWTType.Text.Trim().Length==0)
			{
				strErr+="SWTType不能为空！\\n";	
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
			string WPNum=this.txtWPNum.Text;
			string WPHead=this.txtWPHead.Text;
			string WPFlow=this.txtWPFlow.Text;
			string WPPower=this.txtWPPower.Text;
			string HEType=this.txtHEType.Text;
			string HENum=this.txtHENum.Text;
			string HEHeatArea=this.txtHEHeatArea.Text;
			string SWITemp=this.txtSWITemp.Text;
			string SWOTemp=this.txtSWOTemp.Text;
			string SWFlow=this.txtSWFlow.Text;
			string DNum=this.txtDNum.Text;
			string DType=this.txtDType.Text;
			string SWTSize=this.txtSWTSize.Text;
			string SWTType=this.txtSWTType.Text;
			string WSPNum=this.txtWSPNum.Text;
			string WSPPower=this.txtWSPPower.Text;
			string PVFrequ=this.txtPVFrequ.Text;


			GSSystem.Model.SurfaceWater model=new GSSystem.Model.SurfaceWater();
			model.id=id;
			model.ProName=ProName;
			model.WType=WType;
			model.Type=Type;
			model.Dowtherm=Dowtherm;
			model.WPNum=WPNum;
			model.WPHead=WPHead;
			model.WPFlow=WPFlow;
			model.WPPower=WPPower;
			model.HEType=HEType;
			model.HENum=HENum;
			model.HEHeatArea=HEHeatArea;
			model.SWITemp=SWITemp;
			model.SWOTemp=SWOTemp;
			model.SWFlow=SWFlow;
			model.DNum=DNum;
			model.DType=DType;
			model.SWTSize=SWTSize;
			model.SWTType=SWTType;
			model.WSPNum=WSPNum;
			model.WSPPower=WSPPower;
			model.PVFrequ=PVFrequ;

			GSSystem.BLL.SurfaceWater bll=new GSSystem.BLL.SurfaceWater();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
