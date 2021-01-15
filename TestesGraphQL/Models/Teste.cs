using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestesGraphQL.Models
{
    public class Teste
    {
        public string Inicio { get;  set; }
        public string Fim { get;  set; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
