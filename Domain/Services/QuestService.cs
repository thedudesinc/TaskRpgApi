using TaskRpg.Domain.Abstractions.Services;
using TaskRpgApi.Domain.Abstractions.Repositories;
using TaskRpgApi.Domain.Models;

namespace TaskRpgApi.Domain.Services;

public class QuestService : IQuestService
{
    private readonly IQuestRepository _repository;

    public QuestService(IQuestRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<QuestOutput>> Get(CancellationToken ct)
    {
        return await _repository.Get(ct);
    }

    public async Task<QuestOutput> Get(Guid id, CancellationToken ct)
    {
        return await _repository.Get(id, ct);
    }

    public async Task<IEnumerable<QuestOutput>> GetByUserId(Guid id, CancellationToken ct)
    {
        return await _repository.Find((quest) => quest.UserId == id, ct);
    }

    public async Task<QuestOutput> Create(QuestInput input, CancellationToken ct)
    {
        return await _repository.Create(input, ct);
    }

    public async Task<QuestOutput> Update(Guid id, QuestInput input, CancellationToken ct)
    {
        return await _repository.Update(id, input, ct);
    }

    public async Task Delete(Guid id, CancellationToken ct)
    {
        await _repository.Delete(id, ct);
    }
}
