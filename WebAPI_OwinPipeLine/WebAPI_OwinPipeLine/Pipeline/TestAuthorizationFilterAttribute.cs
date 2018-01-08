using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace WebAPI_OwinPipeLine
{
    public class TestAuthorizationFilterAttribute : AuthorizeAttribute
    {
        public TestAuthorizationFilterAttribute()
        {
        }
        protected override bool IsAuthorized(HttpActionContext actionContext)
        {
            Helper.Write("AuthorizationFilter", actionContext.RequestContext.Principal);
            return true;
        }
    }
}