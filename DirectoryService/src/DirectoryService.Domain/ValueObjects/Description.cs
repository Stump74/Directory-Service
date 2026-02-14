namespace DirectoryService.Domain.ValueObjects;

using CSharpFunctionalExtensions;
using DirectoryService.Domain.Shared;

public record Description
{
    private const int MAX_LENGTH = 1000;

    private Description(string value)
    {
        Value = value;
    }

    private string Value { get; }

    public static Result<Description, Error> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length > MAX_LENGTH)
        {
            return Error.Validation("description.value", "Описание не может быть пустым и должен быть не длиннее " + MAX_LENGTH + " символов.", "description");
        }

        return new Description(value);
    }
}
