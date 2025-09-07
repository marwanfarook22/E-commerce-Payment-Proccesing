



using E_commerce_Payment_Proccesing.Service;
using E_commerce_Payment_Proccesing.UserinterAction;
using E_commerce_Payment_Proccesing.Userinterface;

var R = new ProudectService();
var U = new ManualProudectsUserInterface();
var I = new proudectUserInteraction();
var ProudectList = R.ReadProudctJson();
U.DisplayProudects(ProudectList);
var Cart = I.UserChossenProudect(ProudectList);


Console.WriteLine("Chosse The Way You Want To Payment ");
Console.WriteLine("1- Credit Card");
Console.WriteLine("2- PayPal");
Console.WriteLine("3- Digital Wallet");
var paymentMethod = Console.ReadLine();
PaymentFactory factory = null;
switch (paymentMethod)
{
    case "1":
        factory = new CreditCardFactory();
        break;
    case "2":
        factory = new PayPalFactory();
        break;
    case "3":
        factory = new DigitalWalletFactory();
        break;
    default:
        Console.WriteLine("Invalid Input");
        Console.ReadKey();
        return;
}

try
{
    var payment = factory.ProcessTransaction();
    Console.WriteLine("Payment processed successfully.");

    PlacementOrder placementOrder = new PlacementOrder();
    placementOrder.CreateOrder(Cart, payment);
}
catch (Exception ex)
{
    Console.WriteLine($"Payment failed: {ex.Message}");
    Console.ReadKey();
}



public enum paymnetMethod
{
    CrditCard,
    PayPal,
    DigitalWallet
}

public abstract class PaymentProcessor
{
    public abstract paymnetMethod CardMethod { get; }
    public abstract void ValidatePayment();


}

public abstract class PaymentFactory
{
    public abstract PaymentProcessor CreatePaymentProcessor();

    public PaymentProcessor ProcessTransaction()
    {
        var processor = CreatePaymentProcessor();
        processor.ValidatePayment();
        return processor;
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