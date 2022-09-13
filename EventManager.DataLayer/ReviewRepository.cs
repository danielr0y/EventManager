using EventManager.DomainLayer;
using Microsoft.EntityFrameworkCore;

namespace EventManager.DataLayer;

public class ReviewRepository : IReviewRepository
{
    private readonly EventManagerContext _context;

    public ReviewRepository(EventManagerContext context)
    {
        this._context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public IEnumerable<Review> GetReviewsBy(Event Event) =>
        from review in this._context.Reviews.Include(review => review.User)
        where review.Event == Event
        select review;
}