public class CreditCardFactory : PaymentFactory
{
    public override PaymentProcessor CreatePaymentProcessor()
    {
        Console.WriteLine("Enter Card Number:");
        string cardNumber = Console.ReadLine()!;

        Console.WriteLine("Enter CVV:");
        string cvv = Console.ReadLine()!;

        Console.WriteLine("Enter Expiry Month (MM):");
        string month = Console.ReadLine()!;

        Console.WriteLine("Enter Expiry Year (YY):");
        string year = Console.ReadLine()!;

        Console.WriteLine("Enter Card Holder Name:");
        string name = Console.ReadLine()!;

        return new CreditCardPayment
        {
            CardNumber = cardNumber,
            Cvv = cvv,
            ExpiryDate = $"{month}/{year}",
            CardHolderName = name
        };
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