public class DigitalWalletFactory : PaymentFactory
{

    public override PaymentProcessor CreatePaymentProcessor()
    {
        Console.WriteLine("Enter Your Wallet ID");
        string walletId = Console.ReadLine()!;
        Console.WriteLine("Enter Your Wallet PIN");
        string pin = Console.ReadLine()!;
        return new DigitalWalletproccese
        {
            WalletId = walletId,
            Pin = pin
        };
    }

}










 