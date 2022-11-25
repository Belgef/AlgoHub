using AlgoHub.DAL.Context;
using AlgoHub.DAL.Entities;
using AlgoHub.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AlgoHub.DAL.Repositories.Implementations;

public class LessonRepository : GenericRepository<Lesson>, ILessonRepository
{
    public LessonRepository(AlgoHubContext context) : base(context) { }

    public new IEnumerable<Lesson> GetAll() 
        => _context.Lessons.Include(x => x.Author).Include(x => x.Tags);

    public IEnumerable<Lesson> GetPopularLessons(int n) 
        => _context.Lessons.Include(x => x.Author).Include(x => x.Tags)
        .OrderByDescending(x => x.Views).Take(n);
}