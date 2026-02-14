namespace DirectoryService.Domain.ValueObjects;

public record DepartmentId
{
    private DepartmentId(Guid value)
    {
        Value = value;
    }

    public Guid Value { get; }

    public static DepartmentId NewUnitId() => new(Guid.NewGuid());

    public static DepartmentId Empty() => new(Guid.Empty);
}
