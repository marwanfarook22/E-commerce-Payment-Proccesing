public class PaypalProccese : PaymentProcessor
{
    public string Email { get; init; } = string.Empty;
    public string Password { get; init; } = string.Empty;
    public override paymnetMethod CardMethod => paymnetMethod.PayPal;
    public override void ValidatePayment()
    {
        if (string.IsNullOrWhiteSpace(Email) || !Email.Contains("@"))
        {
            throw new ArgumentException("Invalid email address.");
        }
        if (string.IsNullOrWhiteSpace(Password) || Password.Length < 6)
        {
            throw new ArgumentException("Invalid password.");
        }


    }
}


 






//public record OrderInfo
//{
//    public string OrderId { get; init; } = string.Empty;
//    public decimal TotalPrice { get; init; }
//    public List<Product>? CartDetails { get; init; }
//    public DateTime OrderDate { get; init; }

//    public PaymentProcessor PaymentDetails { get; init; } = null!;
//}
//public class PlacementOrder
//{
//    public OrderInfo CreateOrder(List<Product> cartDetails, PaymentProcessor paymentDetails)
//    {
//        var order = new OrderInfo
//        {
//            OrderId = Guid.NewGuid().ToString(),
//            TotalPrice = (decimal)cartDetails.Sum(p => p.price),
//            CartDetails = cartDetails,
//            OrderDate = DateTime.UtcNow,
//            PaymentDetails = paymentDetails
//        };
//        // Here you would typically save the order to a database or send it to an external service.
//        return order;
//    }



//}