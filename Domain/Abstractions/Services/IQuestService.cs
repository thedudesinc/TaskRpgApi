using TaskRpgApi.Domain.Models;

namespace TaskRpg.Domain.Abstractions.Services;

public interface IQuestService
{
    Task<IEnumerable<QuestOutput>> Get(CancellationToken ct);

    Task<QuestOutput> Get(Guid id, CancellationToken ct);

    Task<IEnumerable<QuestOutput>> GetByUserId(Guid id, CancellationToken ct);

    Task<QuestOutput> Create(QuestInput input, CancellationToken ct);

    Task<QuestOutput> Update(Guid id, QuestInput input, CancellationToken ct);

    Task Delete(Guid id, CancellationToken ct);
}
