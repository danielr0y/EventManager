namespace EventManager.DomainLayer
{
    public interface IEventService
    {
        IEnumerable<Event> GetAllEvents();
        IEnumerable<Event> GetUpcomingEvents();
        IEnumerable<Event> GetEventsBy(string? category, string? search);
        Event GetEvent(string name);
    }
}