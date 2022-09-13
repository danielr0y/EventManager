using System;
namespace EventManager.DomainLayer
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _repository;

        public ReviewService(IReviewRepository reviewRepository)
        {
            _repository = reviewRepository ?? throw new ArgumentNullException(nameof(reviewRepository));
        }

        public IEnumerable<Review> GetReviewsBy(Event Event) => _repository.GetReviewsBy(Event);
    }

}