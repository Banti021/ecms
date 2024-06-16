using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ECMS.Enums;

namespace ECMS.DTO.Ticket;

public class TicketDto
{
    public int Id { get; set; }
        
    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public Decimal Price { get; set; }
        
    [Required]
    public bool IsSeated { get; set; }
        
    public String? SeatNumber { get; set; }
        
    [Required]
    public TicketType TicketType { get; set; }
}