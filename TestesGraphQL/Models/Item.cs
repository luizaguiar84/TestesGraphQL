using System;

namespace TestesGraphQL.QueryTypes
{
    public class Item
    {
        #region Public Properties

        public Product Product { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitCost { get; set; }

        #endregion Public Properties
    }
}