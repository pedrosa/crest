using Crest.Domain.StreamingProducts;

namespace Crest.Domain.Requests;

public sealed class OrderRequest
{
    public Guid Id { get; set; }
    public string Client { get; set; }
    public List<Product> CheckedProducts { get; set; }
    public Status Status { get; set; }
}

public enum Status
{
    Pending = 1,
    Approved = 2,
    Rejected = 3
}