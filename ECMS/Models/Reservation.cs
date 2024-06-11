using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public int Status { get; set; }
        
        [Required]
        public int Category { get; set; }
        
        [Required]
        public int NumberOfGuests { get; set; }
        
        [Required]
        public DateTime ConfirmedAt { get; set; }
        
        public List<ReservationArea> ReservationAreas { get; set; }
    }
}

