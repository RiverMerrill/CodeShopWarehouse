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
            return FakeDb.Orders.Where(x => x.ProductId == id);
        }
    }
}