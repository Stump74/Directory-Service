namespace DirectoryService.Domain.Position;

public class Position
{
    public Guid Id { get; set; }

    public required string Title { get; set; }

    public string Description { get; set; } = string.Empty;

    public List<Guid> Units { get; set; } = [];
}
