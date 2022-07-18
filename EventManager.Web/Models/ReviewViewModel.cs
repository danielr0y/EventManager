
namespace EventManager.Web.Models
{
	public class ReviewViewModel
	{
		public ReviewViewModel(string name, DateTime dateTime, string text)
		{
			this.Name = name;
			this.DateTime = dateTime.ToString();
			this.Text = text;
		}

        public string Name { get; }
        public string DateTime { get; }
        public string Text { get; }
    }
}

