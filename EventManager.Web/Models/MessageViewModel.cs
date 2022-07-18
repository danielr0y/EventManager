namespace EventManager.Web.Models
{
    public class MessageViewModel
    {
        public MessageViewModel(Color category, string body)
        {
            this.Category = category;
            this.Body = body;
        }

        public Color Category { get; }
        public string Body { get; }
    }
}