using AlgoHub.DAL.Context;
using AlgoHub.DAL.Repositories.Implementations;
using AlgoHub.DAL.Repositories.Interfaces;

namespace AlgoHub.DAL.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly AlgoHubContext _context;

    public UnitOfWork(AlgoHubContext context)
    {
        _context = context;
        Lessons = new LessonRepository(context);
    }

    public ILessonRepository Lessons { get; }

    public int Complete() => _context.SaveChanges();
    public void Dispose()
    {
        _context.Dispose();
        GC.SuppressFinalize(this);
    }
}
