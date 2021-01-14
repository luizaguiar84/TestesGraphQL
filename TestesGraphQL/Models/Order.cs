using System;
using System.Collections.Generic;

namespace TestesGraphQL.QueryTypes
{
    public class Order
    {
        #region Public Properties

        public DateTime Date { get; set; }
        public List<Item> Items { get; set; }
        public decimal Total { get; set; }

        #endregion Public Properties
    }
}