using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace WebAPI_OwinPipeLine
{
    public static class Helper
    {
        public static void Write(string stage,IPrincipal principal)
        {
            Debug.WriteLine("------" + stage + "------");
            if(principal==null || principal.Identity==null || !principal.Identity.IsAuthenticated)
            {
                Debug.WriteLine("anonymous user");
            }
            else
            {
                Debug.WriteLine("user:" + principal.Identity.Name);

            }
            Debug.WriteLine("\n");

        }
    }
}