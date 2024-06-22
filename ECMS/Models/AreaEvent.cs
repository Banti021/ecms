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
        public int AreaId { get; set; }

        [Required]
        public int EventId { get; set; }

        [ForeignKey("AreaId")]
        public Area Area { get; set; }

        [ForeignKey("EventId")]
        public Event Event { get; set; }
    }
}