using System.ComponentModel.DataAnnotations;

namespace ECMS.DTO.Auth;

public class LoginRequest
{
    [Required]
    public string UserName { get; set; }
    [Required]
    public string Password { get; set; }
}