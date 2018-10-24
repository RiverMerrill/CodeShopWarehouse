using System;
using CodeShopWarehouse.Data;

namespace CodeShopWarehouse.Shared.Interfaces
{
    public interface IOrder
    {
        int Id { get; set; }
        int ProductId { get; set; }
        int Stock { get; set; }
        OrderTypeEnum OrderType { get; set; }
        DateTimeOffset CreatedAt { get; set; }
        DateTimeOffset? FilledAt { get; set; }
    }
}