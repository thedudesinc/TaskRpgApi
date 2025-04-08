using TaskRpgApi.Domain.Models;
using TaskRpgApi.Persistence.Entities;

namespace TaskRpgApi.Domain.Abstractions.Repositories;

public interface IQuestRepository : IGenericRepository<Quest, QuestInput, QuestOutput>
{

}
