namespace DirectoryService.Domain.Departments;

public record Path
{
    //пока не понятно чем заполнять, поэтому оставим как есть
    private Path(string value) => Value = value;

    public string Value { get; }

    public static Path Create(string value) => new (value);
}