using AlgoHub.DAL.Repositories.Interfaces;

namespace AlgoHub.DAL.UnitOfWork;

public interface IUnitOfWork : IDisposable
{
    ILessonRepository Lessons { get; }
    int Complete();
}