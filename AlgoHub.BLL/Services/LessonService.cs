using AlgoHub.BLL.DTOs;
using AlgoHub.BLL.Services.Interfaces;
using AlgoHub.DAL.Entities;
using AlgoHub.DAL.Repository;
using AutoMapper;

namespace AlgoHub.BLL.Services
{
    public class LessonService : ILessonService
    {
        private readonly IRepository<Lesson> _repository;

        private readonly IMapper _mapper;

        public LessonService(IRepository<Lesson> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IEnumerable<LessonBriefDto> GetTopPopularLessons(int n)
        {
            return _repository.AllIncluding(l => l.Author!, l=>l.Tags!).OrderByDescending(l => l.Views).Take(n).Select(l=>_mapper.Map<LessonBriefDto>(l));
        }
    }
}
