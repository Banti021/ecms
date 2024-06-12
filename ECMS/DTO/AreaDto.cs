using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECMS.DTO;

public class AreaDto
{
    [Required, StringLength(100)]
    public string Name { get; set; }
        
    [Required]
    public int Capacity { get; set; }
        
    [Required, StringLength(255)]
    public string Description { get; set; }
        
    [Required]
    public bool IsAvailable { get; set; }
    
    [Required]
    public int FacilityId { get; set; }
}