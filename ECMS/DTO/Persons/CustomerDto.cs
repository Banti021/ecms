using System.ComponentModel.DataAnnotations;

namespace ECMS.DTO;

public class CustomerDto : PersonDto
{
    [Required]
    public DateOnly DateOfBirth { get; set; }

    [Required]
    public DateOnly JoinDate { get; set; }

    [Required]
    public DateOnly LastVisit { get; set; }
}