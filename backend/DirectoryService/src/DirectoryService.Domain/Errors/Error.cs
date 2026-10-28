namespace DirectoryService.Domain.Errors;

public sealed class Error
{
    public string Code { get; }
    public string Message { get; }
    public ErrorType Type { get; }

    private Error(string code, string message, ErrorType type)
    {
        Code = code;
        Message = message;
        Type = type;
    }

    public static Error Validation(string code, string message) => new (code, message, ErrorType.ValidationError);
    public static Error NotFound(string code, string message) => new (code, message, ErrorType.NotFoundError);
    public static Error Conflict(string code, string message) => new (code, message, ErrorType.ConflictError);
    public static Error Failure(string code, string message) => new (code, message, ErrorType.FailureError);
    public static Error Unknown(string code, string message) => new (code, message, ErrorType.UnknownError);
}