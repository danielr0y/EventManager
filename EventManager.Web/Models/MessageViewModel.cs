namespace EventManager.Web.Models
{
    public class MessageViewModel
    {
        public MessageViewModel(Color category, string body)
        {
            Category = category;
            Body = body;
        }

        public Color Category { get; }
        public string Body { get; }
    }
}