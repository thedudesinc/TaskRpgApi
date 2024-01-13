namespace TaskRpgApi.App.Responses;

public class LoginResponse
{
    public Guid Id { get; set; }

    public string DisplayName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string StringToken { get; set; } = string.Empty;
}
