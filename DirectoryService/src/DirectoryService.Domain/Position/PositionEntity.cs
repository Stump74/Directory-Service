namespace DirectoryService.Domain.Position;

public class PositionEntity
{
    public Guid Id { get; set; }

    public required string Title { get; set; }

    public string Description { get; set; } = string.Empty;

    private List<Guid> Units { get; set; } = [];
}
