﻿namespace EventManager.DomainLayer;

public class EventService : IEventService
{
    private readonly IEventRepository _eventRepository;

    public EventService(IEventRepository eventRepository)
    {
        _eventRepository = eventRepository ?? throw new ArgumentNullException(nameof(eventRepository));
    }

    public IEnumerable<string> Categories => _eventRepository.Categories;

    public IEnumerable<string> Statuses => _eventRepository.Statuses;

    public IEnumerable<Event> AllEvents => _eventRepository.AllEvents;

    public IEnumerable<Event> UpcomingEvents => _eventRepository.UpcomingEvents;

    public IEnumerable<Event> CancelledEvents => _eventRepository.CancelledEvents;

    public IEnumerable<Event> GetEventsBy(string? search, string? category)
    {
        if (search is null && category is null)
        {
            return AllEvents;
        }

        return _eventRepository.GetEventsBy(search, category);
    }

    public Event GetEvent(int id) => _eventRepository.GetEvent(id);
}
