namespace DirectoryService.Domain.ValueObjects;

using System.Text.RegularExpressions;
using CSharpFunctionalExtensions;
using DirectoryService.Domain.Shared;

public partial record Path
{
    private Path(string value)
    {
        Value = value;
    }

    public string Value { get; }

    public static Result<Path, Error> Create(string value)
    {
        if (!PathRegex().IsMatch(value))
        {
            return Error.Validation("path", "Путь может содержать только латиницу, точки и тире.", "path");
        }

        return new Path(value);
    }

    [GeneratedRegex(@"^[A-Za-z.\-]+$")]
    private static partial Regex PathRegex();
}
