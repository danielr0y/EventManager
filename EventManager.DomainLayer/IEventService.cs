namespace EventManager.DomainLayer
{
    public interface IEventService
    {
        IEnumerable<string> Categories { get; }
        IEnumerable<string> Statuses { get; }
        IEnumerable<Event> GetAllEvents();
        IEnumerable<Event> GetUpcomingEvents();
        IEnumerable<Event> GetCancelledEvents();
        IEnumerable<Event> GetEventsBy(string? category, string? search);
        Event GetEvent(int id);
    }
}