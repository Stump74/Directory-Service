namespace DirectoryService.Contracts;

public record CreateDepartmentDto(
    string Name,
    string Identifier,
    Guid ParentId,
    IEnumerable<Guid> ChildId,
    IEnumerable<Guid> LocationId,
    IEnumerable<Guid> PositionId);
