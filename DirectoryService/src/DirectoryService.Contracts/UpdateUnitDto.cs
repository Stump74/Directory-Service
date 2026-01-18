namespace DirectoryService.Contracts;

public record UpdateUnitDto(string Name, string Description, Guid ParentId, Guid[] ChildId, Guid[] LocationId, Guid[] PositionId);
