using TaskRpgApi.Domain.Abstractions.Entities;

namespace TaskRpgApi.Domain.Models;

public class QuestInput : IInput
{
    public Guid UserId { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public List<float> ChallengeLevel { get; set; } = new List<float>();

    public int Xp { get; set; }

    public int Gold { get; set; }
}
