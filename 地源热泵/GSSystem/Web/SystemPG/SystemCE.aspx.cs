using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GSSystem.Web.SystemPG
{
    public partial class SystemCE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double P = 1000;
            double c = 4.18;
            double cont = 3600;
           
            double tx = Convert.ToDouble(TextBox8.Text);
            double td = Convert.ToDouble(TextBox4.Text);
            double Ni = Convert.ToDouble(TextBox2.Text);
            double N = Convert.ToDouble(TextBox3.Text);
            double Vd = Convert.ToDouble(TextBox7.Text);
            double Vx = Convert.ToDouble(TextBox1.Text);
            double Td = Convert.ToDouble(TextBox9.Text);
            double Tx = Convert.ToDouble(TextBox5.Text);
            double qci =(Vd*P*c*td)/3600;
            double qhi =(Vx*P*c*tx)/3600;
            double Qsc = qci * Td;
            double Qsh = qhi * Tx;
            double cops =Qsc/(Ni+N);
            double eers = Qsh/(Ni + N);
            TextBox11.Text = cops.ToString();
            Session["value8"] = TextBox11.Text;
            TextBox12.Text = eers.ToString();
            Session["value9"] = TextBox12.Text;
        }
    }
}