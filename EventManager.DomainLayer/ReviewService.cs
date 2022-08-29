using System;
namespace EventManager.DomainLayer
{
    public class ReviewService : IReviewService
    {
        private readonly IUserService _userService;

        public ReviewService(IUserService userService)
        {
            if (userService == null)
            {
                throw new ArgumentNullException("userService");
            }

            this._userService = userService;
        }

        public IEnumerable<Review> GetReviewsBy(Event Event)
        {
            return new[]
            {
                new Review(
                    _userService.GetUser(100),
                    new DateTime(),
                    "Was sick, eh."
                ),
                new Review(
                    _userService.GetUser(100),
                    new DateTime(),
                    "Was sick, eh."
                ),
                new Review(
                    _userService.GetUser(100),
                    new DateTime(),
                    "Was sick, eh."
                ),
                new Review(
                    _userService.GetUser(100),
                    new DateTime(),
                    "Was sick, eh."
                ),
                new Review(
                    _userService.GetUser(100),
                    new DateTime(),
                    "Was sick, eh."
                )};
        }
    }
}

