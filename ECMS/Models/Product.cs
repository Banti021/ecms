using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ECMS.Enums;

namespace ECMS.Models
{
    [Table("products")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        
        [Required, StringLength(100)]
        public string Name { get; set; }
        
        [Required, StringLength(255)]
        public string Description { get; set; }
        
        [Required]
        public ProductType Category { get; set; }
        
        [Required]
        public int Price { get; set; }
        
        [Required]
        public int Stock { get; set; }
        
        public List<OrderProduct> OrderProducts { get; set; }
        public List<SupplierProduct> SupplierProducts { get; set; }
    }
}

