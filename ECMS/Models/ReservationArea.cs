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
        public int ReservationId { get; set; }

        [Required]
        public int AreaId { get; set; }

        [ForeignKey("ReservationId")]
        public Reservation Reservation { get; set; }

        [ForeignKey("AreaId")]
        public Area Area { get; set; }
    }
}