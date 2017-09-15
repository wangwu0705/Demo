using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GSSystem.Web.InputDate
{
    /// <summary>
    /// WinterType2 的摘要说明
    /// </summary>
    public class WinterType2 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            int id = int.Parse(context.Request["id"]);
            GSSystem.BLL.WinterType biBll = new GSSystem.BLL.WinterType();
            if (biBll.Delete(id))
            {
                context.Response.Write(1);
            }
            else
            {
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