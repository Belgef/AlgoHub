using Microsoft.EntityFrameworkCore;

namespace AlgoHub.DAL.Helpers
{
    public static class IQueriableExtension
    {
        public static IUnorderedQueryable<TEntity> ToUnorderedQueriable<TEntity>(this IQueryable<TEntity> queryable)
            => new UnorderedQueryable<TEntity>(queryable);
        public static IPartiallyOrderedQueryable<TEntity> ToPartiallyOrderedQueriable<TEntity>(this IQueryable<TEntity> queryable)
            => new UnorderedQueryable<TEntity>(queryable);
        public static IUnorderedQueryable<TEntity> ToUnorderedQueriable<TEntity>(this DbSet<TEntity> set)
            => new UnorderedQueryable<TEntity>(set.AsQueryable());
    }
}