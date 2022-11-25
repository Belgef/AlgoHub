using AlgoHub.DAL.Entities;

namespace AlgoHub.BLL.Services.Interfaces;

public interface ILessonService
{
    public IEnumerable<Lesson> GetLessons();
    public IEnumerable<Lesson> GetPopularLessons(int n);
}
