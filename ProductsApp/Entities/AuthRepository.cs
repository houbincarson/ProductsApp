using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using ProductsApp.OAuth;

namespace ProductsApp.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class AuthRepository : IDisposable
    {
        private readonly AuthContext _ctx;
        private readonly UserManager<IdentityUser> _userManager;

        /// <summary>
        /// 
        /// </summary>
        public AuthRepository()
        {
            _ctx= new AuthContext();
            _userManager= new UserManager<IdentityUser>(new UserStore<IdentityUser>(_ctx));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userModel"></param>
        /// <returns></returns>
        public async Task<IdentityResult> RegisterUser(UserModel userModel)
        {
            IdentityUser user = new IdentityUser
             {
                 UserName = userModel.UserName
             };
            var result = await _userManager.CreateAsync(user, userModel.Password);
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public async Task<IdentityUser> FindUser(string userName, string password)
        {
            IdentityUser user = await _userManager.FindAsync(userName, password);
            return user;
        }

        public void Dispose()
        {
            _ctx.Dispose();
            _userManager.Dispose();

        }
    }
}