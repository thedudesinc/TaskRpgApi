using TaskRpgApi.Domain.Abstractions.Entities;

namespace TaskRpgApi.Domain.Models;

public class QuestInput : IInput
{
    public Guid UserId { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public int Xp { get; set; }

    public int Gold { get; set; }
}
