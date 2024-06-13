using System.ComponentModel.DataAnnotations;

namespace ECMS.DTO.Supplier;

public class SupplierDto
{
    public int Id { get; set; }
        
    [Required, StringLength(100)]
    public String Name { get; set; }
        
    [Required, StringLength(50)]
    public String PhoneNumber { get; set; }
        
    [Required]
    public int AddressId { get; set; }
}