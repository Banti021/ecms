using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ECMS.Enums;

namespace ECMS.Models
{
    [Table("events")]
    public class Event
    {
        [Key]
        public int Id { get; set; }
        
        [Required, StringLength(100)]
        public string Title { get; set; }
        
        [Required]
        public EventCategory EventCategory { get; set; }
        
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public Decimal RegularPrice { get; set; }
        
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public Decimal VipPrice { get; set; }
        
        [Required]
        public DateTime StartTime { get; set; }
        
        [Required]
        public DateTime EndTime { get; set; }
        
        [Required, StringLength(255)]
        public string Description { get; set; }
        
        [Required]
        public int MaxAttendees { get; set; }
        
        [Required]
        public int CurrentAttendees { get; set; }
        
        public List<AreaEvent> AreaEvents { get; set; }
        public List<EventCustomer> EventCustomers { get; set; }
    }
}

