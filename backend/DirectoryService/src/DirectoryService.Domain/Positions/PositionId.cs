namespace DirectoryService.Domain.Positions;

public record PositionId
{
    private PositionId(Guid? id)
    {
        Value = id ?? Guid.CreateVersion7();
    }

    public Guid Value { get; }

    public static PositionId New(Guid? id) => new(id) ;
}