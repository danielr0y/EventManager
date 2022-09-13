using System;
namespace EventManager.DomainLayer
{
    public class ReviewService : IReviewService
    {
        private readonly IUserService _userService;
        private readonly IReviewRepository _repository;

        public ReviewService(IUserService userService, IReviewRepository reviewRepository)
        {
            if (userService == null)
            {
                throw new ArgumentNullException("userService");
            }

            this._userService = userService;
            this._repository = reviewRepository ?? throw new ArgumentNullException(nameof(reviewRepository));
        }

        public IEnumerable<Review> GetReviewsBy(Event Event) => this._repository.GetReviewsBy(Event);
    }

}