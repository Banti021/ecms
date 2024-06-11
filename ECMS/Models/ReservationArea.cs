using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECMS.Models
{
    [Table("reservation_areas")]
    public class ReservationArea
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [ForeignKey("Reservation")]
        public int ReservationId { get; set; }
        
        [Required]
        [ForeignKey("Area")]
        public int AreaId { get; set; }
        
        public Reservation Reservation { get; set; }
        public Area Area { get; set; }
    }
}

