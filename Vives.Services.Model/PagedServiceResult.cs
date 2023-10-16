namespace Vives.Services.Model
{
    public class PagedServiceResult<T>: ServiceResult
    {
        public IList<T> Data { get; set; } = new List<T>();
        public required Paging Paging { get; set; }
        public int TotalCount { get; set; }
    }
}
