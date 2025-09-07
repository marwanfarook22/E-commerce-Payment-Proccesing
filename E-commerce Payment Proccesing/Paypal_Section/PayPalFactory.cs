public class PayPalFactory : PaymentFactory
{
    public override PaymentProcessor CreatePaymentProcessor()
    {
        Console.WriteLine("Enter Your Email in Paypal");
        string email = Console.ReadLine()!;
        Console.WriteLine("Enter Your PayPal Password");
        string password = Console.ReadLine()!;

        return new PaypalProccese
        {
            Email = email,
            Password = password
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