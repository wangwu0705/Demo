using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GSSystem.Web.SystemPG
{
    public partial class JiZu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            double P = 1000;
            double c = 4.18;
            double cont = 3600;
            double Vcop = Convert.ToDouble(TextBox1.Text);
            double VeeR = Convert.ToDouble(TextBox4.Text);
            double Δt = Convert.ToDouble(TextBox2.Text);
            double N = Convert.ToDouble(TextBox3.Text);
            double Q1 = Vcop * P * c * Δt;
            double Q2 = VeeR * P * c * Δt;
            double Q = Q1 / cont;
            double Qs = Q2 / cont;
            double COP = Q / N;
            double EER = Qs / N;
            TextBox5.Text = COP.ToString();
            Session["value6"] = TextBox5.Text;
            TextBox6.Text = EER.ToString();
            Session["value7"] = TextBox6.Text;
        }
    }
}