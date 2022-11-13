using AlgoHub.BLL.DTOs;

namespace AlgoHub.BLL.Services.Interfaces
{
    public interface ILessonService
    {
        public IEnumerable<LessonBriefDto> GetTopPopularLessons(int n);
    }
}
