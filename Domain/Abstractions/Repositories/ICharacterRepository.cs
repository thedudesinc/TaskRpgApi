using TaskRpgApi.Domain.Models;
using TaskRpgApi.Persistance.Entities;

namespace TaskRpgApi.Domain.Abstractions.Repositories;

public interface ICharacterRepository : IGenericRepository<Character, CharacterInput, CharacterOutput>
{

}
