using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProductsApp.Models;

namespace ProductsApp.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [RoutePrefix("api/Orders")]
    public class OrdersController : ApiController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Authorize]
        [Route("")]
        public List<Order> Get()
        {
            return Order.CreateOrders();
        }
    }
}
