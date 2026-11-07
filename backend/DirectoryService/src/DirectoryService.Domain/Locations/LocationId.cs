namespace DirectoryService.Domain.Locations;

public record LocationId
{
    private LocationId(Guid? id)
    {
        Value = id ?? Guid.CreateVersion7();
    }

    public Guid Value { get; }

    public static LocationId New(Guid? id) => new(id) ;
}