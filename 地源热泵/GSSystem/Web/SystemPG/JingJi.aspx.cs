using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GSSystem.Web.SystemPG
{
    public partial class JingJi : System.Web.UI.Page
    {
        double Qs = 0;
        double q = 29.037;
        double Cs = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.Cookies["CookieValue"].Values["Qs"] != null)
                {
                    string Qs1 = Request.Cookies["CookieValue"].Values["Qs"];
                    Qs = Convert.ToDouble(Qs1);
                }
            }
            catch
            {
                Response.Redirect("ChangGui.aspx");
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