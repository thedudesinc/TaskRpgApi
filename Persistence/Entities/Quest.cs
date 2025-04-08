using TaskRpgApi.Domain.Abstractions.Entities;
using TaskRpgApi.Persistence.Enums;

namespace TaskRpgApi.Persistence.Entities;

public class Quest : IEntity
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public QuestTag Tag { get; set; }

    public int Xp { get; set; }

    public int Gold { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateModified { get; set; }

    public DateTime? DateDeleted { get; set; }
}
