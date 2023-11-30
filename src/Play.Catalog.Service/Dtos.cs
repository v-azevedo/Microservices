namespace Play.Catalog.Service
{
    public record ItemDto(Guid Id, string Name, string Description, decimal Price, DateTimeOffset CreatedDate);

    public record CreateItemDto(string Name, string Description, decimal Price);

    public record UpdatedItemDto(string Name, string Description, decimal Price);
}