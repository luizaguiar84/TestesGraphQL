using HotChocolate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestesGraphQL.Interfaces;
using TestesGraphQL.QueryTypes;

namespace TestesGraphQL.QueryTypes
{
    public class Query
    {

        public Customer GetCustomer([Service] IProfileRepository repository) => repository.GetCustomer();
        public string Hello() => "World";
    }
}
