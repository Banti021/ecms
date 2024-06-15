using System.ComponentModel.DataAnnotations;
using ECMS.Enums;

public class MakeReservationDto
{
    [Required]
    public DateTime ReservationFrom { get; set; }
        
    [Required]
    public DateTime ReservationTo { get; set; }
        
    [Required]
    public ReservationCategory Category { get; set; }
        
    [Required]
    public int NumberOfGuests { get; set; }
    
    [Required]
    public int AreaId { get; set; }
    
    [Required]
    public int CustomerId { get; set; }

    [Required]
    public string AdditionalInfo { get; set; } // Add this line
}