namespace TaskRpgApi.App.Request;

public class VerifyEmailRequest
{
    public string OmittedEmail { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;
}
