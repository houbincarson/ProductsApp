using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductsApp.OAuth
{
    class RefreshToken
    {
        public object Id { get; set; }
        public string Subject { get; set; }
        public DateTime IssuedUtc { get; set; }
        public DateTime ExpiresUtc { get; set; }
    }
}
