using System.Linq.Expressions;
using AlgoHub.DAL.Context;
using AlgoHub.DAL.Entities;
using AlgoHub.DAL.Repositories.Interfaces;

namespace AlgoHub.DAL.Repositories.Implementations;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, IEntity
{
    protected readonly AlgoHubContext _context;

    public GenericRepository(AlgoHubContext context) => _context = context;

    public void Add(TEntity entity) => _context.Set<TEntity>().Add(entity);

    public void AddRange(IEnumerable<TEntity> entities) => _context.Set<TEntity>().AddRange(entities);

    public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> expression) => _context.Set<TEntity>().Where(expression);

    public IEnumerable<TEntity> GetAll() => _context.Set<TEntity>().ToList();

    public TEntity? GetById(int id) => _context.Set<TEntity>().Find(id);

    public void Remove(TEntity entity) => _context.Set<TEntity>().Remove(entity);

    public void RemoveRange(IEnumerable<TEntity> entities) => _context.Set<TEntity>().RemoveRange(entities);
}
