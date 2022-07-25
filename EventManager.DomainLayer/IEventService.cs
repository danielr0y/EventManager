namespace EventManager.DomainLayer
{
    public interface IEventService
    {
        IEnumerable<Event> GetAllEvents();
        IEnumerable<Event> GetUpcomingEvents();
        Event GetEvent(string name);
    }
}