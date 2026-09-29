namespace EventsHub.Domain;

public class Activity
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public required string Title { set; get; }
    public DateTime Date { set; get; } = DateTime.MinValue;
    public required string Description { set; get; }
    public required string Category { set; get; }
    public bool IsCancelled { set; get; }
    public required string City { set; get; }
    public required string Venue { set; get; }
    public required string Latitude { set; get; }
    public required string Longitude { set; get; }

}