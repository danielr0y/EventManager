namespace EventManager.Web.Models
{
    public class SearchPartialViewModel
    {
        public SearchPartialViewModel(string? search, string? category, IEnumerable<string> categories)
        {
            Search = search ?? "";
            Category = category ?? "All Categories";
            Categories = categories;
        }

        public string Search { get; }
        public string Category { get; }
        public IEnumerable<string> Categories { get; }
        public int NumberOfCategories => Categories.Count();
    }
}