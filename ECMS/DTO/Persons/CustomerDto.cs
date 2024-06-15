using System.ComponentModel.DataAnnotations;

namespace ECMS.DTO;

public class CustomerDto : PersonDto
{
    [Required]
    public DateTime DateOfBirth { get; set; }

    [Required]
    public DateTime JoinDate { get; set; }

    [Required]
    public DateTime LastVisit { get; set; }
}