namespace DirectoryService.Domain.Location;

public class LocationEntity
{
    public Guid Id { get; set; }

    public required string Title { get; set; }

    public string Description { get; set; } = string.Empty;

    private List<Guid> Units { get; set; } = [];
}
