using CodeShopWarehouse.Business;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using CodeShopWarehouse.Data;
using CodeShopWarehouse.Shared;
using CodeShopWarehouse.Shared.Interfaces;

namespace CodeShopWarehouse.CoolWeb.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IOrdersService _ordersService;
        public OrdersController(IOrdersService ordersService)
        {
            _ordersService = ordersService;
        }
        // GET
        public IActionResult Index()
        {
            return View(_ordersService.GetUnprocessedOrders());
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            var order = _ordersService.GetOrderById(id);
            return View(order);
        }

        public IActionResult ProductId(int id)
        {
            var orders = _ordersService.GetOrdersByProductId(id);
            return View(orders);
        }

        [HttpPost]
        public IActionResult FillOrder([FromForm] int id)
        {
            _ordersService.UpdateOrder(id);
            return RedirectToAction("Index", id);
        }
        
        [HttpPost]
        public IActionResult CreatePost([FromForm] Order order)
        {
            _ordersService.CreateOrder(order);
            return Redirect("Index");
        }
       
    }
}