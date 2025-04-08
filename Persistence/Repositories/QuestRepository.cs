using AutoMapper;
using TaskRpgApi.Persistence.Repositories;
using TaskRpgApi.Domain.Abstractions.Repositories;
using TaskRpgApi.Domain.Models;
using TaskRpgApi.Persistence.Entities;

namespace TaskRpgApi.Persistence.Repositories;

public class QuestRepository : GenericRepository<Quest, QuestInput, QuestOutput>, IQuestRepository
{
    public QuestRepository(TaskRpgContext context, IMapper mapper) : base(context, mapper)
    {
    }
}
