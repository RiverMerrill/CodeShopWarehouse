using System;
using System.Collections;
using System.Runtime.CompilerServices;
using CodeShopWarehouse.Shared.Interfaces;

namespace CodeShopWarehouse.Data
{
    public class Order : IOrder
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Stock { get; set; }
        public OrderTypeEnum OrderType { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? FilledAt { get; set; }
    }
}