namespace EventManager.Web.Models
{
    public interface ISearchPartialViewModel
    {
        string Category { get; }
        IEnumerable<string> Categories { get; }
        int NumberOfCategories { get; }
    }
}