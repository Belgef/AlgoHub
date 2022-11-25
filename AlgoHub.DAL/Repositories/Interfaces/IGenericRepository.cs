using System.Linq.Expressions;
using AlgoHub.DAL.Entities;

namespace AlgoHub.DAL.Repositories.Interfaces;

public interface IGenericRepository<TEntity> where TEntity : class, IEntity
{
    TEntity? GetById(int id);
    IEnumerable<TEntity> GetAll();
    IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> expression);
    void Add(TEntity entity);
    void AddRange(IEnumerable<TEntity> entities);
    void Remove(TEntity entity);
    void RemoveRange(IEnumerable<TEntity> entities);
}