using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECMS.Models
{
    [Table("event_customers")]
    public class EventCustomer
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [ForeignKey("Event")]
        public int EventId { get; set; }
        
        [Required]
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        
        [Required]
        [ForeignKey("Ticket")]
        public int TicketId { get; set; }
        
        public Event Event { get; set; }
        public Customer Customer { get; set; }
        public Ticket Ticket { get; set; }
    }
}

