using CSharpFunctionalExtensions;
using DirectoryService.Domain.Errors;

namespace DirectoryService.Domain.Locations;

public sealed record Address
{
    private Address(string country, string city, string street, string house)
    {
        Country = country;
        City = city;
        Street = street;
        House = house;
    }

    public string Country { get; }

    public string City { get; }

    public string Street { get; }

    public string House { get; }

    public static Result<Address, Error> Create(string country, string city, string street, string house)
    {
        if (string.IsNullOrWhiteSpace(country))
            return Error.Validation("AddressCountry","Country cannot be empty");
        if (string.IsNullOrWhiteSpace(city))
            return Error.Validation("AddressCity","City cannot be empty");
        if (string.IsNullOrWhiteSpace(street))
            return Error.Validation("AddressStreet","Street cannot be empty");
        if (string.IsNullOrWhiteSpace(house))
            return Error.Validation("AddressHouse","House cannot be empty");
        return Result.Success<Address, Error>(new Address(country, city, street, house));
    }
}