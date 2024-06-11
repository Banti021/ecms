using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECMS.Models
{
    [Table("area_events")]
    public class AreaEvent
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [ForeignKey("Area")]
        public int AreaId { get; set; }
        
        [Required]
        [ForeignKey("Event")]
        public int EventId { get; set; }
        
        public Area Area { get; set; }
        public Event Event { get; set; }
    }
}

