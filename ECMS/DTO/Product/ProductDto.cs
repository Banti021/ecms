using System.ComponentModel.DataAnnotations;
using ECMS.Enums;

namespace ECMS.DTO.Product;

public class ProductDto
{
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
}