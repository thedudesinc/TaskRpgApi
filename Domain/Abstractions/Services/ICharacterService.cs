using TaskRpgApi.Domain.Models;

namespace TaskRpg.Domain.Abstractions.Services;

public interface ICharacterService
{
    Task<IEnumerable<CharacterOutput>> Get(CancellationToken ct);

    Task<CharacterOutput> Get(Guid id, CancellationToken ct);

    Task<CharacterOutput> GetByUserId(Guid id, CancellationToken ct);

    Task<CharacterOutput> Create(CharacterInput input, CancellationToken ct);

    Task<CharacterOutput> Update(Guid id, CharacterInput input, CancellationToken ct);

    Task Delete(Guid id, CancellationToken ct);
}
