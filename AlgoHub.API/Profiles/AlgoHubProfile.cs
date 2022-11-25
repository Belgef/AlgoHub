using AlgoHub.API.DTOs;
using AlgoHub.DAL.Entities;
using AutoMapper;

namespace AlgoHub.API.Profiles;

public class AlgoHubProfile : Profile
{
    public AlgoHubProfile()
    {
        CreateMap<User, UserDetailDto>();
        CreateMap<User, UserBriefDto>().ForMember(u => u.Name, opt => opt.MapFrom(u => u.FullName ?? "@" + u.UserName));
        CreateMap<Tag, TagDto>();
        CreateMap<Lesson, LessonBriefDto>();
        CreateMap<Lesson, LessonDetailDto>();
    }
}
