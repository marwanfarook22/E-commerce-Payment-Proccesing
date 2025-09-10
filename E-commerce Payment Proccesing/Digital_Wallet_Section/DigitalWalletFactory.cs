using E_commerce_Payment_Proccesing.UserinterAction;
using E_commerce_Payment_Proccesing.Userinterface;

public class DigitalWalletFactory : PaymentFactory
{
    private IDisplayMessage _displayMessage;
    private IUserInputClass _userInput;


    public DigitalWalletFactory(IDisplayMessage displayMessage, IUserInputClass userInput)
    {
        _displayMessage = displayMessage;
        _userInput = userInput;
    }

    public override PaymentProcessor CreatePaymentProcessor()
    {
        _displayMessage.Display("Enter Your Wallet ID");
        string walletId = _userInput.UserInput();
        _displayMessage.Display("Enter Your Wallet PIN");
        string pin = _userInput.UserInput();
        return new DigitalWalletproccese
        {
            WalletId = walletId,
            Pin = pin,
        };
    }

}










