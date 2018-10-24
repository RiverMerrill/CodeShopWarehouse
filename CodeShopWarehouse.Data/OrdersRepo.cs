using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CodeShopWarehouse.Data.Interfaces;
using CodeShopWarehouse.Shared.Interfaces;

namespace CodeShopWarehouse.Data
{
    public class OrdersRepo: IOrdersRepo
    {
        public IOrder CreateOrder(IOrder data)
        {
            return data;
        }
        public IOrder GetOrderById(int id)
        {
            return new Order
            {
                Id = id,
                Stock = 1,
                ProductId = 22,
                CreatedAt = DateTimeOffset.Now,
                OrderType = OrderTypeEnum.Add
            };
        }

        public IOrder UpdateOrder(int id)
        {
            return new Order
            {
                Id = id,
                ProductId = 1,
                CreatedAt = DateTimeOffset.UtcNow.AddDays(-1),
                FilledAt = DateTimeOffset.UtcNow,
                OrderType = OrderTypeEnum.Add,
                Stock = 200
            };
        }

        public IEnumerable<IOrder> GetUnProcessedOrders()
        {
            List<Order> Orders = new List<Order>();
            for (int i = 0; i < 20; i++)
            {
                var unprocessedOrder = new Order 
                    { Id = i, ProductId = i + 100, CreatedAt = DateTimeOffset.Now, OrderType = OrderTypeEnum.Add, Stock = i };
                var processedOrder = new Order
                    { Id = i, ProductId = i + 100, CreatedAt = DateTimeOffset.Now, OrderType = OrderTypeEnum.Add, Stock = i, FilledAt = DateTimeOffset.Now};
                Orders.Add(unprocessedOrder);
                Orders.Add(processedOrder);
            }
            return Orders.Where(x => x.FilledAt == null);
        }
        public IEnumerable<IOrder> GetOrdersByProductId(int id)
        {
            List<Order> Orders = new List<Order>();
            for (int i = 0; i < 20; i++)
            {
                var unprocessedOrder = new Order 
                    { Id = i, ProductId = id, CreatedAt = DateTimeOffset.Now, OrderType = OrderTypeEnum.Add, Stock = i };
                var processedOrder = new Order
                    { Id = i, ProductId = id, CreatedAt = DateTimeOffset.Now, OrderType = OrderTypeEnum.Add, Stock = i, FilledAt = DateTimeOffset.Now};
                Orders.Add(unprocessedOrder);
                Orders.Add(processedOrder);
            }
            return Orders;
        }
    }
}