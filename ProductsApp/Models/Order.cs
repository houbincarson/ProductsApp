using System.Collections.Generic;

namespace ProductsApp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Order
    {
        /// <summary>
        /// 
        /// </summary>
        public int OrderID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CustomerName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ShipperCity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsShipped { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Order> CreateOrders()
        {
            var orderList = new List<Order>
                {
                    new Order
                    {
                        OrderID = 10248,
                        CustomerName = "Taiseer Joudeh",
                        ShipperCity = "Amman",
                        IsShipped = true
                    },
                    new Order
                    {
                        OrderID = 10249,
                        CustomerName = "Ahmad Hasan",
                        ShipperCity = "Dubai",
                        IsShipped = false
                    },
                    new Order
                    {
                        OrderID = 10250,
                        CustomerName = "Tamer Yaser",
                        ShipperCity = "Jeddah",
                        IsShipped = false
                    },
                    new Order
                    {
                        OrderID = 10251,
                        CustomerName = "Lina Majed",
                        ShipperCity = "Abu Dhabi",
                        IsShipped = false
                    },
                    new Order
                    {
                        OrderID = 10252,
                        CustomerName = "Yasmeen Rami",
                        ShipperCity = "Kuwait",
                        IsShipped = true
                    }
                };

            return orderList;
        }
    }
}