using CropKeeperApi.Domain.Models.Inputs;
using CropKeeperApi.Domain.Models.Outputs;
using TaskRpgApi.App.Request;

namespace TaskRpg.Domain.Abstractions.Services;

public interface IUserService
{
    Task<IEnumerable<UserOutput>> Get(CancellationToken ct);

    Task<UserOutput> Get(Guid id, CancellationToken ct);

    Task<UserOutput> Create(UserInput input, CancellationToken ct);

    Task<UserOutput> Update(Guid id, UserInput input, CancellationToken ct);

    Task Delete(Guid id, CancellationToken ct);

    Task<bool> VerifyEmail(VerifyEmailRequest verifyEmailRequest, CancellationToken ct);
}
