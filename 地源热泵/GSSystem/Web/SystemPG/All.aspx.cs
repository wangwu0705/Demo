using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GSSystem.Web.SystemPG
{
    public partial class All : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double Qs1;
            double Qs2;
            double Qco2;
            double Qso2;
            double Qfc;
            double COPj;
            double EERj;
            double COPs;
            double EERs;
            Qs1 = Convert.ToDouble(Session["value1"]);
            Qs2 = Convert.ToDouble(Session["value2"]);
            Qco2 = Convert.ToDouble(Session["value3"]);
            Qso2 = Convert.ToDouble(Session["value4"]);
            Qfc = Convert.ToDouble(Session["value5"]);
            COPj = Convert.ToDouble(Session["value6"]);
            EERj = Convert.ToDouble(Session["value7"]);
            COPs = Convert.ToDouble(Session["value8"]);
            EERs = Convert.ToDouble(Session["value9"]);
            if (Qs1 == 0 && Qs2 == 0)
            {
                Response.Redirect("chang.aspx");
            }
            if (Qco2 == 0 || Qso2 == 0 || Qfc==0)
            {
                Response.Redirect("Huang.aspx");
            }
            if (COPj == 0 || EERj == 0)
            {
                Response.Redirect("JiZu.aspx");
            }
            if (COPs == 0 || EERs == 0)
            {
                Response.Redirect("SystemCE.aspx");
            }
            if(DropDownList1.Text =="冬季使用")
            {
                Label2.Text = Qs1.ToString();
                Label3.Text = Qco2.ToString();
                Label4.Text = Qso2.ToString();
                Label5.Text = Qfc.ToString();
                Label8.Text = COPj.ToString(); 
                Label9.Text = EERj.ToString();
                Label6.Text = COPs.ToString();
                Label7.Text = EERs.ToString();
                if(COPs>=3.5&&EERs >=3.9)
                {
                    Label10.Text ="I级";
                }
                else if(COPs<=2.6 && COPs<3.0 && EERs>=2.6&&EERs<3.0)
                {
                    Label10.Text = "II级";
                }
                else
                {
                    Label10.Text = "III级";
                }
                
            }
            if (DropDownList1.Text == "夏季使用")
            {
                Label2.Text = Qs2.ToString();
                Label3.Text = Qco2.ToString();
                Label4.Text = Qso2.ToString();
                Label5.Text = Qfc.ToString();
                Label8.Text = COPj.ToString();
                Label9.Text = EERj.ToString();
                Label6.Text = COPs.ToString();
                Label7.Text = EERs.ToString();
            }
            if (DropDownList1.Text == "冬夏季使用")
            {
                double sum = Qs1 + Qs2;
                Label2.Text = sum.ToString();
                Label3.Text = Qco2.ToString();
                Label4.Text = Qso2.ToString();
                Label5.Text = Qfc.ToString();
                Label8.Text = COPj.ToString();
                Label9.Text = EERj.ToString();
                Label6.Text = COPs.ToString();
                Label7.Text = EERs.ToString();
            }
        }
    }
}