using TaskRpgApi.Domain.Abstractions.Entities;
using TaskRpgApi.Persistance.Enums;

namespace TaskRpgApi.Domain.Models;

public class QuestInput : IInput
{
    public Guid UserId { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public QuestTag Tag { get; set; }

    public int Xp { get; set; }

    public int Gold { get; set; }
}
