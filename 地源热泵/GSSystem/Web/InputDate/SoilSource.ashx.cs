using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GSSystem.Web.InputDate
{
    /// <summary>
    /// SoilSource2 的摘要说明
    /// </summary>
    public class SoilSource2 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            int id = int.Parse(context.Request["id"]);
            GSSystem.BLL.SoilSource biBll = new GSSystem.BLL.SoilSource();
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