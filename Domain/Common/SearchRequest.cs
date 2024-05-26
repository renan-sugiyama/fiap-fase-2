namespace Domain.Common;

public class SearchRequest
{
    public string? Term { get; set; }
    public List<Criterion>? Criteria { get; set; }
    public int Page { get; set; }
    public int PageSize { get; set; }
}

public class Criterion
{
    public string Field { get; set; }
    public dynamic Value { get; set; }
}