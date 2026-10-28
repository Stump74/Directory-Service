namespace DirectoryService.Domain.Departments;

public class DepartmentPosition
{
    public required Guid Id { get; init; }
    public required Guid DepartmentId { get; init; }
    public required Guid PositionId { get; init; }
}