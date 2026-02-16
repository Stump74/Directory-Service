namespace DirectoryService.Domain.ValueObjects;

using System.Text.RegularExpressions;
using CSharpFunctionalExtensions;
using DirectoryService.Domain.Shared;

public partial record Identifier
{
    private const int MAX_LENGTH = 5000;

    private const int MIN_LENGTH = 3;

    private Identifier(string value)
    {
        Value = value;
    }

    private string Value { get; }

    public static Result<Identifier, Error> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return Error.Validation("identifier.value", "Название не должно быть пустым.", "identifier");
        }

        if (value.Length is > MAX_LENGTH or < MIN_LENGTH)
        {
            return Error.Validation("identifier.value", "Название должно быть более " + (MIN_LENGTH - 1) + " и не длиннее " + MAX_LENGTH + " символов.", "identifier");
        }

        if (!LatinRegex().IsMatch(value))
        {
            return Error.Validation("identifier.value", "Название должно содержать только латинские буквы.", "identifier");
        }

        return new Identifier(value);
    }

    [GeneratedRegex(@"^[a-zA-Z]+$")]
    private static partial Regex LatinRegex();
}
