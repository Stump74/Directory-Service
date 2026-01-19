namespace DirectoryService.Domain.Unit;

public class UnitEntity
{
    public Guid Id { get; set; }

    public UnitEntity? Parent { get; set; }

    public required string Title { get; set; }

    public string Description { get; set; } = string.Empty;

    private List<UnitEntity> Children { get; init; } = [];

    private List<Guid> Locations { get; init; } = [];

    private List<Guid> Positions { get; init; } = [];
}
