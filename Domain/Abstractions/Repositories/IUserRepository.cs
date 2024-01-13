using CropKeeperApi.Domain.Models.Inputs;
using CropKeeperApi.Domain.Models.Outputs;
using TaskRpgApi.Domain.Abstractions.Repositories;
using TaskRpgApi.Persistance.Entities;

namespace TaskRpgApi.Domain.Abstractions;

public interface IUserRepository : IGenericRepository<User, UserInput, UserOutput>
{

}
