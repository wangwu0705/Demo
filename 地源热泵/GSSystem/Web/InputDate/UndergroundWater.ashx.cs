using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GSSystem.Web.InputDate
{
    /// <summary>
    /// UndergroundWater2 的摘要说明
    /// </summary>
    public class UndergroundWater2 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            int id = int.Parse(context.Request["id"]);
            GSSystem.BLL.UndergroundWater biBll = new GSSystem.BLL.UndergroundWater();
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