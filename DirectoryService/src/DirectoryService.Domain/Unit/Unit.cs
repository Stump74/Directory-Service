namespace DirectoryService.Domain.Unit;

public class Unit
{
    public Guid Id { get; set; }

    public Unit? Parent { get; set; }

    public List<Unit> Children { get; set; } = [];

    public required string Title { get; set; }

    public string Description { get; set; } = string.Empty;

    public List<Guid> Locations { get; set; } = [];

    public List<Guid> Positions { get; set; } = [];
}
