namespace EventManager.DomainLayer
{
    public interface IReviewService
    {
        IEnumerable<Review> GetReviewsBy(Event Event);
    }
}