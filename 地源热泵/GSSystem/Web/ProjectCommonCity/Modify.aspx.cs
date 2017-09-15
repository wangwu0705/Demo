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
namespace GSSystem.Web.ProjectCommonCity
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
		GSSystem.BLL.ProjectCommonCity bll=new GSSystem.BLL.ProjectCommonCity();
		GSSystem.Model.ProjectCommonCity model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.txtProName.Text=model.ProName;
		this.txtProAdd.Text=model.ProAdd;
		this.txtProType.Text=model.ProType;
		this.txtConUnit.Text=model.ConUnit;
		this.txtHpManufacturer.Text=model.HpManufacturer;
		this.txtFinTime.Text=model.FinTime.ToString();
		this.txtCoveredArea.Text=model.CoveredArea;
		this.txtHpType.Text=model.HpType;
		this.txtEngCharacter.Text=model.EngCharacter;
		this.txtUseFormat.Text=model.UseFormat;
		this.txtTerminalForm.Text=model.TerminalForm;
		this.txtProjectTHHp.Text=model.ProjectTHHp.ToString();
		this.txtProjectTCHp.Text=model.ProjectTCHp.ToString();
		this.txtHpEquipmentType.Text=model.HpEquipmentType;
		this.txtHpEquipmentNum.Text=model.HpEquipmentNum.ToString();
		this.txtNominalHeat.Text=model.NominalHeat;
		this.txtNominalCool.Text=model.NominalCool;
		this.txtHeatInputPower.Text=model.HeatInputPower;
		this.txtCoolInputPower.Text=model.CoolInputPower;
		this.txtWType.Text=model.WType;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtProName.Text.Trim().Length==0)
			{
				strErr+="ProName不能为空！\\n";	
			}
			if(this.txtProAdd.Text.Trim().Length==0)
			{
				strErr+="ProAdd不能为空！\\n";	
			}
			if(this.txtProType.Text.Trim().Length==0)
			{
				strErr+="ProType不能为空！\\n";	
			}
			if(this.txtConUnit.Text.Trim().Length==0)
			{
				strErr+="ConUnit不能为空！\\n";	
			}
			if(this.txtHpManufacturer.Text.Trim().Length==0)
			{
				strErr+="HpManufacturer不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtFinTime.Text))
			{
				strErr+="FinTime格式错误！\\n";	
			}
			if(this.txtCoveredArea.Text.Trim().Length==0)
			{
				strErr+="CoveredArea不能为空！\\n";	
			}
			if(this.txtHpType.Text.Trim().Length==0)
			{
				strErr+="HpType不能为空！\\n";	
			}
			if(this.txtEngCharacter.Text.Trim().Length==0)
			{
				strErr+="EngCharacter不能为空！\\n";	
			}
			if(this.txtUseFormat.Text.Trim().Length==0)
			{
				strErr+="UseFormat不能为空！\\n";	
			}
			if(this.txtTerminalForm.Text.Trim().Length==0)
			{
				strErr+="TerminalForm不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtProjectTHHp.Text))
			{
				strErr+="ProjectTHHp格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtProjectTCHp.Text))
			{
				strErr+="ProjectTCHp格式错误！\\n";	
			}
			if(this.txtHpEquipmentType.Text.Trim().Length==0)
			{
				strErr+="HpEquipmentType不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtHpEquipmentNum.Text))
			{
				strErr+="HpEquipmentNum格式错误！\\n";	
			}
			if(this.txtNominalHeat.Text.Trim().Length==0)
			{
				strErr+="NominalHeat不能为空！\\n";	
			}
			if(this.txtNominalCool.Text.Trim().Length==0)
			{
				strErr+="NominalCool不能为空！\\n";	
			}
			if(this.txtHeatInputPower.Text.Trim().Length==0)
			{
				strErr+="HeatInputPower不能为空！\\n";	
			}
			if(this.txtCoolInputPower.Text.Trim().Length==0)
			{
				strErr+="CoolInputPower不能为空！\\n";	
			}
			if(this.txtWType.Text.Trim().Length==0)
			{
				strErr+="WType不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int id=int.Parse(this.lblid.Text);
			string ProName=this.txtProName.Text;
			string ProAdd=this.txtProAdd.Text;
			string ProType=this.txtProType.Text;
			string ConUnit=this.txtConUnit.Text;
			string HpManufacturer=this.txtHpManufacturer.Text;
			DateTime FinTime=DateTime.Parse(this.txtFinTime.Text);
			string CoveredArea=this.txtCoveredArea.Text;
			string HpType=this.txtHpType.Text;
			string EngCharacter=this.txtEngCharacter.Text;
			string UseFormat=this.txtUseFormat.Text;
			string TerminalForm=this.txtTerminalForm.Text;
			int ProjectTHHp=int.Parse(this.txtProjectTHHp.Text);
			int ProjectTCHp=int.Parse(this.txtProjectTCHp.Text);
			string HpEquipmentType=this.txtHpEquipmentType.Text;
			int HpEquipmentNum=int.Parse(this.txtHpEquipmentNum.Text);
			string NominalHeat=this.txtNominalHeat.Text;
			string NominalCool=this.txtNominalCool.Text;
			string HeatInputPower=this.txtHeatInputPower.Text;
			string CoolInputPower=this.txtCoolInputPower.Text;
			string WType=this.txtWType.Text;


			GSSystem.Model.ProjectCommonCity model=new GSSystem.Model.ProjectCommonCity();
			model.id=id;
			model.ProName=ProName;
			model.ProAdd=ProAdd;
			model.ProType=ProType;
			model.ConUnit=ConUnit;
			model.HpManufacturer=HpManufacturer;
			model.FinTime=FinTime;
			model.CoveredArea=CoveredArea;
			model.HpType=HpType;
			model.EngCharacter=EngCharacter;
			model.UseFormat=UseFormat;
			model.TerminalForm=TerminalForm;
			model.ProjectTHHp=ProjectTHHp;
			model.ProjectTCHp=ProjectTCHp;
			model.HpEquipmentType=HpEquipmentType;
			model.HpEquipmentNum=HpEquipmentNum;
			model.NominalHeat=NominalHeat;
			model.NominalCool=NominalCool;
			model.HeatInputPower=HeatInputPower;
			model.CoolInputPower=CoolInputPower;
			model.WType=WType;

			GSSystem.BLL.ProjectCommonCity bll=new GSSystem.BLL.ProjectCommonCity();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
