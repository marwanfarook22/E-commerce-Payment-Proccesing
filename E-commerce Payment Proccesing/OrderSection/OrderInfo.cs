
using E_commerce_Payment_Proccesing.Service;

public record OrderInfo
{
    public string OrderId { get; init; } = string.Empty;
    public decimal TotalPrice { get; init; }
    public List<Product>? CartDetails { get; init; }
    public DateTime OrderDate { get; init; }

    public PaymentProcessor PaymentDetails { get; init; } = null!;
}
