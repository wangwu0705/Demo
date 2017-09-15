using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace Shop.Web
{
    public class PageBase:Page
    {
        public void Page_Init(object sender,EventArgs e)
        {
            if (Session["CustomerId"] == null)
            {
                //获取当前页URL，登陆后直接转到这个页面
                Session["urlLogin"] = Request.Url;

                Response.Redirect("CuetomerLogin.aspx");
            }
            else
            {
                Session["urlLogin"] = null;
            }
        }
  
    }
}