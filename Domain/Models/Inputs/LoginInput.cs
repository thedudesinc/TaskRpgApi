using System.ComponentModel.DataAnnotations;

namespace TaskRpgApi.Domain.Models;

public class LoginInput
{
    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    public string Password { get; set; } = string.Empty;
}
