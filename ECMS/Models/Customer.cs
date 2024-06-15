using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECMS.Models
{
    [Table("customers")]
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int PersonId { get; set; }
        
        [Required]
        public DateOnly DateOfBirth { get; set; }
        
        [Required]
        public DateOnly JoinDate { get; set; }
        
        [Required]
        public DateOnly LastVisit { get; set; }
        
        [ForeignKey("PersonId")]
        public Person Person { get; set; }
        
        public List<Order> Orders { get; set; }
        public List<Reservation> Reservations { get; set; }
    }
}