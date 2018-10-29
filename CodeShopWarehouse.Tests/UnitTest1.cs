using System;
using System.Collections.Generic;
using CodeShopWarehouse.Business;
using CodeShopWarehouse.Data;
using CodeShopWarehouse.Data.Interfaces;
using CodeShopWarehouse.Shared.Interfaces;
using Moq;
using Xunit;

namespace CodeShopWarehouse.Tests
{
    public class UnitTest1
    {
        
        [Fact]
        public void Unresolved_Orders_Can_Be_Retrieved()
        {
            // Arrange
            var fakeData = new List<IOrder>()
            {
                new Order()
                {
                    CreatedAt = DateTimeOffset.Now,
                    Id = 1,
                    OrderType = OrderTypeEnum.Add,
                    ProductId = 2,
                    Stock = 1
                }
            };
            var mockOrdersRepo = new Mock<IOrdersRepo>();
            mockOrdersRepo.Setup(o => o.GetUnProcessedOrders())
                .Returns(fakeData);
            var ordersService = new OrdersService(mockOrdersRepo.Object);
            // Act
            var orders = ordersService.GetUnprocessedOrders();
            // Assert 
            Assert.NotNull(orders);
        }

        [Fact]
        public void Unresolved_Order_Can_Be_Processed()
        {
            // Arrange
            var mockOrdersRepo = new Mock<IOrdersRepo>();
            mockOrdersRepo.Setup(o => o.UpdateOrder(It.IsAny<int>()))
                .Returns(new Order()
                {
                    CreatedAt = DateTimeOffset.Now,
                    FilledAt = DateTimeOffset.Now,
                    Id = 1,
                    OrderType = OrderTypeEnum.Add,
                    ProductId = 2,
                    Stock = 1
                });
            mockOrdersRepo.Setup(o => o.GetOrderById(It.IsAny<int>()))
                .Returns(new Order()
                {
                    CreatedAt = DateTimeOffset.Now,
                    Id = 1,
                    OrderType = OrderTypeEnum.Add,
                    ProductId = 2,
                    Stock = 1
                });
            var ordersService = new OrdersService(mockOrdersRepo.Object);
            // Act
            var order = ordersService.UpdateOrder(12);
            // Assert 
            Assert.NotNull(order);
            Assert.NotNull(order.FilledAt);
        }

        [Fact]
        public void Processed_Order_Cannot_Be_Modified()
        {
            // Arrange
            var mockOrdersRepo = new Mock<IOrdersRepo>();
            mockOrdersRepo.Setup(o => o.GetOrderById(It.IsAny<int>()))
                .Returns(new Order()
                {
                    CreatedAt = DateTimeOffset.Now,
                    FilledAt = DateTimeOffset.Now,
                    Id = 1,
                    OrderType = OrderTypeEnum.Add,
                    ProductId = 2,
                    Stock = 1
                });
            var ordersService = new OrdersService(mockOrdersRepo.Object);
            // Act
            // Assert 
            Assert.Throws<Exception>(() => ordersService.UpdateOrder(12));
        }
    }
}