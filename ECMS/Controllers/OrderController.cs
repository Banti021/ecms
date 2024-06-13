using ECMS.DTO.Order;
using ECMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECMS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly OrderService _service;

        public OrderController(OrderService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetOrders(CancellationToken token)
        {
            var orders = await _service.GetAllOrdersAsync(token);
            return Ok(orders);
        }

        [HttpGet("{orderNumber}")]
        public async Task<IActionResult> GetOrder(int orderNumber, CancellationToken token)
        {
            var order = await _service.GetOrderByNumberAsync(orderNumber, token);
            return Ok(order);
        }

        [HttpPost]
        public async Task<IActionResult> AddOrder([FromBody] OrderDto orderDto)
        {
            var order = await _service.AddOrderAsync(orderDto);
            return Ok(order);
        }

        [HttpPut("{orderNumber}")]
        public async Task<IActionResult> UpdateOrder(int orderNumber, [FromBody] OrderDto orderDto)
        {
            var order = await _service.UpdateOrderAsync(orderNumber, orderDto);
            return Ok(order);
        }

        [HttpDelete("{orderNumber}")]
        public async Task<IActionResult> DeleteOrder(int orderNumber)
        {
            await _service.DeleteOrderAsync(orderNumber);
            return NoContent();
        }

        [HttpPost("{orderNumber}/products/{productId}")]
        public async Task<IActionResult> AddProductToOrder(int orderNumber, int productId, [FromBody] int quantity)
        {
            await _service.AddProductToOrderAsync(orderNumber, productId, quantity);
            return Ok();
        }

        [HttpDelete("{orderNumber}/products/{productId}")]
        public async Task<IActionResult> RemoveProductFromOrder(int orderNumber, int productId)
        {
            await _service.RemoveProductFromOrderAsync(orderNumber, productId);
            return NoContent();
        }
    }
}
