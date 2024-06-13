using System.ComponentModel.DataAnnotations;
using Toolbelt.ComponentModel.DataAnnotations.Schema;

namespace ECMS.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [Obsolete("Obsolete")]
        public int OrderNumber { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public int Status { get; set; }

        public decimal? TotalAmount { get; set; }

        [Required]
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public List<OrderProduct> OrderProducts { get; set; }
    }
}