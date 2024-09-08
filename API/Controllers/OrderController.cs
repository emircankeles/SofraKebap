using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SofraKebab.BusinessLayer.Abstract;
using SofraKebab.DataAccessLayer.Abstract;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
           _orderService = orderService;
        }
        [HttpGet("TotalOrderCount")]
        public IActionResult TotalOrderCount() 
        {
            var value = _orderService.TTotalOrderCount();
            return Ok(value);
        }
        [HttpGet("ActiveOrderCount")]
        public IActionResult ActiveOrderCount()
        {
            var value = _orderService.TActiveOrderCount();
            return Ok(value);
        }
        [HttpGet("LastOrderPrice")]
        public IActionResult LastOrderPrice()
        {
            var value = _orderService.TLastOrderPrice();
            return Ok(value);
        }
        [HttpGet("TodayOrderPrice")]
        public IActionResult TodayOrderPrice()
        {
            var value = _orderService.TTodayOrderPrice();
            return Ok(value);
        }
    }
}
