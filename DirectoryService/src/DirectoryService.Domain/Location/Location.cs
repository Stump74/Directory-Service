namespace DirectoryService.Domain.Location;

public class Location
{
    public Guid Id { get; set; }

    public required string Title { get; set; }

    public string Description { get; set; } = string.Empty;

    public List<Guid> Units { get; set; } = [];
}
