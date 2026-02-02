namespace DirectoryService.Domain.ValueObjects;

public record PositionId
{
    private PositionId(Guid value)
    {
        Value = value;
    }

    public Guid Value { get; }

    public static PositionId NewUnitId() => new(Guid.NewGuid());

    public static PositionId Empty() => new(Guid.Empty);
}
