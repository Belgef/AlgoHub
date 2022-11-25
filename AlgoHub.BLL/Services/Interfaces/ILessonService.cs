using AlgoHub.DAL.Entities;

namespace AlgoHub.BLL.Services.Interfaces;

public interface ILessonService
{
    public IEnumerable<Lesson> GetLessons();
    public IEnumerable<Lesson> GetPopularLessons(int n);
    public Lesson? GetLesson(int id);
    public void AddLesson(Lesson lesson);
    public void RemoveLesson(Lesson lesson);
}
