using AutoMapper;
using CropKeeperApi.Persistence.Repositories;
using TaskRpgApi.Domain.Abstractions.Repositories;
using TaskRpgApi.Domain.Models;
using TaskRpgApi.Models;
using TaskRpgApi.Persistance.Entities;

namespace TaskRpgApi.Persistance.Repositories;

public class QuestRepository : GenericRepository<Quest, QuestInput, QuestOutput>, IQuestRepository
{
    public QuestRepository(TaskRpgContext context, IMapper mapper) : base(context, mapper)
    {
    }
}
