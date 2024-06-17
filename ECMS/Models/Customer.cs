using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECMS.Models
{
    [Table("customers")]
    public class Customer : Person
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int PersonId { get; set; }
        
        [Required]
        public DateTime DateOfBirth { get; set; }
        
        [Required]
        public DateTime JoinDate { get; set; }
        
        [Required]
        public DateTime LastVisit { get; set; }
        
        [ForeignKey("PersonId")]
        public Person Person { get; set; }
        
        public List<Order> Orders { get; set; }
        public List<Reservation> Reservations { get; set; }

        public override string GetFullName()
        {
            return $"{Person.GetFullName()} (Customer)";
        }
    }
}