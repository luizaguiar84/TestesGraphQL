using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TestesGraphQL.Models;

namespace TestesGraphQL.QueryTypes
{
    public class TesteType : ObjectType<Teste>
    {
        protected override void Configure(IObjectTypeDescriptor<Teste> descriptor)
        {
            descriptor
                .Field(t => t.Orders)
                .ResolveWith<TesteResolver>(t => t.GetOrders(default!, default));
        }

        private class TesteResolver
        {
            public async Task<IEnumerable<Order>> GetOrders(
                Teste teste,
                CancellationToken cancellationToken)
            {
                return await Task.FromResult(new List<Order>
                {
                   new Order
                   {
                       Total = 50m,
                       Date = DateTime.Now,
                       Items = new List<Item>
                       {
                           new Item
                           {
                               Product = new Product
                               {
                                   Name = "Produto Teste"
                               },
                               Quantity = 1,
                               UnitCost = 43
                           }

                       }
                   }
                }.AsEnumerable());
            }
        }
    }
}
