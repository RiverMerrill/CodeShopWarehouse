using System;
using System.Collections.Generic;
using CodeShopWarehouse.Shared.Interfaces;

namespace CodeShopWarehouse.Data
{
    public class FakeDb
    {
        public static int nextId = 6;
        public static List<IOrder> Orders = new List<IOrder>
        {
            new Order()
            {
                ProductId = 1,
                CreatedAt = DateTimeOffset.Now,
                Id = 1,
                OrderType = OrderTypeEnum.Add,
                Stock = 3
            },
            new Order()
            {
                ProductId = 12,
                CreatedAt = DateTimeOffset.Now,
                Id = 2,
                OrderType = OrderTypeEnum.Add,
                Stock = 3
            },
            new Order()
            {
                ProductId = 25,
                CreatedAt = DateTimeOffset.Now,
                Id = 3,
                OrderType = OrderTypeEnum.Add,
                Stock = 3
            },
            new Order()
            {
                ProductId = 30,
                CreatedAt = DateTimeOffset.Now,
                Id = 4,
                OrderType = OrderTypeEnum.Add,
                Stock = 3
            },
            new Order()
            {
                ProductId = 22,
                CreatedAt = DateTimeOffset.Now,
                Id = 5,
                OrderType = OrderTypeEnum.Add,
                Stock = 3
            },
        };
    }
}