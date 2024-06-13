using System.ComponentModel.DataAnnotations;
using ECMS.Enums;

namespace ECMS.DTO.Shift;

public class ShiftDto
{
    public int Id { get; set; }
    
    [Required]
    public ShiftType ShiftType { get; set; }
        
    [Required]
    public DateTime FromHour { get; set; }
        
    [Required]
    public DateTime ToHour { get; set; }

}