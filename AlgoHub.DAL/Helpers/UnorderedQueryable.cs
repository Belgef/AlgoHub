using System.Linq.Expressions;

namespace AlgoHub.DAL.Helpers
{
    public class UnorderedQueryable<TEntity> : IUnorderedQueryable<TEntity>, IPartiallyOrderedQueryable<TEntity>
    {
        private readonly IQueryable<TEntity> _source;

        public UnorderedQueryable(IQueryable<TEntity> source)
        {
            _source = source;
        }

        public IEnumerable<TEntity> AsEnumerable() => _source.AsEnumerable();

        public IPartiallyOrderedQueryable<TEntity> OrderBy<TKey>(Expression<Func<TEntity, TKey>> orderProperty)
            => _source.OrderBy(orderProperty).ToPartiallyOrderedQueriable();

        public IPartiallyOrderedQueryable<TEntity> OrderByDescending<TKey>(Expression<Func<TEntity, TKey>> orderProperty)
            => _source.OrderByDescending(orderProperty).ToPartiallyOrderedQueriable();

        public IUnorderedQueryable<TEntity> TakeChunk(int skip, int limit)
            => _source.Skip(skip).Take(limit).ToUnorderedQueriable();

        public IUnorderedQueryable<TEntity> AsUnorderedQueryable()
            => this;

        public IPartiallyOrderedQueryable<TEntity> ThenBy<TKey>(Expression<Func<TEntity, TKey>> orderProperty)
            => (_source as IOrderedQueryable<TEntity>)!.ThenBy(orderProperty).ToPartiallyOrderedQueriable();

        public IPartiallyOrderedQueryable<TEntity> ThenByDescending<TKey>(Expression<Func<TEntity, TKey>> orderProperty)
            => (_source as IOrderedQueryable<TEntity>)!.ThenByDescending(orderProperty).ToPartiallyOrderedQueriable();
    }
}