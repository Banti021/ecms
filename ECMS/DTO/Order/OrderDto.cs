using System.ComponentModel.DataAnnotations;
using ECMS.Enums;

namespace ECMS.DTO.Order;

public class OrderDto
{
    [Required]
    public int OrderNumber { get; set; }
        
    [Required]
    public DateTime OrderDate { get; set; }
        
    [Required]
    public OrderStatus Status { get; set; }
        
    public Decimal? TotalAmount { get; set; }
        
    [Required]
    public int CustomerId { get; set; }
}