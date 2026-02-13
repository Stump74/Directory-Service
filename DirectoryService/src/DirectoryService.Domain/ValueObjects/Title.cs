namespace DirectoryService.Domain.ValueObjects;

using CSharpFunctionalExtensions;
using DirectoryService.Domain.Shared;

public record Title
{
    private const int MAX_LENGTH = 200;

    private Title(string value)
    {
        Value = value;
    }

    public string Value { get; }

    public static Result<Title, Error> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length > MAX_LENGTH)
        {
            return Error.Validation("title.value", "Заголовок не может быть пустым и должен быть не длиннее " + MAX_LENGTH + " символов.", "title");
        }

        return new Title(value);
    }
}
