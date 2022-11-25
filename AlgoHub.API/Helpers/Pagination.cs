namespace AlgoHub.API.Helpers;

public class Pagination<T>
{
    public int Page { get; set; }

    public int Limit { get; set; }

    public int PageCount { get; set; }

    public IEnumerable<T> Items { get; set; }

    public Pagination(IEnumerable<T> allItems, int page, int limit)
    {
        Page = page;
        Limit = limit;
        PageCount = limit <= 0 ? 1 : (allItems.Count() + limit - 1) / limit;
        var items = allItems.Skip(page*limit);
        if(limit > 0) 
            items = items.Take(limit);
        Items = items;
    }
}

public static class PaginationExtension
{
    public static Pagination<T> Paginate<T>(this IEnumerable<T> items, int page, int limit)
        => new(items, page, limit);
}
