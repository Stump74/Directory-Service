namespace DirectoryService.Domain.Departments;

public sealed class DepartmentLocation
{
    public required Guid Id { get; init; }
    public required Guid DepartmentId { get; init; }
    public required Guid LocationId { get; init; }
    public bool IsPrimary { get; init; }
}