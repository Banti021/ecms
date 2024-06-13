using System.ComponentModel.DataAnnotations;

namespace ECMS.DTO;

public class EventDto
{
    public int Id { get; set; }
        
    [Required, StringLength(100)]
    public string Title { get; set; }
        
    [Required]
    public int EventCategory { get; set; }
        
    [Required]
    public Decimal RegularPrice { get; set; }
        
    [Required]
    public Decimal VipPrice { get; set; }
        
    [Required]
    public DateTime StartTime { get; set; }
        
    [Required]
    public DateTime EndTime { get; set; }
        
    [Required, StringLength(255)]
    public string Description { get; set; }
        
    [Required]
    public int MaxAttendees { get; set; }
    
    public int CurrentAttendees { get; set; }
}