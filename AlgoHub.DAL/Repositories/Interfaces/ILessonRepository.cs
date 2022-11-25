using AlgoHub.DAL.Entities;

namespace AlgoHub.DAL.Repositories.Interfaces;

public interface ILessonRepository : IGenericRepository<Lesson>
{
    IEnumerable<Lesson> GetPopularLessons(int n);
}