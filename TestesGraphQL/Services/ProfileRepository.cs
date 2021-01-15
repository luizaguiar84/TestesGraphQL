using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestesGraphQL.Interfaces;
using TestesGraphQL.Models;
using TestesGraphQL.QueryTypes;

namespace TestesGraphQL.Services
{
    public class ProfileRepository : IProfileRepository
    {
        public Customer GetCustomer()
        {
            return new Customer
            {
                Title = "Mr",
                LastName = "Aguiar",
                FirstName = "Luiz"
            };
        }

        public Teste GetTeste()
        {
            return new Teste
            {
                Inicio = "Inicio Teste",
                Fim = "Fim Teste"
            };
        }
    }
}
