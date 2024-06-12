using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECMS.DTO;

public class FacilityDto
{
    [Required, StringLength(100)]
    public string Name { get; set; }
        
    [Required]
    public int AddressId { get; set; }
        
    [Required, StringLength(255)]
    public string Description { get; set; }
        
    [Required]
    public int Capacity { get; set; }
}