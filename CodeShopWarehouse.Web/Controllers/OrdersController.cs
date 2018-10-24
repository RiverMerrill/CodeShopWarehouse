using CodeShopWarehouse.Business;
using CodeShopWarehouse.Shared.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CodeShopWarehouse.Web.Controllers
{
    [Route("api/[controller]")]
    public class OrdersController : Controller
    {
        private readonly IOrdersService _ordersService;
        public OrdersController(IOrdersService ordersService)
        {
            _ordersService = ordersService;
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_ordersService.GetOrderById(id));
        }

        [HttpGet("Unprocessed")]
        public IActionResult GetUnprocessed()
        {
            return Ok(_ordersService.GetUnprocessedOrders());
        }
        
        [HttpGet("ProductId/{id}")]
        public IActionResult GetByProductId(int id)
        {
            return Ok(_ordersService.GetOrdersByProductId(id));
        }
        
        [HttpPost("Create")]
        public IActionResult Post([FromBody] IOrder order)
        {
            return Ok(_ordersService.CreateOrder(order));
        }
        
        [HttpPost("update/{id}")]
        public void Put(int id)
        {
            _ordersService.UpdateOrder(id);
        }
        
    }
}