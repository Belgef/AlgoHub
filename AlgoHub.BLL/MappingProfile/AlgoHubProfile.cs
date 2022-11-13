using AlgoHub.BLL.DTOs;
using AlgoHub.DAL.Entities;
using AutoMapper;

namespace AlgoHub.BLL.MappingProfile
{
    public class AlgoHubProfile : Profile
    {
        public AlgoHubProfile() 
        {
            CreateMap<User, UserDto>();
            CreateMap<User, UserBriefDto>().ForMember(u=>u.Name, opt => opt.MapFrom(u => u.FullName ?? ("@"+u.UserName)));
            CreateMap<Tag, TagDto>();
            CreateMap<Lesson, LessonBriefDto>();
            CreateMap<Lesson, LessonDetailDto>();
        }
    }
}
