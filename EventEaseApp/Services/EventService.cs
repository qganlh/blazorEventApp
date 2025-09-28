namespace EventEaseApp.Services;

public class EventService : IEventService
{
    private readonly List<EventItem> _events =
    [
        new("Tech Conference", new DateTime(2025, 11, 5), "Seattle, WA", "A full-day developer event."),
        new("Music Festival", new DateTime(2025, 6, 20), "Austin, TX", "Live performances across multiple stages."),
        new("Startup Meetup", DateTime.Today.AddDays(10), "San Francisco, CA", "Networking and pitches."),
    ];

    public IReadOnlyList<EventItem> GetAll() => _events;

    public EventItem? GetByName(string name) =>
        _events.FirstOrDefault(e => string.Equals(e.Name, name, StringComparison.OrdinalIgnoreCase));

    public bool Add(EventItem item)
    {
        if (string.IsNullOrWhiteSpace(item.Name) || string.IsNullOrWhiteSpace(item.Location))
            return false;

        if (_events.Any(e => string.Equals(e.Name, item.Name, StringComparison.OrdinalIgnoreCase)))
            return false; // prevent duplicates by name

        _events.Add(item);
        return true;
    }
}
