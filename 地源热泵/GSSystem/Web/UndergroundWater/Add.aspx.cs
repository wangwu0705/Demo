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
namespace GSSystem.Web.UndergroundWater
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
			if(this.txtWellNum.Text.Trim().Length==0)
			{
				strErr+="WellNum不能为空！\\n";	
			}
			if(this.txtWEWNum.Text.Trim().Length==0)
			{
				strErr+="WEWNum不能为空！\\n";	
			}
			if(this.txtRWNum.Text.Trim().Length==0)
			{
				strErr+="RWNum不能为空！\\n";	
			}
			if(this.txtWellDepth.Text.Trim().Length==0)
			{
				strErr+="WellDepth不能为空！\\n";	
			}
			if(this.txtSWWExtract.Text.Trim().Length==0)
			{
				strErr+="SWWExtract不能为空！\\n";	
			}
			if(this.txtHeatTime.Text.Trim().Length==0)
			{
				strErr+="HeatTime不能为空！\\n";	
			}
			if(this.txtCoolTime.Text.Trim().Length==0)
			{
				strErr+="CoolTime不能为空！\\n";	
			}
			if(this.txtWPDiameter.Text.Trim().Length==0)
			{
				strErr+="WPDiameter不能为空！\\n";	
			}
			if(this.txtWPipe.Text.Trim().Length==0)
			{
				strErr+="WPipe不能为空！\\n";	
			}
			if(this.txtBWPDiameter.Text.Trim().Length==0)
			{
				strErr+="BWPDiameter不能为空！\\n";	
			}
			if(this.txtBWPipe.Text.Trim().Length==0)
			{
				strErr+="BWPipe不能为空！\\n";	
			}
			if(this.txtDModel.Text.Trim().Length==0)
			{
				strErr+="DModel不能为空！\\n";	
			}
			if(this.txtWTIModel.Text.Trim().Length==0)
			{
				strErr+="WTIModel不能为空！\\n";	
			}
			if(this.txtCPETModel.Text.Trim().Length==0)
			{
				strErr+="CPETModel不能为空！\\n";	
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
			if(this.txtWPPower.Text.Trim().Length==0)
			{
				strErr+="WPPower不能为空！\\n";	
			}
			if(this.txtPVFreque.Text.Trim().Length==0)
			{
				strErr+="PVFreque不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string ProName=this.txtProName.Text;
			string WType=this.txtWType.Text;
			string WellNum=this.txtWellNum.Text;
			string WEWNum=this.txtWEWNum.Text;
			string RWNum=this.txtRWNum.Text;
			string WellDepth=this.txtWellDepth.Text;
			string SWWExtract=this.txtSWWExtract.Text;
			string HeatTime=this.txtHeatTime.Text;
			string CoolTime=this.txtCoolTime.Text;
			string WPDiameter=this.txtWPDiameter.Text;
			string WPipe=this.txtWPipe.Text;
			string BWPDiameter=this.txtBWPDiameter.Text;
			string BWPipe=this.txtBWPipe.Text;
			string DModel=this.txtDModel.Text;
			string WTIModel=this.txtWTIModel.Text;
			string CPETModel=this.txtCPETModel.Text;
			string CPETNum=this.txtCPETNum.Text;
			string FWTSize=this.txtFWTSize.Text;
			string WSPNum=this.txtWSPNum.Text;
			string WPPower=this.txtWPPower.Text;
			string PVFreque=this.txtPVFreque.Text;

			GSSystem.Model.UndergroundWater model=new GSSystem.Model.UndergroundWater();
			model.ProName=ProName;
			model.WType=WType;
			model.WellNum=WellNum;
			model.WEWNum=WEWNum;
			model.RWNum=RWNum;
			model.WellDepth=WellDepth;
			model.SWWExtract=SWWExtract;
			model.HeatTime=HeatTime;
			model.CoolTime=CoolTime;
			model.WPDiameter=WPDiameter;
			model.WPipe=WPipe;
			model.BWPDiameter=BWPDiameter;
			model.BWPipe=BWPipe;
			model.DModel=DModel;
			model.WTIModel=WTIModel;
			model.CPETModel=CPETModel;
			model.CPETNum=CPETNum;
			model.FWTSize=FWTSize;
			model.WSPNum=WSPNum;
			model.WPPower=WPPower;
			model.PVFreque=PVFreque;

			GSSystem.BLL.UndergroundWater bll=new GSSystem.BLL.UndergroundWater();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
