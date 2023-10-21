namespace Crest.Domain.StreamingProducts;

public sealed class Product
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public float Price { get; set; }
}