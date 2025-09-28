namespace EventEaseApp.Services;

public interface IEventService
{
    IReadOnlyList<EventItem> GetAll();
    EventItem? GetByName(string name);
    bool Add(EventItem item);
}
