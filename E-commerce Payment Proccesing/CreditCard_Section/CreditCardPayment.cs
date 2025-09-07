public class CreditCardPayment : PaymentProcessor
{
    public string CardNumber { get; init; } = string.Empty;
    public string Cvv { get; init; } = string.Empty;
    public string ExpiryDate { get; init; } = string.Empty; // Format: MM/YY
    public string CardHolderName { get; init; } = string.Empty;
    public override paymnetMethod CardMethod => paymnetMethod.CrditCard;



    public override void ValidatePayment()
    {
        // Basic validation logic (you can expand this as needed)
        if (string.IsNullOrWhiteSpace(CardNumber) || CardNumber.Length < 13 || CardNumber.Length > 19)
        {
            throw new ArgumentException("Invalid card number.");
        }
        if (string.IsNullOrWhiteSpace(Cvv) || Cvv.Length < 3 || Cvv.Length > 4)
        {
            throw new ArgumentException("Invalid CVV.");
        }
        if (string.IsNullOrWhiteSpace(ExpiryDate) || !DateTime.TryParseExact(ExpiryDate, "MM/yy", null, System.Globalization.DateTimeStyles.None, out DateTime expiry) || expiry < DateTime.UtcNow)
        {
            throw new ArgumentException("Invalid or expired expiry date.");
        }
        if (string.IsNullOrWhiteSpace(CardHolderName))
        {
            throw new ArgumentException("Card holder name is required.");
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