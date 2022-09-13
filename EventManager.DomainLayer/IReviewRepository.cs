namespace EventManager.DomainLayer;

public interface IReviewRepository
{
    IEnumerable<Review> GetReviewsBy(Event Event);
}