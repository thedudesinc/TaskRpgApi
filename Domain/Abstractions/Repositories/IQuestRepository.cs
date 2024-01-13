using TaskRpgApi.Domain.Models;
using TaskRpgApi.Persistance.Entities;

namespace TaskRpgApi.Domain.Abstractions.Repositories;

public interface IQuestRepository : IGenericRepository<Quest, QuestInput, QuestOutput>
{

}
