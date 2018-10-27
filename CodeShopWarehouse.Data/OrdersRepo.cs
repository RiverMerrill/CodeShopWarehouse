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
            var order = data;
            data.Id = FakeDb.nextId;
            data.CreatedAt = DateTimeOffset.Now;
            FakeDb.nextId += 1;
            FakeDb.Orders.Add(order);
            return order;
        }
        public IOrder GetOrderById(int id)
        {
            return FakeDb.Orders.Find(x => x.Id == id);
        }

        public IOrder UpdateOrder(int id)
        {
            var order = FakeDb.Orders.Find(x => x.Id == id);
            order.FilledAt = DateTimeOffset.Now;
            return order;
        }

        public IEnumerable<IOrder> GetUnProcessedOrders()
        {
            return FakeDb.Orders.Where(x => x.FilledAt == null);
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