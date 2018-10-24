using System.Collections.Generic;
using CodeShopWarehouse.Shared.Interfaces;

namespace CodeShopWarehouse.Data.Interfaces
{
    public interface IOrdersRepo
    {
        IOrder GetOrderById(int id);
        IOrder UpdateOrder(int id);
        IOrder CreateOrder(IOrder data);
        IEnumerable<IOrder> GetUnProcessedOrders();
        IEnumerable<IOrder> GetOrdersByProductId(int id);
    }
}