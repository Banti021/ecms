using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ECMS.Enums;

namespace ECMS.Models
{
    [Table("reservations")]
    public class Reservation
    {
        [Key]
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

        public DateTime? ConfirmedAt { get; set; }
        
        public string AdditionalInfo { get; set; }

        public List<ReservationArea> ReservationAreas { get; set; }
    }
}