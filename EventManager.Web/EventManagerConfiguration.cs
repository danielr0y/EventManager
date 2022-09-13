namespace EventManager.Web
{
    public class EventManagerConfiguration
    {
        public EventManagerConfiguration(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentNullException(nameof(connectionString));
            }

            this.ConnectionString = connectionString;
        }

        public string ConnectionString { get; }
        // public Type RepositoryType { get; }
    }
}