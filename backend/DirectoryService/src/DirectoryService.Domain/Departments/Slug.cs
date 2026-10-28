using CSharpFunctionalExtensions;
using DirectoryService.Domain.Errors;

namespace DirectoryService.Domain.Departments;

public record Slug
{
    private const int MinLength = 3;
    private const int MaxLength = 50;
    public string Value { get; }

    private Slug(string value) => Value = value;

    public static Result<Slug, Error> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return Error.Validation("SlugEmpty", "Slug cannot be empty.");
        }

        if (value.Length is < MinLength or > MaxLength)
        {
            return Error.Validation("SlugLength", $"Slug must be between {MinLength} and {MaxLength} characters.");
        }

        #pragma warning disable CA1308
        return new Slug(value.Trim().ToLowerInvariant());
        #pragma warning restore CA1308
    }
}