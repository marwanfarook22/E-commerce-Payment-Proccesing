public class DigitalWalletproccese : PaymentProcessor
{
    public string WalletId { get; init; } = string.Empty;
    public string Pin { get; init; } = string.Empty;
    public override paymnetMethod CardMethod => paymnetMethod.DigitalWallet;


    public override void ValidatePayment()
    {
        if (string.IsNullOrWhiteSpace(WalletId))
        {
            throw new ArgumentException("Invalid Wallet ID.");
        }
        if (string.IsNullOrWhiteSpace(Pin) || Pin.Length < 4)
        {
            throw new ArgumentException("Invalid PIN.");
        }

    }
}