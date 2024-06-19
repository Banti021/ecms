using ECMS.Context;
using ECMS.DTO.Order;
using ECMS.Enums;
using ECMS.Models;
using Microsoft.EntityFrameworkCore;

namespace ECMS.Services
{
    public class OrderService
    {
        private readonly ApplicationContext _context;

        public OrderService(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<List<OrderDto>> GetAllOrdersAsync(CancellationToken token)
        {
            var orders = await _context.Orders.Include(o => o.OrderProducts)
                                              .Include(o => o.Customer)
                                              .Select(o => new OrderDto
                                              {
                                                  OrderNumber = o.OrderNumber,
                                                  OrderDate = o.OrderDate,
                                                  Status = o.Status,
                                                  TotalAmount = o.TotalAmount,
                                                  CustomerId = o.CustomerId
                                              }).ToListAsync(token);

            return orders;
        }

        public async Task<OrderDto> GetOrderByNumberAsync(int orderNumber, CancellationToken token)
        {
            var order = await _context.Orders.Include(o => o.OrderProducts)
                                             .Include(o => o.Customer)
                                             .FirstOrDefaultAsync(o => o.OrderNumber == orderNumber, token);
            if (order == null) throw new Exception("Order not found");

            return new OrderDto
            {
                OrderNumber = order.OrderNumber,
                OrderDate = order.OrderDate,
                Status = order.Status,
                TotalAmount = order.TotalAmount,
                CustomerId = order.CustomerId
            };
        }

        public async Task<OrderDto> AddOrderAsync(OrderDto orderDto)
        {
            var order = new Order
            {
                OrderNumber = orderDto.OrderNumber,
                OrderDate = orderDto.OrderDate,
                Status = orderDto.Status,
                CustomerId = orderDto.CustomerId,
                OrderProducts = new List<OrderProduct>()
            };

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            
            order.TotalAmount = order.CalculateTotalAmount();
            await _context.SaveChangesAsync();

            orderDto.OrderNumber = order.OrderNumber;
            orderDto.TotalAmount = order.TotalAmount;
            return orderDto;
        }

        public async Task<OrderDto> UpdateOrderAsync(int orderNumber, OrderDto orderDto)
        {
            var order = await _context.Orders.Include(o => o.OrderProducts)
                .FirstOrDefaultAsync(o => o.OrderNumber == orderNumber);
            if (order == null) throw new Exception("Order not found");

            order.OrderNumber = orderDto.OrderNumber;
            order.OrderDate = orderDto.OrderDate;
            order.Status = orderDto.Status;
            order.CustomerId = orderDto.CustomerId;
            
            order.TotalAmount = order.CalculateTotalAmount();
            await _context.SaveChangesAsync();

            return orderDto;
        }

        public async Task DeleteOrderAsync(int orderNumber)
        {
            var order = await _context.Orders.Include(o => o.OrderProducts)
                .FirstOrDefaultAsync(o => o.OrderNumber == orderNumber);
            if (order == null) throw new Exception("Order not found");

            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
        }

        public async Task AddProductToOrderAsync(int orderNumber, int productId, int quantity)
        {
            var order = await _context.Orders.Include(o => o.OrderProducts)
                .FirstOrDefaultAsync(o => o.OrderNumber == orderNumber);
            if (order == null) throw new Exception("Order not found");

            var product = await _context.Products.FindAsync(productId);
            if (product == null) throw new Exception("Product not found");

            var orderProduct = order.OrderProducts.FirstOrDefault(op => op.ProductId == productId);
            if (orderProduct == null)
            {
                orderProduct = new OrderProduct
                {
                    OrderId = order.Id,
                    ProductId = productId,
                    Quantity = quantity
                };
                order.OrderProducts.Add(orderProduct);
            }
            else
            {
                orderProduct.Quantity += quantity;
            }
            
            order.TotalAmount = order.CalculateTotalAmount();
            await _context.SaveChangesAsync();
        }

        public async Task RemoveProductFromOrderAsync(int orderNumber, int productId)
        {
            var order = await _context.Orders.Include(o => o.OrderProducts)
                .FirstOrDefaultAsync(o => o.OrderNumber == orderNumber);
            if (order == null) throw new Exception("Order not found");

            var orderProduct = order.OrderProducts.FirstOrDefault(op => op.ProductId == productId);
            if (orderProduct == null) throw new Exception("Product not found in order");

            order.OrderProducts.Remove(orderProduct);
            
            order.TotalAmount = order.CalculateTotalAmount();
            await _context.SaveChangesAsync();
        }
    }
}
