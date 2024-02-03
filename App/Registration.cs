using Microsoft.EntityFrameworkCore;
using TaskRpg.Domain.Abstractions.Services;
using TaskRpg.Domain.Services;
using TaskRpgApi.Domain.Abstractions;
using TaskRpgApi.Domain.Abstractions.Repositories;
using TaskRpgApi.Domain.Abstractions.Services;
using TaskRpgApi.Domain.Profiles;
using TaskRpgApi.Domain.Services;
using TaskRpgApi.Persistance;
using TaskRpgApi.Persistance.Repositories;

namespace TaskRpgApi.App;

public static class Registration
{
    public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<TaskRpgContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("TaskRpgDbContext"), providerOptions => { providerOptions.EnableRetryOnFailure(); }));

        services.AddTransient<IUserRepository, UserRepository>();
        services.AddTransient<IQuestRepository, QuestRepository>();
        services.AddTransient<ICharacterRepository, CharacterRepository>();
        services.AddTransient<IUserService, UserService>();
        services.AddTransient<IQuestService, QuestService>();
        services.AddTransient<ICharacterService, CharacterService>();
        services.AddTransient<IAuthenticationService, AuthenticationService>();

        services.AddAutoMapper(typeof(TaskRpgProfile));
    }
}
