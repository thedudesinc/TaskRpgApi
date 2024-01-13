using CropKeeperApi.Domain.Models.Outputs;

namespace TaskRpgApi.Domain.Abstractions.Services;

public interface IAuthenticationService
{
    Task<UserOutput?> Authenticate(Models.LoginInput login, CancellationToken ct);
}
