using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GSSystem.Web.SystemPG
{
    public partial class chang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            double cop;
            double eer;
            cop = Convert.ToDouble(Session["value8"]);
            eer = Convert.ToDouble(Session["value8"]);
            if(cop==0 && eer==0)
            {
                Response.Write("<script>alert('请先计算系统COP和EER值！');</script>");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double cop;
            double eer;
            cop = Convert.ToDouble(Session["value8"]);
            eer = Convert.ToDouble(Session["value8"]);
            if (TextBox1.Text.Trim() =="")
            {
                Response.Write("<script>alert('请输入QH值！');</script>");
            }
            if (TextBox2.Text.Trim() =="")
            {
                Response.Write("<script>alert('请输入η值！');</script>");
            }
            if (TextBox3.Text.Trim() =="")
            {
                Response.Write("<script>alert('请输入Qr值！');</script>");
            }
            else
            {
                double q = 29.307;
                double c =3.6;                
                double Qh = Convert.ToDouble(TextBox1.Text);
                double n = Convert.ToDouble(TextBox2.Text);
                double D = Convert.ToDouble(TextBox3.Text);
                double Qrh = D*Qh / (c*cop);
                double Qt = Qh / (n * q);
                double Qs = Qt - Qrh;
                TextBox8.Text = Qs.ToString();           
                Session["value1"] = TextBox8.Text;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            double cop;
            double eer;
            cop = Convert.ToDouble(Session["value8"]);
            eer = Convert.ToDouble(Session["value8"]);
            if (TextBox7.Text.Trim() == "")
            {
                Response.Write("<script>alert('请输入D值！');</script>");
            }
           
            else if (TextBox4.Text.Trim() == "")
            {
                Response.Write("<script>alert('请输入Qc值！');</script>");
            }
            else if (TextBox5.Text.Trim() == "")
            {
                Response.Write("<script>alert('请输入EER值！');</script>");
            }
           
            else
            {
                double q = 3.6;
                double D = Convert.ToDouble(TextBox7.Text);
                double Qc = Convert.ToDouble(TextBox4.Text);
                double EER = Convert.ToDouble(TextBox5.Text);
                double Qrc = (D * Qc) / (eer * q);
                double Qt = (D * Qc) / (q * EER);
                double Qs = Qt - Qrc;
                TextBox11.Text = Qs.ToString();
                Session["value2"] = TextBox11.Text;
            }
        }
    }
}