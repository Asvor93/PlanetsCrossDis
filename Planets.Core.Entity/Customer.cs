using System;
using System.Collections.Generic;
using System.Text;

namespace Planets.Core.Entity
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public List<Order> GetAllOrdersFromCustomer { get; set; }
    }
}
