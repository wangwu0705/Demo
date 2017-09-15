using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GSSystem.Web
{
    /// <summary>
    /// CNameExists 的摘要说明
    /// </summary>
    public class CNameExists : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            string cname = context.Request["cname"];

            GSSystem.BLL.User ciBll = new GSSystem.BLL.User();
            if (ciBll.NameExists(cname))
            {
                //用户名已经存在
                context.Response.Write(1);
            }
            else
            {
                //用户名可以使用
                context.Response.Write(0);
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}