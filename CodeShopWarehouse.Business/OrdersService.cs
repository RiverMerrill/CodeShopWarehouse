using System;
using System.Collections;
using System.Collections.Generic;
using CodeShopWarehouse.Data;
using CodeShopWarehouse.Data.Interfaces;
using CodeShopWarehouse.Shared.Interfaces;

namespace CodeShopWarehouse.Business
{
    public class OrdersService : IOrdersService
    {
        public IOrdersRepo _ordersRepo;
        public OrdersService(IOrdersRepo ordersRepo)
        {
            _ordersRepo = ordersRepo;
        }

        public IOrder CreateOrder(IOrder order)
        {
            return _ordersRepo.CreateOrder(order);
        }
        public IOrder GetOrderById(int id)
        {
            return _ordersRepo.GetOrderById(id);
        }
        public IEnumerable<IOrder> GetOrdersByProductId(int id)
        {
            return _ordersRepo.GetOrdersByProductId(id);
        }
        public IOrder UpdateOrder(int id)
        {
            if (GetOrderById(id).FilledAt != null)
            {
                throw new Exception("Order has already been filled.");
            }
            return _ordersRepo.UpdateOrder(id);
        }
        public IEnumerable<IOrder> GetUnprocessedOrders()
        {
            return _ordersRepo.GetUnProcessedOrders();
        }
    }
}