using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProductsCore;

namespace ProductsApp.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class PostsController : ApiController
    {
        private readonly Business _business = new Business();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Post> GetAllProducts()
        {
            return _business.Query();
        }
        [HttpPost]
        [RequestAuthorize]
        public IEnumerable<Post> PostAllProducts(Post strwhere)
        {
            return _business.Query(strwhere);
        }
    }
}
