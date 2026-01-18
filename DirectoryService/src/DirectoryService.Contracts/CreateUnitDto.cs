namespace DirectoryService.Contracts;

public record CreateUnitDto(string Name, string Description, Guid ParentId, Guid[] ChildId, Guid[] LocationId, Guid[] PositionId);
