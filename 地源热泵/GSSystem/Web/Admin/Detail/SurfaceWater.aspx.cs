using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GSSystem.Web.Admin.Detail
{
    public partial class SurfaceWater : System.Web.UI.Page
    {
        SqlConnection sqlcon;
        //string strCon = "server=.;database=GroundSourceSystem;uid=sa;pwd=123";
        string strCon = System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];
        protected void Page_Load(object sender, EventArgs e)
        {
            string ProName = Request.QueryString["ProName"];
            string sqlstr = "select a.id,a.ProName,a.WType,a.ProAdd,a.DetailAdd,a.ProType,a.ConUnit,a.HpManufacturer,a.FinTime,a.CoveredArea,a.HpType,a.EngCharacter,a.UseFormat,a.TerminalForm,a.ProjectTHHp,a.ProjectTCHp,a.HpEquipmentType,a.HpEquipmentNum,a.NominalHeat,a.NominalCool,a.HeatInputPower,a.CoolInputPower,b.ProName,b.WType,b.Type,b.Dowtherm,b.WPNum,b.WPHead,b.WPFlow,b.WPPower,b.HEType,b.HENum,b.HEHeatArea,b.SWITemp,b.SWOTemp,b.SWFlow,b.DNum,b.DType,b.SWTSize,b.SWTType,b.WSPNum,b.WSPPower,b.PVFrequ,c.ProName,c.WType,c.HSSCPNum,c.HSSCPPower,c.HSSCPHead,c.HSSCPFlow,d.ProName,d.WType,d.USCPNum,d.USCPPower,d.USCPHead,d.USCPFlow,w.ProName,w.WType,w.WWPWTemp,w.WWRWTemp,w.WHSSInWTemp,w.WHSSBackWTemp,w.WHSSCWater,w.WUEWSTemp,w.WUEBWTemp,w.WUECircul,w.WRTempeRange,s.ProName,s.WType,s.SHSSInWTemp,s.SHSSBackWTemp,s.SHSSCWater,s.SUEWSTemp,s.SUEBWTemp,s.SUECircul,s.SRTempRange,p.ProName,p.WType,p.ProTotalCost,p.UnitCost,p.SystemCost,p.ProTel from ProjectCommonCity as a inner join SurfaceWater as b on(a.ProName=b.ProName) inner join HSSCP as c on(b.ProName=c.ProName) inner join USCP as d on(c.ProName=d.ProName) inner join WinterType as w on(d.ProName=w.ProName) inner join SummerType as s on(w.ProName=s.ProName) inner join ProjectCost as p on(s.ProName=p.ProName) where a.ProName='" + ProName + "'";//
            sqlcon = new SqlConnection(strCon);
            SqlDataAdapter myda = new SqlDataAdapter(sqlstr, sqlcon);
            DataSet myds = new DataSet();
            sqlcon.Open();
            myda.Fill(myds);
            DataList1.DataSource = myds.Tables[0].DefaultView;
            DataList1.DataBind();
            sqlcon.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string proName = Request.QueryString["ProName"];
            Export("application/ms-excel", proName + "地源热泵信息.xls");
        }
        private void Export(string FileType, string FileName)
        {
            string proName = Request.QueryString["ProName"];
            Response.ClearContent();
            Response.Buffer = false;
            Response.Charset = "GB2312";//设置文字编码为楷体
            Response.AppendHeader("content-disposition", "attachment;filename=\"" + System.Web.HttpUtility.UrlEncode(proName + "地源热泵信息", System.Text.Encoding.UTF8) + ".xls\"");
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("GB2312");
            Response.ContentType = "application/ms-excel";
            Response.Write("<meta http-equiv=Content-Type content=\"text/html; charset=GB2312\">");//设置输出文件类型为excel文件。
            this.EnableViewState = false;
            StringWriter SW = new StringWriter();
            HtmlTextWriter HW = new HtmlTextWriter(SW);
            DataList1.DataBind();
            DataList1.RenderControl(HW);//输出字符
            Response.Write(SW.ToString());
            Response.End();
            DataList1.DataBind();//绑定数据源
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            //这个方法不能删除掉
        } 
    }
}