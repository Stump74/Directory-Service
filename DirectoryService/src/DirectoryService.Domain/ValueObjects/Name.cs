namespace DirectoryService.Domain.ValueObjects;

using CSharpFunctionalExtensions;
using DirectoryService.Domain.Shared;

public record Name
{
    private Name(string value)
    {
        Value = value;
    }

    public string Value { get; }

    public static Result<Name, Error> Create(string value, int minLength, int maxLength)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length > maxLength || value.Length < minLength)
        {
            return Error.Validation("name.value", "Название не может быть пустым, должно быть более " + (minLength - 1) + " и должен быть не длиннее " + maxLength + " символов.", "name");
        }

        return new Name(value);
    }
}
