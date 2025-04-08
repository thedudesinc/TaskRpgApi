using TaskRpgApi.Domain.Abstractions.Entities;

namespace TaskRpgApi.Persistence.Entities;

public class Character : IEntity
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public string Name { get; set; } = string.Empty;

    public int Level { get; set; }

    public int Xp { get; set; }

    public int Gold { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateModified { get; set; }

    public DateTime? DateDeleted { get; set; }
}
