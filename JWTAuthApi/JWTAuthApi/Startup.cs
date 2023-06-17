using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Security.OAuth;
using OAuthApi.Provider;
using System.Web.Http;

[assembly: OwinStartup(typeof(OAuthApi.Startup))]

namespace OAuthApi
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888

            //enable cors Origin Requests
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            var option = new OAuthAuthorizationServerOptions //Work as middleware
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/token"), //http://localhost:12825/token
                AccessTokenExpireTimeSpan = TimeSpan.FromMinutes(30),
                Provider = new AppAuthorizationServerProvider()
            };
            app.UseOAuthAuthorizationServer(option);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());

            HttpConfiguration config = new HttpConfiguration();
            WebApiConfig.Register(config);

        }
    }
}
