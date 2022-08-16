namespace EventManager.DomainLayer
{
    public interface IEventService
    {
        IEnumerable<string> Categories { get; }
        IEnumerable<string> Statuses { get; }
        IEnumerable<Event> AllEvents { get; }
        IEnumerable<Event> UpcomingEvents { get; }
        IEnumerable<Event> CancelledEvents { get; }
        IEnumerable<Event> GetEventsBy(string? category, string? search);
        Event GetEvent(int id);
    }
}