namespace DirectoryService.Domain.ValueObjects;

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

    public static Address Create(string postalCode, string country, string city, string street) =>
        new(postalCode, country, city, street);
}
