using AlgoHub.BLL.Services.Interfaces;
using AlgoHub.DAL.Entities;
using AlgoHub.DAL.UnitOfWork;

namespace AlgoHub.BLL.Services.Implementations;

public class LessonService : ILessonService
{
    private readonly IUnitOfWork _unitOfWork;

    public LessonService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public void AddLesson(Lesson lesson) => _unitOfWork.Lessons.Add(lesson);

    public Lesson? GetLesson(int id) => _unitOfWork.Lessons.GetById(id);

    public IEnumerable<Lesson> GetLessons() => _unitOfWork.Lessons.GetAll();

    public IEnumerable<Lesson> GetPopularLessons(int n) => _unitOfWork.Lessons.GetPopularLessons(n);

    public void RemoveLesson(Lesson lesson) => _unitOfWork.Lessons.Remove(lesson);
}
