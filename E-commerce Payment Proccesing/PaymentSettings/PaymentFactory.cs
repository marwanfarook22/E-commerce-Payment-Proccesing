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
