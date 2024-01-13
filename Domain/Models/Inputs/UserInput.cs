using TaskRpgApi.Domain.Abstractions.Entities;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CropKeeperApi.Domain.Models.Inputs;

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

    [Required]
    [RegularExpression(@"^\d{5}(?:[-\s]\d{4})?$",
         ErrorMessage = "Zip Code must be in the format of '#####' or '#####-####', example: '32334' or '32334-0092'")]
    public string Zip { get; set; } = string.Empty;

    public string DisplayImageUrl { get; set; } = string.Empty;

    [Required]
    public bool AllowEmailNotifications { get; set; } = true;

    [Required]
    public bool AllowSiteNotifications { get; set; } = true;
}
