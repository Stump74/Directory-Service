namespace DirectoryService.Domain.ValueObjects;

using CSharpFunctionalExtensions;

public record Deleted
{
    private Deleted()
    {
    }

    private Deleted(DateTime? value)
    {
        Value = value;
    }

    public DateTime? Value { get; }

    public bool IsDeleted => Value.HasValue;

    public static Result<Deleted> Delete()
    {
        return new Deleted(DateTime.UtcNow);
    }

    public static Result<Deleted> Create()
    {
        return new Deleted();
    }
}
