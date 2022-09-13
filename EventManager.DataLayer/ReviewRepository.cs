using EventManager.DomainLayer;
using Microsoft.EntityFrameworkCore;

namespace EventManager.DataLayer;

public class ReviewRepository : IReviewRepository
{
    private readonly EventManagerContext _context;

    public ReviewRepository(EventManagerContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public IEnumerable<Review> GetReviewsBy(Event Event) =>
        from review in _context.Reviews.Include(review => review.User)
        where review.Event == Event
        select review;
}