using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FabricShop.Data.Entities
{
    public class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string Weave { get; set; }
        public string Composition { get; set; }
        public string Color { get; set; }
        public string Cate1 { get; set; }
        public string Cate2 { get; set; }
        public string Cate3 { get; set; }
        public string VendorName { get; set; }
    }
}
