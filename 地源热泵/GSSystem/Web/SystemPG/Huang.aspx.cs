using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GSSystem.Web.SystemPG
{
    public partial class Huang : System.Web.UI.Page
    {
        double Qs = 0;
        double Vco2 = 2.47;
        double Vso2 = 0.02;
        double Vfc = 0.01;
        protected void Page_Load(object sender, EventArgs e)
        {
            double Qs1;
            double Qs2;
            Qs1 = Convert.ToDouble(Session["value1"]);
            Qs2 = Convert.ToDouble(Session["value2"]);
            Qs = Qs1 + Qs2;
            if (Qs != 0)
            {
                double Qco2 = Qs * Vco2;
                double Qso2 = Qs * Vso2;
                double Qfc = Qs * Vfc;
                Label3.Text = Qco2.ToString();
                Session["value3"] = Label3.Text;
                Label2.Text = Qso2.ToString();
                Session["value4"] = Label2.Text;
                Label1.Text = Qfc.ToString();
                Session["value5"] = Label1.Text;
            }
            else
            {
                Response.Redirect("chang.aspx");
            }
        }
    }
}