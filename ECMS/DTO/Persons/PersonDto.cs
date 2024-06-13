using System.ComponentModel.DataAnnotations;

namespace ECMS.DTO;

public class PersonDto
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string FirstName { get; set; }

    [Required]
    [StringLength(100)]
    public string LastName { get; set; }

    [StringLength(100)]
    public string? Email { get; set; }

    [StringLength(50)]
    public string PhoneNumber { get; set; }
}