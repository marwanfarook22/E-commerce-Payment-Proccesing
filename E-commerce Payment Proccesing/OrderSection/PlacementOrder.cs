
using E_commerce_Payment_Proccesing.Service;

public class PlacementOrder
{
    public OrderInfo CreateOrder(List<Product> cartDetails, PaymentProcessor paymentDetails)
    {
        var order = new OrderInfo
        {
            OrderId = Guid.NewGuid().ToString(),
            TotalPrice = (decimal)cartDetails.Sum(p => p.price),
            CartDetails = cartDetails,
            OrderDate = DateTime.UtcNow,
            PaymentDetails = paymentDetails
        };
        // Here you would typically save the order to a database or send it to an external service.
        return order;
    }




}