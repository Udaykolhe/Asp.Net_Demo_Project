using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Net.Http;

namespace OAuthApi
{
    public class AppAuthorizeAttribute : AuthorizeAttribute 
    {
        protected override void HandleUnauthorizedRequest(System.Web.Http.Controllers.HttpActionContext actionContext)
        {
            if (HttpContext.Current.User.Identity.IsAuthenticated)
            {
                base.HandleUnauthorizedRequest(actionContext);
            }
            else
            {
                actionContext.Response = new HttpResponseMessage(System.Net.HttpStatusCode.Forbidden);
            }
           
        }
    }
}