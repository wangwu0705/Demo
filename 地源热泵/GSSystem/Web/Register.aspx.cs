﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GSSystem.Web
{
    public partial class Register : System.Web.UI.Page
    {
        protected string Msg { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                if (Request["cName"] == null && Request["cpwd1"] == null)
                {
                    Msg = "用户名或密码为空，请重新输入";
                    return;
                }
                else
                {
                    GSSystem.Model.User ciModel = new GSSystem.Model.User();
                    ciModel.U_name = Request["cName"];
                    ciModel.U_mima = Request["cpwd1"];

                    GSSystem.BLL.User ciBll = new GSSystem.BLL.User();
                    if (ciBll.Add(ciModel) > 0)
                    {
                        Response.Redirect("Login.aspx");
                    }
                }
            }
        }
    }
}