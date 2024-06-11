using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECMS.Models
{
    [Table("orders")]
    public class Order
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int OrderNumber { get; set; }
        
        [Required]
        public DateTime OrderDate { get; set; }
        
        [Required]
        public int Status { get; set; }
        
        public Decimal? TotalAmount { get; set; }
        
        [Required]
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        
        public Customer Customer { get; set; }
        public List<OrderProduct> OrderProducts { get; set; }
    }
}
