using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ProductsApp.OAuth
{
    /// <summary>
    /// 
    /// </summary>
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        /// <summary>
        /// 
        /// </summary>
        public AuthContext() : base("AuthContext")
        {
            
        }
    }
}