
using EventManager.DomainLayer;

namespace EventManager.Web.Models
{
	public class ReviewPartialViewModel
	{
		public ReviewPartialViewModel(Review review)
		{
			Name = review.User.Name;
			DateTime = review.DateTime.ToString();
			Text = review.Text;
		}

        public string Name { get; }
        public string DateTime { get; }
        public string Text { get; }
    }
}

