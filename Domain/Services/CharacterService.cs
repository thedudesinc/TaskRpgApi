using TaskRpg.Domain.Abstractions.Services;
using TaskRpgApi.Domain.Abstractions.Repositories;
using TaskRpgApi.Domain.Models;

namespace TaskRpgApi.Domain.Services;

public class CharacterService : ICharacterService
{
    private readonly ICharacterRepository _repository;

    public CharacterService(ICharacterRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<CharacterOutput>> Get(CancellationToken ct)
    {
        return await _repository.Get(ct);
    }

    public async Task<CharacterOutput> Get(Guid id, CancellationToken ct)
    {
        return await _repository.Get(id, ct);
    }

    public async Task<IEnumerable<CharacterOutput>> GetByUserId(Guid id, CancellationToken ct)
    {
        return await _repository.Find((character) => character.UserId == id, ct);
    }

    public async Task<CharacterOutput> Create(CharacterInput input, CancellationToken ct)
    {
        return await _repository.Create(input, ct);
    }

    public async Task<CharacterOutput> Update(Guid id, CharacterInput input, CancellationToken ct)
    {
        return await _repository.Update(id, input, ct);
    }

    public async Task Delete(Guid id, CancellationToken ct)
    {
        await _repository.Delete(id, ct);
    }
}
