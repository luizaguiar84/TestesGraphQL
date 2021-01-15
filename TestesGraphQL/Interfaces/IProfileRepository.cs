using TestesGraphQL.Models;

namespace TestesGraphQL.Interfaces
{
    public interface IProfileRepository
    {
        Customer GetCustomer();

        Teste GetTeste();
    }
}