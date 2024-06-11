using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECMS.Models
{
    [Table("persons")]
    public class Person
    {
        [Key]
        public int Id { get; set; }
        
        [Required, StringLength(100)]
        public string FirstName { get; set; }
        
        [Required, StringLength(100)]
        public string LastName { get; set; }
        
        [StringLength(100)]
        public string? Email { get; set; }
        
        [StringLength(50)]
        public string PhoneNumber { get; set; }
        
        [InverseProperty("Person")]
        public Employee Employee { get; set; }
        
        [InverseProperty("Person")]
        public Customer Customer { get; set; }
    } 
}

