namespace DirectoryService.Domain.ValueObjects;

public record LocationId
{
    private LocationId(Guid value)
    {
        Value = value;
    }

    public Guid Value { get; }

    public static LocationId NewUnitId() => new(Guid.NewGuid());

    public static LocationId Empty() => new(Guid.Empty);
}
