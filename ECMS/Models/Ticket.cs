using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ECMS.Enums;

namespace ECMS.Models
{
    [Table("tickets")]
    public class Ticket
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public Decimal Price { get; set; }
        
        [Required]
        public bool IsSeated { get; set; }
        
        public String? SeatNumber { get; set; }
        
        [Required]
        public TicketType TicketType { get; set; }
        
        public List<EventCustomer> EventCustomers { get; set; }
    }
}

