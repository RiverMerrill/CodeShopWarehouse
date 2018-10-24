using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeShopWarehouse.Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CodeShopWarehouse.Data;
using CodeShopWarehouse.Shared.Interfaces;
using CodeShopWarehouse.Web.Models;

namespace CodeShopWarehouse.Web.Controllers
{
    public class OrdersViewController : Controller
    {
        private readonly IOrdersService _ordersService;

        public OrdersViewController(IOrdersService ordersService)
        {
            _ordersService = ordersService;
        }

        // GET: Orders1
        public async Task<IActionResult> Index()
        {
            return View(_ordersService.GetUnprocessedOrders());
        }

        // GET: Orders1/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var order = _ordersService.GetOrderById(id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // GET: Orders1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Orders1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProductId,Stock,OrderType,CreatedAt,FilledAt")] Order order)
        {
            return View(_ordersService.CreateOrder(order));
        }

        // GET: Orders1/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var order = _ordersService.UpdateOrder(id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        // POST: Orders1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(int id)
//        {
//            IOrder order = _ordersService.UpdateOrder(id);
//            return View(order);
//        }
    }
}
