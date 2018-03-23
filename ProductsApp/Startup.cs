using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Security.Infrastructure;
using Microsoft.Owin.Security.OAuth;
using Owin;
using ProductsApp.OAuth;

namespace ProductsApp
{
    /// <summary>
    /// 
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();
            WebApiConfig.Register(config);
            app.UseCors(CorsOptions.AllowAll);
            ConfigureOAuth(app);
            app.UseWebApi(config);
        }

        private void ConfigureOAuth(IAppBuilder app)
        {
            OAuthAuthorizationServerOptions oAuthServerOptions = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true, //允许客户端使用http协议请求
                TokenEndpointPath = new PathString("/token"), //token请求的地址，即http://localhost:端口号/token；
                AccessTokenExpireTimeSpan = TimeSpan.FromMinutes(30), //token过期时间；
                RefreshTokenProvider = new SimpleRefreshTokenProvider(),//refresh_token 授权服务
                Provider = new SimpleAuthorizationServerProvider() //提供具体的认证策略； 
            };
            app.UseOAuthAuthorizationServer(oAuthServerOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());


            
        } 
    }
}