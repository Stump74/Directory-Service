using CSharpFunctionalExtensions;
using DirectoryService.Domain.Errors;

namespace DirectoryService.Domain.Shared;

public sealed record Name
{
    private const int MaxNameLength = 128;
    private const int MinNameLength = 3;

    public string Value { get; }

    private Name(string value) => Value = value;

    public static Result<Name, Error> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return Error.Validation("Name empty","Name cannot be empty.");
        }

        if (value.Length is < MinNameLength or > MaxNameLength)
        {
            return Error.Validation("Name length","Name must be between {MinNameLength} and {MaxNameLength} characters.");
        }

        return new Name(value);
    }
}
