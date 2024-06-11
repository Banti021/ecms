using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECMS.Models
{
    [Table("order_products")]
    public class OrderProduct
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        
        [Required]
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        
        [Required]
        public int Quantity { get; set; }
        
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}