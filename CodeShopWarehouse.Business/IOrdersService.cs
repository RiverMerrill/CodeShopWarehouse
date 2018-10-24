using System.Collections.Generic;
using CodeShopWarehouse.Shared.Interfaces;

namespace CodeShopWarehouse.Business
{
    public interface IOrdersService
    {
        IOrder CreateOrder(IOrder order);
        IOrder GetOrderById(int id);
        IEnumerable<IOrder> GetOrdersByProductId(int id);
        IOrder UpdateOrder(int id);
        IEnumerable<IOrder> GetUnprocessedOrders();
    }
}