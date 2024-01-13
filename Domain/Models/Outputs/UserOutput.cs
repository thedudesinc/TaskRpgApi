using System.Text.Json.Serialization;
using TaskRpgApi.Domain.Abstractions.Entities;

namespace CropKeeperApi.Domain.Models.Outputs;

public class UserOutput : IOutput
{
    public Guid Id { get; set; }

    public string DisplayName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Zip { get; set; } = string.Empty;

    public string DisplayImageUrl { get; set; } = string.Empty;

    [JsonIgnore]
    public string Password { get; set; } = string.Empty;

    public bool AllowEmailNotifications { get; set; } = true;

    public bool AllowSiteNotifications { get; set; } = true;

    public DateTime DateCreated { get; set; }

    public DateTime DateModified { get; set; }

    public DateTime? DateDeleted { get; set; }
}
