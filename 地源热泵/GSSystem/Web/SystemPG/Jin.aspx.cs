using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GSSystem.Web.SystemPG
{
    public partial class Jin : System.Web.UI.Page
    {
        double Qs = 0;
        double q = 29.037;
        double Cs = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            double Qs1 = Convert.ToDouble(Session["value1"]);
            double Qs2 = Convert.ToDouble(Session["value2"]);
            Qs = Qs1 + Qs2;
            if (Qs == 0)
            {
                Response.Redirect("chang.aspx");
            }           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double M = Convert.ToDouble(TextBox1.Text);
            double Pr = Convert.ToDouble(TextBox2.Text);
            double R = Convert.ToDouble(TextBox3.Text);
            double P = Pr / R;
            Cs = P * ((Qs * q) / 3.6) - M;
            Label1.Text = Cs.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            double C = Convert.ToDouble(TextBox4.Text);
            double N = C / Cs;
            Label2.Text = N.ToString();
        }
    }
}