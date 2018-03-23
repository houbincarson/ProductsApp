using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Infrastructure;
using ProductsApp.Entities;

namespace ProductsApp.OAuth
{
    /// <summary>
    /// 
    /// </summary>
    public class SimpleRefreshTokenProvider : AuthenticationTokenProvider
    {
        private static ConcurrentDictionary<string, string> _refreshTokens = new ConcurrentDictionary<string, string>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public override void Create(AuthenticationTokenCreateContext context)
        {
            context.Ticket.Properties.IssuedUtc = DateTime.UtcNow;
            context.Ticket.Properties.ExpiresUtc = DateTime.UtcNow.AddDays(60);
            context.SetToken(Guid.NewGuid().ToString("n"));
            _refreshTokens[context.Token] = context.SerializeTicket();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public override void Receive(AuthenticationTokenReceiveContext context)
        {
            string value;
            if (_refreshTokens.TryRemove(context.Token, out value))
            {
                context.DeserializeTicket(value);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override async Task CreateAsync(AuthenticationTokenCreateContext context)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override async Task ReceiveAsync(AuthenticationTokenReceiveContext context)
        {
            
        }
    }
}