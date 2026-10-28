using System.Text.RegularExpressions;
using CSharpFunctionalExtensions;
using DirectoryService.Domain.Errors;

namespace DirectoryService.Domain.Departments;

public partial record Path
{
    private Path(string value) => Value = value;

    public string Value { get; }

    public static Result<Path, Error> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return Error.Validation("PathEmpty", "Path cannot be empty.");
        if (!AllowedChars.IsMatch(value))
            return Error.Validation("PathInvalid", "Path can only contain lowercase letters, numbers and slashes.");

        return new Path(value);
    }

    [GeneratedRegex("^[a-z0-9/]+$", RegexOptions.None, matchTimeoutMilliseconds: 100)]
    private static partial Regex AllowedChars { get; }
}