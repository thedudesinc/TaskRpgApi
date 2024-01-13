using TaskRpgApi.Domain.Abstractions.Entities;

namespace TaskRpgApi.Persistance.Entities;

public class User : IEntity
{
    public Guid Id { get; set; }

    public string CharacterName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;

    public DateTime DateCreated { get; set; }

    public DateTime DateModified { get; set; }

    public DateTime? DateDeleted { get; set; }
}
