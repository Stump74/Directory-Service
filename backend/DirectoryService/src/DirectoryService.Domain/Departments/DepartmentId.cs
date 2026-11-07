namespace DirectoryService.Domain.Departments;

public record DepartmentId
{
    private DepartmentId(Guid? id)
    {
        Value = id ?? Guid.CreateVersion7();
    }

    public Guid Value { get; }

    public static DepartmentId New(Guid? id) => new(id) ;
}