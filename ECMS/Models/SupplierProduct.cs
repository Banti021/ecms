using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECMS.Models
{
    [Table("supplier_products")]
    public class SupplierProduct
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [ForeignKey("Supplier")]
        public int SupplierId { get; set; }
        
        [Required]
        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public Supplier Supplier { get; set; }
        public Product Product { get; set; }
    }
}

