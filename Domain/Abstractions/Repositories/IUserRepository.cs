using TaskRpgApi.Domain.Models.Inputs;
using TaskRpgApi.Domain.Models.Outputs;
using TaskRpgApi.Domain.Abstractions.Repositories;
using TaskRpgApi.Persistence.Entities;

namespace TaskRpgApi.Domain.Abstractions;

public interface IUserRepository : IGenericRepository<User, UserInput, UserOutput>
{

}
