using AutoMapper;
using TaskRpgApi.Domain.Models.Inputs;
using TaskRpgApi.Domain.Models.Outputs;
using TaskRpgApi.Domain.Models;
using TaskRpgApi.Persistence.Entities;

namespace TaskRpgApi.Domain.Profiles;

public class TaskRpgProfile : Profile
{
    public TaskRpgProfile()
    {
        CreateMap<UserInput, User>();
        CreateMap<User, UserOutput>();

        CreateMap<QuestInput, Quest>();
        CreateMap<Quest, QuestOutput>();

        CreateMap<CharacterInput, Character>();
        CreateMap<Character, CharacterOutput>();
        // Use CreateMap... Etc.. here (Profile methods are the same as configuration methods)
    }
}
