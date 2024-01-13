using TaskRpgApi.Domain.Abstractions.Entities;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TaskRpgApi.Domain.Models.Inputs;

public class UserInput : IInput
{
    [Required]
    [StringLength(25, ErrorMessage = "{0} length must be at least {2} characters", MinimumLength = 2)]
    public string DisplayName { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    [Remote(action: "VerifyEmail", controller: "User")]
    public string Email { get; set; } = string.Empty;

    public string? Password { get; set; }
}
