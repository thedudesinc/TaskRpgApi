using TaskRpgApi.Domain.Models.Inputs;
using TaskRpgApi.Domain.Models.Outputs;
using TaskRpg.Domain.Abstractions.Services;
using TaskRpgApi.App.Request;
using TaskRpgApi.Domain.Abstractions;

namespace TaskRpg.Domain.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _repository;

    public UserService(IUserRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<UserOutput>> Get(CancellationToken ct)
    {
        return await _repository.Get(ct);
    }

    public async Task<UserOutput> Get(Guid id, CancellationToken ct)
    {
        return await _repository.Get(id, ct);
    }

    public async Task<UserOutput> Create(UserInput input, CancellationToken ct)
    {
        input.Password = BCrypt.Net.BCrypt.HashPassword(input.Password);

        return await _repository.Create(input, ct);
    }

    public async Task<UserOutput> Update(Guid id, UserInput input, CancellationToken ct)
    {
        return await _repository.Update(id, input, ct);
    }

    public async Task Delete(Guid id, CancellationToken ct)
    {
        await _repository.Delete(id, ct);
    }

    public async Task<bool> VerifyEmail(VerifyEmailRequest verifyEmailRequest, CancellationToken ct)
    {
        if (verifyEmailRequest.Email.ToLower() == verifyEmailRequest.OmittedEmail.ToLower()) return true;

        var users = await _repository.Find(users => users.Email.ToLower() == verifyEmailRequest.Email.ToLower(), ct);

        return users.Count() == 0;
    }
}
