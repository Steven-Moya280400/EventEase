namespace EventEase.Data
{
    public class EventService
    {
        private List<Event> allEvents = new()
        {
            new Event { Id = 1, Name = "Tech Conference 2025", Date = new DateTime(2025, 5, 15), Location = "San José" },
            new Event { Id = 2, Name = "Summer Gala", Date = new DateTime(2025, 6, 1), Location = "Cartago" },
            new Event { Id = 3, Name = "Developer Meetup", Date = new DateTime(2025, 6, 20), Location = "Heredia" }
        };

        public Task<List<Event>> GetEventsAsync()
        {
            return Task.FromResult(allEvents);
        }

        public Task<Event?> GetEventByIdAsync(int id)
        {
            return Task.FromResult(allEvents.FirstOrDefault(x=>x.Id==id));
        }
    }
}
