namespace EventManager.DomainLayer
{
    public interface IEventRepository
    {
        IEnumerable<string> Categories { get; }
        IEnumerable<string> Statuses { get; }
        IEnumerable<Event> AllEvents { get; }
        IEnumerable<Event> UpcomingEvents { get; }
        IEnumerable<Event> CancelledEvents { get; }
        IEnumerable<Event> GetEventsBy(string? search, string? category);
        Event GetEvent(int id);
    }
}