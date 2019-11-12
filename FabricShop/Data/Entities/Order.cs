using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FabricShop.Data.Entities
{
    public class Order
    {
        public string OrderId { get; set; }
        public string ProductCode { get; set; }
        public string OrderType{ get; set; }
        public int DeliveryDistance { get; set; }
        public int DeliveryTime { get; set; }
    }
}
