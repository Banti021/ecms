using System.ComponentModel.DataAnnotations;
using ECMS.Enums;

namespace ECMS.DTO.Reservation;

public class ReservationDto
{
    public int Id { get; set; }
        
    [Required]
    public DateTime ReservationFrom { get; set; }
        
    [Required]
    public DateTime ReservationTo { get; set; }
        
    [Required]
    public ReservationStatus Status { get; set; }
        
    [Required]
    public ReservationCategory Category { get; set; }
        
    [Required]
    public int NumberOfGuests { get; set; }
        
    [Required]
    public DateTime? ConfirmedAt { get; set; }
    
    [Required]
    public string AdditionalInfo { get; set; }
    
    public List<int> AreaIds { get; set; }
}