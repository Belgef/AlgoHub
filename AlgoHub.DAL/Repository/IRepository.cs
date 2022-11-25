using System.Linq.Expressions;
using AlgoHub.DAL.Entities;
using AlgoHub.DAL.Helpers;

namespace AlgoHub.DAL.Repository
{
    public interface IRepository<TEntity> where TEntity : class, IEntity
    {
        IUnorderedQueryable<TEntity> GetAll();
        IUnorderedQueryable<TEntity> GetAll(params Expression<Func<TEntity, object>>[] includeProperties);
        int GetCount();
        TEntity? GetSingle(int id);
        TEntity? GetSingle(Expression<Func<TEntity, bool>> predicate);
        TEntity? GetSingle(
            Expression<Func<TEntity?, bool>> predicate,
            params Expression<Func<TEntity, object>>[] includeProperties
        );
        IUnorderedQueryable<TEntity> FindAll(Expression<Func<TEntity, bool>> predicate);
        IUnorderedQueryable<TEntity> FindAll(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void DeleteWhere(Expression<Func<TEntity, bool>> predicate);
        void Save();
    }
}