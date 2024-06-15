using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECMS.Models
{
    [Table("persons")]
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Required]
        public string Role { get; set; }

        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [InverseProperty("Person")]
        public Employee Employee { get; set; }

        [InverseProperty("Person")]
        public Customer Customer { get; set; }
    }
}