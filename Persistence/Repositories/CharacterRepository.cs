using AutoMapper;
using TaskRpgApi.Persistence.Repositories;
using TaskRpgApi.Domain.Abstractions.Repositories;
using TaskRpgApi.Domain.Models;
using TaskRpgApi.Persistence.Entities;

namespace TaskRpgApi.Persistence.Repositories;

public class CharacterRepository : GenericRepository<Character, CharacterInput, CharacterOutput>, ICharacterRepository
{
    public CharacterRepository(TaskRpgContext context, IMapper mapper) : base(context, mapper)
    {
    }
}
