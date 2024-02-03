using TaskRpgApi.Domain.Abstractions.Entities;

namespace TaskRpgApi.Domain.Models;

public class CharacterInput : IInput
{
    public string Name { get; set; } = string.Empty;

    public int Level { get; set; }

    public int Xp { get; set; }

    public int Gold { get; set; }
}
