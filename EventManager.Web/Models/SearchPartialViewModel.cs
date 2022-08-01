namespace EventManager.Web.Models
{
    public class SearchPartialViewModel
    {
        public SearchPartialViewModel(string category, IEnumerable<string> Categories)
        {
            this.Category = category;
            this.Categories = Categories;
        }

        public string Category { get; }
        public IEnumerable<string> Categories { get; }
        public int NumberOfCategories { get { return this.Categories.Count(); } }
    }
}