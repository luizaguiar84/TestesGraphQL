# TestesGraphQL
Api para testar uso de GraphQL no C# .Net Core 3.1

(chamar no endpoint /playground) 

Chamada de Teste:
{ 
  customer
    title
    firstName
    lastName
    orders{
      total
      items{
        quantity
        unitCost
        productId
        product{
          name
        }
      }
    }
  }
}
