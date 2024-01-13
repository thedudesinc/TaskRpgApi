using System.Text.Json.Serialization;
using TaskRpgApi.Domain.Abstractions.Entities;

namespace TaskRpgApi.Domain.Models.Outputs;

public class UserOutput : IOutput
{
    public Guid Id { get; set; }

    public string DisplayName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    [JsonIgnore]
    public string Password { get; set; } = string.Empty;

    public DateTime DateCreated { get; set; }

    public DateTime DateModified { get; set; }

    public DateTime? DateDeleted { get; set; }
}
