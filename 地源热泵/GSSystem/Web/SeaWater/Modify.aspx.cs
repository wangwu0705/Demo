﻿using System;
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
namespace GSSystem.Web.SeaWater
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
		GSSystem.BLL.SeaWater bll=new GSSystem.BLL.SeaWater();
		GSSystem.Model.SeaWater model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtProName.Text=model.ProName;
		this.txtWType.Text=model.WType;
		this.txtType.Text=model.Type;
		this.txtDowtherm.Text=model.Dowtherm;
		this.txtSWWellNum.Text=model.SWWellNum;
		this.txtSWWellDep.Text=model.SWWellDep;
		this.txtCWPNum.Text=model.CWPNum;
		this.txtCWPHead.Text=model.CWPHead;
		this.txtCWPFlow.Text=model.CWPFlow;
		this.txtCWPPower.Text=model.CWPPower;
		this.txtExHeatType.Text=model.ExHeatType;
		this.txtExHeatNum.Text=model.ExHeatNum;
		this.txtExHeatArea.Text=model.ExHeatArea;
		this.txtSWInTemp.Text=model.SWInTemp;
		this.txtSWOutTemp.Text=model.SWOutTemp;
		this.txtSeaWaterFlow.Text=model.SeaWaterFlow;
		this.txtDesanderNum.Text=model.DesanderNum;
		this.txtDesanderType.Text=model.DesanderType;
		this.txtSoftWTSize.Text=model.SoftWTSize;
		this.txtSoftWType.Text=model.SoftWType;
		this.txtWPNum.Text=model.WPNum;
		this.txtWPpower.Text=model.WPpower;
		this.txtPVariableFre.Text=model.PVariableFre;

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
			if(this.txtSWWellNum.Text.Trim().Length==0)
			{
				strErr+="SWWellNum不能为空！\\n";	
			}
			if(this.txtSWWellDep.Text.Trim().Length==0)
			{
				strErr+="SWWellDep不能为空！\\n";	
			}
			if(this.txtCWPNum.Text.Trim().Length==0)
			{
				strErr+="CWPNum不能为空！\\n";	
			}
			if(this.txtCWPHead.Text.Trim().Length==0)
			{
				strErr+="CWPHead不能为空！\\n";	
			}
			if(this.txtCWPFlow.Text.Trim().Length==0)
			{
				strErr+="CWPFlow不能为空！\\n";	
			}
			if(this.txtCWPPower.Text.Trim().Length==0)
			{
				strErr+="CWPPower不能为空！\\n";	
			}
			if(this.txtExHeatType.Text.Trim().Length==0)
			{
				strErr+="ExHeatType不能为空！\\n";	
			}
			if(this.txtExHeatNum.Text.Trim().Length==0)
			{
				strErr+="ExHeatNum不能为空！\\n";	
			}
			if(this.txtExHeatArea.Text.Trim().Length==0)
			{
				strErr+="ExHeatArea不能为空！\\n";	
			}
			if(this.txtSWInTemp.Text.Trim().Length==0)
			{
				strErr+="SWInTemp不能为空！\\n";	
			}
			if(this.txtSWOutTemp.Text.Trim().Length==0)
			{
				strErr+="SWOutTemp不能为空！\\n";	
			}
			if(this.txtSeaWaterFlow.Text.Trim().Length==0)
			{
				strErr+="SeaWaterFlow不能为空！\\n";	
			}
			if(this.txtDesanderNum.Text.Trim().Length==0)
			{
				strErr+="DesanderNum不能为空！\\n";	
			}
			if(this.txtDesanderType.Text.Trim().Length==0)
			{
				strErr+="DesanderType不能为空！\\n";	
			}
			if(this.txtSoftWTSize.Text.Trim().Length==0)
			{
				strErr+="SoftWTSize不能为空！\\n";	
			}
			if(this.txtSoftWType.Text.Trim().Length==0)
			{
				strErr+="SoftWType不能为空！\\n";	
			}
			if(this.txtWPNum.Text.Trim().Length==0)
			{
				strErr+="WPNum不能为空！\\n";	
			}
			if(this.txtWPpower.Text.Trim().Length==0)
			{
				strErr+="WPpower不能为空！\\n";	
			}
			if(this.txtPVariableFre.Text.Trim().Length==0)
			{
				strErr+="PVariableFre不能为空！\\n";	
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
			string SWWellNum=this.txtSWWellNum.Text;
			string SWWellDep=this.txtSWWellDep.Text;
			string CWPNum=this.txtCWPNum.Text;
			string CWPHead=this.txtCWPHead.Text;
			string CWPFlow=this.txtCWPFlow.Text;
			string CWPPower=this.txtCWPPower.Text;
			string ExHeatType=this.txtExHeatType.Text;
			string ExHeatNum=this.txtExHeatNum.Text;
			string ExHeatArea=this.txtExHeatArea.Text;
			string SWInTemp=this.txtSWInTemp.Text;
			string SWOutTemp=this.txtSWOutTemp.Text;
			string SeaWaterFlow=this.txtSeaWaterFlow.Text;
			string DesanderNum=this.txtDesanderNum.Text;
			string DesanderType=this.txtDesanderType.Text;
			string SoftWTSize=this.txtSoftWTSize.Text;
			string SoftWType=this.txtSoftWType.Text;
			string WPNum=this.txtWPNum.Text;
			string WPpower=this.txtWPpower.Text;
			string PVariableFre=this.txtPVariableFre.Text;


			GSSystem.Model.SeaWater model=new GSSystem.Model.SeaWater();
			model.id=id;
			model.ProName=ProName;
			model.WType=WType;
			model.Type=Type;
			model.Dowtherm=Dowtherm;
			model.SWWellNum=SWWellNum;
			model.SWWellDep=SWWellDep;
			model.CWPNum=CWPNum;
			model.CWPHead=CWPHead;
			model.CWPFlow=CWPFlow;
			model.CWPPower=CWPPower;
			model.ExHeatType=ExHeatType;
			model.ExHeatNum=ExHeatNum;
			model.ExHeatArea=ExHeatArea;
			model.SWInTemp=SWInTemp;
			model.SWOutTemp=SWOutTemp;
			model.SeaWaterFlow=SeaWaterFlow;
			model.DesanderNum=DesanderNum;
			model.DesanderType=DesanderType;
			model.SoftWTSize=SoftWTSize;
			model.SoftWType=SoftWType;
			model.WPNum=WPNum;
			model.WPpower=WPpower;
			model.PVariableFre=PVariableFre;

			GSSystem.BLL.SeaWater bll=new GSSystem.BLL.SeaWater();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
