using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Owin;

namespace WebAPI_OwinPipeLine
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            var configuration = new HttpConfiguration();
            configuration.Routes.MapHttpRoute("default", "api/{controller}");
            appBuilder.Use(typeof(TestMiddleWare));
            appBuilder.UseWebApi(configuration);
        }
    }
}