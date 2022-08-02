namespace EventManager.Web.Models
{
    public class SearchPartialViewModel
    {
        public SearchPartialViewModel(string? search, string? category, IEnumerable<string> Categories)
        {
            this.Search = search ?? "";
            this.Category = category ?? "All Categories";
            this.Categories = Categories;
        }

        public string Search { get; }
        public string Category { get; }
        public IEnumerable<string> Categories { get; }
        public int NumberOfCategories { get { return this.Categories.Count(); } }
    }
}