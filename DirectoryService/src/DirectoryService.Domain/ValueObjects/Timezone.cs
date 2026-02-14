namespace DirectoryService.Domain.ValueObjects;

using System;
using CSharpFunctionalExtensions;
using DirectoryService.Domain.Shared;

public record Timezone
{
    private Timezone(string value)
    {
        Value = value;
    }

    public string Value { get; private set; }

    public static Result<Timezone, Error> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return Error.Validation("timezone.value", "Timezone не может быть пустой.", "value");
        }

        if (!TimeZoneInfo.TryConvertIanaIdToWindowsId(value, out _))
        {
            return Error.Validation("timezone.value", "Timezone должен быть валидным IANA идентификатором.", "value");
        }

        return new Timezone(value);
    }
}
