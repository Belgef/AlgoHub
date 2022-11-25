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

    public IEnumerable<Lesson> GetLessons()
    {
        return _unitOfWork.Lessons.GetAll();
    }

    public IEnumerable<Lesson> GetPopularLessons(int n)
    {
        return _unitOfWork.Lessons.GetPopularLessons(n);
    }
}
