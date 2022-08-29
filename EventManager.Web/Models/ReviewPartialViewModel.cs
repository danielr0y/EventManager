
using EventManager.DomainLayer;

namespace EventManager.Web.Models
{
	public class ReviewPartialViewModel
	{
		public ReviewPartialViewModel(Review review)
		{
			this.Name = review.User.Name;
			this.DateTime = review.DateTime.ToString();
			this.Text = review.Text;
		}

        public string Name { get; }
        public string DateTime { get; }
        public string Text { get; }
    }
}

