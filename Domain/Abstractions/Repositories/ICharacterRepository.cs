using TaskRpgApi.Domain.Models;
using TaskRpgApi.Persistence.Entities;

namespace TaskRpgApi.Domain.Abstractions.Repositories;

public interface ICharacterRepository : IGenericRepository<Character, CharacterInput, CharacterOutput>
{

}
