using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestesGraphQL.QueryTypes
{
    public class Customer
    {
        public Guid UserId { get; set; }
        public string Title { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
