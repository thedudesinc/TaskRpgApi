using TaskRpgApi.Domain.Abstractions.Entities;

namespace TaskRpgApi.Domain.Models;

public class QuestOutput : IOutput
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public int Xp { get; set; }

    public int Gold { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateModified { get; set; }

    public DateTime? DateDeleted { get; set; }
}
