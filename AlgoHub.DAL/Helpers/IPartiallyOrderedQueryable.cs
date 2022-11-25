using System.Linq.Expressions;

namespace AlgoHub.DAL.Helpers
{
    public interface IPartiallyOrderedQueryable<TEntity>
    {
        IPartiallyOrderedQueryable<TEntity> ThenBy<TKey>(Expression<Func<TEntity, TKey>> orderProperty);
        IPartiallyOrderedQueryable<TEntity> ThenByDescending<TKey>(Expression<Func<TEntity, TKey>> orderProperty);
        IUnorderedQueryable<TEntity> AsUnorderedQueryable();
    }
}