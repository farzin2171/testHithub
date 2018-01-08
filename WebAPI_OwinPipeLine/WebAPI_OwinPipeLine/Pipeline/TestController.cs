using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace WebAPI_OwinPipeLine
{
    [TestAuthonticationAttribute]
    [TestAuthorizationFilter]
    public class TestController : ApiController
    {
        public IHttpActionResult Get()
        {
            //Helper.Write("Controller", Request.GetRequestContext().Principal);
            Helper.Write("Controller", User);
            return Ok();
        }
    }
}
