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
namespace GSSystem.Web.ProjectCommonCity
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int id=(Convert.ToInt32(strid));
					ShowInfo(id);
				}
			}
		}
		
	private void ShowInfo(int id)
	{
		GSSystem.BLL.ProjectCommonCity bll=new GSSystem.BLL.ProjectCommonCity();
		GSSystem.Model.ProjectCommonCity model=bll.GetModel(id);
		this.lblid.Text=model.id.ToString();
		this.lblProName.Text=model.ProName;
		this.lblProAdd.Text=model.ProAdd;
		this.lblProType.Text=model.ProType;
		this.lblConUnit.Text=model.ConUnit;
		this.lblHpManufacturer.Text=model.HpManufacturer;
		this.lblFinTime.Text=model.FinTime.ToString();
		this.lblCoveredArea.Text=model.CoveredArea;
		this.lblHpType.Text=model.HpType;
		this.lblEngCharacter.Text=model.EngCharacter;
		this.lblUseFormat.Text=model.UseFormat;
		this.lblTerminalForm.Text=model.TerminalForm;
		this.lblProjectTHHp.Text=model.ProjectTHHp.ToString();
		this.lblProjectTCHp.Text=model.ProjectTCHp.ToString();
		this.lblHpEquipmentType.Text=model.HpEquipmentType;
		this.lblHpEquipmentNum.Text=model.HpEquipmentNum.ToString();
		this.lblNominalHeat.Text=model.NominalHeat;
		this.lblNominalCool.Text=model.NominalCool;
		this.lblHeatInputPower.Text=model.HeatInputPower;
		this.lblCoolInputPower.Text=model.CoolInputPower;
		this.lblWType.Text=model.WType;

	}


    }
}
