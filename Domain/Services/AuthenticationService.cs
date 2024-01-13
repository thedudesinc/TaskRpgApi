using BCrypt.Net;
using CropKeeperApi.Domain.Models.Outputs;
using TaskRpgApi.Domain.Abstractions;
using TaskRpgApi.Domain.Abstractions.Services;

namespace TaskRpgApi.Domain.Services;

public class AuthenticationService : IAuthenticationService
{
    private readonly IUserRepository _repository;

    public AuthenticationService(IUserRepository repository)
    {
        _repository = repository;
    }

    public async Task<UserOutput?> Authenticate(Models.LoginInput login, CancellationToken ct)
    {
        var user = (await _repository.Find(user => user.Email == login.Email, ct)).SingleOrDefault();

        if (user == null) return null;

        var matchingPassword = BCrypt.Net.BCrypt.Verify(login.Password, user.Password, false, HashType.SHA384);

        return !!matchingPassword ? user : null;
    }
}
