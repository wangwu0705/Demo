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
namespace GSSystem.Web.SoilSource
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
		GSSystem.BLL.SoilSource bll=new GSSystem.BLL.SoilSource();
		GSSystem.Model.SoilSource model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtProName.Text=model.ProName;
		this.txtWType.Text=model.WType;
		this.txtPHoleNum.Text=model.PHoleNum;
		this.txtHoleDepth.Text=model.HoleDepth;
		this.txtHoleDistance.Text=model.HoleDistance;
		this.txtUHEMaterial.Text=model.UHEMaterial;
		this.txtUHEDiameter.Text=model.UHEDiameter;
		this.txtHeatTime.Text=model.HeatTime;
		this.txtCoolTime.Text=model.CoolTime;
		this.txtBPFormat.Text=model.BPFormat;
		this.txtUHEUType.Text=model.UHEUType;
		this.txtUHESparallel.Text=model.UHESparallel;
		this.txtUHETotalLen.Text=model.UHETotalLen;
		this.txtWTIModel.Text=model.WTIModel;
		this.txtCPETModel.Text=model.CPETModel;
		this.txtCPETNum.Text=model.CPETNum;
		this.txtFWTSize.Text=model.FWTSize;
		this.txtWSPNum.Text=model.WSPNum;
		this.txtWSPPower.Text=model.WSPPower;
		this.txtPVFreque.Text=model.PVFreque;

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
			if(this.txtPHoleNum.Text.Trim().Length==0)
			{
				strErr+="PHoleNum不能为空！\\n";	
			}
			if(this.txtHoleDepth.Text.Trim().Length==0)
			{
				strErr+="HoleDepth不能为空！\\n";	
			}
			if(this.txtHoleDistance.Text.Trim().Length==0)
			{
				strErr+="HoleDistance不能为空！\\n";	
			}
			if(this.txtUHEMaterial.Text.Trim().Length==0)
			{
				strErr+="UHEMaterial不能为空！\\n";	
			}
			if(this.txtUHEDiameter.Text.Trim().Length==0)
			{
				strErr+="UHEDiameter不能为空！\\n";	
			}
			if(this.txtHeatTime.Text.Trim().Length==0)
			{
				strErr+="HeatTime不能为空！\\n";	
			}
			if(this.txtCoolTime.Text.Trim().Length==0)
			{
				strErr+="CoolTime不能为空！\\n";	
			}
			if(this.txtBPFormat.Text.Trim().Length==0)
			{
				strErr+="BPFormat不能为空！\\n";	
			}
			if(this.txtUHEUType.Text.Trim().Length==0)
			{
				strErr+="UHEUType不能为空！\\n";	
			}
			if(this.txtUHESparallel.Text.Trim().Length==0)
			{
				strErr+="UHESparallel不能为空！\\n";	
			}
			if(this.txtUHETotalLen.Text.Trim().Length==0)
			{
				strErr+="UHETotalLen不能为空！\\n";	
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
			if(this.txtWSPPower.Text.Trim().Length==0)
			{
				strErr+="WSPPower不能为空！\\n";	
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
			int id=int.Parse(this.lblid.Text);
			string ProName=this.txtProName.Text;
			string WType=this.txtWType.Text;
			string PHoleNum=this.txtPHoleNum.Text;
			string HoleDepth=this.txtHoleDepth.Text;
			string HoleDistance=this.txtHoleDistance.Text;
			string UHEMaterial=this.txtUHEMaterial.Text;
			string UHEDiameter=this.txtUHEDiameter.Text;
			string HeatTime=this.txtHeatTime.Text;
			string CoolTime=this.txtCoolTime.Text;
			string BPFormat=this.txtBPFormat.Text;
			string UHEUType=this.txtUHEUType.Text;
			string UHESparallel=this.txtUHESparallel.Text;
			string UHETotalLen=this.txtUHETotalLen.Text;
			string WTIModel=this.txtWTIModel.Text;
			string CPETModel=this.txtCPETModel.Text;
			string CPETNum=this.txtCPETNum.Text;
			string FWTSize=this.txtFWTSize.Text;
			string WSPNum=this.txtWSPNum.Text;
			string WSPPower=this.txtWSPPower.Text;
			string PVFreque=this.txtPVFreque.Text;


			GSSystem.Model.SoilSource model=new GSSystem.Model.SoilSource();
			model.id=id;
			model.ProName=ProName;
			model.WType=WType;
			model.PHoleNum=PHoleNum;
			model.HoleDepth=HoleDepth;
			model.HoleDistance=HoleDistance;
			model.UHEMaterial=UHEMaterial;
			model.UHEDiameter=UHEDiameter;
			model.HeatTime=HeatTime;
			model.CoolTime=CoolTime;
			model.BPFormat=BPFormat;
			model.UHEUType=UHEUType;
			model.UHESparallel=UHESparallel;
			model.UHETotalLen=UHETotalLen;
			model.WTIModel=WTIModel;
			model.CPETModel=CPETModel;
			model.CPETNum=CPETNum;
			model.FWTSize=FWTSize;
			model.WSPNum=WSPNum;
			model.WSPPower=WSPPower;
			model.PVFreque=PVFreque;

			GSSystem.BLL.SoilSource bll=new GSSystem.BLL.SoilSource();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
