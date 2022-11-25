using System.Linq.Expressions;
using AlgoHub.DAL.Context;
using AlgoHub.DAL.Entities;
using AlgoHub.DAL.Helpers;
using Microsoft.EntityFrameworkCore;

namespace AlgoHub.DAL.Repository;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
{
    private readonly AlgoHubContext _context;

    public Repository(AlgoHubContext context)
    {
        _context = context;
    }

    public IUnorderedQueryable<TEntity> GetAll() => _context.Set<TEntity>().ToUnorderedQueriable();

    public IUnorderedQueryable<TEntity> GetAll(params Expression<Func<TEntity, object>>[] includeProperties)
    {
        IQueryable<TEntity> query = _context.Set<TEntity>();

        query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));

        return query.ToUnorderedQueriable();
    }

    public int GetCount() => _context.Set<TEntity>().Count();

    public TEntity? GetSingle(int id) => _context.Set<TEntity>().SingleOrDefault(e => e.Id == id);

    public TEntity? GetSingle(Expression<Func<TEntity, bool>> predicate) => _context.Set<TEntity>().FirstOrDefault(predicate);

    public TEntity? GetSingle(Expression<Func<TEntity?, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
    {
        IQueryable<TEntity> query = _context.Set<TEntity>();

        query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));

        return query.FirstOrDefault(predicate);
    }

    public IUnorderedQueryable<TEntity> FindAll(Expression<Func<TEntity, bool>> predicate) => _context.Set<TEntity>().Where(predicate).ToUnorderedQueriable();

    public IUnorderedQueryable<TEntity> FindAll(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
    {
        IQueryable<TEntity> query = _context.Set<TEntity>();

        query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));

        return query.Where(predicate).ToUnorderedQueriable();
    }
    
    public void Add(TEntity entity) => _context.Set<TEntity>().Add(entity);

    public void Update(TEntity entity) => _context.Set<TEntity>().Update(entity);

    public void Delete(TEntity entity) => _context.Set<TEntity>().Remove(entity);

    public void DeleteWhere(Expression<Func<TEntity, bool>> predicate) => _context.Set<TEntity>().RemoveRange(_context.Set<TEntity>().Where(predicate));

    public void Save()
    {
        _context.SaveChanges();
    }
}