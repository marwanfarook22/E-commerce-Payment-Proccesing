public abstract class PaymentProcessor
{
    public abstract paymnetMethod CardMethod { get; set; }
    public abstract void ValidatePayment();


}
