using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Filters;

namespace WebAPI_OwinPipeLine
{
    public class TestAuthonticationAttribute : Attribute,IAuthenticationFilter
    {
        public TestAuthonticationAttribute()
        {
        }

        public bool AllowMultiple => false;

        public async Task AuthenticateAsync(HttpAuthenticationContext context, CancellationToken cancellationToken)
        {
            Helper.Write("AuthonticationFilter", context.ActionContext.RequestContext.Principal);
        }

        public async Task ChallengeAsync(HttpAuthenticationChallengeContext context, CancellationToken cancellationToken)
        {
           // throw new NotImplementedException();
        }
    }
}