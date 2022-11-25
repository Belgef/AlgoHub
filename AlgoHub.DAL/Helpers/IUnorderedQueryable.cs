using System.Linq.Expressions;

namespace AlgoHub.DAL.Helpers
{
    public interface IUnorderedQueryable<TEntity>
    {
        IEnumerable<TEntity> AsEnumerable();
        IPartiallyOrderedQueryable<TEntity> OrderBy<TKey>(Expression<Func<TEntity, TKey>> orderProperty);
        IPartiallyOrderedQueryable<TEntity> OrderByDescending<TKey>(Expression<Func<TEntity, TKey>> orderProperty);
        IUnorderedQueryable<TEntity> TakeChunk(int skip, int limit);
    }
}