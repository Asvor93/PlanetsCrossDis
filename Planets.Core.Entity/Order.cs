using System;
using System.Collections.Generic;
using System.Text;

namespace Planets.Core.Entity
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public Customer Customer { get; set; }
        public List<Order> Orders { get; set; }
    }
}
