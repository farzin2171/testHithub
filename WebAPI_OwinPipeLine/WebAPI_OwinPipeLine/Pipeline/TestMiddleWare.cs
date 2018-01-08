using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Owin;

namespace WebAPI_OwinPipeLine
{
    public class TestMiddleWare
    {
        private Func<IDictionary<string, object>, Task> _next;

        public TestMiddleWare(Func<IDictionary<string,object>,Task> next)
        {
            _next = next;
        }
        public async Task Invoke(IDictionary<string,object> env)
        {
            var context = new OwinContext(env);
            //authentication
            context.Request.User = new GenericPrincipal(new GenericIdentity("farzin"), new string[] { });
            Helper.Write("MiddleWare", context.Request.User);
            await _next(env);
        }
    }
}