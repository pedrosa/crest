using Crest.Domain.Requests;

namespace Crest.Domain.Clients;

public sealed class Client
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
    public List<OrderRequest> OrderedRequests { get; set; }
}

public enum PaymentMethod
{
    CreditCard = 1,
    Pix = 2
}