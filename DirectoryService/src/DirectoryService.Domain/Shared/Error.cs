namespace DirectoryService.Domain.Shared;

public enum ErrorType
{
    /// <summary>
    /// Ошибка валидации.
    /// </summary>
    VALIDATION,

    /// <summary>
    /// Ресурс не найден.
    /// </summary>
    NOT_FOUND,

    /// <summary>
    /// Конфликт данных.
    /// </summary>
    CONFLICT,

    /// <summary>
    /// Ошибка выполнения операции.
    /// </summary>
    FAILURE,

    /// <summary>
    /// Ошибка авторизации.
    /// </summary>
    AUTHORIZATION,

    /// <summary>
    /// Ошибка аутентификации.
    /// </summary>
    AUTHENTICATION,
}

public record Error
{
    private Error(string code, string message, ErrorType type, string? invalidField = null)
    {
        Code = code;
        Message = message;
        Type = type;
        InvalidField = invalidField;
    }

    public string Code { get; }

    public string Message { get; }

    public ErrorType Type { get; }

    public string? InvalidField { get; }

    public static Error Validation(string code, string message, string? invalidField = null)
        => new(code, message, ErrorType.VALIDATION, invalidField);

    public static Error NotFound(string code, string message)
        => new(code, message, ErrorType.NOT_FOUND);

    public static Error Conflict(string code, string message)
        => new(code, message, ErrorType.CONFLICT);

    public static Error Failure(string code, string message)
        => new(code, message, ErrorType.FAILURE);

    public static Error Authorization(string code, string message)
        => new(code, message, ErrorType.AUTHORIZATION);

    public static Error Authentication(string code, string message)
        => new(code, message, ErrorType.AUTHENTICATION);
}
