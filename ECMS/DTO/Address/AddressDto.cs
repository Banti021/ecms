using System.ComponentModel.DataAnnotations;

namespace ECMS.DTO;

public class AddressDto
{
    [Required, StringLength(100)]
    public String City { get; set; }
        
    [Required, StringLength(100)]
    public String Street { get; set; }
        
    [Required, StringLength(50)]
    public String BuildingNo { get; set; }
}