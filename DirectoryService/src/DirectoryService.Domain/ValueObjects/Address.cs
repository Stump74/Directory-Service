namespace DirectoryService.Domain.ValueObjects;

using CSharpFunctionalExtensions;
using DirectoryService.Domain.Shared;

public record Address
{
    private Address(string postalCode, string country, string city, string street)
    {
        PostalCode = postalCode;
        Country = country;
        City = city;
        Street = street;
    }

    public string PostalCode { get; }

    public string Country { get; }

    public string City { get; }

    public string Street { get; }

    // TODO в будущем будет сделана проверка, пока непонятно что надо проверять и как
    public static Result<Address, Error> Create(string postalCode, string country, string city, string street)
    {
        return new Address(postalCode, country, city, street);
    }
}
