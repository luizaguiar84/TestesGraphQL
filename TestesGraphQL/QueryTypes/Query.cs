using HotChocolate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestesGraphQL.Interfaces;
using TestesGraphQL.Models;
using TestesGraphQL.QueryTypes;

namespace TestesGraphQL.QueryTypes
{
    public class Query
    {
        public Customer GetCustomer([Service] IProfileRepository repository) => repository.GetCustomer();
        public Teste GetTeste([Service] IProfileRepository repository) => repository.GetTeste();
        public string Hello() => "World";
        public string Teste() => "testado!";
    }
}
