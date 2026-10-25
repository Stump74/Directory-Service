namespace DirectoryService.Domain.Errors;

public enum ErrorType
{
    UnknownError = 0,
    ValidationError = 1,
    NotFoundError = 2,
    ConflictError = 3,
    FailureError = 4,
}